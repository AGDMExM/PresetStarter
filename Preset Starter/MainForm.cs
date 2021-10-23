using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Preset_Starter
{
    public partial class MainForm : Form
    {
        private PresetStarter ps = new PresetStarter();
        public MainForm()
        {
            InitializeComponent();
            if (File.Exists(Directory.GetCurrentDirectory() + "\\settings.txt"))
            {
                ps.Export();
                RefreshListTotalPath();
            }
        }

        private void button_AddPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Path.ShowDialog() == DialogResult.Cancel)
                return;

            string path = openFileDialog_Path.FileName;

            ps.AddPath(path);

            RefreshListTotalPath();
        }

        private void RefreshListTotalPath()
        {
            listTotalPath.Items.Clear();
            List<string> namesPathes = ps.GetTargetPathes();
            for (int i = 0; i < namesPathes.Count; i++)
            {
                listTotalPath.Items.Add(namesPathes[i]);
            }
        }

        private void button_DeletePath_Click(object sender, EventArgs e)
        {
            ps.DeletePath(listTotalPath.SelectedIndex);

            RefreshListTotalPath();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ps.Clear();
            RefreshListTotalPath();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            ps.Save();
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            ps.Save();
            ps.Run();
        }

        protected override void OnClosed(EventArgs e)
        {
            ps.Save();
            base.OnClosed(e);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            ps.CloseAllProcess();
        }
    }
}
