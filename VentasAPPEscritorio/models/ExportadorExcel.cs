using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace VentasAPPEscritorio.models
{
    public static class ExportadorExcel
    {
        public static void ExportarDataGridView(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                sfd.FileName = "Reporte.xlsx";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Reporte");

                    // Encabezados
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        ws.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                        ws.Cell(1, i + 1).Style.Font.Bold = true;
                    }

                    // Filas
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            ws.Cell(i + 2, j + 1).Value =
                                dgv.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    ws.Columns().AdjustToContents();
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Reporte exportado correctamente.");
            }
        }
    }
}
