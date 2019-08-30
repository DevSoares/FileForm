using System;
using System.IO;
using System.Text;


namespace FuckingFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte trava = 1;           
            while (trava != 0)
            {
                string sourcePath = @"c:\TEMP\sourceForm.txt";
                string targetPath = @"c:\TEMP\FORMS\";

                try
                {
                    using (StreamReader streamReader = File.OpenText(sourcePath))
                    {
                        StringBuilder builder = new StringBuilder();
                        int incrementor = 0;
                        while (!streamReader.EndOfStream)
                        {
                            string line = streamReader.ReadLine();
                            builder.Append(line);
                            if (incrementor == 0)
                            {
                                string temp = MainForm(incrementor);
                                builder.Append(temp);
                                builder.AppendLine();
                                targetPath += temp.Replace(",", "") + ".txt";
                                targetPath.Trim();                         
                            }
                            else
                            {
                                builder.Append(MainForm(incrementor));
                                builder.AppendLine();
                            }
                            incrementor++;
                        }                        
                        StreamWriter streamWriter = File.AppendText(targetPath);
                        streamWriter.Write(builder);
                        streamWriter.Close();
                        streamReader.Close();
                    };
                        Console.WriteLine("Document done!");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Some shit has happend");
                    Console.WriteLine(e.Message);
                }
                catch (NotSupportedException a)
                {
                    Console.WriteLine("Deu ruim jamelão, NotSuportedException");
                    Console.WriteLine(a.Message);
                }
                Console.WriteLine("Type 0 to quit...");
                trava = Byte.Parse(Console.ReadLine());
                Console.Clear();
            }
        }

        public static string MainForm(int selector)
        {
            Console.Clear();
            StringBuilder builder = new StringBuilder();
            switch (selector)
            {
                case 0:                    
                    Console.WriteLine("Insert Last Name: ");
                    builder.Append(" " + Console.ReadLine());
                    Console.WriteLine("Insert First Name: ");
                    builder.Append(", " + Console.ReadLine());
                    break;
                case 1:
                    Console.WriteLine("Insert ID: ");
                    builder.Append(" " + Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Insert Father's Full Name: ");
                    builder.Append(" " + Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Insert Father's ID: ");
                    builder.Append(" " + Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Insert Mother's Full Name: ");
                    builder.Append(" " + Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Insert Mother's ID: ");
                    builder.Append(" " + Console.ReadLine());
                    break;
                case 6:
                    Console.WriteLine("Insert Main Skill: ");
                    builder.Append(" " + Console.ReadLine());
                    break;
                case 7:
                    Console.WriteLine("Insert born date: ");
                    builder.Append(" " + Console.ReadLine());
                    break;
                case 8:
                    Console.WriteLine("Insert deceased date: ");
                    builder.Append(" " + Console.ReadLine());
                    break;
                default:
                    builder.Append(" Unkown");
                    break;
                    
            }
            return builder.ToString();
        }
    }   
}

