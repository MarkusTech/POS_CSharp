
namespace POSales
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.txtComPass = new MetroFramework.Controls.MetroTextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 50);
            this.panel1.TabIndex = 8;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(418, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 35);
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Your Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.DisplayIcon = true;
            this.txtPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtPass.Icon")));
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(44, 144);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PromptText = "Current Password";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(361, 31);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSelectable = true;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WaterMark = "Current Password";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(100, 96);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 18);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(315, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.CustomButton.Image = null;
            this.txtNewPass.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtNewPass.CustomButton.Name = "";
            this.txtNewPass.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPass.CustomButton.TabIndex = 1;
            this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPass.CustomButton.UseSelectable = true;
            this.txtNewPass.CustomButton.Visible = false;
            this.txtNewPass.DisplayIcon = true;
            this.txtNewPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtNewPass.Icon")));
            this.txtNewPass.Lines = new string[0];
            this.txtNewPass.Location = new System.Drawing.Point(44, 144);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.PromptText = "New Password";
            this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.SelectionLength = 0;
            this.txtNewPass.SelectionStart = 0;
            this.txtNewPass.ShortcutsEnabled = true;
            this.txtNewPass.Size = new System.Drawing.Size(361, 31);
            this.txtNewPass.TabIndex = 14;
            this.txtNewPass.UseSelectable = true;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.Visible = false;
            this.txtNewPass.WaterMark = "New Password";
            this.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtComPass
            // 
            // 
            // 
            // 
            this.txtComPass.CustomButton.Image = null;
            this.txtComPass.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtComPass.CustomButton.Name = "";
            this.txtComPass.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtComPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComPass.CustomButton.TabIndex = 1;
            this.txtComPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComPass.CustomButton.UseSelectable = true;
            this.txtComPass.CustomButton.Visible = false;
            this.txtComPass.DisplayIcon = true;
            this.txtComPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtComPass.Icon")));
            this.txtComPass.Lines = new string[0];
            this.txtComPass.Location = new System.Drawing.Point(44, 193);
            this.txtComPass.MaxLength = 32767;
            this.txtComPass.Name = "txtComPass";
            this.txtComPass.PasswordChar = '●';
            this.txtComPass.PromptText = "Confirm Password";
            this.txtComPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComPass.SelectedText = "";
            this.txtComPass.SelectionLength = 0;
            this.txtComPass.SelectionStart = 0;
            this.txtComPass.ShortcutsEnabled = true;
            this.txtComPass.Size = new System.Drawing.Size(361, 31);
            this.txtComPass.TabIndex = 15;
            this.txtComPass.UseSelectable = true;
            this.txtComPass.UseSystemPasswordChar = true;
            this.txtComPass.Visible = false;
            this.txtComPass.WaterMark = "Confirm Password";
            this.txtComPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(315, 252);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 35);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 299);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtComPass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNewPass);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePassword_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtNewPass;
        private MetroFramework.Controls.MetroTextBox txtComPass;
        public System.Windows.Forms.Button btnNext;
    }
}