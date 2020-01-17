using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaihatsuEnshuu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '●';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "mainform" && passwordTextBox.Text == "password")
            {
                MainForm mainmenu = new MainForm();
                mainmenu.FormClosing += new FormClosingEventHandler(this.Form_FormClosing);
                mainmenu.Show();
                this.Hide();

                
            }

            if (usernameTextBox.Text == "administrator" && passwordTextBox.Text == "password")
            {
                AdministratorForm mainmenu = new AdministratorForm();
                mainmenu.FormClosing += new FormClosingEventHandler(this.Form_FormClosing);
                mainmenu.Show();
                this.Hide();
            }

            if (usernameTextBox.Text == "order" && passwordTextBox.Text == "password" )
            {
                NewOrderForm newOrderForm = new NewOrderForm();
                newOrderForm.FormClosing += new FormClosingEventHandler(this.Form_FormClosing);
                newOrderForm.Show();
                this.Hide();
            }

            if(usernameTextBox.Text == "stock" )
            {
                StockForm stockform = new StockForm();
                stockform.FormClosing += new FormClosingEventHandler(this.Form_FormClosing);
                stockform.Show();
                this.Hide();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();


        }



        private void Form_FormClosing(object sender, FormClosingEventArgs e)//this is what it does
        {

            //check if form closed and if then executes this code

            try
            {
                this.Show();
                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ProductError");

            }

        }

    }

}
