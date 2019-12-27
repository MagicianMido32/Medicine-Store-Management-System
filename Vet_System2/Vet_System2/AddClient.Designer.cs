namespace VetSystem
{
    partial class AddClient
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatAlertBox1 = new FlatUI.FlatAlertBox();
            this.flatStickyButton1 = new FlatUI.FlatStickyButton();
            this.flatGroupBox2 = new FlatUI.FlatGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.flatStatusBar1 = new FlatUI.FlatStatusBar();
            this.btnAddClient = new FlatUI.FlatButton();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.txtPayments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.formSkin1.SuspendLayout();
            this.flatGroupBox2.SuspendLayout();
            this.flatGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatAlertBox1);
            this.formSkin1.Controls.Add(this.flatStickyButton1);
            this.formSkin1.Controls.Add(this.flatGroupBox2);
            this.formSkin1.Controls.Add(this.flatStatusBar1);
            this.formSkin1.Controls.Add(this.btnAddClient);
            this.formSkin1.Controls.Add(this.flatGroupBox1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(1076, 534);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "إضافة عميل جديد";
            // 
            // flatAlertBox1
            // 
            this.flatAlertBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatAlertBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatAlertBox1.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.flatAlertBox1.Location = new System.Drawing.Point(250, 0);
            this.flatAlertBox1.Name = "flatAlertBox1";
            this.flatAlertBox1.Size = new System.Drawing.Size(576, 42);
            this.flatAlertBox1.TabIndex = 43;
            this.flatAlertBox1.Text = "flatAlertBox1";
            this.flatAlertBox1.Visible = false;
            // 
            // flatStickyButton1
            // 
            this.flatStickyButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton1.Location = new System.Drawing.Point(1023, 3);
            this.flatStickyButton1.Name = "flatStickyButton1";
            this.flatStickyButton1.Rounded = false;
            this.flatStickyButton1.Size = new System.Drawing.Size(50, 39);
            this.flatStickyButton1.TabIndex = 42;
            this.flatStickyButton1.Text = "X";
            this.flatStickyButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatStickyButton1.Click += new System.EventHandler(this.flatStickyButton1_Click);
            // 
            // flatGroupBox2
            // 
            this.flatGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatGroupBox2.Controls.Add(this.label4);
            this.flatGroupBox2.Controls.Add(this.txtNotes);
            this.flatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox2.Location = new System.Drawing.Point(31, 60);
            this.flatGroupBox2.Name = "flatGroupBox2";
            this.flatGroupBox2.ShowText = true;
            this.flatGroupBox2.Size = new System.Drawing.Size(464, 445);
            this.flatGroupBox2.TabIndex = 40;
            this.flatGroupBox2.Text = "ملاحظات العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(363, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNotes.Location = new System.Drawing.Point(22, 61);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(417, 358);
            this.txtNotes.TabIndex = 4;
            // 
            // flatStatusBar1
            // 
            this.flatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatStatusBar1.ForeColor = System.Drawing.Color.White;
            this.flatStatusBar1.Location = new System.Drawing.Point(0, 511);
            this.flatStatusBar1.Name = "flatStatusBar1";
            this.flatStatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStatusBar1.ShowTimeDate = false;
            this.flatStatusBar1.Size = new System.Drawing.Size(1076, 23);
            this.flatStatusBar1.TabIndex = 39;
            this.flatStatusBar1.Text = "مركز النور الإستشاري البيطري";
            this.flatStatusBar1.TextColor = System.Drawing.Color.White;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClient.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddClient.Location = new System.Drawing.Point(815, 408);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Rounded = false;
            this.btnAddClient.Size = new System.Drawing.Size(187, 71);
            this.btnAddClient.TabIndex = 38;
            this.btnAddClient.Text = "أضافة عميل";
            this.btnAddClient.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatGroupBox1.Controls.Add(this.txtPayments);
            this.flatGroupBox1.Controls.Add(this.label1);
            this.flatGroupBox1.Controls.Add(this.txtPhone);
            this.flatGroupBox1.Controls.Add(this.label3);
            this.flatGroupBox1.Controls.Add(this.label5);
            this.flatGroupBox1.Controls.Add(this.txtClientName);
            this.flatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox1.Location = new System.Drawing.Point(501, 60);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = true;
            this.flatGroupBox1.Size = new System.Drawing.Size(539, 223);
            this.flatGroupBox1.TabIndex = 37;
            this.flatGroupBox1.Text = "بيانات العميل";
            // 
            // txtPayments
            // 
            this.txtPayments.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayments.Location = new System.Drawing.Point(41, 147);
            this.txtPayments.Name = "txtPayments";
            this.txtPayments.Size = new System.Drawing.Size(321, 27);
            this.txtPayments.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "اسم العميل";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(41, 96);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(321, 27);
            this.txtPhone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(433, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "التليفون";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(402, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "المستحقات";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(41, 48);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(321, 27);
            this.txtClientName.TabIndex = 1;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1076, 534);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة عميل";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.flatGroupBox2.ResumeLayout(false);
            this.flatGroupBox2.PerformLayout();
            this.flatGroupBox1.ResumeLayout(false);
            this.flatGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label4;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private System.Windows.Forms.TextBox txtPayments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientName;
        private FlatUI.FlatGroupBox flatGroupBox2;
        private FlatUI.FlatStatusBar flatStatusBar1;
        private FlatUI.FlatButton btnAddClient;
        private FlatUI.FlatStickyButton flatStickyButton1;
        private FlatUI.FlatAlertBox flatAlertBox1;

    }
}