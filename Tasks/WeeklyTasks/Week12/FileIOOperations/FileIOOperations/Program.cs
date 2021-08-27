using System;
using System.IO;
using System.Text;

namespace FileIOOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            string root = @"D:\CSharpGroup3";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
                Console.WriteLine("CSharpGroup3 qovluğu yaradıldı.");
            }
            string path = root + @"\CSharpGroup3.txt";
            if (!Directory.Exists(path))
            {
                using (FileStream txtStream = File.Create(path))
                {
                    Console.WriteLine("CSharpGroup3.txt faylı yaradıldı.");
                    txtStream.Close();
                }
                
            }
            string subDirectory = root + @"\SubFolderCSharpGroup3";
            if (!Directory.Exists(subDirectory))
            {
                Console.WriteLine("SubFolderCSharpGroup3 qovluğu mövcud deyil.");
                Directory.CreateDirectory(subDirectory);
                Console.WriteLine("SubFolderCSharpGroup3 qovluğu yaradıldı.");
            }
            else
            {
                Console.WriteLine("SubFolderCSharpGroup3 qovluğu mövcuddur.");
            }
            string DocxPath = subDirectory + @"\DocxFile.docx";
            if (!Directory.Exists(DocxPath))
            {
                using (FileStream docxStream = File.Create(DocxPath))
                {
                    Console.WriteLine("DocxFile.docx faylı yaradıldı.");
                    docxStream.Close();
                }
            }
            string xlsxPath = subDirectory + @"\XlsxFile.xlsx";
            if (!Directory.Exists(xlsxPath))
            {
                using (FileStream xlsxStream = File.Create(xlsxPath))
                {
                    Console.WriteLine("XlsxFile.xlsx faylı yaradıldı.");
                    xlsxStream.Close();
                }
            }
            string[] files = Directory.GetFiles(root, "*.*", SearchOption.AllDirectories);
            string txtFile = "";
            foreach (string file in files)
            {
                if (file.Contains(".txt"))
                {
                    txtFile = file;
                }
            }

            FileStream txtStreamer = File.Open(txtFile, FileMode.Open);
            string fStreamText = "Bu mətn FileStream Class-ı vasitəsi ilə yazılmışdır.";
            byte[] fStreamByte = Encoding.Default.GetBytes(fStreamText);
            txtStreamer.Write(fStreamByte, 0, fStreamByte.Length);
            Console.WriteLine($"Mətn {Path.GetFileName(txtFile)} faylına yazıldı.");
            txtStreamer.Close();

            string docxFile = "";
            foreach (string file in files)
            {
                if (file.Contains(".docx"))
                {
                    docxFile = file;
                }
            }
            //string[] fTextLines = { "Bu mətn File class-ı vasitəsi ilə yazılmışdır." };
            //File.WriteAllLines(docxFile, fTextLines);
            string fText = "Bu mətn File class-ı vasitəsi ilə yazılmışdır.";
            File.WriteAllText(docxFile, fText);
            Console.WriteLine($"Mətn {Path.GetFileName(docxFile)} faylına yazıldı.");

            StreamReader txtStreamReader = File.OpenText(txtFile);
            StreamReader docxStreamReader = File.OpenText(docxFile);
            string docxFileText = docxStreamReader.ReadToEnd();
            string txtFileText = txtStreamReader.ReadToEnd();
            Console.WriteLine($"{txtFileText} - bu mətn uzantısı .txt olan fayldan götürülmüşdür,\n{docxFileText} - bu mətn uzantısı .docx olan fayldan götürülmüşdür.");

        }
    }
}
