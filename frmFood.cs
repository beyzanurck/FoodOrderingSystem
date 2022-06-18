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
        private void frmFood_Load(object sender, EventArgs e)
        {
            txtOrderHistory.Font = new Font("Times New Roman", 9.0f);
            foreach (var item in Order.orderList)
            {
                txtOrderHistory.Text += String.Format("Order: {0}\nPrice: ${1}\n", item.name, item.price);
            }
        }
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

            txtOrderHistory.Clear();
            foreach (var item in Order.orderList)
            {
                txtOrderHistory.Text += String.Format("Order: {0}\nPrice: ${1}\n", item.name, item.price);
            }
        }
        private void btnOrderCB_Click(object sender, EventArgs e)
        {
            Food CheeseBurger = foodFactory("Cheese Burger");
            if (checkCBSpicy.Checked == false) { CheeseBurger.spicy = false; }
            else
            {
                CheeseBurger.spicy = true;
                CheeseBurger.name += " w/spicy";
            }

            if (checkCBDouble.Checked == false) { CheeseBurger.portion = false; }
            else
            {
                CheeseBurger.portion = true;
                CheeseBurger.name += " -Double-";
                CheeseBurger.price += 1;

            }

            order.AddFood(CheeseBurger);

            txtOrderHistory.Clear();
            foreach (var item in Order.orderList)
            {
                txtOrderHistory.Text += String.Format("Order: {0}\nPrice: ${1}\n", item.name, item.price);
            }
        }

        private void btnOrderSha_Click(object sender, EventArgs e)
        {
            Food Shawarma = foodFactory("Shawarma");

            if (checkShaSpicy.Checked == false) { Shawarma.spicy = false; }
            else
            {
                Shawarma.spicy = true;
                Shawarma.name += " w/spicy";
            }

            if (checkShaDouble.Checked == false) { Shawarma.portion = false; }
            else
            {
                Shawarma.portion = true;
                Shawarma.name += " -Double-";
                Shawarma.price += 1;
            }

            order.AddFood(Shawarma);

            txtOrderHistory.Clear();
            foreach (var item in Order.orderList)
            {
                txtOrderHistory.Text += String.Format("Order: {0}\nPrice: ${1}\n", item.name, item.price);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
