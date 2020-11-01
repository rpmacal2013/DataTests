
using System;
using System.IO;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Colors;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Borders;
using iText.Layout.Properties;
using System.Data;

namespace DataTests
{
    public class PdfUA
    {
        public static readonly string DEST = "c:/temp/pdf_ua.pdf";

        public static readonly String DOG = "c:/temp/origen/block_dibujo.jpg";

        public static readonly String FONT = "../../resources/font/FreeSans.ttf";

        public static readonly String FOX = "c:/temp/origen/cinta adhesiva-scotch.jpg";

        //---------------------------------------------------------------------
        // 
        //---------------------------------------------------------------------
        public void ManipulatePdf()
        {
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();

            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(DEST,
                new WriterProperties().AddUAXmpMetadata().SetPdfVersion
                    (PdfVersion.PDF_1_7)));
            Document document = new Document(pdfDoc, PageSize.A4.Rotate());

            //TAGGED PDF
            //Make document tagged
            pdfDoc.SetTagged();

            //PDF/UA
            //Set document metadata
            pdfDoc.GetCatalog().SetViewerPreferences(new PdfViewerPreferences().SetDisplayDocTitle(true));
            pdfDoc.GetCatalog().SetLang(new PdfString("en-US"));
            PdfDocumentInfo info = pdfDoc.GetDocumentInfo();
            info.SetTitle("Reporte de Ventas del Mes");

            Paragraph p = new Paragraph();

            //PDF/UA
            //Embed font
            //PdfFont font = PdfFontFactory.CreateFont(FONT, PdfEncodings.WINANSI, true);
            //p.SetFont(font);

            PdfFont font = PdfFontFactory.CreateFont();
            p.SetFont(font);
            p.SetFontSize(26);

            p.Add("Papelería D'Loreto");

            //Image img = new Image(ImageDataFactory.Create(FOX));

            //PDF/UA
            //Set alt text
            //img.GetAccessibilityProperties().SetAlternateDescription("Fox");
            //p.Add(img);
            //p.Add(" jumps over the lazy ");

            //img = new Image(ImageDataFactory.Create(DOG));

            //PDF/UA
            //Set alt text
            //img.GetAccessibilityProperties().SetAlternateDescription("Dog");
            //p.Add(img);

            document.Add(p);

            p = new Paragraph("\n\n\n\n\n\n\n\n\n\n\n\n").SetFont(font).SetFontSize(20);
            document.Add(p);

            List list = new List().SetFont(font).SetFontSize(20);
            list.Add(new ListItem("quick"));
            list.Add(new ListItem("brown"));
            list.Add(new ListItem("fox"));
            list.Add(new ListItem("jumps"));
            list.Add(new ListItem("over"));
            list.Add(new ListItem("the"));
            list.Add(new ListItem("lazy"));
            list.Add(new ListItem("dog"));
            document.Add(list);

            document.Close();
        }


        public void ReporteVentas1()
        {
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();

            string dest = "c:/temp/reporte_ventas1.pdf";
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(dest,
                new WriterProperties().AddUAXmpMetadata().SetPdfVersion
                    (PdfVersion.PDF_1_7)));
            Document document = new Document(pdfDoc, PageSize.LETTER.Rotate());

            //TAGGED PDF
            //Make document tagged
            //pdfDoc.SetTagged();

            //PDF/UA
            //Set document metadata
            pdfDoc.GetCatalog().SetViewerPreferences(new PdfViewerPreferences().SetDisplayDocTitle(true));
            pdfDoc.GetCatalog().SetLang(new PdfString("en-US"));
            PdfDocumentInfo info = pdfDoc.GetDocumentInfo();
            info.SetTitle("Reporte de Ventas de la Semana");

            Paragraph p = new Paragraph();

            PdfFont font = PdfFontFactory.CreateFont();
            p.SetFont(font);
            p.SetFontSize(26);
            p.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

            p.Add("Reporte de Ventas de la Semana");

            document.Add(p);

            Table tabla = new Table(2);
            tabla.SetWidth(200);

            //tabla.SetBorder(Border.NO_BORDER);

            for (int i = 0; i < 8; i++)
            {
                Cell celda = new Cell().Add(new Paragraph("Celda " + i));
                //celda.SetBorder(Border.NO_BORDER);
                tabla.AddCell(celda);
            }

            document.Add(tabla);
            document.Close();
        }

        public void ReporteVentas2()
        {
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();

            string dest = "c:/temp/reporte_ventas1.pdf";
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(dest,
                new WriterProperties().AddUAXmpMetadata().SetPdfVersion
                    (PdfVersion.PDF_1_7)));
            Document document = new Document(pdfDoc, PageSize.LETTER.Rotate());

            //PDF/UA
            //Set document metadata
            pdfDoc.GetCatalog().SetViewerPreferences(new PdfViewerPreferences().SetDisplayDocTitle(true));
            pdfDoc.GetCatalog().SetLang(new PdfString("en-US"));
            PdfDocumentInfo info = pdfDoc.GetDocumentInfo();
            info.SetTitle("Reporte de Ventas de la Semana");

            float[] columnWidths = { 0.5f, 1, 5, 1 };
            Table tabla = new Table(UnitValue.CreatePercentArray(columnWidths));
            //tabla.SetWidth();
            tabla.UseAllAvailableWidth();
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            // celda de encabezado

            Text txt = new Text("Reporte de Ventas Semanal")
                        .SetFontSize(20)
                        .SetBold();

            Paragraph pTitulo = new Paragraph(txt)
                                    .SetTextAlignment(TextAlignment.CENTER);
            document.Add(pTitulo);

            //Cell cell = new Cell(1, 4)
            //    .Add(new Paragraph("Reporte de Ventas Semanal"))
            //    .SetFont(font)
            //    .SetFontSize(13)
            //    .SetFontColor(DeviceGray.WHITE)
            //    .SetBackgroundColor(DeviceGray.BLACK)
            //    .SetTextAlignment(TextAlignment.CENTER);

            //tabla.AddHeaderCell(cell);

            for (int i = 0; i < 2; i++)
            {
                Cell[] headerFooter =
                {
                    new Cell()
                        .SetBackgroundColor(new DeviceGray(0.75f))
                        .Add(new Paragraph("No."))
                        .SetBorder(Border.NO_BORDER),
                    new Cell()
                        .SetBackgroundColor(new DeviceGray(0.75f))
                        .Add(new Paragraph("Cant."))
                        .SetBorder(Border.NO_BORDER),
                    new Cell()
                        .SetBackgroundColor(new DeviceGray(0.75f))
                        .Add(new Paragraph("Artículo"))
                        .SetBorder(Border.NO_BORDER),
                    new Cell()
                        .SetBackgroundColor(new DeviceGray(0.75f))
                        .Add(new Paragraph("Total"))
                        .SetBorder(Border.NO_BORDER)

                };

                foreach (Cell hfCell in headerFooter)
                {
                    if (i == 0)
                    {
                        tabla.AddHeaderCell(hfCell);
                    }
                    //    else
                    //    {
                    //        tabla.AddFooterCell(hfCell);
                    //    }
                }
            }

            for (int j = 0; j < 10; j++)
            {
                tabla.AddCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph((j + 1).ToString())));
                tabla.AddCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("cantidad " + (j + 1))));
                tabla.AddCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("lapiz adhesivo resistol no tóxico 100gr -- lapiz adhesivo resistol no tóxico 100gr " + (j + 1))));
                tabla.AddCell(new Cell()
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .Add(new Paragraph("$100" + (j + 1))));
            }

            document.Add(tabla);
            Paragraph p = new Paragraph();
            p.SetTextAlignment(TextAlignment.RIGHT);
            p.Add("Total de la semana: $" + 10000);

            document.Add(p);

            document.Close();
        }

        public void TotalVentasMesArticulo(DataTable dt)
        {
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();

            string dest = "c:/temp/ReporteMesArticulo1.pdf";
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(dest,
                new WriterProperties().AddUAXmpMetadata().SetPdfVersion
                    (PdfVersion.PDF_1_7)));
            Document document = new Document(pdfDoc, PageSize.LETTER.Rotate());

            //PDF/UA
            //Set document metadata
            pdfDoc.GetCatalog().SetViewerPreferences(new PdfViewerPreferences().SetDisplayDocTitle(true));
            pdfDoc.GetCatalog().SetLang(new PdfString("en-US"));
            PdfDocumentInfo info = pdfDoc.GetDocumentInfo();
            info.SetTitle("Reporte de Ventas de Artículo por Mes");

            float[] columnWidths = { 1, 5, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(columnWidths));
            //tabla.SetWidth();
            tabla.UseAllAvailableWidth();
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            // celda de encabezado

            Text txt = new Text("Reporte de Ventas Semanal")
                        .SetFontSize(20)
                        .SetBold();

            Paragraph pTitulo = new Paragraph(txt)
                                    .SetTextAlignment(TextAlignment.CENTER);
            document.Add(pTitulo);

            for (int i=0; i< 2; i++)
            {
                Cell[] headerFooter =
                {
                    new Cell()
                        .SetBackgroundColor(new DeviceGray(0.75f))
                        .Add(new Paragraph("Mes"))
                        .SetBorder(Border.NO_BORDER),
                    new Cell()
                        .SetBackgroundColor(new DeviceGray(0.75f))
                        .Add(new Paragraph("Artículo"))
                        .SetBorder(Border.NO_BORDER),
                    new Cell()
                        .SetBackgroundColor(new DeviceGray(0.75f))
                        .Add(new Paragraph("Total"))
                        .SetBorder(Border.NO_BORDER)
                };

                foreach (Cell hfCell in headerFooter)
                {
                    if (i == 0) tabla.AddHeaderCell(hfCell);
                }
            }
            
            decimal totalMes = 0;

            Cell c_mes = new Cell().SetTextAlignment(TextAlignment.CENTER);
            Cell c_articulo = new Cell().SetTextAlignment(TextAlignment.LEFT);
            Cell c_total = new Cell().SetTextAlignment(TextAlignment.RIGHT);
            tabla.AddCell(c_articulo);
            tabla.AddCell(c_mes);
            tabla.AddCell(c_total);

            // ciclo para filas
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                c_mes.Add(new Paragraph(dt.Rows[j][0].ToString()));
                c_articulo.Add(new Paragraph(dt.Rows[j][1].ToString()));
                c_total.Add(new Paragraph(dt.Rows[j][2].ToString()));

                totalMes += (decimal)dt.Rows[j][2];
            }

            document.Add(tabla);
            Paragraph p = new Paragraph();
            p.SetTextAlignment(TextAlignment.RIGHT);
            p.Add("Total del mes: $" + totalMes);

            document.Add(p);

            document.Close();
        }
    }
}