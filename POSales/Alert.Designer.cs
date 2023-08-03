
namespace POSales
{
    partial class Alert
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPcode = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReorder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPcode);
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnReorder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 75);
            this.panel1.TabIndex = 0;
            // 
            // lblPcode
            // 
            this.lblPcode.AutoSize = true;
            this.lblPcode.Location = new System.Drawing.Point(343, 54);
            this.lblPcode.Name = "lblPcode";
            this.lblPcode.Size = new System.Drawing.Size(20, 17);
            this.lblPcode.TabIndex = 7;
            this.lblPcode.Text = "lb";
            this.lblPcode.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(73, 4);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(245, 57);
            this.lblMsg.TabIndex = 6;
            this.lblMsg.Text = "Message Text";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(324, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReorder
            // 
            this.btnReorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReorder.BackgroundImage")));
            this.btnReorder.Enabled = false;
            this.btnReorder.FlatAppearance.BorderSize = 0;
            this.btnReorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReorder.ForeColor = System.Drawing.Color.White;
            this.btnReorder.Location = new System.Drawing.Point(8, 7);
            this.btnReorder.Name = "btnReorder";
            this.btnReorder.Size = new System.Drawing.Size(50, 50);
            this.btnReorder.TabIndex = 4;
            this.btnReorder.UseVisualStyleBackColor = true;
            this.btnReorder.Click += new System.EventHandler(this.btnReorder_Click);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(370, 75);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Alert";
            this.Text = "Alert";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblPcode;
        public System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.Button btnReorder;
    }
}