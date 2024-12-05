using System.Text.RegularExpressions;

namespace EvTapsiriqi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\PC\Desktop\Misal2.txt";
            #region Misal-3
            ////Faylin icerisindeki boyuk A herfi ile baslamayan setirlerin sayini tapmaq fayli liste ve ya arraya yiqmadan
            //Regex regex = new Regex(@"^A+"); //A herfi ile baslayan             
            //try
            //{
            //    if (File.Exists(filePath))
            //    {
            //        using (StreamReader sr = new StreamReader(filePath))
            //        {
            //            string line;
            //            while ((line = sr.ReadLine()) != null)
            //            {
            //                if (regex.IsMatch(line))
            //                {
            //                    Console.WriteLine(line);
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("not faund File");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message, ex.StackTrace);
            //}
            #endregion

            #region Misal-5
            ////en uzun deyere sahib olan setri oxumaq
            //try
            //{
            //    using (StreamReader sr = new StreamReader(filePath))
            //    {
            //        string line;
            //        string linemax = string.Empty;
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            if ((linemax.Length < line.Length))
            //            {
            //                linemax = line;
            //            }
            //        }
            //        Console.WriteLine(linemax);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message, ex.StackTrace);
            //}
            #endregion

            #region Misal-6
            //Icerisinde melumat olan faylin uzerine elave melumat yazmaq
            //try
            //{
            //    if (File.Exists(filePath))
            //    {
            //        using (StreamWriter sw = new StreamWriter(filePath, append: true))
            //        {
            //            sw.WriteLine(Console.ReadLine().ToString());
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("fayl movcud deyil");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message, "//", ex.StackTrace);
            //}
            #endregion

            #region Misal-7
            //Faylin movcudluqunu yoxlamaq ve onu silmek
            //try
            //{
            //    if (File.Exists(filePath))
            //    {
            //        File.Delete(filePath);
            //        Console.WriteLine("fayl movcud idi ve silindi hal hazirda sistemde yoxdur");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message,"//",ex.StackTrace);
            //}
            #endregion

            #region Misal-8
            ////Fayli bir kataloqdan digerine kocurmek
            //string fileCopypart = @"C:\Users\SP-1\Desktop\TapsiriqKurs\test12121sa2.txt";
            //File.Move(filePath, fileCopypart);
            #endregion

            #region Misal-9
            ////  Kataloqdaki fayllarin adinda reqemin olub olmamasini yoxlamaq
            //string numberControllerPattern = @"\d";
            //Regex regex = new Regex(numberControllerPattern);
            //string folderpath = @"C:\Users\PC\Desktop\DersTest";
            //string[] numberController = Directory.GetFiles(folderpath);
            //int sum = numberController.Length;
            //int count = 0;
            //foreach (var item in numberController)
            //{
            //    string result = Path.GetFileName(item);
            //    if (regex.IsMatch(result))
            //    {
            //        Console.WriteLine(result);
            //        count++;
            //    }
            //}
            //Console.WriteLine($"gosterilen folderde umumu {sum} file var \nfile adininda reqem olan {count} sayda file var ");
            
           
            #endregion

            #region Misal-10
          ////  ”Qismet Altun Ehmed Nurlan Mirmecid kursa gelirdiler” cumlesindeki sozleri List<string> - e yiqmaq(Regex)
          //  string word = "Qismet Altun Ehmed Nurlan Mirmecid kursa gelirdiler";
          //  string[] wordArray = Regex.Split(word, @"\s+");
          //  List<string> wordList = new List<string>();
          //  foreach (var item in wordArray)
          //  {
          //      wordList.Add(item);
          //  }
          //  wordList.ForEach(x => Console.WriteLine(x));
            #endregion

            Console.ReadKey();
        }
    }
}
