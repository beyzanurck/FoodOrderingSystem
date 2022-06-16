using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingSystem
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }

        Order order = new Order();
        List<MenuItem> menu = new List<MenuItem>();

        private void frmFood_Load(object sender, EventArgs e)
        {
            menu.Add(new Food()
            { name = "Hamburger", price = 6, portion = false, spicy = false });
            menu.Add(new Food()
            { name = "Cheese Burger", price = 8, portion = false, spicy = false });
            menu.Add(new Food()
            { name = "Shawarma", price = 7, portion = false, spicy = false });
          
        }

        private void btnOrderHam_Click(object sender, EventArgs e)
        {
            foreach (var item in menu)
            {
                if ("Hamburger" == item.name)
                {
                    if (checkHamSpicy.Checked == false) { ((Food)item).spicy = false; }
                    else 
                    { 
                        ((Food)item).spicy = true;
                        item.name += " w/spicy";
                    }

                    if (checkHamDouble.Checked == false) { ((Food)item).portion = false; }
                    else
                    { 
                        ((Food)item).portion = true;
                        item.name += " -Double-";
                        item.price += 1;

                    }

                    order.AddFood(item);

                    txtOrderHistory.Text += String.Format("Order: {0}\nPrice: ${1}", item.name, item.price);
                }
            }
            
        }
       
    }
}
