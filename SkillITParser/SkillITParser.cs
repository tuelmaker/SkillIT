using Skillit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Schema;

namespace SkillITParser
{
    public partial class SkillITParser : Form
    {
        List<JobInformationModel> jobInformationModels= new List<JobInformationModel>();
        public SkillITParser()
        {
            InitializeComponent();
        }

        private void buttonLoadJsonFile_Click(object sender, EventArgs e)
        {
            openFileDialogLoadJsonFile = new OpenFileDialog();
            openFileDialogLoadJsonFile.DefaultExt = "json";
            openFileDialogLoadJsonFile.ShowDialog();
            textBoxJsonFile.Text = openFileDialogLoadJsonFile.FileName;
            if (LoadDataFromJsonFile(textBoxJsonFile.Text))
            {
                DataTable dt = FlattenJsonFile();
                dataGridViewFlattenedJson.AutoGenerateColumns = true;
                dataGridViewFlattenedJson.DataSource = FlattenJsonFile();
            }
            else
            {
                dataGridViewFlattenedJson.DataSource = null;
            }

        }

        private bool LoadDataFromJsonFile(string jsonFilePath)
        {
            string jsonFileContents = File.ReadAllText(jsonFilePath);
            try
            {
                jobInformationModels = JsonConvert.DeserializeObject<List<JobInformationModel>>(jsonFileContents);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The data does not correspond to the JobInformationModel so it cannot be deserialized\r\n\r\n{GetJsonSchema().Format}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
        }

        private JSchema GetJsonSchema()
        {
            JSchemaGenerator generator = new JSchemaGenerator();
            JSchema schema = generator.Generate(typeof(JobInformationModel));
            return schema;
        }

        private DataTable FlattenJsonFile()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("JobTitle");
            dt.Columns.Add("CompanyName");
            dt.Columns.Add("JobId");
            dt.Columns.Add("JobUrl");
            dt.Columns.Add("Location");
            dt.Columns.Add("PostStatus");
            dt.Columns.Add("PostedDaysAgo");
            dt.Columns.Add("ApplicantCount");
            dt.Columns.Add("SkillCategory");
            dt.Columns.Add("SkillName");
            foreach (JobInformationModel jobInformationModel in jobInformationModels)
            {
                foreach(string missingSkill in jobInformationModel.MissingSkills)
                {
                    dt = GenerateDataRow(dt, jobInformationModel, "MissingSkills", missingSkill);
                }

                foreach(string matchingSkill in jobInformationModel.MatchingSkills)
                {
                    dt = GenerateDataRow(dt, jobInformationModel, "MatchingSkills", matchingSkill);
                }

                foreach(string applicantSkill in jobInformationModel.ApplicantSkills)
                {
                    dt = GenerateDataRow(dt, jobInformationModel, "ApplicantSkills", applicantSkill);
                }
            }
            return dt;
        }

        private DataTable GenerateDataRow(DataTable dt, JobInformationModel jobInformationModel,string skillCategory, string skillName)
        {
            DataRow dr = dt.NewRow();
            dr["JobTitle"] = jobInformationModel.JobTitle;
            dr["CompanyName"] = jobInformationModel.CompanyName;
            dr["JobId"] = jobInformationModel.JobId;
            dr["JobUrl"] = jobInformationModel.JobUrl;
            dr["Location"] = jobInformationModel.Location;
            dr["PostStatus"] = jobInformationModel.PostStatus;
            dr["PostedDaysAgo"] = jobInformationModel.PostedDaysAgo;
            dr["ApplicantCount"] = jobInformationModel.ApplicantCount;
            dr["SkillCategory"] = skillCategory;
            dr["SkillName"] = skillName;
            dt.Rows.Add(dr);
            return dt;
        }

        private void buttonSaveAsCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
            saveFileDialog.ShowDialog();
            string csvFilePath = saveFileDialog.FileName;
            DataTable dt = (DataTable)dataGridViewFlattenedJson.DataSource;
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));
            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString().Replace(",", "|"));
                sb.AppendLine(string.Join(",", fields));
            }
            File.WriteAllText(csvFilePath, sb.ToString());

        }
    }
}
