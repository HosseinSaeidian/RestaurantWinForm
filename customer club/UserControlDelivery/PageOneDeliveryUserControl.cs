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

namespace customer_club.UserControlDelivery
{
    public partial class PageOneDeliveryUserControl : UserControl
    {
        #region Create Methods

        /// <summary>
        /// این متد برای این است که اگه فیلدمان خالی بود یه ارور کوچک به کاربر بدهد
        /// </summary>
        /// <param name="myText"></param>
        /// <returns></returns>
        private bool ErroForTextBoxMethod(Control myText)
        {
            if (string.IsNullOrEmpty(myText.Text))
            {
                ErrorForTextBox.SetError(myText, "This form cannot be empty");
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion



        public PageOneDeliveryUserControl()
        {
            InitializeComponent();
        }


        private void PageOneDeliveryUserControl_Load(object sender, EventArgs e)
        {
            ToolClass.EnableFalseMethod(RFLable , ConfirmedCheckBox);
            ToolClass.EnableFalseMethod(TimeDeliveryCombo , TimeDeliveryCheckBox);
            ToolClass.VisibleFalseMethod(TimeOfLable, AnotherTimeTextBox);
            ToolClass.CheckedFalse(ConfirmedCheckBox, TimeDeliveryCheckBox);
            ToolClass.VisibleTFMethod(TimeDeliveryCombo, AnotherTimeTextBox);
            ToolClass.VisibleFalseMethod(AnotherTimeTextBox, AnotherTimeTwoTextBox);
            ToolClass.VisibleFalseMethod(Lable1, Lable2);
            ToolClass.VisibleFalseMethod(label3, label4);
            ToolClass.VisibleFalseMethod(label5, label66);
            ToolClass.EnableFalseMethod(AnotherTimeTextBox , AnotherTimeTwoTextBox);
            label7.Visible = false;
            TimeDeliveryCombo.Visible = true;
        }


        private void ConfirmCodeButton_Click(object sender, EventArgs e)
        {

            if (ErroForTextBoxMethod(ConfirmCodeDeliveryTextBox))
                return;

            if (!(ToolClass.TextBoxisNumber(ConfirmCodeDeliveryTextBox)))
            {
                MessageBox.Show("Please enter only the number without space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConfirmCodeDeliveryTextBox.Clear();
                return;
            }

            if (ToolClass.WithoutZero(ConfirmCodeDeliveryTextBox))
            {
                MessageBox.Show("Write your own card without the first zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConfirmCodeDeliveryTextBox.Clear();
                return;
            }



            SqlDataReader read = (DataBase.CommandMethodThree("select *from subscription where Id = @Id ", "@Id", ConfirmCodeDeliveryTextBox.Text)).ExecuteReader();

            if (read.Read() == false)
            {
                MessageBox.Show("This subscription code does not exist", "Warning" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
                ConfirmCodeDeliveryTextBox.Clear();
                return;
            }

                ToolClass.EnableFalseMethod(ConfirmCodeButton, ConfirmedCheckBox);
                ToolClass.EnableTFMethod(TimeDeliveryCombo, ConfirmCodeDeliveryTextBox);
                ToolClass.EnableTrueMethod(TimeDeliveryCheckBox, AnotherTimeTextBox);
                ConfirmedCheckBox.Checked = true;
            

        }

        private void TimeDeliveryButton_Click(object sender, EventArgs e)
        {
            ToolClass.VisibleTFMethod(AnotherTimeTextBox , TimeDeliveryCombo);
        }



        private void ClickHereButton_Click_1(object sender, EventArgs e)
        {
                if ( !(string.IsNullOrEmpty(AnotherTimeTwoTextBox.Text)) && !(string.IsNullOrEmpty(AnotherTimeTwoTextBox.Text)))
                {

                if (!(ToolClass.TextBoxisNumber(AnotherTimeTextBox) && ToolClass.TextBoxisNumber(AnotherTimeTwoTextBox)))
                {
                
                      ToolClass.ClearTextBox(AnotherTimeTextBox, AnotherTimeTwoTextBox);
                      MessageBox.Show("Please just enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      return;
                }

                     if (!(ToolClass.HowmanyMethod(AnotherTimeTextBox , 1) && ToolClass.HowmanyMethod(AnotherTimeTwoTextBox , 1)))
                     {
                        ToolClass.ClearTextBox(AnotherTimeTextBox, AnotherTimeTwoTextBox);
                        MessageBox.Show("Time must be ' 1 ' digits  without Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                     }


                if (!(ToolClass.YoungerAndAgins(AnotherTimeTextBox , AnotherTimeTwoTextBox)))
                {
                        ToolClass.ClearTextBox(AnotherTimeTextBox, AnotherTimeTwoTextBox);
                        MessageBox.Show("The time difference should be two hours", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                }


            if (TimeDeliveryCheckBox.Checked == true)
            {

                if ((string.IsNullOrEmpty(AnotherTimeTwoTextBox.Text)) || (string.IsNullOrEmpty(AnotherTimeTwoTextBox.Text)))
                {
                    MessageBox.Show(" ' Please fill in all the fields correctly ' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else
            {
                if (ErroForTextBoxMethod(TimeDeliveryCombo))
                {
                    MessageBox.Show(" ' Please fill in all the fields correctly ' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            if ((string.IsNullOrEmpty(AnotherTimeTextBox.Text)) || string.IsNullOrEmpty(AnotherTimeTwoTextBox.Text))
            {
              if ( ! (TimeDeliveryCombo.SelectedIndex == 1 || TimeDeliveryCombo.SelectedIndex == 2 ||TimeDeliveryCombo.SelectedIndex == 3 || TimeDeliveryCombo.SelectedIndex == 4))
              {
                  MessageBox.Show("Choose from ready times Or click the option \" I write myself \" ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  TimeDeliveryCombo.SelectedIndex = 0;
                  return;
              }
            }

            ToolClass.EnableTFMethod(EditeConfirmButton, TimeDeliveryCombo);
            ToolClass.EnableFalseMethod(AnotherTimeTwoTextBox , AnotherTimeTextBox);
            ToolClass.EnableFalseMethod(TimeDeliveryCheckBox, TimeOfLable);
            TimeDeliveryCombo.Enabled = false;
            MessageBox.Show("Your request has been successfully submitted" , "Information" , MessageBoxButtons.OK , MessageBoxIcon.Information);
        }


        private void TimeDeliveryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeDeliveryCheckBox.Checked == true)
            {
                ToolClass.VisibleTFMethod(AnotherTimeTextBox, TimeDeliveryCombo);
                ToolClass.EnableFalseMethod(TimeDeliveryCombo ,TimeOfLable);
                ToolClass.VisibleTrueMethod(AnotherTimeTextBox , AnotherTimeTwoTextBox);
                ToolClass.VisibleTrueMethod(Lable1 , Lable2);
                ToolClass.VisibleTrueMethod(label3, label4);
                ToolClass.VisibleTrueMethod(label5 , label66);
                ToolClass.VisibleTrueMethod(label7 , TimeOfLable);
                AnotherTimeTwoTextBox.Enabled = true;
                TimeDeliveryCombo.SelectedIndex = 0;

            }

            if (TimeDeliveryCheckBox.Checked == false)
            {
                ToolClass.ClearTextBox(AnotherTimeTextBox, AnotherTimeTwoTextBox);
                ToolClass.VisibleTFMethod(TimeDeliveryCombo, AnotherTimeTextBox);
                ToolClass.VisibleFalseMethod(AnotherTimeTextBox , AnotherTimeTwoTextBox);
                ToolClass.VisibleFalseMethod(Lable1, Lable2);
                ToolClass.VisibleFalseMethod(label3 , label4);
                ToolClass.VisibleFalseMethod(label5 , label66);
                ToolClass.VisibleFalseMethod(label7 , TimeOfLable);
                TimeDeliveryCombo.Enabled = true;
            }

        }

        private void ConfirmCodeDeliveryTextBox_TextChanged(object sender, EventArgs e)
        { 

        }

        private void EditeConfirmButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure about the edit" , "Warning" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes ))
            {
                TimeDeliveryCombo.SelectedIndex = 0;
                ConfirmCodeDeliveryTextBox.Clear();
                ToolClass.EnableFalseMethod(TimeDeliveryCombo, TimeDeliveryCheckBox);
                ToolClass.ClearTextBox(AnotherTimeTwoTextBox, AnotherTimeTextBox);
                ToolClass.EnableTrueMethod(ConfirmCodeDeliveryTextBox, ConfirmCodeButton);
                ToolClass.VisibleFalseMethod(AnotherTimeTextBox, TimeOfLable);
                ToolClass.CheckedFalse(TimeDeliveryCheckBox, ConfirmedCheckBox);
                TimeDeliveryCombo.Enabled = false;
            }
            else
            {
                AnotherTimeTextBox.Clear();
                AnotherTimeTwoTextBox.Clear();
                TimeDeliveryCombo.SelectedIndex = 0;
                ToolClass.EnableFalseMethod(TimeDeliveryCombo , TimeDeliveryCheckBox);
                ToolClass.EnableFalseMethod(AnotherTimeTextBox , AnotherTimeTwoTextBox);
                return;
            }

            if (ErroForTextBoxMethod(ConfirmCodeDeliveryTextBox))
                return;
            if (ErroForTextBoxMethod(ConfirmCodeDeliveryTextBox))
                return;
            
            if (ToolClass.TextBoxisNumber(ConfirmCodeDeliveryTextBox))
            {
                MessageBox.Show("Please just enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConfirmCodeDeliveryTextBox.Text = "";
                return;
            }
            else
            {
                ToolClass.EnableFalseMethod(ConfirmCodeButton, ConfirmedCheckBox);
                ToolClass.EnableTFMethod(TimeDeliveryCombo, ConfirmCodeDeliveryTextBox);
                ConfirmedCheckBox.Checked = true;
                TimeDeliveryCheckBox.Enabled = true;
            }
        }
    }
}
