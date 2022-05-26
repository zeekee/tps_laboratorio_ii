using BackendPlatypus;
using System;
using System.Windows.Forms;

namespace Platypus_2
{
    public partial class ConfirmExit : UserControl
    {
        public ConfirmExit()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlController.CloseConnection();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
