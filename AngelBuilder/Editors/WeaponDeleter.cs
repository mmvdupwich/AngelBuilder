using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelBuilder
{
    public partial class WeaponDeleter : Form
    {
        public WeaponDeleter()
        {
            InitializeComponent();
        }

        private void WeaponDeleter_Load(object sender, EventArgs e)
        {

        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void WeaponDeleter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_Delete_Click(this, new EventArgs());
            }

            if (e.KeyCode == Keys.Escape)
            {
                Button_Cancel_Click(this, new EventArgs());
            }
        }
    }
}
