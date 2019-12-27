namespace Vet_System2
{
    partial class frmErrorHandel
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
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatStickyButton1 = new FlatUI.FlatStickyButton();
            this.txtError = new FlatUI.FlatTextBox();
            this.flatStatusBar1 = new FlatUI.FlatStatusBar();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatAlertBox1 = new FlatUI.FlatAlertBox();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatLabel3);
            this.formSkin1.Controls.Add(this.flatStickyButton1);
            this.formSkin1.Controls.Add(this.txtError);
            this.formSkin1.Controls.Add(this.flatStatusBar1);
            this.formSkin1.Controls.Add(this.flatLabel2);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.flatAlertBox1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(583, 443);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "حدث خطأ";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(121, 337);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(340, 17);
            this.flatLabel3.TabIndex = 47;
            this.flatLabel3.Text = "تم حفظ كود الخطأ بجوار البرنامج في ملف بإسم Error Report";
            // 
            // flatStickyButton1
            // 
            this.flatStickyButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton1.Location = new System.Drawing.Point(538, 0);
            this.flatStickyButton1.Name = "flatStickyButton1";
            this.flatStickyButton1.Rounded = false;
            this.flatStickyButton1.Size = new System.Drawing.Size(45, 42);
            this.flatStickyButton1.TabIndex = 46;
            this.flatStickyButton1.Text = "X";
            this.flatStickyButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatStickyButton1.Click += new System.EventHandler(this.flatStickyButton1_Click);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.Transparent;
            this.txtError.FocusOnHover = false;
            this.txtError.Location = new System.Drawing.Point(48, 133);
            this.txtError.MaxLength = 32767;
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = false;
            this.txtError.Size = new System.Drawing.Size(486, 201);
            this.txtError.TabIndex = 4;
            this.txtError.Text = "txtError";
            this.txtError.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtError.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtError.UseSystemPasswordChar = false;
            // 
            // flatStatusBar1
            // 
            this.flatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatStatusBar1.ForeColor = System.Drawing.Color.White;
            this.flatStatusBar1.Location = new System.Drawing.Point(0, 420);
            this.flatStatusBar1.Name = "flatStatusBar1";
            this.flatStatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStatusBar1.ShowTimeDate = false;
            this.flatStatusBar1.Size = new System.Drawing.Size(583, 23);
            this.flatStatusBar1.TabIndex = 3;
            this.flatStatusBar1.Text = "حدث خطأ منطقي";
            this.flatStatusBar1.TextColor = System.Drawing.Color.White;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(250, 381);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(83, 30);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "XXXXX";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(128, 109);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(328, 21);
            this.flatLabel1.TabIndex = 1;
            this.flatLabel1.Text = "يرجى إرسال كود الخطأ الى المبرمج على هذا الرقم ";
            // 
            // flatAlertBox1
            // 
            this.flatAlertBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatAlertBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatAlertBox1.kind = FlatUI.FlatAlertBox._Kind.Error;
            this.flatAlertBox1.Location = new System.Drawing.Point(3, 52);
            this.flatAlertBox1.Name = "flatAlertBox1";
            this.flatAlertBox1.Size = new System.Drawing.Size(576, 42);
            this.flatAlertBox1.TabIndex = 0;
            this.flatAlertBox1.Text = "حدث خطأ منطقي أثناء تنفيذ عمليات البرنامج , يرجى مراسلة المبرمج";
            this.flatAlertBox1.Visible = false;
            // 
            // frmErrorHandel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 443);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmErrorHandel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmErrorHandel";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmErrorHandel_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatTextBox txtError;
        private FlatUI.FlatStatusBar flatStatusBar1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatAlertBox flatAlertBox1;
        private FlatUI.FlatStickyButton flatStickyButton1;
        private FlatUI.FlatLabel flatLabel3;
    }
}