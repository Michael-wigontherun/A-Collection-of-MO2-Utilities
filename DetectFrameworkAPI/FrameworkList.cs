namespace DetectFrameworkAPI
{
    public class FrameworkList
    {
        public string Name = "";
        public HashSet<string> FileNameList = new HashSet<string>();

        private FrameworkList() { }

        public FrameworkList(string path)
        {
            Name = Path.GetFileNameWithoutExtension(path);
            foreach (string line in File.ReadAllLines(path))
            {
                FileNameList.Add(Path.GetFileNameWithoutExtension(line));
            }
        }

        public static HashSet<FrameworkList> BuildFrameworkList()
        {
            HashSet<FrameworkList> frameworkLists = new HashSet<FrameworkList>();
            IEnumerable<string> lists = Directory.EnumerateFiles("FrameworkLists");
            foreach (string path in lists)
            {
                frameworkLists.Add(new FrameworkList(path));
            }
            return frameworkLists;
        }
        
        public static Dictionary<string, string> BuildFrameworkListDictionary(HashSet<FrameworkList> frameworkLists)
        {//            ScriptName, APIName
            Dictionary<string    , string> frameworkListsD = new();
            foreach(FrameworkList frameworkList in frameworkLists)
            {
                foreach(string scriptName in frameworkList.FileNameList)
                {
                    frameworkListsD.Add(scriptName, frameworkList.Name);
                }
            }
            return frameworkListsD;
        }
    }
}
