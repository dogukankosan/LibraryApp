
namespace KutuphaneOtomasyonu.Forms
{
    partial class frm_AdminAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AdminAdd));
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.şifreyiGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreyiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.excelAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(5, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Şifre";
            // 
            // Txt_Password
            // 
            this.Txt_Password.ContextMenuStrip = this.contextMenuStrip2;
            this.Txt_Password.Location = new System.Drawing.Point(120, 47);
            this.Txt_Password.MaxLength = 50;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(147, 23);
            this.Txt_Password.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreyiGösterToolStripMenuItem,
            this.şifreyiKapatToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(144, 48);
            // 
            // şifreyiGösterToolStripMenuItem
            // 
            this.şifreyiGösterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("şifreyiGösterToolStripMenuItem.Image")));
            this.şifreyiGösterToolStripMenuItem.Name = "şifreyiGösterToolStripMenuItem";
            this.şifreyiGösterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.şifreyiGösterToolStripMenuItem.Text = "Şifreyi Göster";
            this.şifreyiGösterToolStripMenuItem.Click += new System.EventHandler(this.şifreyiGösterToolStripMenuItem_Click);
            // 
            // şifreyiKapatToolStripMenuItem
            // 
            this.şifreyiKapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("şifreyiKapatToolStripMenuItem.Image")));
            this.şifreyiKapatToolStripMenuItem.Name = "şifreyiKapatToolStripMenuItem";
            this.şifreyiKapatToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.şifreyiKapatToolStripMenuItem.Text = "Şifreyi Kapat";
            this.şifreyiKapatToolStripMenuItem.Click += new System.EventHandler(this.şifreyiKapatToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(5, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "E-Mail";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(120, 82);
            this.Txt_Email.MaxLength = 50;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(147, 23);
            this.Txt_Email.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİLToolStripMenuItem,
            this.excelAlToolStripMenuItem,
            this.pDFAlToolStripMenuItem,
            this.htmlAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 92);
            // 
            // sİLToolStripMenuItem
            // 
            this.sİLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sİLToolStripMenuItem.Image")));
            this.sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            this.sİLToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.sİLToolStripMenuItem.Text = "SİL";
            this.sİLToolStripMenuItem.Click += new System.EventHandler(this.sİLToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(120, 12);
            this.Txt_UserName.MaxLength = 50;
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(147, 23);
            this.Txt_UserName.TabIndex = 0;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.Lime;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Add.Location = new System.Drawing.Point(0, 212);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(273, 33);
            this.Btn_Add.TabIndex = 5;
            this.Btn_Add.Text = "EKLE (F2)";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Blue;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(0, 179);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(273, 33);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "GÜNCELLE (F5)";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Clear.Location = new System.Drawing.Point(0, 146);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(273, 33);
            this.Btn_Clear.TabIndex = 3;
            this.Btn_Clear.Text = "TEMİZLE (F3)";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(273, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(430, 249);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // excelAlToolStripMenuItem
            // 
            this.excelAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excelAlToolStripMenuItem.Image")));
            this.excelAlToolStripMenuItem.Name = "excelAlToolStripMenuItem";
            this.excelAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excelAlToolStripMenuItem.Text = "Excel Al";
            this.excelAlToolStripMenuItem.Click += new System.EventHandler(this.excelAlToolStripMenuItem_Click);
            // 
            // pDFAlToolStripMenuItem
            // 
            this.pDFAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pDFAlToolStripMenuItem.Image")));
            this.pDFAlToolStripMenuItem.Name = "pDFAlToolStripMenuItem";
            this.pDFAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pDFAlToolStripMenuItem.Text = "PDF Al";
            this.pDFAlToolStripMenuItem.Click += new System.EventHandler(this.pDFAlToolStripMenuItem_Click);
            // 
            // htmlAlToolStripMenuItem
            // 
            this.htmlAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("htmlAlToolStripMenuItem.Image")));
            this.htmlAlToolStripMenuItem.Name = "htmlAlToolStripMenuItem";
            this.htmlAlToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.htmlAlToolStripMenuItem.Text = "Resim Al";
            this.htmlAlToolStripMenuItem.Click += new System.EventHandler(this.htmlAlToolStripMenuItem_Click);
            // 
            // frm_AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(703, 249);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_AdminAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Hesabı Aç-Düzenle";
            this.Load += new System.EventHandler(this.frm_AdminAdd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_AdminAdd_KeyDown);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sİLToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem şifreyiGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreyiKapatToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripMenuItem excelAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlAlToolStripMenuItem;
    }
}