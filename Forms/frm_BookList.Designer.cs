
namespace KutuphaneOtomasyonu.Forms
{
    partial class frm_BookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BookList));
            this.Msk_BarcodeNo = new System.Windows.Forms.MaskedTextBox();
            this.nmr_StockCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmr_PageCount = new System.Windows.Forms.NumericUpDown();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Cmb_Publisher = new System.Windows.Forms.ComboBox();
            this.Cbm_BookType = new System.Windows.Forms.ComboBox();
            this.Rch_Description = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_RackNo = new System.Windows.Forms.TextBox();
            this.Txt_Writer = new System.Windows.Forms.TextBox();
            this.Txt_BookName = new System.Windows.Forms.TextBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excelAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_StockCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_PageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Msk_BarcodeNo
            // 
            this.Msk_BarcodeNo.Location = new System.Drawing.Point(108, 14);
            this.Msk_BarcodeNo.Mask = "0-000000-000000";
            this.Msk_BarcodeNo.Name = "Msk_BarcodeNo";
            this.Msk_BarcodeNo.Size = new System.Drawing.Size(155, 23);
            this.Msk_BarcodeNo.TabIndex = 0;
            this.Msk_BarcodeNo.ValidatingType = typeof(int);
            // 
            // nmr_StockCount
            // 
            this.nmr_StockCount.InterceptArrowKeys = false;
            this.nmr_StockCount.Location = new System.Drawing.Point(108, 260);
            this.nmr_StockCount.Name = "nmr_StockCount";
            this.nmr_StockCount.Size = new System.Drawing.Size(155, 23);
            this.nmr_StockCount.TabIndex = 6;
            this.nmr_StockCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmr_StockCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Stok Sayısı";
            // 
            // nmr_PageCount
            // 
            this.nmr_PageCount.InterceptArrowKeys = false;
            this.nmr_PageCount.Location = new System.Drawing.Point(108, 178);
            this.nmr_PageCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmr_PageCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_PageCount.Name = "nmr_PageCount";
            this.nmr_PageCount.Size = new System.Drawing.Size(155, 23);
            this.nmr_PageCount.TabIndex = 4;
            this.nmr_PageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmr_PageCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Green;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Update.Location = new System.Drawing.Point(284, 358);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(270, 60);
            this.Btn_Update.TabIndex = 9;
            this.Btn_Update.Text = "GÜNCELLE (F2)";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Cmb_Publisher
            // 
            this.Cmb_Publisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Publisher.FormattingEnabled = true;
            this.Cmb_Publisher.Location = new System.Drawing.Point(108, 137);
            this.Cmb_Publisher.Name = "Cmb_Publisher";
            this.Cmb_Publisher.Size = new System.Drawing.Size(155, 23);
            this.Cmb_Publisher.TabIndex = 3;
            // 
            // Cbm_BookType
            // 
            this.Cbm_BookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbm_BookType.FormattingEnabled = true;
            this.Cbm_BookType.Location = new System.Drawing.Point(108, 219);
            this.Cbm_BookType.Name = "Cbm_BookType";
            this.Cbm_BookType.Size = new System.Drawing.Size(155, 23);
            this.Cbm_BookType.TabIndex = 5;
            // 
            // Rch_Description
            // 
            this.Rch_Description.Location = new System.Drawing.Point(108, 342);
            this.Rch_Description.MaxLength = 100;
            this.Rch_Description.Name = "Rch_Description";
            this.Rch_Description.Size = new System.Drawing.Size(155, 71);
            this.Rch_Description.TabIndex = 8;
            this.Rch_Description.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Açıklama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Raf No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kitap Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yayın Evi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Barkod No";
            // 
            // Txt_RackNo
            // 
            this.Txt_RackNo.Location = new System.Drawing.Point(108, 301);
            this.Txt_RackNo.Name = "Txt_RackNo";
            this.Txt_RackNo.Size = new System.Drawing.Size(155, 23);
            this.Txt_RackNo.TabIndex = 7;
            // 
            // Txt_Writer
            // 
            this.Txt_Writer.Location = new System.Drawing.Point(108, 96);
            this.Txt_Writer.MaxLength = 50;
            this.Txt_Writer.Name = "Txt_Writer";
            this.Txt_Writer.Size = new System.Drawing.Size(155, 23);
            this.Txt_Writer.TabIndex = 2;
            this.Txt_Writer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Writer_KeyPress);
            // 
            // Txt_BookName
            // 
            this.Txt_BookName.Location = new System.Drawing.Point(108, 55);
            this.Txt_BookName.MaxLength = 50;
            this.Txt_BookName.Name = "Txt_BookName";
            this.Txt_BookName.Size = new System.Drawing.Size(155, 23);
            this.Txt_BookName.TabIndex = 1;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Delete.Location = new System.Drawing.Point(284, 298);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(270, 60);
            this.Btn_Delete.TabIndex = 10;
            this.Btn_Delete.Text = "SİL (F5)";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Clear.Location = new System.Drawing.Point(284, 238);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(270, 60);
            this.Btn_Clear.TabIndex = 11;
            this.Btn_Clear.Text = "TEMİZLE (F3)";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(271, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Kitap Resim";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(564, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(741, 427);
            this.gridControl1.TabIndex = 33;
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
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(365, 14);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(193, 84);
            this.pictureEdit1.TabIndex = 34;
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
            this.pdfAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pdfAlToolStripMenuItem.Text = "Pdf Al";
            this.pdfAlToolStripMenuItem.Click += new System.EventHandler(this.pdfAlToolStripMenuItem_Click);
            // 
            // resimAlToolStripMenuItem
            // 
            this.resimAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resimAlToolStripMenuItem.Image")));
            this.resimAlToolStripMenuItem.Name = "resimAlToolStripMenuItem";
            this.resimAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resimAlToolStripMenuItem.Text = "Resim Al";
            this.resimAlToolStripMenuItem.Click += new System.EventHandler(this.resimAlToolStripMenuItem_Click);
            // 
            // frm_BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1305, 427);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Msk_BarcodeNo);
            this.Controls.Add(this.nmr_StockCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nmr_PageCount);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Cmb_Publisher);
            this.Controls.Add(this.Cbm_BookType);
            this.Controls.Add(this.Rch_Description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_RackNo);
            this.Controls.Add(this.Txt_Writer);
            this.Controls.Add(this.Txt_BookName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_BookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.frm_BookList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_BookList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_StockCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_PageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox Msk_BarcodeNo;
        private System.Windows.Forms.NumericUpDown nmr_StockCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmr_PageCount;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.ComboBox Cmb_Publisher;
        private System.Windows.Forms.ComboBox Cbm_BookType;
        private System.Windows.Forms.RichTextBox Rch_Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_RackNo;
        private System.Windows.Forms.TextBox Txt_Writer;
        private System.Windows.Forms.TextBox Txt_BookName;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excelAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimAlToolStripMenuItem;
    }
}