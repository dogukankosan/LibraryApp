
namespace KutuphaneOtomasyonu.Forms
{
    partial class frm_BookAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BookAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_BookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Writer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_RackNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Rch_Description = new System.Windows.Forms.RichTextBox();
            this.Cbm_BookType = new System.Windows.Forms.ComboBox();
            this.Cmb_Publisher = new System.Windows.Forms.ComboBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.nmr_PageCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmr_StockCount = new System.Windows.Forms.NumericUpDown();
            this.Msk_BarcodeNo = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_PageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_StockCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod No";
            // 
            // Txt_BookName
            // 
            this.Txt_BookName.Location = new System.Drawing.Point(99, 69);
            this.Txt_BookName.MaxLength = 50;
            this.Txt_BookName.Name = "Txt_BookName";
            this.Txt_BookName.Size = new System.Drawing.Size(165, 23);
            this.Txt_BookName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // Txt_Writer
            // 
            this.Txt_Writer.Location = new System.Drawing.Point(99, 112);
            this.Txt_Writer.MaxLength = 50;
            this.Txt_Writer.Name = "Txt_Writer";
            this.Txt_Writer.Size = new System.Drawing.Size(165, 23);
            this.Txt_Writer.TabIndex = 2;
            this.Txt_Writer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Writer_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yazarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yayın Evi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kitap Türü";
            // 
            // Txt_RackNo
            // 
            this.Txt_RackNo.Location = new System.Drawing.Point(99, 327);
            this.Txt_RackNo.Name = "Txt_RackNo";
            this.Txt_RackNo.Size = new System.Drawing.Size(165, 23);
            this.Txt_RackNo.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(5, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Raf No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(5, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Açıklama";
            // 
            // Rch_Description
            // 
            this.Rch_Description.Location = new System.Drawing.Point(99, 370);
            this.Rch_Description.MaxLength = 100;
            this.Rch_Description.Name = "Rch_Description";
            this.Rch_Description.Size = new System.Drawing.Size(165, 65);
            this.Rch_Description.TabIndex = 7;
            this.Rch_Description.Text = "";
            // 
            // Cbm_BookType
            // 
            this.Cbm_BookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbm_BookType.FormattingEnabled = true;
            this.Cbm_BookType.Location = new System.Drawing.Point(99, 241);
            this.Cbm_BookType.Name = "Cbm_BookType";
            this.Cbm_BookType.Size = new System.Drawing.Size(165, 23);
            this.Cbm_BookType.TabIndex = 5;
            // 
            // Cmb_Publisher
            // 
            this.Cmb_Publisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Publisher.FormattingEnabled = true;
            this.Cmb_Publisher.Location = new System.Drawing.Point(99, 155);
            this.Cmb_Publisher.Name = "Cmb_Publisher";
            this.Cmb_Publisher.Size = new System.Drawing.Size(165, 23);
            this.Cmb_Publisher.TabIndex = 3;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.Green;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Add.Location = new System.Drawing.Point(0, 593);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(266, 60);
            this.Btn_Add.TabIndex = 8;
            this.Btn_Add.Text = "EKLE (F2)";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Clear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Clear.Location = new System.Drawing.Point(0, 533);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(266, 60);
            this.Btn_Clear.TabIndex = 9;
            this.Btn_Clear.Text = "TEMİZLE (F3)";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // nmr_PageCount
            // 
            this.nmr_PageCount.InterceptArrowKeys = false;
            this.nmr_PageCount.Location = new System.Drawing.Point(99, 198);
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
            this.nmr_PageCount.Size = new System.Drawing.Size(165, 23);
            this.nmr_PageCount.TabIndex = 4;
            this.nmr_PageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmr_PageCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(5, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Stok Sayısı";
            // 
            // nmr_StockCount
            // 
            this.nmr_StockCount.InterceptArrowKeys = false;
            this.nmr_StockCount.Location = new System.Drawing.Point(99, 284);
            this.nmr_StockCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_StockCount.Name = "nmr_StockCount";
            this.nmr_StockCount.Size = new System.Drawing.Size(165, 23);
            this.nmr_StockCount.TabIndex = 6;
            this.nmr_StockCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmr_StockCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Msk_BarcodeNo
            // 
            this.Msk_BarcodeNo.Location = new System.Drawing.Point(99, 25);
            this.Msk_BarcodeNo.Mask = "0-000000-000000";
            this.Msk_BarcodeNo.Name = "Msk_BarcodeNo";
            this.Msk_BarcodeNo.Size = new System.Drawing.Size(165, 23);
            this.Msk_BarcodeNo.TabIndex = 0;
            this.Msk_BarcodeNo.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(5, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Kitap Resim";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(99, 448);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(165, 79);
            this.pictureEdit1.TabIndex = 35;
            // 
            // frm_BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(266, 653);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Msk_BarcodeNo);
            this.Controls.Add(this.nmr_StockCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nmr_PageCount);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Add);
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
            this.Name = "frm_BookAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frm_BookAdd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_BookAdd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_PageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_StockCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_BookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Writer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_RackNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox Rch_Description;
        private System.Windows.Forms.ComboBox Cbm_BookType;
        private System.Windows.Forms.ComboBox Cmb_Publisher;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.NumericUpDown nmr_PageCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmr_StockCount;
        private System.Windows.Forms.MaskedTextBox Msk_BarcodeNo;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}