using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelloCS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnGreeting_click(object sender, EventArgs e)
        {
            MessageBox.Show("우왕ㅇ아앙 안녕?", "반가워~", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
