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

        private Food foodFactory(string Name)
        {
            //Constructor class içerisinde ilk oluşturulurken cağrılan fonksiyona denir
            //Factory ise genel olarak farklı class lar oluşturmak için kullanılır.
            if (Name == "Hamburger") return new Food() { name = "Hamburger", price = 6, portion = false, spicy = false };
            else if (Name == "Cheese Burger") return new Food() { name = "Cheese Burger", price = 8, portion = false, spicy = false };
            else return new Food() { name = "Shawarma", price = 7, portion = false, spicy = false };
        }

        private void btnOrderHam_Click(object sender, EventArgs e)
        {
            Food Hamburger = foodFactory("Hamburger");
            if (checkHamSpicy.Checked == false) { Hamburger.spicy = false; }
            else
            {
                Hamburger.spicy = true;
                Hamburger.name += " w/spicy";
            }

            if (checkHamDouble.Checked == false) { Hamburger.portion = false; }
            else
            {
                Hamburger.portion = true;
                Hamburger.name += " -Double-";
                Hamburger.price += 1;

            }

            order.AddFood(Hamburger);

            txtOrderHistory.Text += String.Format("Order: {0}\nPrice: ${1}\n", Hamburger.name, Hamburger.price);
        }
       
    }
}
