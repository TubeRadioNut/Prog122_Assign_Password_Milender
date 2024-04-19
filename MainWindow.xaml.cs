//Charles Milender
//4-18-2024
//Programming 122
//Assignment Password Login Form
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_Assign_Password_Milender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //create string variables for user input
        public string userName;
        public string password;
        public MainWindow()
        {
            InitializeComponent();//<---Don't delete this
            
        }//end of MainWindow

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            //create variables for login user input from text boxes
            string logInUserName = txtUserName.Text;
            string logInPassword = txtPassWord.Text;
            //test user input with if, elseif, else, first check username and password have been created, then check username and
            //password match stored username and password
            if(userName == null && password == null)
            {
                //inform user that username and password are not set
                MessageBox.Show("Username and password not set");
                //log user input
                rtbDisplay.Text += "Sign In Attempt: Username and/or password not set \n";

            }
            else if(logInUserName == userName && logInPassword == password)
            {
                //inform user of successful login
                MessageBox.Show($"Login Successful");
                //log user input
                rtbDisplay.Text += $"Login Successful - Username: {logInUserName}, Password: {logInPassword}\n";
                //clear text box fields
                txtUserName.Text = "";
                txtPassWord.Text = "";
                
            }
            //only runs if username and password don't match stored username and password
            //inform user of invalid username or password
            else
            {
                //inform user of invalid username or password
                MessageBox.Show("Invalid username or password");
                //log user input
                rtbDisplay.Text += $"Sign In Attempt: Invalid username or password - Username: {logInUserName}, Password: {logInPassword}\n";
            }
            

        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            //assign variables to user input from text boxes
            userName = txtUserName.Text;
            password = txtPassWord.Text;
            //test user input with if, else if, else, first test for empty fields
            if (userName.Length <= 0 || password.Length <= 0  )
            {
                //inform user to input valid user name and password
                MessageBox.Show("Please enter a valid user name and password");
                //log user input
                rtbDisplay.Text += $"Sign up Attempt: Empty fields - Username:{userName} , Password:{password} \n";
                //set userName and password variables to null
                userName = null;
                password = null;
            }
            //test user input for password: make sure it is at lest 8 charaters
            else if (password.Length < 8)
            {
                //inform user password must be 8 charaters minimun
                MessageBox.Show("The Password must be 8 charaters minimum");
                //log user input
                rtbDisplay.Text += $"Sign Up Attempt: Password too short - Username: {userName}, Password: {password} \n";
                //set userName and password variables to null
                userName = null;
                password = null;
            }
            //inform user of successful creation of username and password
            else
            {
                //inform user of successful sign up
                MessageBox.Show("Sign Up Successful");
                //log user input
                rtbDisplay.Text += $"Sign Up Successful - Username: {userName}, Password: {password} \n";
            }
            //clear text box fields
            txtUserName.Text = "";
            txtPassWord.Text = "";
        }
    }//end of class

}//end of namespace