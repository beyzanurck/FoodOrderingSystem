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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Order order = new Order();
        frmFood frmFood;
        frmDrink frmDrink;

        DateTime moment = new DateTime();

        private void frmMain_Load(object sender, EventArgs e)
        {
            //menu.Add(new Drink()
            //{ name = "Cola", price = 1.5, size = 'M', iced = true });

            //menu.Add(new Drink()
            //{ name = "Lemonade", price = 2, size = 'M', iced = true });
            //menu.Add(new Drink()
            //{ name = "Smothie", price = 3, size = 'M', iced = true });

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmFood = new frmFood();
            frmFood.Show();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            frmDrink = new frmDrink();
            frmDrink.Show();
        }

        private void btnCompOrder_Click(object sender, EventArgs e)
        {
            double price = 0;

            foreach (var item in Order.orderList)
            {
                price += item.price;
            }

            moment = FormatTime();

            MessageBox.Show("Your total price is: $" + price.ToString() +"\n"+ moment.ToString());

            this.Close();
        }

        public static DateTime FormatTime()
        {
            return DateTime.UtcNow.ToLocalTime();
        }
    }
}
