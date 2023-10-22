using MO2CollectionGlobalLibrary;

namespace DARPriorityRemapper
{
    public class DARMod
    {
        public string OrgFolderName = string.Empty;
        public int OrgPriority = int.MinValue;
        public int NewPriority = int.MinValue;

        public DARMod(int orgPriority, int newPriority)
        {
            this.OrgPriority = orgPriority;
            this.NewPriority = newPriority;
        }

        public DARMod(string orgFolderName, int orgPriority)
        {
            this.OrgFolderName = orgFolderName;
            OrgPriority = orgPriority;
        }

        public DARMod(string orgFolderName, int orgPriority, int newPriority) : this(orgFolderName, orgPriority)
        {
            NewPriority = newPriority;
        }

        public static List<DARMod> ReadCSV(string csvPath, out bool notFail)
        {
            notFail = true;
            List<DARMod> list = new List<DARMod>();

            string[] fileLines = File.ReadAllLines(csvPath);

            for (int i = 0; i < fileLines.Length; i++)
            {
                string[] lineArr = fileLines[i].Split(';');

                if (lineArr.Length < 2)
                {
                    GL.WriteLine("Missing data on line " + (i + 1));
                    notFail = false;
                    break;
                }

                if (!Int32.TryParse(lineArr[0], out int orgPriority))
                {
                    GL.WriteLine("Original priority not int on line " + (i + 1));
                    notFail = false;
                    break;
                }

                if (!Int32.TryParse(lineArr[1], out int newPriority))
                {
                    GL.WriteLine("New priority not int on line " + (i + 1));
                    notFail = false;
                    break;
                }

                list.Add(new DARMod(lineArr[0], orgPriority, newPriority));


            }

            return list;
        }

    }

}
