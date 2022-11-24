
namespace KutuphaneOtomasyonu.Forms
{
    partial class frm_MemberUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MemberUpdate));
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sifreyiGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreyiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dt_Birthday = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Rch_Adress = new System.Windows.Forms.RichTextBox();
            this.Msk_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_NameSurname = new System.Windows.Forms.TextBox();
            this.Txt_TC = new System.Windows.Forms.TextBox();
            this.Cmb_Gender = new System.Windows.Forms.ComboBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Şifre";
            // 
            // Txt_Password
            // 
            this.Txt_Password.ContextMenuStrip = this.contextMenuStrip2;
            this.Txt_Password.Location = new System.Drawing.Point(131, 225);
            this.Txt_Password.MaxLength = 50;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(140, 23);
            this.Txt_Password.TabIndex = 6;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sifreyiGösterToolStripMenuItem,
            this.şifreyiKapatToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(144, 48);
            // 
            // sifreyiGösterToolStripMenuItem
            // 
            this.sifreyiGösterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sifreyiGösterToolStripMenuItem.Image")));
            this.sifreyiGösterToolStripMenuItem.Name = "sifreyiGösterToolStripMenuItem";
            this.sifreyiGösterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sifreyiGösterToolStripMenuItem.Text = "Sifreyi Göster";
            this.sifreyiGösterToolStripMenuItem.Click += new System.EventHandler(this.sifreyiGösterToolStripMenuItem_Click);
            // 
            // şifreyiKapatToolStripMenuItem
            // 
            this.şifreyiKapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("şifreyiKapatToolStripMenuItem.Image")));
            this.şifreyiKapatToolStripMenuItem.Name = "şifreyiKapatToolStripMenuItem";
            this.şifreyiKapatToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.şifreyiKapatToolStripMenuItem.Text = "Şifreyi Kapat";
            this.şifreyiKapatToolStripMenuItem.Click += new System.EventHandler(this.şifreyiKapatToolStripMenuItem_Click);
            // 
            // Dt_Birthday
            // 
            this.Dt_Birthday.Location = new System.Drawing.Point(131, 76);
            this.Dt_Birthday.Name = "Dt_Birthday";
            this.Dt_Birthday.Size = new System.Drawing.Size(141, 23);
            this.Dt_Birthday.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Üye Resim";
            // 
            // Rch_Adress
            // 
            this.Rch_Adress.Location = new System.Drawing.Point(130, 271);
            this.Rch_Adress.MaxLength = 75;
            this.Rch_Adress.Name = "Rch_Adress";
            this.Rch_Adress.Size = new System.Drawing.Size(140, 57);
            this.Rch_Adress.TabIndex = 7;
            this.Rch_Adress.Text = "";
            // 
            // Msk_Phone
            // 
            this.Msk_Phone.Location = new System.Drawing.Point(131, 146);
            this.Msk_Phone.Mask = "(999)000-0000";
            this.Msk_Phone.Name = "Msk_Phone";
            this.Msk_Phone.Size = new System.Drawing.Size(140, 23);
            this.Msk_Phone.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "TC";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(131, 181);
            this.Txt_Email.MaxLength = 50;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(140, 23);
            this.Txt_Email.TabIndex = 5;
            // 
            // Txt_NameSurname
            // 
            this.Txt_NameSurname.Location = new System.Drawing.Point(131, 41);
            this.Txt_NameSurname.MaxLength = 50;
            this.Txt_NameSurname.Name = "Txt_NameSurname";
            this.Txt_NameSurname.Size = new System.Drawing.Size(140, 23);
            this.Txt_NameSurname.TabIndex = 1;
            // 
            // Txt_TC
            // 
            this.Txt_TC.Location = new System.Drawing.Point(131, 6);
            this.Txt_TC.MaxLength = 11;
            this.Txt_TC.Name = "Txt_TC";
            this.Txt_TC.Size = new System.Drawing.Size(140, 23);
            this.Txt_TC.TabIndex = 0;
            // 
            // Cmb_Gender
            // 
            this.Cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Gender.FormattingEnabled = true;
            this.Cmb_Gender.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.Cmb_Gender.Location = new System.Drawing.Point(131, 111);
            this.Cmb_Gender.Name = "Cmb_Gender";
            this.Cmb_Gender.Size = new System.Drawing.Size(140, 23);
            this.Cmb_Gender.TabIndex = 3;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Clear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Clear.Location = new System.Drawing.Point(0, 437);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(282, 33);
            this.Btn_Clear.TabIndex = 9;
            this.Btn_Clear.Text = "TEMİZLE (F3)";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Blue;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.Location = new System.Drawing.Point(0, 470);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(282, 33);
            this.Btn_Update.TabIndex = 8;
            this.Btn_Update.Text = "GÜNCELLE(F2)";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(131, 343);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(140, 84);
            this.pictureEdit1.TabIndex = 52;
            // 
            // frm_MemberUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 503);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Dt_Birthday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Rch_Adress);
            this.Controls.Add(this.Msk_Phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_NameSurname);
            this.Controls.Add(this.Txt_TC);
            this.Controls.Add(this.Cmb_Gender);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_MemberUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgilerinizi Güncelle";
            this.Load += new System.EventHandler(this.frm_MemberUpdate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_MemberUpdate_KeyDown);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.DateTimePicker Dt_Birthday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox Rch_Adress;
        private System.Windows.Forms.MaskedTextBox Msk_Phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_NameSurname;
        private System.Windows.Forms.TextBox Txt_TC;
        private System.Windows.Forms.ComboBox Cmb_Gender;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sifreyiGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreyiKapatToolStripMenuItem;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}