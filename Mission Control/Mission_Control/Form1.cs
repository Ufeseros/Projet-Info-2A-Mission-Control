using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mission_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chargerMission_Click(object sender, EventArgs e)
        {
            Mission M = new Mission(500, "images/nanedi valles.jpg", "Mission test");
        }

    }
}
