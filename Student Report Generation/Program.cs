using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Student_Report_Generation
{
    internal class Program
    {

        //public static void ExportReceiptToPDF(string filePath, string customerName, string serviceName, decimal totalAmount)
        //{
        //    Document doc = new Document();
        //    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
        //    doc.Open();           

        //    // You can style it however you want
        //    doc.Add(new Paragraph("Vehicle Service Center"));
        //    doc.Add(new Paragraph("------ Receipt ------"));
        //    doc.Add(new Paragraph($"Customer: {customerName}"));
        //    doc.Add(new Paragraph($"Service: {serviceName}"));
        //    doc.Add(new Paragraph($"Total Amount: ৳{totalAmount}"));
        //    doc.Add(new Paragraph($"Date: {DateTime.Now.ToString("dd/MM/yyyy")}"));
        //    doc.Add(new Paragraph("----------------------"));
        //    doc.Add(new Paragraph("Thank you for choosing us!"))            

        //    doc.Close();
        //}

        static void Main(string[] args)
        {

            //ExportReceiptToPDF("D:\\CSE\\Meh\\Final Ass\\Student Report Generation\\receipt1.pdf", "Anik", "Oil Change", 1500m);



            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler((sender, e) =>
            {
                e.Graphics.DrawString("Vehicle Service Center", new Font("Arial", 12), Brushes.Black, 100, 100);
                e.Graphics.DrawString("------ Receipt ------", new Font("Arial", 12), Brushes.Black, 100, 120);
                e.Graphics.DrawString("Customer: Anik", new Font("Arial", 12), Brushes.Black, 100, 140);
                e.Graphics.DrawString("Service: Hehe", new Font("Arial", 12), Brushes.Black, 100, 160);
                e.Graphics.DrawString("Total: ৳1500", new Font("Arial", 12), Brushes.Black, 100, 180);
                e.Graphics.DrawString($"Date: {DateTime.Now:dd/MM/yyyy}", new Font("Arial", 12), Brushes.Black, 100, 200);
                e.Graphics.DrawString("----------------------", new Font("Arial", 12), Brushes.Black, 100, 220);
                e.Graphics.DrawString("Thank you for choosing us!", new Font("Arial", 12), Brushes.Black, 100, 240);
            });


            // Show the print dialog
            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = pd;

            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }



            //StudentReport report = new StudentReport();

            //// Let's say you have a class object
            //Type type = typeof(StudentReport);

            //Console.WriteLine("Class Name: " + type.Name);
            //Console.WriteLine("Namespace: " + type.Namespace);

            //Console.WriteLine("\nProperties:");
            //foreach (var prop in type.GetProperties())
            //{
            //    Console.WriteLine($"- {prop.PropertyType.Name} {prop.Name}");
            //}

            //Console.WriteLine("\nFields:");
            //foreach (var field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            //{
            //    Console.WriteLine($"- {field.FieldType.Name} {field.Name}");
            //}

            //Console.WriteLine("\nMethods:");
            //foreach (var method in type.GetMethods())
            //{
            //    Console.WriteLine($"- {method.ReturnType.Name} {method.Name}()");
            //}
        }
    }
}
