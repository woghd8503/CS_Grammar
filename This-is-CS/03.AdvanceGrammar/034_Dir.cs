using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    internal class _034_Dir
    {
        static void Main(string[] args)
        {
            string directory;
            if (args.Length < 1)
                directory = ".";
            else
                directory = args[0];

            Console.WriteLine($"{directory} directory Info");
            Console.WriteLine("- Directories :");
            var directories = (from dir in Directory.GetDirectories(directory)
                               let info = new DirectoryInfo(dir)
                               select new
                               {
                                   Name = info.Name,
                                   Attributes = info.Attributes
                               }).ToList();

            foreach(var d in directories)
                Console.WriteLine($"{d.Name} : {d.Attributes}");

            Console.WriteLine("- Files :");
            var files = (from file in Directory.GetFiles(directory))
                let info = new FileInfo(file)
                select new
                {
                    Name = info.Name,
                    Attributes = info.Attributes
                }).ToList();

            foreach(var )

        }

    }
}
