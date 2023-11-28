using SkillIT;
using SkillIT.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SkillITForm.ChildForms
{
    public partial class OptionsForm : Form
    {
        OptionsModel options;
        IsolatedStorageOptions iso;
        public OptionsForm()
        {
            InitializeComponent();
        }

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
                iso = new IsolatedStorageOptions();
                options = iso.GetIsolatedStorage();
                LoadValuesFromStorage(options);                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load the options from storage:{ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private OptionsModel GetCurrentlySetOptions(OptionsModel options)
        {
            options.PageLoadWait = (int)comboBoxPageLoadWait.SelectedItem;
            options.LoginWait = (int)comboBoxLoginWait.SelectedItem;
            options.JobNavigationWait = (int)comboBoxJobNavigationWait.SelectedItem;
            options.BrowserSelected = (BrowserOptionEnum)Enum.Parse(typeof(BrowserOptionEnum), groupBoxBrowserSelected.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);

            return options;
        }

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            options = GetCurrentlySetOptions(options);
            iso.SetIsolatedStorage(options);
            
            MessageBox.Show("Options Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
