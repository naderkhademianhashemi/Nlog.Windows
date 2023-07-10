using Nlog.Windows.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nlog.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnError_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Extens.LogError(ex.ToString());
            }
        }
    }
}
