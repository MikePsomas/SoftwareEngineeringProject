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
    public partial class AssignIdea : Form
    {
        private bool Successful = false;
        public AssignIdea()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ViewCallClientsFE = new ShowInfo();
            ViewCallClientsFE.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btAssignIdea_Click(object sender, EventArgs e)
        {
          Successful =  DBConnectionClass.getInstanceOfDBConnection().AssignIdeaBE(TbClientUsername.Text, TbIdeaName.Text);
            if (Successful)
            {
                MessageBox.Show("Assigning successful!");
            }
            else
            {
                MessageBox.Show("Assigning unsuccessful, please try again...");
            }
        }
    }
}
