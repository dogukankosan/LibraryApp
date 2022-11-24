
namespace KutuphaneOtomasyonu.Forms
{
    partial class frm_MemberList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MemberList));
            this.Dt_Birthday = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Rch_Adress = new System.Windows.Forms.RichTextBox();
            this.Msk_Phone = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
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
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sifreyiGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreyiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excelAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_Punishment = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Dt_Birthday
            // 
            this.Dt_Birthday.Location = new System.Drawing.Point(121, 79);
            this.Dt_Birthday.MaxDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.Dt_Birthday.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.Dt_Birthday.Name = "Dt_Birthday";
            this.Dt_Birthday.Size = new System.Drawing.Size(141, 23);
            this.Dt_Birthday.TabIndex = 2;
            this.Dt_Birthday.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(2, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Üye Resim";
            // 
            // Rch_Adress
            // 
            this.Rch_Adress.Location = new System.Drawing.Point(120, 274);
            this.Rch_Adress.MaxLength = 75;
            this.Rch_Adress.Name = "Rch_Adress";
            this.Rch_Adress.Size = new System.Drawing.Size(140, 57);
            this.Rch_Adress.TabIndex = 6;
            this.Rch_Adress.Text = "";
            // 
            // Msk_Phone
            // 
            this.Msk_Phone.Location = new System.Drawing.Point(121, 149);
            this.Msk_Phone.Mask = "(999)000-0000";
            this.Msk_Phone.Name = "Msk_Phone";
            this.Msk_Phone.Size = new System.Drawing.Size(140, 23);
            this.Msk_Phone.TabIndex = 4;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Blue;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.Location = new System.Drawing.Point(0, 555);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(262, 33);
            this.Btn_Update.TabIndex = 8;
            this.Btn_Update.Text = "GÜNCELLE(F2)";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(2, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(2, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(2, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "TC";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(121, 184);
            this.Txt_Email.MaxLength = 50;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(140, 23);
            this.Txt_Email.TabIndex = 5;
            // 
            // Txt_NameSurname
            // 
            this.Txt_NameSurname.Location = new System.Drawing.Point(121, 44);
            this.Txt_NameSurname.MaxLength = 50;
            this.Txt_NameSurname.Name = "Txt_NameSurname";
            this.Txt_NameSurname.Size = new System.Drawing.Size(140, 23);
            this.Txt_NameSurname.TabIndex = 1;
            this.Txt_NameSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NameSurname_KeyPress);
            // 
            // Txt_TC
            // 
            this.Txt_TC.Location = new System.Drawing.Point(121, 9);
            this.Txt_TC.MaxLength = 11;
            this.Txt_TC.Name = "Txt_TC";
            this.Txt_TC.Size = new System.Drawing.Size(140, 23);
            this.Txt_TC.TabIndex = 0;
            this.Txt_TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_TC_KeyPress);
            // 
            // Cmb_Gender
            // 
            this.Cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Gender.FormattingEnabled = true;
            this.Cmb_Gender.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.Cmb_Gender.Location = new System.Drawing.Point(121, 114);
            this.Cmb_Gender.Name = "Cmb_Gender";
            this.Cmb_Gender.Size = new System.Drawing.Size(140, 23);
            this.Cmb_Gender.TabIndex = 3;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Delete.Location = new System.Drawing.Point(0, 522);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(262, 33);
            this.Btn_Delete.TabIndex = 7;
            this.Btn_Delete.Text = "SİL (F5)";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Clear.Location = new System.Drawing.Point(0, 489);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(262, 33);
            this.Btn_Clear.TabIndex = 9;
            this.Btn_Clear.Text = "TEMİZLE (F3)";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(2, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Şifre";
            // 
            // Txt_Password
            // 
            this.Txt_Password.ContextMenuStrip = this.contextMenuStrip2;
            this.Txt_Password.Location = new System.Drawing.Point(121, 228);
            this.Txt_Password.MaxLength = 50;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(140, 23);
            this.Txt_Password.TabIndex = 32;
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
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(268, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(675, 591);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelAlToolStripMenuItem,
            this.pdfAlToolStripMenuItem,
            this.resimAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 70);
            // 
            // excelAlToolStripMenuItem
            // 
            this.excelAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excelAlToolStripMenuItem.Image")));
            this.excelAlToolStripMenuItem.Name = "excelAlToolStripMenuItem";
            this.excelAlToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.excelAlToolStripMenuItem.Text = "Excel Al";
            this.excelAlToolStripMenuItem.Click += new System.EventHandler(this.excelAlToolStripMenuItem_Click);
            // 
            // pdfAlToolStripMenuItem
            // 
            this.pdfAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pdfAlToolStripMenuItem.Image")));
            this.pdfAlToolStripMenuItem.Name = "pdfAlToolStripMenuItem";
            this.pdfAlToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.pdfAlToolStripMenuItem.Text = "Pdf Al";
            this.pdfAlToolStripMenuItem.Click += new System.EventHandler(this.pdfAlToolStripMenuItem_Click);
            // 
            // resimAlToolStripMenuItem
            // 
            this.resimAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resimAlToolStripMenuItem.Image")));
            this.resimAlToolStripMenuItem.Name = "resimAlToolStripMenuItem";
            this.resimAlToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.resimAlToolStripMenuItem.Text = "Resim Al";
            this.resimAlToolStripMenuItem.Click += new System.EventHandler(this.resimAlToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(120, 346);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(142, 104);
            this.pictureEdit1.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(16, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "Üyenin Cezası ₺";
            // 
            // Lbl_Punishment
            // 
            this.Lbl_Punishment.AutoSize = true;
            this.Lbl_Punishment.Location = new System.Drawing.Point(120, 460);
            this.Lbl_Punishment.Name = "Lbl_Punishment";
            this.Lbl_Punishment.Size = new System.Drawing.Size(13, 15);
            this.Lbl_Punishment.TabIndex = 37;
            this.Lbl_Punishment.Text = "0";
            // 
            // frm_MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(943, 591);
            this.Controls.Add(this.Lbl_Punishment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Dt_Birthday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Rch_Adress);
            this.Controls.Add(this.Msk_Phone);
            this.Controls.Add(this.Btn_Update);
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
            this.Name = "frm_MemberList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Listesi";
            this.Load += new System.EventHandler(this.frm_MemberList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_MemberList_KeyDown);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Dt_Birthday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox Rch_Adress;
        private System.Windows.Forms.MaskedTextBox Msk_Phone;
        private System.Windows.Forms.Button Btn_Update;
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
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sifreyiGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreyiKapatToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excelAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimAlToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_Punishment;
    }
}