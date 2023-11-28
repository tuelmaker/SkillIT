using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using Skillit.Models;
using SkillIT;
using SkillIT.Models;
using SkillIT.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading;
using System.Windows.Forms;

namespace SkillITForm
{
    public partial class SkillITMain : Form
    {
        public OptionsModel optionsModel;
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        WebDriver webDriver;
        List<JobInformationModel> jobInformationModelList = new List<JobInformationModel>();
        Dictionary<string, string> exceptions = new Dictionary<string, string>();
        int jobsFound = 0;
        IsolatedStorageOptions iso;
        public SkillITMain()
        {
            InitializeComponent();
            textBoxInitialJobSearchURL.Text = "https://www.linkedin.com/jobs/search/?distance=25&f_JT=F&f_TPR=r2592000&f_WT=2&geoId=103644278&keywords=reliability%20engineer&origin=JOB_SEARCH_PAGE_JOB_FILTER&refresh=true&sortBy=R";
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.WorkerReportsProgress = true;
            comboBoxLimitJobLookup.DataSource = new string[] { "-1", "25", "50", "100", "200", "500", "1000" };
            comboBoxLimitJobLookup.SelectedIndex = 0;
        }

        /// <summary>
        /// This is used within a progress bar to update the progress of the background worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarProcessing.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DumpExtractedInformation();
            progressBarProcessing.Visible = false;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            foreach (int increment in (List<int>)e.Argument)
            {
                string url = IncrementJobLookup(increment);

                /// here we want to start the extraction of the data by navigating to the url and then 
                /// clicking on each of the links which then will update the right panel with the information rather than
                /// reloading the entire page
                /// 

                webDriver.Navigate().GoToUrl(url);
                Thread.Sleep(optionsModel.PageLoadWait);
                ReadOnlyCollection<IWebElement> jobLinks = webDriver.FindElements(By.CssSelector(Constants.JOB_LINK_CLASS_NAME));
                foreach (WebElement jobLink in jobLinks)
                {
                    try
                    {
                        jobLink.Click();
                        Thread.Sleep(optionsModel.JobNavigationWait);
                        IWebElement rootJobDetailContainer = webDriver.FindElement(By.CssSelector(Constants.ROOT_JOB_DETAIL_CONTAINER_CLASS_NAME));
                        JobInformationModel jobInformationModel = ExtractInformation(rootJobDetailContainer);
                        if(jobInformationModel != null)
                        {
                            UpdateJobInformationModelList(jobInformationModel);
                        }            
                        i+=1;

                    }
                    catch (Exception ex)
                    {
                        /// do nothing
                    }
                    backgroundWorker.ReportProgress((int)Math.Floor((double)i / (double)jobsFound * 100));
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            webDriver.Navigate().GoToUrl(textBoxInitialJobSearchURL.Text);            
            webDriver.FindElement(By.CssSelector(Constants.LOGIN_BUTTON_CLASS_NAME)).Click();
            webDriver.FindElement(By.Id(Constants.USERNAME_TEXTBOX_ID)).SendKeys(textBoxUserName.Text);
            webDriver.FindElement(By.Id(Constants.PASSWORD_TEXTBOX_ID)).SendKeys(textBoxPassword.Text);
            webDriver.FindElement(By.CssSelector(Constants.LOGIN_SUBMIT_BUTTON_CLASS_NAME)).Click();
            Thread.Sleep(optionsModel.LoginWait);
            try
            {
                labelLoginStatus.Text = webDriver.FindElement(By.CssSelector(Constants.LOGIN_STATUS_EVALUATION_CLASS_NAME))
                    .FindElement(By.TagName(Constants.SPAN_TAG)).Text == "Me" ? "Logged In" : "Not Logged In";
            }
            catch(Exception ex) 
            {
                labelLoginStatus.Text = Resources.ResourceManager.GetString(Constants.LOGIN_FAILURE_LOOKUP_NAME);
            }
        }


        /// <summary>
        /// Go through each of the jobids and extract the information from the page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExtractInformation_Click(object sender, EventArgs e)
        {
            /// here we will extract the number of jobs found and then use that as a basis to generate the urls necessary to go through all
            /// of the jobs and get the ids                       

            progressBarProcessing.Visible = true;
            progressBarProcessing.Maximum = jobsFound;
            progressBarProcessing.Minimum = 0;
            

            List<int> incrementList = GenerateListOfNumbersIncrementedByValueUpToValue(Constants.JOB_INCREMENT_NUMBER);
            jobInformationModelList.Clear();
            backgroundWorker.RunWorkerAsync(incrementList);
        }

        /// <summary>
        /// Update the jobs found based on the value in the textbox
        /// </summary>
        private void UpdateJobsFound()
        {

        try
            {
                IWebElement jobsFoundContainer = webDriver.FindElement(By.ClassName(Constants.JOBS_FOUND_COUNT_CLASS_NAME));
                jobsFound = int.Parse(jobsFoundContainer.FindElement(By.TagName(Constants.SPAN_TAG)).Text
                    .Split(new string[] { Constants.SINGLESPACE }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList()[0]
                    .Replace(Constants.COMMA,string.Empty));

                if(comboBoxLimitJobLookup.SelectedIndex > 0)
                {
                    jobsFound = int.Parse(comboBoxLimitJobLookup.SelectedItem.ToString());
                }
            }
            catch(Exception ex)
            {
                // default to 100 jobs found if we can't find the element or value of the element
                jobsFound = 100;
                return;
            }
        }

        /// <summary>
        /// Get the number of jobs found based on the url in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetJobCount_Click(object sender, EventArgs e)
        {
            webDriver.Navigate().GoToUrl(textBoxInitialJobSearchURL.Text);
            Thread.Sleep(optionsModel.PageLoadWait);

            UpdateJobsFound();

            if (jobsFound == 0)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(Constants.NO_JOBS_FOUND_LOOKUP_NAME), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            labelJobsFound.Text = $"Jobs Found: {jobsFound}";
        }

        /// <summary>
        /// Build a new url which we can then use to page through the jobs    
        /// </summary>
        /// <param name="increment"></param>
        /// <returns></returns>
        private string IncrementJobLookup(int increment)
        {
            return new Url(string.Format(textBoxInitialJobSearchURL.Text + "&start={0}", increment)).Value;
        }

        /// <summary>
        /// Extract the information from the job detail panel and populate the jobinformationmodel <see cref="JobInformationModel"/>  
        /// </summary>
        /// <param name="jobDetailPanel"></param>
        private JobInformationModel ExtractInformation(IWebElement jobDetailPanel)
        {
            JobInformationModel jobInformationModel = new JobInformationModel();

            jobInformationModel.JobId = jobDetailPanel
                .FindElement(By.CssSelector(Constants.JOBS_FOUND_COUNT_CLASS_NAME))
                .FindElement(By.TagName(Constants.ANCHOR_TAG))
                .GetAttribute(Constants.HREF_ATTRIBUTE)
                .Split(new char[] { Path.AltDirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries)[4];

            jobInformationModel.JobUrl = $"https://www.linkedin.com/jobs/search/?currentJobId={jobInformationModel.JobId}";


            /// Get the title of the job
            string jobTitle = jobDetailPanel.FindElement(By.CssSelector(Constants.JOB_TITLE_CLASS_NAME)).Text;
            jobInformationModel.JobTitle = jobTitle;
            
            /// Get the job details and do some hefty parsing to extract the relevant parts 
            IWebElement jobDetails = jobDetailPanel.FindElement(By.ClassName(Constants.JOB_DETAIL_LOGISTICS_CLASS_NAME));
            string jobDetailLine = jobDetails.Text;
            
            string[] jobDetailLineSplit = jobDetailLine
                .Split(new string[] { Constants.JOB_DETAIL_SPLIT_CHAR }, StringSplitOptions.RemoveEmptyEntries);

            jobInformationModel.CompanyName = jobDetailLineSplit[0].Trim();

            jobInformationModel.ApplicantCount = jobDetailLineSplit.Count() == Constants.JOB_DETAIL_SEGMENT_COUNT
                ? jobDetailLineSplit[Constants.JOB_DETAIL_SEGMENT_APPLICANT_INDEX].Trim()
                : SkillIT.Properties.Resources.ResourceManager.GetString(Constants.APPLICANT_COUNT_MISSING_LOOKUP_NAME);

            jobInformationModel.PostStatus = jobDetailLineSplit[1].Contains(Constants.JOB_POSTING_STATUS_REPOSTED) ? Constants.JOB_POSTING_STATUS_REPOSTED : Constants.JOB_POSTING_STATUS_NEW;
            jobInformationModel.PostedDaysAgo = jobDetailLineSplit[1].Split(new string[] { Constants.JOB_DETAIL_SPLIT_DOUBLE_SPACE }, StringSplitOptions.RemoveEmptyEntries)
                .Last()
                .Trim();
            jobInformationModel.Location = jobDetailLineSplit[1].Split(new string[] { Constants.JOB_DETAIL_SPLIT_DOUBLE_SPACE }, StringSplitOptions.RemoveEmptyEntries)
                .First()
                .Replace(Constants.JOB_POSTING_STATUS_REPOSTED, string.Empty)
                .Trim();

            ReadOnlyCollection<IWebElement> elements = jobDetailPanel.FindElements(By.CssSelector(Constants.JOB_SKILLS_SECTION_CLASS_NAME));

            for (int s = 0; s < elements.Count; s++)
            {
                switch (s)
                {
                    case 0:
                        jobInformationModel.MatchingSkills.AddRange(elements[s].Text
                            .Split(new string[] {Constants.JOB_SKILLS_SPLIT_STRING_COMMA
                            ,Constants.JOB_SKILLS_SPLIT_STRING_AND_WITH_BUFFERS }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList().Select(x => x.Trim()));
                        break;
                    case 1:
                        jobInformationModel.MissingSkills.AddRange(elements[s].Text.Split(new string[] {Constants.JOB_SKILLS_SPLIT_STRING_COMMA
                            ,Constants.JOB_SKILLS_SPLIT_STRING_AND_WITH_BUFFERS }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList().Select(x => x.Trim()));
                        break;
                    case 2:
                        jobInformationModel.ApplicantSkills.AddRange(elements[s].Text.Split(new string[] {Constants.JOB_SKILLS_SPLIT_STRING_COMMA
                            ,Constants.JOB_SKILLS_SPLIT_STRING_AND_WITH_BUFFERS }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList().Select(x => x.Trim()));
                        break;
                    default:
                        break;

                }

            }
            return jobInformationModel;
           
        }

        /// <summary>
        /// Update the job information model list by adding a new job information model item
        /// </summary>
        /// <param name="jobInformationModel"></param>
        private void UpdateJobInformationModelList(JobInformationModel jobInformationModel)
        {
            /// locking the list to prevent multiple threads from accessing it at the same time
            /// NOTE: this is currently single threaded but if we ever want to make it multi-threaded we will need to lock the list
            lock (jobInformationModelList)
            {
                jobInformationModelList.Add(jobInformationModel);
            }
        }

        /// <summary>
        /// Generate a list of integers incremented by a value up to a value
        /// </summary>
        /// <returns></returns>
        private List<int> GenerateListOfNumbersIncrementedByValueUpToValue(int incrementor)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < jobsFound; i += incrementor)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        /// <summary>
        /// Dump the extracted information into the output textbox
        /// </summary>
        private void DumpExtractedInformation()
        {
            if (jobInformationModelList.Count == 0)
            {
                MessageBox.Show(
                    SkillIT.Properties.Resources.ResourceManager.GetString(Constants.DUMP_ERROR_RESOURCE_DESCRIPTION_LOOKUP_NAME),
                    SkillIT.Properties.Resources.ResourceManager.GetString(Constants.DUMP_ERROR_RESOURCE_TITLE_LOOKUP_NAME),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            textBoxExtractedInformation.Text = Newtonsoft.Json.JsonConvert.SerializeObject(jobInformationModelList);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForms.OptionsForm optionsForm = new ChildForms.OptionsForm();
            optionsForm.FormClosed += OptionsForm_FormClosed;
            this.Enabled = false;
            DialogResult result = optionsForm.ShowDialog();

        }

        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void SkillITMain_Load(object sender, EventArgs e)
        {
            optionsModel = new OptionsModel();

            optionsModel = LoadOptionsFromStorage();

            switch(optionsModel.BrowserSelected)
            {
                case BrowserOptionEnum.Chrome:
                    webDriver = new ChromeDriver();
                    break;
                case BrowserOptionEnum.Firefox:
                    webDriver = new FirefoxDriver();
                    break;
                case BrowserOptionEnum.Edge:
                    webDriver = new EdgeDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }            
            
            Thread.Sleep(optionsModel.PageLoadWait);
            //webDriver.ExecuteScript("document.body.style.zoom='25%';");

            
        }

        private OptionsModel LoadOptionsFromStorage()
        {
            iso = new IsolatedStorageOptions();
             return iso.GetIsolatedStorage();
        }

        private void buttonSaveJSON_Click(object sender, EventArgs e)
        {
            if(textBoxExtractedInformation.Text.Length == 0)
            {
                MessageBox.Show("No information to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON Files (*.json)|*.json";
                saveFileDialog.DefaultExt = "json";
                saveFileDialog.AddExtension = true;
                saveFileDialog.ShowDialog();
                if(saveFileDialog.FileName.Length > 0)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBoxExtractedInformation.Text);
                }
            }
        }
    }
}

