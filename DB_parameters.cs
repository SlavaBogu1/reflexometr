using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflexes_UI
{
    public partial class DB_parameters : Form
    {
        public DB_parameters()
        {
            InitializeComponent();
        }

        
        private void db_param_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
