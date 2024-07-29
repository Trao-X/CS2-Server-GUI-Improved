using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace cs2servergui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Global.Initialize();
            label2.Text = Global.CS2Path;
        }

        public static class Global
        {
            public static int GameMode { get; set; }
            public static int GameType { get; set; }
            public static string CS2Path { get; set; }
            public static string CS2MapFile { get; set; }
            public static string CS2SrvArgs { get; set; }

            public static void Initialize()
            {
                CS2MapFile = null;
                CS2Path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\game\\bin\\win64\\cs2.exe";
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Global.CS2Path))
                {
                    MessageBox.Show("Please select a path for cs2.exe.", "Error: Cannot find cs2.exe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Global.CS2SrvArgs = $"-dedicated -insecure +game_mode {Global.GameMode} +game_type {Global.GameType} +map {Global.CS2MapFile}";
                    Process p = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = Global.CS2Path,
                            Arguments = Global.CS2SrvArgs
                        }
                    };
                    p.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void game_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(game_mode_sel.SelectedIndex.ToString(), out int mode))
            {
                Global.GameMode = mode;
            }
        }

        private void game_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(game_type_sel.SelectedIndex.ToString(), out int type))
            {
                Global.GameType = type;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://developer.valvesoftware.com/wiki/Counter-Strike:_Global_Offensive/Game_Modes",
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive";
            openFileDialog1.Filter = "cs2.exe|cs2.exe|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = string.Empty; // Ensure no file is pre-selected

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of cs2.exe
                Global.CS2Path = openFileDialog1.FileName;
                label2.Text = Global.CS2Path;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\game\\csgo\\maps";
            openFileDialog2.Filter = "*.vpk|*.vpk|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.FileName = string.Empty; // Ensure no file is pre-selected

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the map file
                Global.CS2MapFile = $"\"{openFileDialog2.FileName}\"";
                label3.Text = Global.CS2MapFile;
            }
        }
    }
}