using SkillIT;
using SkillIT.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SkillIT.ChildForms
{
    public partial class OptionsForm : Form
    {
        /// <summary>
        /// Options model to hold the options
        /// </summary>
        OptionsModel options;

        /// <summary>
        /// Isolated storage options class to handle the isolated storage of the options
        /// </summary>
        IsolatedStorageOptions optionStorage;

        public OptionsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prime the form with combobox values and trigger the load of the options from isolated storage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            
            comboBoxLoginWait.DataSource = new int[] { 10000, 15000, 25000, 40000 };
            comboBoxLoginWait.SelectedItem = 25000;
            comboBoxPageLoadWait.DataSource = new int[] { 1000, 2000, 5000, 10000 };
            comboBoxPageLoadWait.SelectedItem = 1000;
            comboBoxJobNavigationWait.DataSource = new int[] { 50, 100, 500, 1000, 2000 };
            comboBoxJobNavigationWait.SelectedItem = 100;

            radioButtonChrome.Checked = true;            

            try
            {
                optionStorage = new IsolatedStorageOptions();
                options = optionStorage.GetIsolatedStorage();
                LoadValuesFromStorage(options);                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load the options from storage:{ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Retrieve the options from the form
        /// </summary>
        /// <param name="options"></param>
        /// <returns><see cref="OptionsModel"/></returns>
        private OptionsModel GetCurrentlySetOptions(OptionsModel options)
        {
            options.PageLoadWait = (int)comboBoxPageLoadWait.SelectedItem;
            options.LoginWait = (int)comboBoxLoginWait.SelectedItem;
            options.JobNavigationWait = (int)comboBoxJobNavigationWait.SelectedItem;
            options.BrowserSelected = (BrowserOptionEnum)Enum.Parse(typeof(BrowserOptionEnum), groupBoxBrowserSelected.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);

            return options;
        }

        /// <summary>
        /// Load the values from isolated storage into the form
        /// </summary>
        /// <param name="options"></param>
        private void LoadValuesFromStorage(OptionsModel options)
        {
            comboBoxJobNavigationWait.SelectedItem = options.JobNavigationWait;
            comboBoxLoginWait.SelectedItem = options.LoginWait;
            comboBoxPageLoadWait.SelectedItem = options.PageLoadWait;
            switch(options.BrowserSelected)
            {
                case BrowserOptionEnum.Chrome:
                    radioButtonChrome.Checked = true;
                    break;
                case BrowserOptionEnum.Firefox:
                    radioButtonFireFox.Checked = true;
                    break;
                case BrowserOptionEnum.Edge:
                    radioButtonEdge.Checked = true;
                    break;
                default:
                    radioButtonChrome.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Trigger save of options to isolated storage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {               
                SaveOptions();
                MessageBox.Show("Options Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save the options to storage:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Save the options to isolated storage
        /// </summary>
        private void SaveOptions()
        {
            options = GetCurrentlySetOptions(options);
            optionStorage.SetIsolatedStorage(options);
        }
    }
}
