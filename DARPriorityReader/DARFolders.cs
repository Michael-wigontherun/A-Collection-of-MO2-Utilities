using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DARPriorityReader
{
    public class DARFolder
    {
        public string FolderPath { get; set; } = "";

        public HashSet<int> Priorities { get; set; } = new();

        public DARFolder(string customConditionFolder)
        {
            FolderPath = customConditionFolder;
        }
    }
}
