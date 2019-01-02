using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace GTAV_Profiles_manager
{
    public partial class MainForm : Form
    {
        private List<Profile> profiles;
        private Options options;
        public MainForm(List<Profile> profiles, Options options)
        {
            this.profiles = profiles;
            this.options = options;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (MainClass.LoadProfile(cbxProfile.Text))
            {
                lblCurrent.Text = cbxProfile.Text;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Add if name is not empty and not exists
            if (txtName.Text != "" || profiles.All(el => el.name != txtName.Text))
            { 
                Profile new_p = new Profile(
                    txtName.Text,
                    MainClass.NowString(), 
                    ""
                );
                profiles.Add(new_p);
                ApplyProfiles();

                var new_profile_path = Path.Combine(options.path_to_profiles, txtName.Text);
                var g_new_path = Path.Combine(new_profile_path, "GTA V");
                var s_new_path = Path.Combine(new_profile_path, "Social Club");

                Directory.CreateDirectory(g_new_path);
                Directory.CreateDirectory(s_new_path);

                // Grab saves from game files
                if (chkExists.Checked)
                {
                    var g_profiles_path = Path.Combine(options.path_to_rockstar, "GTA V", "Profiles");
                    var s_profiles_path = Path.Combine(options.path_to_rockstar, "Social Club", "Profiles");

                    MainClass.CopyDirectoryContent(g_profiles_path, g_new_path);
                    MainClass.CopyDirectoryContent(s_profiles_path, s_new_path);
                }
            }
        }

        private void btnChooseSavesPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtRockstarPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnChooseAppPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtProfilesPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSaveOptions_Click(object sender, EventArgs e)
        {
            options.active_profile = cbxProfile.Text;
            options.path_to_rockstar = txtRockstarPath.Text;
            options.path_to_profiles = txtProfilesPath.Text;
            MainClass.SerializeConfigJson(@"config.json");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbxProfile.Text != options.active_profile)
            {
                profiles.Remove(profiles.Find(el => el.name == cbxProfile.Text));
                ApplyProfiles();
            }
        }

        private void btnValidatePaths_Click(object sender, EventArgs e)
        {
            MainClass.ValidateData();
        }

        private void chkSaveClose_CheckedChanged(object sender, EventArgs e)
        {
            txtProfilesPath.Enabled = !chkSaveNearby.Checked;
            btnChooseAppPath.Enabled = !chkSaveNearby.Checked;
            if (chkSaveNearby.Checked)
            {
                txtProfilesPath.Text = txtRockstarPath.Text;
            }
        }

        private void txtRockstarPath_TextChanged(object sender, EventArgs e)
        {
            if (chkSaveNearby.Checked)
            {
                txtProfilesPath.Text = txtRockstarPath.Text;
            }
        }

        public void ApplyData()
        {
            ApplyProfiles();
            ApplyOptions();
        }
        public void ApplyProfiles()
        {
            cbxProfile.Items.Clear();
            for (int i = 0; i < profiles.Count; ++i)
            {
                cbxProfile.Items.Add(profiles[i].name);
            }
            cbxProfile.SelectedItem = options.active_profile;
        }

        public void ApplyOptions()
        {
            cbxProfile.SelectedItem = options.active_profile;
            lblCurrent.Text = options.active_profile;

            txtRockstarPath.Text = options.path_to_rockstar;
            txtProfilesPath.Text = options.path_to_profiles;
        }

    }
}
