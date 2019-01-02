namespace GTAV_Profiles_manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkExists = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRockstarPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChooseSavesPath = new System.Windows.Forms.Button();
            this.txtProfilesPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChooseAppPath = new System.Windows.Forms.Button();
            this.chkSaveNearby = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSaveOptions = new System.Windows.Forms.Button();
            this.btnValidatePaths = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxProfile
            // 
            this.cbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Location = new System.Drawing.Point(16, 29);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(149, 21);
            this.cbxProfile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose profile";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(171, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 21);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create profile";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(282, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // chkExists
            // 
            this.chkExists.AutoSize = true;
            this.chkExists.Location = new System.Drawing.Point(282, 55);
            this.chkExists.Name = "chkExists";
            this.chkExists.Size = new System.Drawing.Size(226, 17);
            this.chkExists.TabIndex = 6;
            this.chkExists.Text = "This profile already has saves in game files";
            this.chkExists.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(68, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paths";
            // 
            // txtRockstarPath
            // 
            this.txtRockstarPath.Location = new System.Drawing.Point(16, 124);
            this.txtRockstarPath.Name = "txtRockstarPath";
            this.txtRockstarPath.Size = new System.Drawing.Size(396, 20);
            this.txtRockstarPath.TabIndex = 8;
            this.txtRockstarPath.TextChanged += new System.EventHandler(this.txtRockstarPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "\'Rockstar Games\' directory with saves";
            // 
            // btnChooseSavesPath
            // 
            this.btnChooseSavesPath.Location = new System.Drawing.Point(421, 123);
            this.btnChooseSavesPath.Name = "btnChooseSavesPath";
            this.btnChooseSavesPath.Size = new System.Drawing.Size(75, 21);
            this.btnChooseSavesPath.TabIndex = 10;
            this.btnChooseSavesPath.Text = "Choose";
            this.btnChooseSavesPath.UseVisualStyleBackColor = true;
            this.btnChooseSavesPath.Click += new System.EventHandler(this.btnChooseSavesPath_Click);
            // 
            // txtProfilesPath
            // 
            this.txtProfilesPath.Location = new System.Drawing.Point(16, 163);
            this.txtProfilesPath.Name = "txtProfilesPath";
            this.txtProfilesPath.Size = new System.Drawing.Size(396, 20);
            this.txtProfilesPath.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Where should I hold profiles?";
            // 
            // btnChooseAppPath
            // 
            this.btnChooseAppPath.Location = new System.Drawing.Point(421, 162);
            this.btnChooseAppPath.Name = "btnChooseAppPath";
            this.btnChooseAppPath.Size = new System.Drawing.Size(75, 21);
            this.btnChooseAppPath.TabIndex = 14;
            this.btnChooseAppPath.Text = "Choose";
            this.btnChooseAppPath.UseVisualStyleBackColor = true;
            this.btnChooseAppPath.Click += new System.EventHandler(this.btnChooseAppPath_Click);
            // 
            // chkSaveNearby
            // 
            this.chkSaveNearby.AutoSize = true;
            this.chkSaveNearby.Location = new System.Drawing.Point(163, 146);
            this.chkSaveNearby.Name = "chkSaveNearby";
            this.chkSaveNearby.Size = new System.Drawing.Size(100, 17);
            this.chkSaveNearby.TabIndex = 15;
            this.chkSaveNearby.Text = "Same as above";
            this.chkSaveNearby.UseVisualStyleBackColor = true;
            this.chkSaveNearby.CheckedChanged += new System.EventHandler(this.chkSaveClose_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 21);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(282, 79);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 21);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(84, 53);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(28, 13);
            this.lblCurrent.TabIndex = 18;
            this.lblCurrent.Text = "###";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Current profile:";
            // 
            // btnSaveOptions
            // 
            this.btnSaveOptions.Location = new System.Drawing.Point(16, 194);
            this.btnSaveOptions.Name = "btnSaveOptions";
            this.btnSaveOptions.Size = new System.Drawing.Size(87, 21);
            this.btnSaveOptions.TabIndex = 20;
            this.btnSaveOptions.Text = "Save options";
            this.btnSaveOptions.UseVisualStyleBackColor = true;
            this.btnSaveOptions.Click += new System.EventHandler(this.btnSaveOptions_Click);
            // 
            // btnValidatePaths
            // 
            this.btnValidatePaths.Location = new System.Drawing.Point(112, 194);
            this.btnValidatePaths.Name = "btnValidatePaths";
            this.btnValidatePaths.Size = new System.Drawing.Size(87, 21);
            this.btnValidatePaths.TabIndex = 21;
            this.btnValidatePaths.Text = "Validate Paths";
            this.btnValidatePaths.UseVisualStyleBackColor = true;
            this.btnValidatePaths.Click += new System.EventHandler(this.btnValidatePaths_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 227);
            this.Controls.Add(this.btnValidatePaths);
            this.Controls.Add(this.btnSaveOptions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkSaveNearby);
            this.Controls.Add(this.btnChooseAppPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProfilesPath);
            this.Controls.Add(this.btnChooseSavesPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRockstarPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkExists);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxProfile);
            this.Name = "MainForm";
            this.Text = "GTA V - Profile Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkExists;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRockstarPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChooseSavesPath;
        private System.Windows.Forms.TextBox txtProfilesPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChooseAppPath;
        private System.Windows.Forms.CheckBox chkSaveNearby;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSaveOptions;
        private System.Windows.Forms.Button btnValidatePaths;
    }
}

