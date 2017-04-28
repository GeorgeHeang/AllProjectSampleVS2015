using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + @"\PIC"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\PIC");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.FileName = "";
            op.Filter = "PNG File|*.png|JPEG File|*.jpg|ALL file|*.*";
            op.Multiselect = false;
            op.FilterIndex = 2;
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = op.FileName;
                pictureBox1.LoadAsync();
                File.Copy(op.FileName, Application.StartupPath + "\\PIC\\" + Path.GetFileName(op.FileName), true);
                listBox1.Items.Add(Path.GetFileName(op.FileName));
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (string file in Directory.GetFiles(Application.StartupPath + "\\PIC"))
            {
                string filename = Path.GetFileName(file);
                Panel p = new Panel();
                p.BackColor = Color.Red;
                p.Size = new Size(100, 145);
                PictureBox pic = new PictureBox();
                pic.Size = new Size(90, 110);
                pic.Location = new Point(5, 5);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.ImageLocation = file;
                pic.LoadAsync();
                pic.Click += Pic_Click;
                p.Controls.Add(pic);
                Label lbl = new Label();
                lbl.Text = filename;
                lbl.Location = new Point(5, 120);
                p.Controls.Add(lbl);
                flowLayoutPanel1.Controls.Add(p);

            }
        }
        private void Pic_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((PictureBox)sender).ImageLocation);
        }
    }
}
