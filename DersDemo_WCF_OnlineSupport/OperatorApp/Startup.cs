using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperatorApp
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Misc")]
        public string OperatorName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
