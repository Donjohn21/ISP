using System;
//John aquino 2022-0417
namespace PrinterApp
{
    // Definimos una interfaz específica para la impresión
    public interface IPrint
    {
        void Print(Document document);
    }

    // Definimos una interfaz específica para el escaneo
    public interface IScan
    {
        void Scan(Document document);
    }

    // Clase Document
    public class Document
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    // Implementamos la impresora simple
    public class SimplePrinter : IPrint
    {
        public void Print(Document document)
        {
            Console.WriteLine($"Printing document: {document.Name}");
        }
    }

    // Implementamos la impresora multifunción
    public class MultiFunctionPrinter : IPrint, IScan
    {
        public void Print(Document document)
        {
            Console.WriteLine($"Printing document: {document.Name}");
        }

        public void Scan(Document document)
        {
            Console.WriteLine($"Scanning document: {document.Name}");
        }
    }

    // Código cliente para probar la implementación
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document { Name = "MyDocument", Description = "A sample document" };

            IPrint simplePrinter = new SimplePrinter();
            simplePrinter.Print(doc);

            IPrint multiFunctionPrinter = new MultiFunctionPrinter();
            IScan multiFunctionScanner = new MultiFunctionPrinter();
            
            multiFunctionPrinter.Print(doc);
            multiFunctionScanner.Scan(doc);
        }
    }
}
