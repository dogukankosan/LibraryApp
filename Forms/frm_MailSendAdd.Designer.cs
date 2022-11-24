
namespace KutuphaneOtomasyonu.Forms
{
    partial class frm_MailSendAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MailSendAdd));
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sifreyiGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Host = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.şifreyiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "E-Mail";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(85, 9);
            this.Txt_Email.MaxLength = 50;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(140, 23);
            this.Txt_Email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Şifreniz";
            // 
            // Txt_Password
            // 
            this.Txt_Password.ContextMenuStrip = this.contextMenuStrip2;
            this.Txt_Password.Location = new System.Drawing.Point(85, 52);
            this.Txt_Password.MaxLength = 50;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(140, 23);
            this.Txt_Password.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sifreyiGösterToolStripMenuItem,
            this.şifreyiKapatToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 70);
            // 
            // sifreyiGösterToolStripMenuItem
            // 
            this.sifreyiGösterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sifreyiGösterToolStripMenuItem.Image")));
            this.sifreyiGösterToolStripMenuItem.Name = "sifreyiGösterToolStripMenuItem";
            this.sifreyiGösterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sifreyiGösterToolStripMenuItem.Text = "Sifreyi Göster";
            this.sifreyiGösterToolStripMenuItem.Click += new System.EventHandler(this.sifreyiGösterToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Host";
            // 
            // Txt_Host
            // 
            this.Txt_Host.Location = new System.Drawing.Point(85, 95);
            this.Txt_Host.MaxLength = 50;
            this.Txt_Host.Name = "Txt_Host";
            this.Txt_Host.Size = new System.Drawing.Size(140, 23);
            this.Txt_Host.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Port";
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Blue;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(0, 175);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(248, 33);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "GÜNCELLE(F2)";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(85, 140);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // şifreyiKapatToolStripMenuItem
            // 
            this.şifreyiKapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("şifreyiKapatToolStripMenuItem.Image")));
            this.şifreyiKapatToolStripMenuItem.Name = "şifreyiKapatToolStripMenuItem";
            this.şifreyiKapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.şifreyiKapatToolStripMenuItem.Text = "Şifreyi Kapat";
            this.şifreyiKapatToolStripMenuItem.Click += new System.EventHandler(this.şifreyiKapatToolStripMenuItem_Click);
            // 
            // frm_MailSendAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(248, 208);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Host);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_MailSendAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Düzenleme İşlemi";
            this.Load += new System.EventHandler(this.frm_MailSendAdd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_MailSendAdd_KeyDown);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Host;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sifreyiGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreyiKapatToolStripMenuItem;
    }
}