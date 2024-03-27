using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ScriptEditor
{
    public class Configuration
    {
        [JsonInclude]
        public string ModPath { get; set; } = String.Empty;

        [JsonInclude]
        public string? OutputLocation { get; set; }

        [JsonInclude]
        public List<ConfigurationNode> ConfigurationNodes { get; set; } = new();

        public void Print()
        {
            Console.WriteLine(ModPath);
            foreach (var node in ConfigurationNodes)
            {
                Console.WriteLine(node.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public bool HasValidNode()
        {
            foreach(var node in ConfigurationNodes)
            {
                if(node.IsValid()) return true;
            }
            Console.WriteLine("Not valid");
            return false;
        }
    }

    public class ConfigurationNode
    {
        [JsonInclude]
        public string SearchString { get; set; } = String.Empty;

        [JsonInclude]
        public int DuplicateLine { get; set; } = 0;

        [JsonInclude]
        public string? ReplaceSearch {  get; set; }

        [JsonInclude]
        public string? ReplaceLine { get; set; }

        [JsonInclude]
        public bool LinesInsertAbove { get; set; } = false;

        [JsonInclude]
        public string[]? Lines { get; set; }

        public override string? ToString()
        {
            return $"{SearchString} : {DuplicateLine} : {ReplaceSearch} : {ReplaceLine} : {LinesInsertAbove}";
        }

        public bool IsValid()
        {
            if (SearchString.Equals(String.Empty)) return false;

            int failCounter = 0;
            if (DuplicateLine == 0) failCounter++;
            if(ReplaceSearch == null || ReplaceSearch.Equals(String.Empty)) failCounter++;
            if(ReplaceLine == null || ReplaceLine.Equals(String.Empty)) failCounter++;
            if(Lines == null || Lines.Length == 0) failCounter++;

            if (failCounter == 4) return false;

            return true;
        }
    }
}
