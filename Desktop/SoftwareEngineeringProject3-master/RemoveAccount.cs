using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RemoveAccount : Form
    {
        public RemoveAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRemoveAcc_Click(object sender, EventArgs e)
        {
            DBConnectionClass.getInstanceOfDBConnection().DeleteAccount(tbUsernamedel.Text, cbAccounttype_del.Text);
        }
    }
}
