using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotSoGoodForYou
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                System.Windows.Forms.MessageBox.Show("Name Cannot Be Blank. Reenter");
            }

            else
            {
                label1.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;

                txtItemKey.Enabled = true;
                txtOrderCount.Enabled = true;
                btnAdd.Enabled = true;
                btnMoreToOrder.Enabled = true;
                btnAllDone.Enabled = true;


             System.Windows.Forms.MessageBox.Show("Please enter the corresponding" +
                 " order key to select something from the menu. ");

               MessageBox.Show( Global.OrderList.buildStringForMessageBox());


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int key = Int32.Parse(txtItemKey.Text);
            int quantity = Int32.Parse(txtOrderCount.Text);

            if (key > 0 && key < 9) {


                //Global.OrderList.buildStringForMessageBox();

              string keyy = Global.MenuInfo.getMenuItemName(key);
              decimal price =  Global.MenuInfo.getMenuItemPrice(key);
              int ordercount = Int32.Parse(txtOrderCount.Text);

                OrderItem order = new OrderItem(key ,keyy, price,ordercount );
                Global.OrderList.addNewItem(order);
               string content =  Global.OrderList.buildStringForMessageBox();
                MessageBox.Show(content);
            }
            else
            {

                MessageBox.Show("Faulty Not on the Menu. Try again", "Error");

            }



           
        }
        

    private void txtItemKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMoreToOrder_Click(object sender, EventArgs e)
        {
            txtOrderCount.Text = "";
            txtItemKey.Text = "";

        }

        private void btnAllDone_Click(object sender, EventArgs e)
        {
            //PROFESSOR I COULDNT FINISH. 
            
        }
    }
}
