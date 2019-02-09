using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gatelog
{
    public partial class GateInOut : Form
    {
        public GateInOut()
        {
            InitializeComponent();
        }

        private void GateInOut_Load(object sender, EventArgs e)
        {

        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        
        
        private void btnsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + txtname.Text);
        }

        
        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit Data");
        }
    }
}
