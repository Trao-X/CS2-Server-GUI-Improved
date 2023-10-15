using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs2servergui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class Global
        {
            public static string game_mode;
            public static string game_type;
            public static string map;
            public static string cs2_path;
            public static string cs2_srv_args;
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            // Get the text from textBox1 and store it in the 'path' variable
            string path = textBox1.Text;

            // Check if the path is not empty and is an absolute path
            if (!string.IsNullOrEmpty(path) && Path.IsPathRooted(path))
            {
                // Set the Global.cs2_path variable to the 'path' value
                Global.cs2_path = path;

                // Clear any previous error message
                label1.Text = "The Counter-Strike 2 executable file:";

                // Set the Global.cs2_srv_args
                Global.cs2_srv_args = " -dedicated -insecure " + "+game_mode " + Global.game_mode + " +game_type " + Global.game_type + " +map " + Global.map;

                Process p = new Process();
                p.StartInfo.FileName = Global.cs2_path;
                p.StartInfo.Arguments = Global.cs2_srv_args;
                p.Start();
            }
            else
            {
                // Display "Invalid Path!" in label1
                label1.Text = "Invalid Path!";
            }

        }
        private void game_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.game_mode = game_mode_sel.SelectedIndex.ToString();
        }

        private void game_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.game_type = game_type_sel.SelectedIndex.ToString();
        }

        private void map_sel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.map = map_sel.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://developer.valvesoftware.com/wiki/Counter-Strike:_Global_Offensive/Game_Modes",
                UseShellExecute = true
            });
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void game_mode_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
