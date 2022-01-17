using Porxy.PorxyDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IKullaniciBilgi proxy = new ProxyKullaniciBilgi();
            MessageBox.Show(proxy.getUserInformation());
            MessageBox.Show("AHAHAHAH");
            MessageBox.Show(proxy.getUserInformation());
        }
    }
}
