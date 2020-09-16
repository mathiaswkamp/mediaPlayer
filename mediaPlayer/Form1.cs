using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AXVLC;
using AxAXVLC;

namespace mediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "( *.mp4) | *.mp4";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                form2.mediaPlayer.playlist.add(openFileDialog.FileName, openFileDialog.SafeFileName, null);
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
           

            DirectoryInfo di = new DirectoryInfo("E:/");
            FileInfo[] fi = di.GetFiles("*.mp4");

            foreach (FileInfo curFile in fi)
            {
                VlcVideos.Items.Add(curFile.Name);
                form2.mediaPlayer.playlist.add("File:///" + curFile.FullName);

            }
        }

        private void VlcVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            form2.WindowState = FormWindowState.Maximized;
            form2.mediaPlayer.Dock = DockStyle.Fill;
            form2.Show();
            int selIndex = VlcVideos.SelectedIndex;
            form2.mediaPlayer.playlist.playItem(selIndex);
        }
    }
}
