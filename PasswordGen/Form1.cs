using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGen
{
    public partial class PG : Form
    {
        //Strings are arrays of characters e.g. ULetters[3] = D
        string Uletters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string LLetters = "abcdefghijklmnopqrstuvwxyz";
        string nums = "0123456789";
        string special = "!£$%^&*()_+-=<>,.?{}[]:;@'~#";
        
        //These boolean values determine the rules for password generation
        bool upper;
        bool useLetters = true;
        bool useNums;
        bool useSpecial;

        
        //A slider can be used to set the required password length
        int passwordLength = 10;

        public PG()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This is for special actions when the form is loaded. Currently the form is quite static so has no initial code required.
        }

        private void GeneratePassword() 
        {
            string newPassword = "";

            //As we a generating a password, we need to randomise the chosen characters
            Random R = new Random();

            //A loop that will add characters until the integer value 'passwordLength' has been reached
            while (newPassword.Length < passwordLength) 
            {
                int x = R.Next(4);
                int y;

                //Above we create a random value between 0 and 4, this is for the options in the switch
                //For each generated character, it will randomly choose different character types
                switch (x)
                {
                    case 0:
                        if (upper) 
                        {
                            y = R.Next(Uletters.Length);
                            newPassword += Uletters[y];
                        }
                        break;
                    case 1:
                        if (useLetters) 
                        {
                            y = R.Next(LLetters.Length);
                            newPassword += LLetters[y];
                        }
                        break;
                    case 2:
                        if (useNums) 
                        {
                            y = R.Next(nums.Length);
                            newPassword += nums[y];
                        }
                       
                        break;
                    case 3:
                        if (useSpecial) 
                        {
                            y = R.Next(special.Length);
                            newPassword += special[y];
                        }
                        break;
                    default:
                        newPassword += "x";
                        break;
                }
                
            }
            //Once the password has been generated, display in the textbox
            passwordBox.Text = newPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //The generate password button gets all of the currently checked options, then generates a password
            upper = upperCheck.Checked;
            useNums = numCheck.Checked;
            useSpecial = specialCheck.Checked;
            passwordLength = LengthBar.Value;
            GeneratePassword();
        }

        private void LengthBar_Scroll(object sender, EventArgs e)
        {
            //The passwordLength value is set based on this lengthbar value.
            passWordLengthLabel.Text = LengthBar.Value.ToString();
        }

        
    }
}
