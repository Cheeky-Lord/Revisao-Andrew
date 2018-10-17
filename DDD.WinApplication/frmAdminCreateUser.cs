using DDD.Domain.Commands.Inputs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD.WinApplication
{
    public partial class frmAdminCreateUser : Form
    {
        private AdminCreateUser command;
        public frmAdminCreateUser()
        {
            InitializeComponent();
        }

        private void frmAdminCreateUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            command = (AdminCreateUser)adminCreateUserBindingSource.Current;
        }
    }
}
