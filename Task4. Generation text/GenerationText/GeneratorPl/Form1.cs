using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenerationText.BLL;

namespace GeneratorPl
{
    public partial class Form1 : Form
    {
        GenerationLogic logic = new GenerationLogic();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void сВыборомКолчичестваСловToolStripMenuItem_Click(object sender, EventArgs e)
        {

           label1.Text = logic.GenerateRandom("говорил");

        }

        private void изФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                logic.AddFile(openFileDialog1.FileName);
            }
        }   

        private void случайнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
