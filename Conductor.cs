using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Проводник
{
    public class Conductor
    {
        private static int elem = Cursor.ymarg - 5;

        public static void Interface()
        {
            Console.SetCursorPosition(55, 0);
            Console.WriteLine("Этот компьютер");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            DriveInfo[] drives = DriveInfo.GetDrives();
            Console.SetCursorPosition(10, 4);
            Console.WriteLine("Диски");
            int disk = 5;
            Console.SetCursorPosition(3, disk);
            foreach (DriveInfo drive in drives)
            {
                long free = drive.TotalFreeSpace / 1073741824;
                long all = drive.TotalSize / 1073741824;
                Console.Write($"{drive.Name}");
                Console.Write($" {free} ГБ свободно из {all} ГБ");
            }
            string driveName = $"{drives[elem]}";
            int menu = 1;
            int b = 5;
            var directory = new DirectoryInfo(driveName);
            DirectoryInfo[] dirs = directory.GetDirectories();

            Cursor.Change();
            Console.Clear();


            if (Cursor.key.Key == ConsoleKey.Enter && menu == 1)
            {

                if (directory.Exists)
                {
                    foreach (DirectoryInfo dir in dirs)
                    {
                        Console.SetCursorPosition(3, b);
                        Console.WriteLine(dir.Name);
                        Console.SetCursorPosition(40, b);
                        Console.WriteLine(dir.CreationTime);
                        b++;
                    }
                    FileInfo[] files = directory.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        Console.SetCursorPosition(3, b);
                        Console.WriteLine(file.Name);
                        Console.SetCursorPosition(40, b);
                        Console.WriteLine(file.CreationTime);
                        Console.SetCursorPosition(65, b);
                        Console.WriteLine(file.Extension);
                        b++;
                    }
                    Console.SetCursorPosition(55, 0);
                    Console.WriteLine($"Папка           ");
                    Console.SetCursorPosition(10, 3);
                    Console.WriteLine("Название");
                    Console.SetCursorPosition(45, 3);
                    Console.WriteLine("Дата создания");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(60, 3);
                    Console.WriteLine("Тип");
                }
                menu++;
            }
            Cursor.Change();
            Console.Clear();

            Cursor.Change();
            string dirName = "C:\\";
            var directory2 = new DirectoryInfo(dirName);
            DirectoryInfo[] dirs2 = directory2.GetDirectories();
            while (true)
            {
                if (Cursor.key.Key == ConsoleKey.Enter && menu > 1)
                {
                    int d = 5;
                    if (directory.Exists)
                    {
                        foreach (DirectoryInfo dir in dirs2)
                        {
                            Console.SetCursorPosition(3, d);
                            Console.WriteLine(dir.Name);
                            Console.SetCursorPosition(40, d);
                            Console.WriteLine(dir.CreationTime);
                            b++;
                        }
                        FileInfo[] files = directory.GetFiles();
                        foreach (FileInfo file in files)
                        {
                            Console.SetCursorPosition(3, d);
                            Console.WriteLine(file.Name);
                            Console.SetCursorPosition(40, d);
                            Console.WriteLine(file.CreationTime);
                            Console.SetCursorPosition(65, d);
                            Console.WriteLine(file.Extension);
                            b++;
                        }
                        Console.SetCursorPosition(55, 0);
                        Console.WriteLine($"Папка  {dirs2[elem].Name}");
                        Console.SetCursorPosition(10, 3);
                        Console.WriteLine("Название");
                        Console.SetCursorPosition(45, 3);
                        Console.WriteLine("Дата создания");
                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        Console.SetCursorPosition(60, 3);
                        Console.WriteLine("Тип");
                    }


                    dirName = $"{dirs2[elem]}";







                }
            }
            

        }
    }
}
