using CompleteAssignment1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAssignment
{
    public partial class Form1 : Form
    {
        Logic l = new Logic();
        public Form1()
        {
            InitializeComponent();
        }
        private void load(object sender, EventArgs e)
        {
            l.Load();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            l.Spin();
        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            l.Shoot();
        }

        private void StartAgain_Click(object sender, EventArgs e)
        {
            l.StartAgain();
        }
    }
}
