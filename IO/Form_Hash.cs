using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoCore;

namespace IO
{
    public partial class Form_Hash : Form
    {
        public Form_Hash()
        {
            InitializeComponent();
            Heng heng = new Heng();
            heng.Fuck = "vannary";
            MessageBox.Show(heng.Fuck);
        }
        //symmetric AES DES triple des 
        //AES and triple des = 1letter up
        // DES = 8letters
        private void btnmd5_Click(object sender, EventArgs e)
        {
            Hash sh = new Hash(new MD5());
            textBox2.Text = sh.ComputeString(textBox1.Text);
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            aes.Password = "prohos";
            Symmetric sym = new Symmetric(aes);
            textBox2.Text = sym.EncryptString(textBox1.Text);
            textBox1.Text = sym.DecryptString(textBox2.Text);
        }

        private void Form_Hash_Load(object sender, EventArgs e)
        {

        }
    }
}
