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

namespace TreeSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //test stuff
            DirectoryInfo files = new DirectoryInfo(@"c:\Temp\");
            listBox1.DataSource = files.GetFiles();
            files.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo current = (FileInfo)listBox1.SelectedItem;
            namevalue.Text = current.Name;
            sizevalue.Text = current.Length.ToString();
        }
    }
}
