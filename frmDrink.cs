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
    public partial class frmDrink : Form
    {
        public frmDrink()
        {
            InitializeComponent();
        }

        List<RadioButton> radioCola = new List<RadioButton>();
        List<RadioButton> radioLime = new List<RadioButton>();
        List<RadioButton> radioSmothie = new List<RadioButton>();

        Order order = new Order();

        private void frmDrink_Load(object sender, EventArgs e)
        {
            txtOrderHistory.Font = new Font("Times New Roman", 9.0f);
            foreach (var item in Order.orderList)
            {
                txtOrderHistory.Text += String.Format("Order: {0}\nPrice: ${1}\n", item.name, item.price);
            }

            radioCola.Add(radioLCola);
            radioCola.Add(radioMCola);
            radioCola.Add(radioSCola);

            radioLime.Add(radioLLime);
            radioLime.Add(radioMLime);
            radioLime.Add(radioSLime);


            radioSmothie.Add(radioLSmothie);
            radioSmothie.Add(radioMSmothie);
            radioSmothie.Add(radioSSmothie);
        }

        private Drink DrinkFactory(string name)
        {
            if (name == "Cola") return new Drink() { name = "Cola", price = 1, iced = false, size = 'S' };
            else if (name == "Lemonade") return new Drink() { name = "Lemonade", price = 2, iced = false, size = 'S' };
            else return new Drink() { name = "Smothie", price = 3, iced = false, size = 'S' };
        }


        private void btnOrderCola_Click(object sender, EventArgs e)
        {
            Drink Cola = DrinkFactory("Cola");

            foreach (var item in radioCola)
            {
                if (item.Checked)
                {
                    Cola.size = Convert.ToChar(item.Text);
                    Cola.name += "-" + Cola.size.ToString();
                    break;
                }
            }            

            switch (Cola.size)
            {
                case 'M':
                    Cola.price += 0.5;
                    break;

                case 'L':
                    Cola.price += 0.75;
                    break;
            }

            if (checkIcedCola.Checked)
            {
                Cola.iced = true;
                Cola.name += " w/ice ";
            }

            order.AddFood(Cola);

            txtOrderHistory.Clear();
            foreach (var item in Order.orderList)
            {
                txtOrderHistory.Text += String.Format("Order: {0}\nPrice: ${1}\n", item.name, item.price);
            }
        }

        private void btnOrderLime_Click(object sender, EventArgs e)
        {
            Drink Lemonade = DrinkFactory("Lemonade");

            foreach (var item in radioLime)
            {
                if (item.Checked)
                {
                    Lemonade.size = Convert.ToChar(item.Text);
                    Lemonade.name += "-" + Lemonade.size.ToString();
                    break;
                }
            }

            switch (Lemonade.size)
            {
                case 'M':
                    Lemonade.price += 0.5;
                    break;

                case 'L':
                    Lemonade.price += 0.75;
                    break;
            }

            if (checkIcedLime.Checked)
            {
                Lemonade.iced = true;
                Lemonade.name += " w/ice ";
            }

            order.AddFood(Lemonade);

            txtOrderHistory.Clear();
            foreach (var item in Order.orderList)
            {
                txtOrderHistory.Text += String.Format("Order: {0}\nPrice: ${1}\n", item.name, item.price);
            }
        }

        private void btnOrderSmothie_Click(object sender, EventArgs e)
        {
            Drink Smothie = DrinkFactory("Smothie");

            foreach (var item in radioSmothie)
            {
                if (item.Checked)
                {
                    Smothie.size = Convert.ToChar(item.Text);
                    Smothie.name += "-" + Smothie.size.ToString();
                    break;
                }
            }

            switch (Smothie.size)
            {
                case 'M':
                    Smothie.price += 0.5;
                    break;

                case 'L':
                    Smothie.price += 0.75;
                    break;
            }

            if (checkIcedSmothie.Checked)
            {
                Smothie.iced = true;
                Smothie.name += " w/ice ";
            }

            order.AddFood(Smothie);

            txtOrderHistory.Clear();
            foreach (var item in Order.orderList)
            {
                txtOrderHistory.Text += String.Format("Order: {0}\nPrice: ${1}\n", item.name, item.price);
            }
        }
    }
}
