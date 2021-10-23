using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

public class PresetStarter
{
    private List<string> pathes = new List<string>();
    private Dictionary<string, int> procId = new Dictionary<string, int>();

    public void AddPath(string path)
    {
        pathes.Add(path);
    }

    public void DeletePath(int value)
    {
        pathes.RemoveAt(value);
    }

    public void Clear()
    {
        pathes.Clear();
        
    }

    public List<string> GetTargetPathes()
    {
        List<string> names = new List<string>();

        for (int i = 0; i < pathes.Count; i++)
        {
            string[] tmp = pathes[i].Split('\\');
            names.Add(tmp[tmp.Length - 1]);
        }

        return names;
    }

    public void Run()
    {
        for(int i=0; i < pathes.Count; i++)
        {
            string[] tmp = pathes[i].Split('\\');
            string name = tmp[tmp.Length - 1];

            if(!procId.ContainsKey(name))
            {
                procId.Add(name, Process.Start(pathes[i]).Id);
            }
            

            //bool run = true;

            //foreach(Process proc in Process.GetProcesses())
            //{
            //    if (procId.ContainsValue(proc.Id)) // if we runned process with this Id
            //    {
                    //procId.Add(name, Process.Start(pathes[i]).Id);
            //        run = false;
                    //break;
            //    }
            //}

            //if (run)
            //{
                //Process.Start(pathes[i]);
            //    procId.Add(name, Process.Start(pathes[i]).Id);
            //}

            //if (Process.GetProcessesByName(name).Length == 0)
            //    Process.Start(pathes[i]);
            
        }
    }

    public void Save()
    {
        StreamWriter writer = new StreamWriter("settings.txt");

        for (int i = 0; i < pathes.Count; i++)
        {
            writer.WriteLine(pathes[i]);
        }

        writer.Close();
    }

    public void Export()
    {
        StreamReader reader = new StreamReader("settings.txt");

        string path;
        while((path = reader.ReadLine()) != null)
        {
            if(File.Exists(path))
                AddPath(path);
        }
        reader.Close();
    }

    public void CloseAllProcess()
    {
        for(int i=0; i < pathes.Count; i++)
        {
            string[] tmp = pathes[i].Split('\\');
            string name = tmp[tmp.Length - 1];

            foreach (Process proc in Process.GetProcesses())
            {
                if (procId.ContainsValue(proc.Id))
                {
                    //proc.Kill();
                    proc.CloseMainWindow();
                    proc.WaitForExit();
                    if (!proc.HasExited)
                        proc.Kill();
                    procId.Remove(name);
                }
            }

            //if (Process.GetProcessesByName(name).Length != 0)
            //{
            //    foreach (Process proc in Process.GetProcessesByName(name))
            //    {
            //        proc.Kill();
            //    }
            //}
        }
    }
}

