namespace VetSystem
{
    partial class frmClientPage
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
            this.btnDelClient = new System.Windows.Forms.Button();
            this.flatStickyButton1 = new FlatUI.FlatStickyButton();
            this.flatAlertBox1 = new FlatUI.FlatAlertBox();
            this.btnSave = new FlatUI.FlatButton();
            this.flatStatusBar1 = new FlatUI.FlatStatusBar();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.flatGroupBox3 = new FlatUI.FlatGroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPayments = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flatGroupBox2 = new FlatUI.FlatGroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.formSkin1.SuspendLayout();
            this.flatGroupBox1.SuspendLayout();
            this.flatGroupBox3.SuspendLayout();
            this.flatGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.btnDelClient);
            this.formSkin1.Controls.Add(this.flatStickyButton1);
            this.formSkin1.Controls.Add(this.flatAlertBox1);
            this.formSkin1.Controls.Add(this.btnSave);
            this.formSkin1.Controls.Add(this.flatStatusBar1);
            this.formSkin1.Controls.Add(this.flatGroupBox1);
            this.formSkin1.Controls.Add(this.flatGroupBox3);
            this.formSkin1.Controls.Add(this.flatGroupBox2);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(1032, 666);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "صفحة العميل";
            // 
            // btnDelClient
            // 
            this.btnDelClient.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelClient.Location = new System.Drawing.Point(507, 572);
            this.btnDelClient.Name = "btnDelClient";
            this.btnDelClient.Size = new System.Drawing.Size(118, 39);
            this.btnDelClient.TabIndex = 46;
            this.btnDelClient.Text = "حذف العميل !";
            this.btnDelClient.UseVisualStyleBackColor = false;
            this.btnDelClient.Click += new System.EventHandler(this.btnDelClient_Click);
            // 
            // flatStickyButton1
            // 
            this.flatStickyButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton1.Location = new System.Drawing.Point(987, 0);
            this.flatStickyButton1.Name = "flatStickyButton1";
            this.flatStickyButton1.Rounded = false;
            this.flatStickyButton1.Size = new System.Drawing.Size(45, 42);
            this.flatStickyButton1.TabIndex = 45;
            this.flatStickyButton1.Text = "X";
            this.flatStickyButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatStickyButton1.Click += new System.EventHandler(this.flatStickyButton1_Click);
            // 
            // flatAlertBox1
            // 
            this.flatAlertBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatAlertBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatAlertBox1.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.flatAlertBox1.Location = new System.Drawing.Point(228, 0);
            this.flatAlertBox1.Name = "flatAlertBox1";
            this.flatAlertBox1.Size = new System.Drawing.Size(576, 42);
            this.flatAlertBox1.TabIndex = 44;
            this.flatAlertBox1.Text = "flatAlertBox1";
            this.flatAlertBox1.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Location = new System.Drawing.Point(803, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rounded = false;
            this.btnSave.Size = new System.Drawing.Size(187, 71);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "حفظ التغييرات";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flatStatusBar1
            // 
            this.flatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatStatusBar1.ForeColor = System.Drawing.Color.White;
            this.flatStatusBar1.Location = new System.Drawing.Point(0, 643);
            this.flatStatusBar1.Name = "flatStatusBar1";
            this.flatStatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStatusBar1.ShowTimeDate = false;
            this.flatStatusBar1.Size = new System.Drawing.Size(1032, 23);
            this.flatStatusBar1.TabIndex = 30;
            this.flatStatusBar1.Text = "مركز النور الإستشاري البيطري";
            this.flatStatusBar1.TextColor = System.Drawing.Color.White;
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatGroupBox1.Controls.Add(this.label1);
            this.flatGroupBox1.Controls.Add(this.txtClientName);
            this.flatGroupBox1.Controls.Add(this.label3);
            this.flatGroupBox1.Controls.Add(this.txtPhone);
            this.flatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox1.Location = new System.Drawing.Point(507, 55);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = true;
            this.flatGroupBox1.Size = new System.Drawing.Size(494, 158);
            this.flatGroupBox1.TabIndex = 27;
            this.flatGroupBox1.Text = "بيانات العميل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "اسم العميل";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(23, 46);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(321, 27);
            this.txtClientName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "التليفون";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(23, 91);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(321, 27);
            this.txtPhone.TabIndex = 2;
            // 
            // flatGroupBox3
            // 
            this.flatGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatGroupBox3.Controls.Add(this.label5);
            this.flatGroupBox3.Controls.Add(this.txtPayments);
            this.flatGroupBox3.Controls.Add(this.txtPaid);
            this.flatGroupBox3.Controls.Add(this.label7);
            this.flatGroupBox3.Controls.Add(this.txtRemain);
            this.flatGroupBox3.Controls.Add(this.label6);
            this.flatGroupBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox3.Location = new System.Drawing.Point(507, 219);
            this.flatGroupBox3.Name = "flatGroupBox3";
            this.flatGroupBox3.ShowText = true;
            this.flatGroupBox3.Size = new System.Drawing.Size(497, 240);
            this.flatGroupBox3.TabIndex = 29;
            this.flatGroupBox3.Text = "البيانات المالية للعميل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "المستحقات";
            // 
            // txtPayments
            // 
            this.txtPayments.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayments.Location = new System.Drawing.Point(39, 56);
            this.txtPayments.Name = "txtPayments";
            this.txtPayments.Size = new System.Drawing.Size(321, 27);
            this.txtPayments.TabIndex = 3;
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(39, 111);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(321, 27);
            this.txtPaid.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "دفع";
            // 
            // txtRemain
            // 
            this.txtRemain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemain.Location = new System.Drawing.Point(39, 180);
            this.txtRemain.Name = "txtRemain";
            this.txtRemain.Size = new System.Drawing.Size(321, 27);
            this.txtRemain.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "الباقي";
            // 
            // flatGroupBox2
            // 
            this.flatGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatGroupBox2.Controls.Add(this.txtNotes);
            this.flatGroupBox2.Controls.Add(this.label4);
            this.flatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox2.Location = new System.Drawing.Point(24, 55);
            this.flatGroupBox2.Name = "flatGroupBox2";
            this.flatGroupBox2.ShowText = true;
            this.flatGroupBox2.Size = new System.Drawing.Size(477, 587);
            this.flatGroupBox2.TabIndex = 28;
            this.flatGroupBox2.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNotes.Location = new System.Drawing.Point(25, 59);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(423, 497);
            this.txtNotes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "ملاحظات";
            // 
            // frmClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(144)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1032, 666);
            this.Controls.Add(this.formSkin1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmClientPage_Load);
            this.formSkin1.ResumeLayout(false);
            this.flatGroupBox1.ResumeLayout(false);
            this.flatGroupBox1.PerformLayout();
            this.flatGroupBox3.ResumeLayout(false);
            this.flatGroupBox3.PerformLayout();
            this.flatGroupBox2.ResumeLayout(false);
            this.flatGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatStatusBar flatStatusBar1;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private FlatUI.FlatGroupBox flatGroupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPayments;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemain;
        private System.Windows.Forms.Label label6;
        private FlatUI.FlatGroupBox flatGroupBox2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label4;
        private FlatUI.FlatButton btnSave;
        private FlatUI.FlatAlertBox flatAlertBox1;
        private FlatUI.FlatStickyButton flatStickyButton1;
        private System.Windows.Forms.Button btnDelClient;

    }
}