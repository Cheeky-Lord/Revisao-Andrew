using DDD.Domain.Commands.Handlers;
using DDD.Domain.Commands.Inputs;
using DDD.Domain.Repositories;
using DDD.Infra.Context;
using DDD.Shared.Commands;
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
    public partial class frmPublicCreateUser : Form
    {
       
       
        private UserHandler _handler;
     
        public frmPublicCreateUser(UserHandler handler)
        {
            _handler = handler;
            
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var PublicCreateUser = (PublicCreateUser)publicCreateUserBindingSource.Current;
            _handler.Handle(PublicCreateUser);
        }

        private void frmPublicCreateUser_Load(object sender, EventArgs e)
        {
            publicCreateUserBindingSource.AddNew();
        }
    }
}
