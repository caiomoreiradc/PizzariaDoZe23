using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using PizzariaDoZe.DAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe
{
    public class ClassGeraPdf
    {

        readonly static string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly static string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        //métodos
        public static string pathArquivo(string nome)
        {
            SaveFileDialog savePath = new()
            {
                Title = "Selecione o local e o nome para salvar seu relatório",
                Filter = "Arquivo|*.pdf",
                FileName = nome + "-" + Convert.ToString(DateTime.Now).Replace("/", "-").Replace(":", "-") + ".pdf"
            };
            if (savePath.ShowDialog() == DialogResult.OK)
            {
                return Convert.ToString(savePath.FileName);
            }
            else
            {
                return "PizzariaDoZe.pdf";
            }
        }

        public static void PdfSabor(string pathArquivo, int id)
        {
            try
            {
                using (PdfWriter pdfWriter = new PdfWriter(pathArquivo))
                {
                    using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
                    {
                        using (Document document = new Document(pdfDocument, PageSize.A4.Rotate()))
                        {
                            document.Add(new Paragraph("Pizzaria do Zé").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
                            document.Add(new Paragraph("Pedido" + ((id == 0) ? "s" : ": " + id)).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15));
                            document.Add(new LineSeparator(new SolidLine()));

                            Table table = new Table(10).UseAllAvailableWidth();
                            table.SetTextAlignment(TextAlignment.LEFT);

                            table.AddHeaderCell("ID Pedido");
                            table.AddHeaderCell("ID Cliente");
                            table.AddHeaderCell("ID Funcionario");
                            table.AddHeaderCell("Nome Cliente");
                            table.AddHeaderCell("CPF Cliente");
                            table.AddHeaderCell("Email Cliente");
                            table.AddHeaderCell("Data Pedido");
                            table.AddHeaderCell("Valor Total");
                            table.AddHeaderCell("Forma Pagamento");
                            table.AddHeaderCell("Status");

                            // realiza a busca no Banco de Dados
                            PedidoDAO pedidoDAO = new PedidoDAO(provider, strConnection);
                            Pedidos pedido = new Pedidos
                            {
                                Id = id
                            };
                            DataTable linhas = pedidoDAO.Buscar(pedido);

                            foreach (DataRow row in linhas.Rows)
                            {
                                table.AddCell(row[0].ToString());
                                table.AddCell(row[1].ToString());
                                table.AddCell(row[2].ToString());
                                table.AddCell(row[3].ToString());
                                table.AddCell(row[4].ToString());
                                table.AddCell(row[5].ToString());
                                table.AddCell(row[6].ToString());
                                table.AddCell(row[7].ToString());
                                table.AddCell(row[8].ToString());
                                table.AddCell(row[9].ToString());
                            }

                            document.Add(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
