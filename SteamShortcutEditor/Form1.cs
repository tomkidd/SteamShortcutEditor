using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace SteamShortcutEditor
{
    public partial class Form1 : Form
    {
        List<Game> games;
        DataTable dtGames;

        public Form1()
        {
            DataColumn dcAppName = new DataColumn("AppName");
            DataColumn dcExe = new DataColumn("Exe");
            DataColumn dcStartDir = new DataColumn("StartDir");

            dtGames = new DataTable();
            dtGames.Columns.Add(dcAppName);
            dtGames.Columns.Add(dcExe);
            dtGames.Columns.Add(dcStartDir);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"D:\games\steam\config\shortcuts - Copy.vdf";
            StringBuilder sb = GetByteText(filename);

           // textBox1.Text = sb.ToString();
        }

        private static StringBuilder GetByteText(string filename)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(filename).Length;
            buff = br.ReadBytes((int)numBytes);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in buff)
            {
                //char c = '\0';
                //try{c = (char)b;}catch{}
                if ((int)b != 0)
                {
                    sb.AppendLine(string.Format("\"{3}\"\t{0}\tU+{1:x4}\t{2}", b, (int)b, (int)b, (char)b));
                }
                else
                {
                    sb.AppendLine(string.Format("\"{3}\"\t{0}\tU+{1:x4}\t{2}", b, (int)b, (int)b, ""));
                }
            }
            return sb;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte byteZero = byte.Parse("0");
            byte byteOne = byte.Parse("1");
            byte byteEight = byte.Parse("8");
            byte[] byteShortcuts = Encoding.ASCII.GetBytes("Shortcuts");
            byte[] byteAppName = Encoding.ASCII.GetBytes("AppName");
            byte[] byteExe = Encoding.ASCII.GetBytes("Exe");
            byte[] byteStartDir = Encoding.ASCII.GetBytes("StartDir");
            byte[] byteIcon = Encoding.ASCII.GetBytes("icon");
            byte[] byteTags = Encoding.ASCII.GetBytes("tags");

            List<byte> lbytes = new List<byte>();

            lbytes.Add(byteZero);
            //lbytes.Add(byteOne);
            lbytes.AddRange(byteShortcuts);
            lbytes.Add(byteZero);

            List<Game> games = new List<Game>();

            foreach (DataRow drGame in dtGames.Rows)
            {
                Game game = new Game(drGame["AppName"].ToString() + " (Non-Steam)", drGame["Exe"].ToString(), drGame["StartDir"].ToString());
                games.Add(game);
            }

            int i = 0;

            foreach (Game game in games)
            {
                lbytes.Add(byteZero);

                byte[] byteIndex = Encoding.ASCII.GetBytes(i.ToString());
                lbytes.AddRange(byteIndex);

                lbytes.Add(byteZero);
                lbytes.Add(byteOne);

                lbytes.AddRange(byteAppName);
                lbytes.Add(byteZero);
                lbytes.AddRange(Encoding.ASCII.GetBytes(game.AppName));
                lbytes.Add(byteZero);
                lbytes.Add(byteOne);

                lbytes.AddRange(byteExe);
                lbytes.Add(byteZero);
                lbytes.AddRange(Encoding.ASCII.GetBytes(game.Exe));
                lbytes.Add(byteZero);
                lbytes.Add(byteOne);

                lbytes.AddRange(byteStartDir);
                lbytes.Add(byteZero);
                lbytes.AddRange(Encoding.ASCII.GetBytes(game.StartDir));
                lbytes.Add(byteZero);
                lbytes.Add(byteOne);

                lbytes.AddRange(byteIcon);
                lbytes.Add(byteZero);
                lbytes.Add(byteZero);
                lbytes.Add(byteZero);

                lbytes.AddRange(byteTags);
                lbytes.Add(byteZero);
                lbytes.Add(byteEight);
                lbytes.Add(byteEight);

                i++;
            }

            lbytes.Add(byteEight);
            lbytes.Add(byteEight);
            
            byte[] buffer = lbytes.ToArray();

            string outputFilename = txtSteamDir.Text + "\\config\\shortcuts.vdf";

            if (File.Exists(outputFilename))
            {
                File.Delete(outputFilename);
            }

            FileStream fs = new FileStream(outputFilename, FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(buffer);
            bw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            games = new List<Game>();

            GameSearch(txtGamesDir.Text);

            foreach (Game game in games)
            {
                DataRow drGame = dtGames.NewRow();
                drGame["AppName"] = game.AppName;
                drGame["Exe"] = game.Exe;
                drGame["StartDir"] = game.StartDir;
                dtGames.Rows.Add(drGame);
            }

            dataGridView1.DataSource = dtGames;
        }

        private void GameSearch(string sDir)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(sDir);
                foreach (DirectoryInfo subdi in di.GetDirectories())
                {
                    foreach (FileInfo fi in subdi.GetFiles("*.exe"))
                    {
                        if (!fi.FullName.Contains(txtSteamDir.Text))
                        {
                            games.Add(new Game(fi.Name.Replace(fi.Extension,""), fi.FullName, fi.Directory.FullName));
                        }
                    }
                    GameSearch(subdi.FullName);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XmlDocument xmlGames = new XmlDocument();
            XmlElement xeGames = xmlGames.CreateElement("games");

            foreach (DataRow dr in dtGames.Rows)
            {
                //games.Add(new Game(dr["AppName"].ToString(), dr["Exe"].ToString(), dr["StartDir"].ToString()));
                XmlElement xeGame = xmlGames.CreateElement("game");
                XmlElement xeAppName = xmlGames.CreateElement("AppName");
                XmlElement xeExe = xmlGames.CreateElement("Exe");
                XmlElement xeStartDir = xmlGames.CreateElement("StartDir");

                xeAppName.InnerText = dr["AppName"].ToString();
                xeExe.InnerText = dr["Exe"].ToString();
                xeStartDir.InnerText = dr["StartDir"].ToString();

                xeGame.AppendChild(xeAppName);
                xeGame.AppendChild(xeExe);
                xeGame.AppendChild(xeStartDir);

                xeGames.AppendChild(xeGame);
            }

            xmlGames.AppendChild(xeGames);

            if (File.Exists("games.xml"))
            {
                File.Delete("games.xml");
            }

            xmlGames.Save("games.xml");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XmlDocument xmlGames = new XmlDocument();
            xmlGames.Load("games.xml");

            XmlNodeList xnlGames = xmlGames.GetElementsByTagName("game");
            
            dtGames.Clear();

            foreach (XmlElement xeGame in xnlGames)
            {
                DataRow drGame = dtGames.NewRow();
                drGame["AppName"] = xeGame["AppName"].InnerText;
                drGame["Exe"] = xeGame["Exe"].InnerText;
                drGame["StartDir"] = xeGame["StartDir"].InnerText;
                dtGames.Rows.Add(drGame);
            }

            dataGridView1.DataSource = dtGames;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtGames.Rows.Count.ToString());
        }
    }

    public class Game
    {
        public Game()
        {
        }

        public Game(string AppName, string Exe, string StartDir)
        {
            this.AppName = AppName;
            this.Exe = Exe;
            this.StartDir = StartDir;
        }

        private string appName;

        public string AppName
        {
            get { return appName; }
            set { appName = value; }
        }

        private string exe;

        public string Exe
        {
            get { return exe; }
            set { exe = value; }
        }

        private string startDir;

        public string StartDir
        {
            get { return startDir; }
            set { startDir = value; }
        }
    }

}
