using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Rayan
{
    public static class ToolClass
    {
        public static void HintHomeMethod(Panel hintbutton, Button myButton)
        {
            hintbutton.Height = myButton.Height;
            hintbutton.Top = myButton.Top;
        }

        public static void ClearTextBox(TextBox myText1)
        { 
            myText1.Text = "";
        }
        public static void ClearTextBox(TextBox myText1, TextBox myText2)
        {
            myText1.Text = "";
            myText2.Text = "";
        }
        public static void ClearTextBox(TextBox myText1 , TextBox myText2 , TextBox myText3)
        {
            myText1.Text = "";
            myText2.Text = "";
            myText3.Text = "";
        }

        #region Methodes for Visibel and Enable

        //..... this methods for visible ......

        public static void VisibleTrueMethod(Control myTrue1, Control myTrue2)
        {
            myTrue1.Visible = true;
            myTrue2.Visible = true;
        }

        public static void VisibleFalseMethod(Control myFalse1, Control myFalse2)
        {
            myFalse1.Visible = false;
            myFalse2.Visible = false;
        }

        public static void VisibleTFMethod(Control myTrue, Control myFalse)
        {
            myTrue.Visible = true;
            myFalse.Visible = false;
        }


        // ....... this methods for Enable

        public static void EnableTrueMethod(Control myTrue1, Control myTrue2)
        {
            myTrue1.Enabled = true;
            myTrue2.Enabled = true;
        }

        public static void EnableFalseMethod(Control myFalse1, Control myFalse2)
        {
            myFalse1.Enabled = false;
            myFalse2.Enabled = false;
        }

        public static void EnableTFMethod(Control myTrue, Control myFalse)
        {
            myTrue.Enabled = true;
            myFalse.Enabled = false;

        }


        public static void CheckedTrue(CheckBox myTrue1 , CheckBox myTrue2)
        {
            myTrue1.Checked = true;
            myTrue2.Checked = true;
        }


        public static void CheckedFalse(CheckBox myFalse1  , CheckBox myFalse2)
        {
            myFalse2.Checked = false;
            myFalse1.Checked = false;
        }


        #endregion

        #region Methods General


        /// <summary>
        /// این متد برای تشخیص این که استرینگ وارد شده به تکست باکس ، عدد هست یا خیر
        /// </summary>
        /// <param name="myText"></param>
        /// <returns></returns>
        public static bool TextBoxisNumber(TextBox myText)
        {
            long number;
            string text = myText.Text;
            bool result = long.TryParse(text, out number);
            
            if (result == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="myText"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool HowmanyMethod(TextBox myText , int number)
        {
            string text = myText.Text.Trim();


            if ((text.Length == number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public static bool YoungerAndAgins(TextBox myText1 , TextBox myText2)
        {
            int numberOne, numberTwo , numberThree;
            string textOne, textTwo;

            textOne = myText1.Text;
            textTwo = myText2.Text;

            
            int.TryParse(textOne , out numberOne);
            int.TryParse(textTwo , out numberTwo);

            numberThree = numberTwo - 2;

            if (numberOne == numberThree)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool WithoutZero(TextBox text)
        {
            if (text.Text.StartsWith("0"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion

        #region Methods for Page Sub . . .

        public static void ClearTextBox()
        { 
            
        
        
        
        }


        #endregion

    }
}
