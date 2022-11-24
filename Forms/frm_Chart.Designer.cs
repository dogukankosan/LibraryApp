
namespace KutuphaneOtomasyonu.Forms
{
    partial class frm_Chart
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Chart));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excelAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(900, 493);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "GRAFİK";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
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
            // frm_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 493);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafik";
            this.Load += new System.EventHandler(this.frm_Chart_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Chart_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excelAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimAlToolStripMenuItem;
    }
}