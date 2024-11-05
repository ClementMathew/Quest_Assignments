# File ReadAsync

#### Discussed about :

    Creating Custom FileReadAsync.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_File_Reading
{
    internal class Async_File_Reading
    {
        public class FileReadAsync
        {
            public void ReadAsync(string filePath)
            {
                var thread = new Thread(() =>
                {
                    var content = File.ReadAllLines(filePath);

                    foreach (var line in content)
                    {
                        Console.WriteLine(line);
                        Thread.Sleep(1000);
                    }
                });
                thread.Start();
            }
        }

        public static async Task Main(string[] args)
        {
            string path = @"C:\Users\cleme\Documents\AsyncRead";
            string fileName = "AsyncRead.txt";

            var filePath = Path.Combine(path, fileName);

            if (Directory.Exists(path))
            {
                Console.WriteLine("Directory Exists...");
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Directory Created!");
            }
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists...");
            }
            else
            {
                File.WriteAllText(filePath, "Hello Clement...");
                Console.WriteLine("File Created...");
            }

            var readAsync = new FileReadAsync();
            readAsync.ReadAsync(filePath);
        }
    }
}

```
