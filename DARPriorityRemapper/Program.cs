﻿using MO2CollectionGlobalLibrary;

namespace DARPriorityRemapper
{
    internal class Program
    {
        public static Settings _Settings = new();

        public static void Main(string[] args)
        {
            GL.WriteLine("Hello, World!");

            _Settings = Settings.Args(args, false, false, "This will be the .csv file name for your dar configuration,\nExample: \n  This locates DAR folder number 0, 20, and 302\n  and the command argument -S=\"200000\"\n  This will change 0 to 200000\n  This will change 20 to 200001\n  This will change 302 to 200002");

            if (!_Settings.Start)
            {
                GL.WriteLine("Problem with Arguments.");
                GL.WriteLine("Run with the Argument \"-Help\" without quotes for help.");
                Console.ReadLine();
                return;
            }

            if (File.Exists(Path.Combine(_Settings.Path, "Skyrim.esm")))
            {
                GL.WriteLine("This can not and should not be run on your data folder you will regret it");
                Console.ReadLine();
                return;
            }

             

            if (File.Exists(_Settings.ExtraString))
            {
                List<DARMod> dARMods = DARMod.ReadCSV(_Settings.ExtraString, out bool notFail);

                if (!notFail)
                {
                    GL.WriteLine("CSV had a problem. Cancelling data.");
                    Console.ReadLine();
                    return;
                }

                IEnumerable<string> _CustomConditionFolders = Directory.GetDirectories(Path.Combine(_Settings.Path, "Meshes"),
                    "_CustomConditions",
                    SearchOption.AllDirectories);
                foreach (string _CustomConditionFolder in _CustomConditionFolders)
                {
                    foreach (var darMod in dARMods)
                    {
                        string orgFolder = Path.Combine(_CustomConditionFolder, darMod.OrgFolderName);
                        if (Directory.Exists(orgFolder))
                        {
                            string newFolder = Path.Combine(_CustomConditionFolder, darMod.NewPriority.ToString());

                            Directory.Move(orgFolder, newFolder);
                        }
                    }
                }
            }//End CSV run
            else if(Int32.TryParse(_Settings.ExtraString, out int StartPriority))
            {
                GL.WriteLine("Entering iteration mode from: " + StartPriority);
                Console.ReadLine();

                IEnumerable<string> _CustomConditionFolders = Directory.GetDirectories(Path.Combine(_Settings.Path, "Meshes"),
                    "_CustomConditions",
                    SearchOption.AllDirectories);
                foreach (string _CustomConditionFolder in _CustomConditionFolders)
                {
                    Console.WriteLine("Checking Folder: " + _CustomConditionFolder);
                    IEnumerable<string> darFolders = Directory.GetDirectories(_CustomConditionFolder, "*", SearchOption.TopDirectoryOnly);
                    List<DARMod> darMods = new();

                    foreach (string darFolder in darFolders)
                    {
                        string nameS = Path.GetFileName(darFolder);
                        if (int.TryParse(nameS, out int name))
                        {
                            darMods.Add(new DARMod(nameS, name));
                        }
                    }

                    darMods = darMods.OrderBy(x => x.OrgPriority).ToList();

                    if (darMods.Any())
                    {
                        darMods[0].NewPriority = StartPriority;

                        {
                            string orgFolder = Path.Combine(_CustomConditionFolder, darMods[0].OrgFolderName);
                            if (Directory.Exists(orgFolder))
                            {
                                string newFolder = Path.Combine(_CustomConditionFolder, StartPriority.ToString());

                                Directory.Move(orgFolder, newFolder);
                            }
                        }

                        for (int i = 1; i < darMods.Count; i++)
                        {
                            string orgFolder = Path.Combine(_CustomConditionFolder, darMods[i].OrgFolderName);
                            if (Directory.Exists(orgFolder))
                            {
                                StartPriority++;
                                string newFolder = Path.Combine(_CustomConditionFolder, StartPriority.ToString());

                                Directory.Move(orgFolder, newFolder);
                            }
                        }



                    }
                    else
                    {
                        GL.WriteLine("No Priority Folders found.");
                        GL.WriteLine("");
                    }
                }


            }//End ExtraString number run
            else
            {
                GL.WriteLine("The Extra String could not be parsed as an int or the csv could not be found.");
            }


            
            Console.ReadLine();
        }

    }

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

            for(int i = 0; i < fileLines.Length; i++)
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