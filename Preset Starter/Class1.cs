using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

public class PresetStarter
{
    private List<string> pathes = new List<string>();
    private Dictionary<string, int> procId = new Dictionary<string, int>();
    private List<Process> runningProcesses = new List<Process>();

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
                Process currProc = Process.Start(pathes[i]);
                runningProcesses.Add(currProc);
                procId.Add(name, currProc.Id);
            }
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
        foreach (Process proc in runningProcesses)
        {
            proc.CloseMainWindow();
            proc.WaitForExit();       
        }
        runningProcesses.Clear();
        procId.Clear();
    }
}

