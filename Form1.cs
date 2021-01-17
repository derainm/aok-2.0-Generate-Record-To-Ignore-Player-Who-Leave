using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Generate_Record_To_Ignore_Player_Who_Leave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string restoreGame;
        private byte[] RestoreFile;


        public void Injection(uint Addresse, string value)
        {
           

            string empty = string.Empty;
            uint num1 = 0;
            byte[] exe = this.RestoreFile;

            string str = Regex.Replace(value, ".{2}", "$0 ");
            char[] chArray = new char[1] { ' ' };
            foreach (string s in str.Split(chArray))
            {
                if (!string.IsNullOrEmpty(s))
                {
                    int num2 = int.Parse(s, NumberStyles.HexNumber);
                    int num3 = (int)exe[(int)Addresse + (int)num1];
                    exe[(int)Addresse + (int)num1] = (byte)num2;
                    int num4 = (int)exe[(int)Addresse + (int)num1];
                }
                ++num1;
            }
            this.RestoreFile = exe;
        }


        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Out of Sync Save -  (*.mgs)|*.mgs";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.restoreGame = openFileDialog.FileName;

        }

        private void buttonGenerateFile_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.restoreGame))
            {
                MessageBox.Show("Browser resore file !");
                return;
            }
            if(string.IsNullOrEmpty(this.textBoxPlayerName.Text))
            {
                MessageBox.Show("set player name !");
                return;
            }
            if (this.numericUpDown1.Value == 0)
            {
                MessageBox.Show("set player position !");
                return;
            }
            if (File.Exists(this.restoreGame + "__"))
                File.Delete(this.restoreGame + "__");
            File.Copy(this.restoreGame, this.restoreGame + "__");
            this.RestoreFile = File.ReadAllBytes(this.restoreGame + "__");
            //player Name
            byte[] baPlayerName = Encoding.Default.GetBytes(this.textBoxPlayerName.Text);
            var hexPlayerName = BitConverter.ToString(baPlayerName).Replace("-","");
            Injection( 0x508, hexPlayerName);
            //player position
            string playerpos = this.numericUpDown1.Text.Trim().PadLeft(2,'0');
            Injection( 0x590, playerpos);
            Injection( 0x594, playerpos);
            File.WriteAllBytes(this.restoreGame + "__", this.RestoreFile);
        }
    }
}
