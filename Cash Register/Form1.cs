//Created by Doyle Blacklock on October, 14 2016
//To create a cashregister that can be used to calculate the total of a meal
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        const double BURGER = 5.39;//Creates constant for cost of burgers
        const double FRIES = 2.43;//Creates constant for cost of fries
        const double DRINK = 1.73;//Creates constant for cost of drink
        const double TAXRATE = 0.13;//Creates constant for rate of tax
        int burgerAmount;//Creates a variable for number of burgers bought 
        int friesAmount;//Creates a variable for number of fries bought
        int drinkAmount;//Creates a variable for number of drinks bought
        double tendered;//Creates a double for amount paid by customer
        double change;//Creates a variable for change returned to customer
        double tax;//Creates a variable for the cost of the tax
        double subtotal;//Creates a variable for the subtotal
        double total;//Creates a variable for the total cost
        double burgerCost;//Creates a variale for the cost of just the burgers
        double friesCost;//Creates a variable for the cost of just the fries
        double drinkCost;//Creates a variable for the cost of just the drinks
        bool printRec = false;//Creates a boolean variable for the paint event

        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();//Allows for graphics to be created
            SolidBrush whiteBrush = new SolidBrush(Color.White);//Creates a white brush
            Font drawFont = new Font("Arial", 8, FontStyle.Bold);//Allows for strings to be drawen
            SoundPlayer cashRegister = new SoundPlayer(Properties.Resources.Cash_Register_201159);//Creates Sound player

            //Makes variables equal the text boxes
            friesAmount = Convert.ToInt32(inputFries.Text);
            drinkAmount = Convert.ToInt32(inputDrinks.Text);
            burgerAmount = Convert.ToInt32(inputBurgers.Text);

            try
            {
                //Calculates the subtotal, tax and total
                subtotal = burgerAmount * BURGER + friesAmount * FRIES + drinkAmount * DRINK;
                tax = subtotal * TAXRATE;
                total = subtotal + tax;

                //Makes it impossible to enter negative values
                if (burgerAmount < 0)
                {
                    subtotalOutput.Text = "Please use positive numbers.";
                    taxOutput.Text = "";
                    totalOutput.Text = "";
                    changeOutput.Text = "";
                    formGraphics.Clear(Color.Black);
                }

                else if (drinkAmount < 0)
                {
                    subtotalOutput.Text = "Please use positive numbers.";
                    taxOutput.Text = "";
                    totalOutput.Text = "";
                    changeOutput.Text = "";
                    formGraphics.Clear(Color.Black);
                }

                else if (friesAmount < 0)
                {
                    subtotalOutput.Text = "Please use positive numbers.";
                    taxOutput.Text = "";
                    totalOutput.Text = "";
                    changeOutput.Text = "";
                    formGraphics.Clear(Color.Black);
                }

                else if (total <= 0)//Prevents the user from printing a receipt after ordering nothing
                {
                    subtotalOutput.Text = "Please enter your order.";
                    taxOutput.Text = "";
                    totalOutput.Text = "";
                    changeOutput.Text = "";
                    formGraphics.Clear(Color.Black);
                }
                else
                {
                    //Clears the screen and graphics to make sure no error messages are still there
                    subtotalOutput.Text = "";
                    taxOutput.Text = "";
                    totalOutput.Text = "";
                    formGraphics.Clear(Color.Black);
                    changeOutput.Text = "";

                    subtotalOutput.Text = subtotal.ToString("C");//Displays the subtotal

                    //Plays cash register sound
                    cashRegister.Play();

                    //Refreshes and delays for half a second
                    Refresh();
                    Thread.Sleep(1200);

                    taxOutput.Text = tax.ToString("C");//Displays the tax

                    //Plays cash register sound
                    cashRegister.Play();

                    //Refreshes and delays for half a second
                    Refresh();
                    Thread.Sleep(1200);

                    totalOutput.Text = total.ToString("C");//Displays the tax

                    //Plays cash register sound
                    cashRegister.Play();

                    //Refreshes and delays for half a second
                    Refresh();
                    Thread.Sleep(1200);

                    formGraphics.FillRectangle(whiteBrush, 10, 220, 150, 10);//Draws a white reactangle
                }
            }
            catch//Prevents the user from inputing decimals and letters
            {
                subtotalOutput.Text = "Please use whole numbers.";
                taxOutput.Text = "";
                totalOutput.Text = "";
                formGraphics.Clear(Color.Black);
                changeOutput.Text = "";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            SoundPlayer purchase = new SoundPlayer(Properties.Resources._209578__zott820__cash_register_purchase);//Creates Sound player

            try
            {
                //Lets tendered be changed by the user
                tendered = Convert.ToDouble(changeInput.Text);

                //Prevents the user from paying less than the total
                if (tendered <= total)
                {
                    changeOutput.Text = "Tendered must exceed the total.";
                }
                else if (subtotal <= 0)
                {
                    subtotalOutput.Text = "Please enter your order.";
                }
                else
                {
                    change = tendered - total;//Calculates change

                    purchase.Play();//Plays sound

                    changeOutput.Text = change.ToString("C");//Displays change
                }
            }
            catch
            {
                changeOutput.Text = "Please use whole numbers.";//Prevents the user from using decimals and letters
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();//Allows for graphics to be created

            if (tendered < total)
            {
                changeOutput.Text = "Tendered must exceed the total.";

            }
            else if (total <= 0)//Prevents the user from printing a receipt after ordering nothing
            {
                subtotalOutput.Text = "Please enter your order.";
                taxOutput.Text = "";
                totalOutput.Text = "";
                changeOutput.Text = "";
            }
            else
            {
                for (int x = 188; x < 388; x += 20)//Resizes the form to allow for the reciept
                {
                    this.Size = new Size(x, 432);

                    Thread.Sleep(50);
                }
                printRec = true;//Makes printRec true to allow paint event to happen

                Refresh();//Calls the paint event
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Declares variables
            int x1 = 360;
            int x2 = 380;
            int x3 = 400;
            int x4 = 430;
            int x5 = 450;
            int x6 = 470;
            int x7 = 500;
            int x8 = 520;
            int x9 = 540;
            int x10 = 570;
            int x11 = 590;
            int x12 = 640;

            if (printRec)//Calls printRec when it is true
            {
                SolidBrush whiteBrush = new SolidBrush(Color.White);//Creates Brush
                Font drawFont = new Font("Arial", 8, FontStyle.Bold);//Creates string function
                SolidBrush drawBrush = new SolidBrush(Color.Black);//Creates Brush
                SoundPlayer Receipt = new SoundPlayer(Properties.Resources._345056__azumarill__epson_receipt_printer3);//Creates Soundplayer

                DateTime thisDay = DateTime.Today;//Makes a variable for the current date

                //Performs calculations for cost of individual components
                burgerCost = burgerAmount * BURGER;
                friesCost = friesAmount * FRIES;
                drinkCost = drinkAmount * DRINK;

                Receipt.Play();//Plays Sound
                for (int x = 0; x < 18; x++)
                {
                    e.Graphics.FillRectangle(whiteBrush, 10, 220, 150, 10);//Redraws the rectangle between tendered and total
                    e.Graphics.FillRectangle(whiteBrush, 190, 10, 160, 325);//Draws a rectangle

                    //Draws the information for the receipt
                    e.Graphics.DrawString("Bob's Burger Banaza Inc.", drawFont, drawBrush, 190, x1);
                    e.Graphics.DrawString("Order Number 1059", drawFont, drawBrush, 190, x2);
                    e.Graphics.DrawString(thisDay.ToString("D"), drawFont, drawBrush, 190, x3);
                    e.Graphics.DrawString("Hamburger's X" + burgerAmount + " @ " + burgerCost.ToString("C"), drawFont, drawBrush, 190, x4);
                    e.Graphics.DrawString("Fries X" + friesAmount + "              @ " + friesCost.ToString("C"), drawFont, drawBrush, 190, x5);
                    e.Graphics.DrawString("Drinks X" + drinkAmount + "            @ " + drinkCost.ToString("C"), drawFont, drawBrush, 190, x6);
                    e.Graphics.DrawString("Subtotal " + subtotal.ToString("C"), drawFont, drawBrush, 190, x7);
                    e.Graphics.DrawString("Tax " + tax.ToString("C"), drawFont, drawBrush, 190, x8);
                    e.Graphics.DrawString("Total " + total.ToString("C"), drawFont, drawBrush, 190, x9);
                    e.Graphics.DrawString("Tendered " + tendered.ToString("C"), drawFont, drawBrush, 190, x10);
                    e.Graphics.DrawString("Change " + change.ToString("C"), drawFont, drawBrush, 190, x11);
                    e.Graphics.DrawString("Have a great day!!", drawFont, drawBrush, 190, x12);

                    //Subtracts 20 from each variable
                    x1 -= 20;
                    x2 -= 20;
                    x3 -= 20;
                    x4 -= 20;
                    x5 -= 20;
                    x6 -= 20;
                    x7 -= 20;
                    x8 -= 20;
                    x9 -= 20;
                    x10 -= 20;
                    x11 -= 20;
                    x12 -= 20;

                    //Delays for 300 milliseconds
                    Thread.Sleep(300);
                }

                printRec = false;//Makes printRec false and unable to be called upon
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();//Allows for graphics to be created

            //Resizes form to default size
            this.Size = new Size(188, 432);

            //Resets screen to default text 
            inputBurgers.Text = "0";
            inputFries.Text = "0";
            inputDrinks.Text = "0";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeInput.Text = "0";
            changeOutput.Text = "";
            formGraphics.Clear(Color.Black);

            //Resets all variable to 0
            burgerAmount = 0;
            friesAmount = 0;
            drinkAmount = 0;
            tendered = 0;
            change = 0;
            tax = 0;
            subtotal = 0;
            total = 0;
            burgerCost = 0;
            friesCost = 0;
            drinkCost = 0;
        }
    }
}
    

