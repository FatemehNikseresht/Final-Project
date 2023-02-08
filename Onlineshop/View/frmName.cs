using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmName : Form
    {
        public frmName()
        {
            InitializeComponent();
            this.btnPerson.MouseHover += btnPerson_MouseHover;
            this.btnProduct.MouseHover += btnProduct_MouseHover;
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            new frmPerson().Show();
            this.Hide();
        }

        

        private void btnPerson_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnPerson, "شخص");


        }

        private void btnProduct_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnProduct, "محصولات");

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

            new frmProduct().Show();
            this.Hide();
        }
    }
}
