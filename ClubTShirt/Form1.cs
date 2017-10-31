using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubTShirt
{
    public partial class T_Shirt_Sell : MetroFramework.Forms.MetroForm
    {
        string size;
        int quatity;
        public T_Shirt_Sell()
        {
            InitializeComponent();
        }

        private void Make_Order_Click(object sender, EventArgs e)
        {
            // assing the selected size valiable.
            size = size_chose.SelectedItem.ToString();

            // assign quantity
            quatity = Convert.ToInt32(Amount_TextBox.Text);
            MetroFramework.MetroMessageBox.Show(this ,"Your order is complete");
        }

        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show message to user about the order size and quatity.

            MetroFramework.MetroMessageBox.Show(this, "Size is " + size + " Quatity is " + quatity);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close application
            this.Close();
        }
    }
}
