using DevExpress.XtraCharts;
using DevExpress.XtraGrid;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Class
{
    internal class DataExport
    {
        internal static void ChartExport(ChartControl ct, string path, string formatName)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    if (formatName.Contains("pdf"))
                    {
                        ct.ExportToPdf(path + "\\" + formatName);
                        MessageBox.Show("PDF ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (formatName.Contains("xlsx"))
                    {
                        ct.ExportToXlsx(path + "\\" + formatName);
                        MessageBox.Show("EXCEL ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (formatName.Contains("html"))
                    {
                        ct.ExportToHtml(path + "\\" + formatName);
                        MessageBox.Show("RESİM ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("DIŞARI AKTARMA İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        internal static void GridExport(GridControl gc, string path, string formatName)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    if (formatName.Contains("pdf"))
                    {
                        gc.ExportToPdf(path + "\\" + formatName);
                        MessageBox.Show("PDF ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (formatName.Contains("xlsx"))
                    {
                        gc.ExportToXlsx(path + "\\" + formatName);
                        MessageBox.Show("EXCEL ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (formatName.Contains("html"))
                    {
                        gc.ExportToHtml(path + "\\" + formatName);
                        MessageBox.Show("RESİM ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("DIŞARI AKTARMA İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}