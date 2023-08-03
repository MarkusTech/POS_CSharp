
namespace POSales
{
    partial class CancelOrder
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
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelOrder));
            this.picClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPcode = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTransno = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCancelBy = new System.Windows.Forms.TextBox();
            this.txtVoidBy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboInventory = new System.Windows.Forms.ComboBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCOrder = new System.Windows.Forms.Button();
            this.udCancelQty = new System.Windows.Forms.NumericUpDown();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCancelQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            panel1.Controls.Add(this.picClose);
            panel1.Controls.Add(this.label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(894, 50);
            panel1.TabIndex = 9;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(865, 0);
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
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancel Order Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(177, 105);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(181, 26);
            this.txtId.TabIndex = 11;
            // 
            // txtPcode
            // 
            this.txtPcode.Enabled = false;
            this.txtPcode.Location = new System.Drawing.Point(177, 145);
            this.txtPcode.Name = "txtPcode";
            this.txtPcode.Size = new System.Drawing.Size(181, 26);
            this.txtPcode.TabIndex = 11;
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(177, 185);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(181, 63);
            this.txtDesc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transaction No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Qty / Discount";
            // 
            // txtTransno
            // 
            this.txtTransno.Enabled = false;
            this.txtTransno.Location = new System.Drawing.Point(531, 105);
            this.txtTransno.Name = "txtTransno";
            this.txtTransno.Size = new System.Drawing.Size(316, 26);
            this.txtTransno.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(531, 145);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(316, 26);
            this.txtPrice.TabIndex = 11;
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(531, 185);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(127, 26);
            this.txtQty.TabIndex = 11;
            // 
            // txtDisc
            // 
            this.txtDisc.Enabled = false;
            this.txtDisc.Location = new System.Drawing.Point(692, 185);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(155, 26);
            this.txtDisc.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(531, 225);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(316, 26);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(29, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "SOLD ITEM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(30, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "CANCEL ITEM(S)";
            // 
            // txtCancelBy
            // 
            this.txtCancelBy.Enabled = false;
            this.txtCancelBy.Location = new System.Drawing.Point(177, 351);
            this.txtCancelBy.Name = "txtCancelBy";
            this.txtCancelBy.Size = new System.Drawing.Size(181, 26);
            this.txtCancelBy.TabIndex = 16;
            // 
            // txtVoidBy
            // 
            this.txtVoidBy.Location = new System.Drawing.Point(177, 311);
            this.txtVoidBy.Name = "txtVoidBy";
            this.txtVoidBy.Size = new System.Drawing.Size(181, 26);
            this.txtVoidBy.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Add To Inventory ?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Cancelled By :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Void By :";
            // 
            // cboInventory
            // 
            this.cboInventory.FormattingEnabled = true;
            this.cboInventory.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboInventory.Location = new System.Drawing.Point(177, 394);
            this.cboInventory.Name = "cboInventory";
            this.cboInventory.Size = new System.Drawing.Size(181, 28);
            this.cboInventory.TabIndex = 18;
            this.cboInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboInventory_KeyPress);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(531, 348);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(316, 74);
            this.txtReason.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(394, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Reason(s) :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(394, 311);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Cancel Qty :";
            // 
            // btnCOrder
            // 
            this.btnCOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnCOrder.FlatAppearance.BorderSize = 0;
            this.btnCOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOrder.ForeColor = System.Drawing.Color.White;
            this.btnCOrder.Location = new System.Drawing.Point(692, 447);
            this.btnCOrder.Name = "btnCOrder";
            this.btnCOrder.Size = new System.Drawing.Size(155, 35);
            this.btnCOrder.TabIndex = 23;
            this.btnCOrder.Text = "Cance Order";
            this.btnCOrder.UseVisualStyleBackColor = false;
            this.btnCOrder.Click += new System.EventHandler(this.btnCOrder_Click);
            // 
            // udCancelQty
            // 
            this.udCancelQty.Location = new System.Drawing.Point(531, 311);
            this.udCancelQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udCancelQty.Name = "udCancelQty";
            this.udCancelQty.Size = new System.Drawing.Size(316, 26);
            this.udCancelQty.TabIndex = 24;
            this.udCancelQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 494);
            this.Controls.Add(this.udCancelQty);
            this.Controls.Add(this.btnCOrder);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboInventory);
            this.Controls.Add(this.txtCancelBy);
            this.Controls.Add(this.txtVoidBy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTransno);
            this.Controls.Add(this.txtPcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CancelOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelOrder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CancelOrder_KeyDown);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCancelQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button btnCOrder;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtPcode;
        public System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.TextBox txtTransno;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.TextBox txtDisc;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtCancelBy;
        public System.Windows.Forms.TextBox txtVoidBy;
        public System.Windows.Forms.ComboBox cboInventory;
        public System.Windows.Forms.TextBox txtReason;
        public System.Windows.Forms.NumericUpDown udCancelQty;
    }
}