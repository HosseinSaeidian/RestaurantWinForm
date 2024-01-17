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

namespace customer_club.UserControlSubscription
{
    public partial class PageOneSubscriptionUserControl : UserControl 
    {
        public PageOneSubscriptionUserControl()
        {
            InitializeComponent();
        }


        #region Create Methods

        /// <summary>
        /// این متد برای تشخیص این است که اون فیلد مورد نظر ما پر است یا خالی
        /// </summary>
        /// <param name="myText"></param>
        /// <returns></returns>
        private bool ErroForTextBoxMethod(TextBox myText)
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


        /// <summary>
        /// این متد برای پیغام به کاربر است در صورت بروز خطا در پر کردن فیلد ها
        /// </summary>
        private void MessageBoxError()
        {
            MessageBox.Show(" ' Please fill in all the fields correctly ' " , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
        }


        /// <summary>
        ///  این متد برای پاک کردن نوشته های داخل تکست باکس ها است درواقع برای بعد از خطا
        /// </summary>
        public void ClearTextBox()
        {
            FirstNameSubTextBox.Text = "";
            LastNameSubTextBox.Text = "";
            PhoneNumberTextbox.Text = "";
            CodeSubTextBox.Text = "";
            CopiedCheckBox.Checked = false;
        }


        #endregion




        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            GetCodeButton.Enabled = false;
            CopiedCheckBox.Checked = false;

            if (((string.IsNullOrEmpty(FirstNameSubTextBox.Text) && (string.IsNullOrEmpty(LastNameSubTextBox.Text) && (string.IsNullOrEmpty(PhoneNumberTextbox.Text))))))
            {
                ClearTextBox();

            }

            CodeSubTextBox.Clear();
            ToolClass.EnableTrueMethod(FirstNameSubTextBox , LastNameSubTextBox);
            PhoneNumberTextbox.Enabled = true;

            if (ErroForTextBoxMethod(FirstNameSubTextBox))
            {
                //MessageBoxError();
                return;
            }

            if (ErroForTextBoxMethod(LastNameSubTextBox))
            {
                //MessageBoxError();
                return;
            }

            if (ErroForTextBoxMethod(PhoneNumberTextbox))
            {
                //MessageBoxError();
                return;
            }

            if (!(ToolClass.TextBoxisNumber(PhoneNumberTextbox)))
            {
                ToolClass.ClearTextBox(PhoneNumberTextbox);
                MessageBox.Show("Please enter only the number without space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!(ToolClass.HowmanyMethod(PhoneNumberTextbox , 11)))
            {
                ToolClass.ClearTextBox(PhoneNumberTextbox);
                MessageBox.Show("Phone number must be '11' digits  without Space" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }

            ToolClass.TextBoxisNumber(PhoneNumberTextbox);



            SqlCommand command = new SqlCommand();
            command.Connection = DataBase.ConnectionMethod();
            command.CommandText = $"select Id from subscription where phoneNumber = @phoneNumber ";
            command.Parameters.AddWithValue("@phoneNumber", PhoneNumberTextbox.Text);
            //command.Parameters.Add( new SqlParameter() { ParameterName = "@phoneNumber", Value = PhoneNumberTextbox.Text });


            SqlDataReader read = command.ExecuteReader();

            if (read.Read() == true)
            {
                MessageBox.Show("An account has been registered with this phone number", "Wrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextBox();
                return;
            }


            DataBase.ExcuteNonQuery($@"insert into subscription 
               values(@firstName , @lastName , @phoneNumber)",
               new SqlParameter() { ParameterName = "@firstName", Value = FirstNameSubTextBox.Text },
               new SqlParameter() { ParameterName = "@lastName", Value = LastNameSubTextBox.Text },
               new SqlParameter() { ParameterName = "@phoneNumber", Value = PhoneNumberTextbox.Text }
               );

            ToolClass.EnableFalseMethod(FirstNameSubTextBox , LastNameSubTextBox);
            ToolClass.EnableFalseMethod(PhoneNumberTextbox , GetCodeButton);
            MessageBox.Show("Your account was created successfully" , "Information" , MessageBoxButtons.OK , MessageBoxIcon.Information);

        }

        private void UserControlSubscription_Load(object sender, EventArgs e)
        {
            ToolClass.EnableFalseMethod(CopiedCheckBox , CopiedLable);
            CodeSubTextBox.Enabled = false;
            
        }

        private void CopyTheCodeButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(CodeSubTextBox.Text)))
            {
                Clipboard.SetText(CodeSubTextBox.Text);
                CopiedCheckBox.Checked = true;
            }

        }


        /// <summary>
        /// این متد برای دادن کد اشتراک به مشتری است
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ToolClass.EnableTFMethod(PhoneNumberTextbox , CreateAccountButton);
            ToolClass.EnableFalseMethod(FirstNameSubTextBox, LastNameSubTextBox);
            FirstNameSubTextBox.Clear();
            LastNameSubTextBox.Clear();

                if (string.IsNullOrEmpty(PhoneNumberTextbox.Text))
                {
                    ErroForTextBoxMethod(PhoneNumberTextbox);
                    return;
                }


            #region Methods

            if (!(string.IsNullOrEmpty(PhoneNumberTextbox.Text)))
            {

                if (!(ToolClass.TextBoxisNumber(PhoneNumberTextbox)))
                {
                    ToolClass.ClearTextBox(PhoneNumberTextbox);
                    MessageBox.Show("Please enter only the number without space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!(ToolClass.HowmanyMethod(PhoneNumberTextbox, 11)))
                {
                    ToolClass.ClearTextBox(PhoneNumberTextbox);
                    MessageBox.Show("Phone number must be '11' digits  without Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }




            }
            #endregion


            SqlCommand command = new SqlCommand();
            command.Connection = DataBase.ConnectionMethod();
            command.CommandText = $@"select Id from subscription where phoneNumber = @phonNumber";
            command.Parameters.Add(new SqlParameter() { ParameterName = "@phonNumber", Value = PhoneNumberTextbox.Text });
            //command.Parameters.AddWithValue("@phoneNumber", PhoneNumberTextbox.Text);

            SqlDataReader readOne = command.ExecuteReader();

            if (readOne.Read() == false)
            {
                MessageBox.Show("This phone number is not registered, please create your account", "Wrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextBox();
                return;
            }
            readOne.Close();


            SqlDataReader read = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            DataGrideSubscription.DataSource = table;
            CodeSubTextBox.Text = DataGrideSubscription.Rows[0].Cells[0].FormattedValue.ToString();

            //.......... اطلاعات از دیتا بیس خوانده میشود و در گرید ویو نیز دیده میشود
            //.......... تنها کاری که باید کرد این است که مقداری که در گرید ویو است را در تکست بتویسیم
            
            
            

        }


        /// <summary>
        /// این متد برای ری استارت کردن این پارت است
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Are you sure you want to restart this part ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ToolClass.EnableFalseMethod(FirstNameSubTextBox , LastNameSubTextBox);
                ToolClass.EnableTFMethod(GetCodeButton, PhoneNumberTextbox);
                CreateAccountButton.Enabled = true;
                ClearTextBox();
            }

        }
    }
}
