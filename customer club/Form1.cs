using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Rayan;

namespace customer_club
{
    public partial class Form1 : Form
    {

        #region General Method

        private void ConnectionMessageMethod()
        {
            MessageBox.Show("Your connection to the database could not be established" , "Warning" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
        }


        public void SizeMaxMethod(int x , int y)
        {
            pageOnePizzaUserControl1.Size = new Size(x, y);
            pageTwoPizzaUserControl1.Size = new Size(x , y);
            pageOneHamburgerUserControl1.Size = new Size(x , y);
            pageTwoHamburgerUserControl1.Size = new Size(x , y);
            pageOneSandwichUserControl1.Size = new Size(x , y);
            pageTwoSandwichUserControl1.Size = new Size(x , y);
            pageOneDeliveryUserControl1.Size = new Size(x , y);
            pageOneSubscriptionUserControl1.Size = new Size(x , y);
            
        }



        public void LocationMaxMethod(int x , int y)
        {
            cheesburgerUserControl1.Location = new Point(x, y);
            pageOnePizzaUserControl1.Location = new Point(x, y);
            pageTwoPizzaUserControl1.Location = new Point(x, y);
            pageOneHamburgerUserControl1.Location = new Point(x,y);
            pageTwoHamburgerUserControl1.Location = new Point(x, y);
            pageOneSandwichUserControl1.Location = new Point(x, y);
            pageTwoSandwichUserControl1.Location = new Point(x, y);
            pageOneDrinksUserControl1.Location = new Point(x, y);
            pageOneDeliveryUserControl1.Location = new Point(x, y);
            pageOneSubscriptionUserControl1.Location = new Point(x, y);
        }


        public void LocationMinMethod(int x , int y)
        {
            cheesburgerUserControl1.Location = new Point(x, y);
            pageOnePizzaUserControl1.Location = new Point(x, y);
            pageTwoPizzaUserControl1.Location = new Point(x,y);
            pageOneHamburgerUserControl1.Location = new Point(x, y);
            pageTwoHamburgerUserControl1.Location = new Point(x, y);
            pageOneSandwichUserControl1.Location = new Point(x, y);
            pageTwoSandwichUserControl1.Location = new Point(x, y);
            pageOneDrinksUserControl1.Location = new Point(x,y);
            pageOneDeliveryUserControl1.Location = new Point(x, y);
            pageOneSubscriptionUserControl1.Location = new Point(x,y);
        }
        

        #endregion

        #region MethodHintOnAndOff

        /// <summary>
        /// این متد برای روشن کردن کلید های پیتزا بعد و قبل در پیج پیتزا است
        /// </summary>
        /// 
        private void HintOnPizzaMethod()
        {
            HintRightPizzaButton.Visible = true;
            HintLeftPizzaButton.Visible = true;
        }


        /// <summary>
        /// این متد برای خاموش  کردن کلید های پیتزا بعد و قبل در پیج پیتزا است
        /// </summary>
        private void HintOffPizzaMethod()
        {
            HintRightPizzaButton.Visible = false;
            HintLeftPizzaButton.Visible = false;
        }

        

        /// <summary>
        /// 
        /// این متد برای روشن کردن کلید های همبرگر بعد و قبل در پیج همبرگر است
        /// </summary>
        private void HintOnBurgerMethod()
        {
            HintRightBurgerButton.Visible = true;
            HintLeftBurgerButton.Visible = true;
        }



        /// <summary>
        /// این متد برای خاموش  کردن کلید های همبرگر بعد و قبل در پیج همبرگر است
        /// </summary>
        private void HintOffBurgerMethod()
        {
            HintRightBurgerButton.Visible = false;
            HintLeftBurgerButton.Visible = false;
        }


        /// <summary>
        /// این متد برای روشن کردن کلید های ساندویچ بعد و قبل در پیج همبرگر است
        /// </summary>
        private void HintOnSandwichMethod()
        {
            HintRightSandwichButton.Visible = true;
            HintLeftSandwichButton.Visible = true;
        }



        /// <summary>
        /// این متد برای خاموش کلید های ساندویچ بعد و قبل در پیج همبرگر است
        /// </summary>
        private void HintOffSandwichMethod()
        {
            HintRightSandwichButton.Visible = false;
            HintLeftSandwichButton.Visible = false;
        }



        /// <summary>
        /// این متد برای تمیز تر نوشته شدن کدها نوشته شده است
        /// </summary>
        private void HintOffPizzaBurgerSandwich()
        {
            HintOffPizzaMethod();
            HintOffBurgerMethod();
            HintOffSandwichMethod();

        }


        private void HintOnPizzaOffBurgerSandwich()
        {
            HintOnPizzaMethod();
            HintOffBurgerMethod();
            HintOffSandwichMethod();
        }

        private void HintOnBurgerOffPizzaSandwich()
        {
            HintOnBurgerMethod();
            HintOffPizzaMethod();
            HintOffSandwichMethod();
        }

        private void HintOnSandwichOffPizzaBurger()
        {
            HintOnSandwichMethod();
            HintOffPizzaMethod();
            HintOffBurgerMethod();
        }


        private void ClearTextSubscription()
        {
            pageOneSubscriptionUserControl1.FirstNameSubTextBox.Clear();
            pageOneSubscriptionUserControl1.LastNameSubTextBox.Clear();
            pageOneSubscriptionUserControl1.PhoneNumberTextbox.Clear();
            pageOneSubscriptionUserControl1.CodeSubTextBox.Clear();
            pageOneSubscriptionUserControl1.CopiedCheckBox.Checked = false;
        }


        private void ClearTextDelivery()
        {
           
        }



        #endregion

        #region Not Use Methods

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        #endregion

        public Form1()
        {
            InitializeComponent();
            ToolClass.HintHomeMethod(HintButton, HomeButton);
        }

        private void CloseAppPicture_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RestoreDownPicture_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MinimizedPicture_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ToolClass.HintHomeMethod(HintButton, HomeButton);
            cheesburgerUserControl1.Visible = true;
            cheesburgerUserControl1.BringToFront();
            HintOffPizzaBurgerSandwich();
            ClearTextSubscription();

        }

        private void PizzasButton_Click(object sender, EventArgs e)
        {
            ToolClass.HintHomeMethod(HintButton, PizzasButton);
            cheesburgerUserControl1.Visible = false;
            pageOnePizzaUserControl1.BringToFront();
            HintOnPizzaOffBurgerSandwich();
            ClearTextSubscription();
            ClearTextDelivery();
        }


        private void HamburgersButton_Click(object sender, EventArgs e)
        {
            ToolClass.HintHomeMethod(HintButton, HamburgersButton);
            cheesburgerUserControl1.Visible = false;
            pageOneHamburgerUserControl1.BringToFront();
            HintOnBurgerOffPizzaSandwich();
            ClearTextSubscription();
            ClearTextDelivery();
        }

        private void SandwichesButton_Click(object sender, EventArgs e)
        {
            ToolClass.HintHomeMethod(HintButton, SandwichesButton);
            cheesburgerUserControl1.Visible = false;
            pageOneSandwichUserControl1.BringToFront();
            HintOnSandwichMethod();
            ClearTextSubscription();
            ClearTextDelivery();
        }

        private void DrinkButton_Click(object sender, EventArgs e)
        {
            ToolClass.HintHomeMethod(HintButton, DrinkButton);
            cheesburgerUserControl1.Visible = false;
            pageOneDrinksUserControl1.BringToFront();
            HintOffPizzaBurgerSandwich();
            ClearTextSubscription();
            ClearTextDelivery();
        }

        private void DliveryButton_Click(object sender, EventArgs e)
        {
            ToolClass.HintHomeMethod(HintButton, DliveryButton);
            cheesburgerUserControl1.Visible = false;
            pageOneDeliveryUserControl1.BringToFront();
            HintOffPizzaBurgerSandwich();
            ClearTextSubscription();
            ClearTextDelivery();
        }

        private void SubscriptionButton_Click(object sender, EventArgs e)
        {
            ToolClass.HintHomeMethod(HintButton, SubscriptionButton);
            cheesburgerUserControl1.Visible = false;
            pageOneSubscriptionUserControl1.BringToFront();
            HintOffPizzaBurgerSandwich();
            ClearTextSubscription();
            ClearTextDelivery();
        }

        private void SettingPictureButton_Click(object sender, EventArgs e)
        {
            ClearTextSubscription();
            ClearTextDelivery();
        }

        private void NotifPictureButton_Click(object sender, EventArgs e)
        {
            ClearTextSubscription();
        }

        private void DirectPictureButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolClass.EnableFalseMethod(pageOneSubscriptionUserControl1.FirstNameSubTextBox , pageOneSubscriptionUserControl1.LastNameSubTextBox);
            pageOneSubscriptionUserControl1.PhoneNumberTextbox.Enabled = false;
            pageOneSubscriptionUserControl1.DataGrideSubscription.Visible = false;
            cheesburgerUserControl1.BringToFront();
            HintOffPizzaBurgerSandwich();
            //MaximizeBox = false;
            //MinimizeBox = false;
        }

        private void HintRightPizzaButton_Click(object sender, EventArgs e)
        {
            pageTwoPizzaUserControl1.BringToFront();
        }

        private void HintLeftPizzaButton_Click(object sender, EventArgs e)
        {
           pageOnePizzaUserControl1.BringToFront();
        }

        private void HintLeftBurgerButton_Click(object sender, EventArgs e)
        {
          pageOneHamburgerUserControl1.BringToFront();
        }

        private void HintRightBurgerButton_Click(object sender, EventArgs e)
        {
          pageTwoHamburgerUserControl1.BringToFront();
        }

        private void HintLeftSandwichButton_Click(object sender, EventArgs e)
        {
          pageOneSandwichUserControl1.BringToFront();
        }

        private void HintRightSandwichButton_Click(object sender, EventArgs e)
        {
          pageTwoSandwichUserControl1.BringToFront();
        }

        private void pageTwoSandwichUserControl1_LocationChanged(object sender, EventArgs e)
        { 
        }

        private void pageOneSubscriptionUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pageOneSubscriptionUserControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
