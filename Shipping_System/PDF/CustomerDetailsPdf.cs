using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Document = iTextSharp.text.Document;
using Font = iTextSharp.text.Font;


namespace Shipping_System.PDF
{
    public class CustomerDetailsPdf
    {
        String connectionstring = "Server=LAPTOP-59PVKG7G; Database=Eshift; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";

        public CustomerDetailsPdf(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public void GenerateCustomerPdf(string outputPath)
        {
            // Create document with A4 page size
            Document document = new Document(PageSize.A4, 20, 20, 30, 30);

            try
            {
                // Create PDF writer
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

                // Open the document
                document.Open();

                // Add title
                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLUE);
                Paragraph title = new Paragraph("Customer Details Report", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f;
                document.Add(title);

                // Get customer data from database
                DataTable customers = GetCustomerData();

                // Create PDF table
                PdfPTable table = new PdfPTable(customers.Columns.Count);
                table.WidthPercentage = 100; // Table width 100% of page

                // Set table headers
                Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE);
                foreach (DataColumn column in customers.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, headerFont));
                    cell.BackgroundColor = new BaseColor(70, 130, 180); // Steel blue
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 5;
                    table.AddCell(cell);
                }

                // Add table rows
                Font contentFont = FontFactory.GetFont(FontFactory.HELVETICA, 9);
                foreach (DataRow row in customers.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), contentFont));
                        cell.Padding = 5;
                        table.AddCell(cell);
                    }
                }

                // Add table to document
                document.Add(table);

                // Add report generation date
                Font footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 8);
                Paragraph footer = new Paragraph($"Report generated on: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}", footerFont);
                footer.Alignment = Element.ALIGN_RIGHT;
                footer.SpacingBefore = 20f;
                document.Add(footer);
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating PDF: " + ex.Message);
            }
            finally
            {
                document.Close();
            }
        }
        private DataTable GetCustomerData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string query = "SELECT * FROM Customer";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }
    }

}
