
namespace KutuphaneOtomasyonu.Forms
{
    partial class frm_OrderFiche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OrderFiche));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dt_Purchase = new System.Windows.Forms.DateTimePicker();
            this.Dt_Delivery = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_RowAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Rch_Desc = new System.Windows.Forms.RichTextBox();
            this.Lk_Member = new DevExpress.XtraEditors.LookUpEdit();
            this.Lk_Book = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_Member.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_Book.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Member,
            this.Book,
            this.Purchase,
            this.Delivery,
            this.Description,
            this.BookID,
            this.MemberID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 335);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 179);
            this.dataGridView1.TabIndex = 4;
            // 
            // Member
            // 
            this.Member.HeaderText = "UYE";
            this.Member.Name = "Member";
            this.Member.ReadOnly = true;
            // 
            // Book
            // 
            this.Book.HeaderText = "KITAP";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            // 
            // Purchase
            // 
            this.Purchase.HeaderText = "ALIM_TARIHI";
            this.Purchase.Name = "Purchase";
            this.Purchase.ReadOnly = true;
            // 
            // Delivery
            // 
            this.Delivery.HeaderText = "TESLIM_TARIHI";
            this.Delivery.Name = "Delivery";
            this.Delivery.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "ACIKLAMA";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "KitapID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // MemberID
            // 
            this.MemberID.HeaderText = "UyeID";
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Üye Seç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitap Seç";
            // 
            // Dt_Purchase
            // 
            this.Dt_Purchase.Enabled = false;
            this.Dt_Purchase.Location = new System.Drawing.Point(115, 106);
            this.Dt_Purchase.Name = "Dt_Purchase";
            this.Dt_Purchase.Size = new System.Drawing.Size(165, 23);
            this.Dt_Purchase.TabIndex = 9;
            // 
            // Dt_Delivery
            // 
            this.Dt_Delivery.Location = new System.Drawing.Point(115, 150);
            this.Dt_Delivery.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.Dt_Delivery.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Dt_Delivery.Name = "Dt_Delivery";
            this.Dt_Delivery.Size = new System.Drawing.Size(165, 23);
            this.Dt_Delivery.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alım Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Teslim Tarihi";
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.Lime;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Add.ForeColor = System.Drawing.Color.Black;
            this.Btn_Add.Location = new System.Drawing.Point(0, 292);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(1044, 43);
            this.Btn_Add.TabIndex = 4;
            this.Btn_Add.Text = "EKLE (F2)";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_RowAdd
            // 
            this.Btn_RowAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_RowAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RowAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_RowAdd.ForeColor = System.Drawing.Color.Black;
            this.Btn_RowAdd.Location = new System.Drawing.Point(112, 243);
            this.Btn_RowAdd.Name = "Btn_RowAdd";
            this.Btn_RowAdd.Size = new System.Drawing.Size(122, 43);
            this.Btn_RowAdd.TabIndex = 3;
            this.Btn_RowAdd.Text = "SATIR EKLE";
            this.Btn_RowAdd.UseVisualStyleBackColor = false;
            this.Btn_RowAdd.Click += new System.EventHandler(this.Btn_RowAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Açıklama";
            // 
            // Rch_Desc
            // 
            this.Rch_Desc.Location = new System.Drawing.Point(112, 190);
            this.Rch_Desc.Name = "Rch_Desc";
            this.Rch_Desc.Size = new System.Drawing.Size(168, 47);
            this.Rch_Desc.TabIndex = 14;
            this.Rch_Desc.Text = "";
            // 
            // Lk_Member
            // 
            this.Lk_Member.Location = new System.Drawing.Point(112, 20);
            this.Lk_Member.Name = "Lk_Member";
            this.Lk_Member.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lk_Member.Properties.NullText = "";
            this.Lk_Member.Size = new System.Drawing.Size(168, 20);
            this.Lk_Member.TabIndex = 15;
            // 
            // Lk_Book
            // 
            this.Lk_Book.Location = new System.Drawing.Point(112, 62);
            this.Lk_Book.Name = "Lk_Book";
            this.Lk_Book.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lk_Book.Properties.NullText = "";
            this.Lk_Book.Size = new System.Drawing.Size(168, 20);
            this.Lk_Book.TabIndex = 16;
            // 
            // frm_OrderFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1044, 514);
            this.Controls.Add(this.Lk_Book);
            this.Controls.Add(this.Lk_Member);
            this.Controls.Add(this.Rch_Desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_RowAdd);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dt_Delivery);
            this.Controls.Add(this.Dt_Purchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_OrderFiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Verme İşlemi";
            this.Load += new System.EventHandler(this.frm_OrderFiche_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_OrderFiche_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_Member.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lk_Book.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dt_Purchase;
        private System.Windows.Forms.DateTimePicker Dt_Delivery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_RowAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Rch_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private DevExpress.XtraEditors.LookUpEdit Lk_Member;
        private DevExpress.XtraEditors.LookUpEdit Lk_Book;
    }
}