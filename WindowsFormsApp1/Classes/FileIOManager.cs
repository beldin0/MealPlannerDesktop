using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerApp.Classes
{
    class FileIOManager : IDisposable
    {
        private static readonly string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MealPlannerDb\";
        string _path;

        internal FileIOManager(string filename)
        {
            _path = folder + filename;
        }

        public void Dispose() { }

        internal string[] Read()
        {
            if (File.Exists(_path))
            {
                string[] text = File.ReadAllLines(_path);
                return text;
            }
            else
            {
                return new string[] { };
            }
        }

        internal void Write(IEnumerable<string> text)
        {
            File.WriteAllLines(_path, text);
        }
    }
}
