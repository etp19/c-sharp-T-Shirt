using System;
using MetroFramework;
using MetroFramework.Forms;

namespace ClubTShirt
{
    /*
     * Author:          Eduardo Torres
     * Date:            10/31/2017
     * Class:           T_Shirt_Sell
     * Description:     This class creates various events that handle the make order button and the process menu. It also displays messages.      
     */
    public partial class T_Shirt_Sell : MetroForm
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
            MetroMessageBox.Show(this ,"Your order is complete");
        }

        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show message to user about the order size and quatity.

            MetroMessageBox.Show(this, "Size is " + size + " Quatity is " + quatity);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close application
            Close();
        }
    }
}
