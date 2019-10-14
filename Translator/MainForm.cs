using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void But1_Click(object sender, EventArgs e)
        {
            firstTr f = new firstTr();
            f.Show();
        }

        private void But2_Click(object sender, EventArgs e)
        {
            secondTr f = new secondTr();
            f.Show();
        }

        private void But3_Click(object sender, EventArgs e)
        {
            thirdTr f = new thirdTr();
            f.Show();
        }
    }
}
