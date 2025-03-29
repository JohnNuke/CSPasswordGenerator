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
        string Uletters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string LLetters = "abcdefghijklmnopqrstuvwxyz";
        string nums = "0123456789";
        string special = "!£$%^&*()_+-=<>,.?{}[]:;@'~#";
        
        bool upper;
        bool useLetters = true;
        bool useNums;
        bool useSpecial;

        int passwordLength = 10;

        public PG()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GeneratePassword() 
        {
            string newPassword = "";
            Random R = new Random();
            
            while (newPassword.Length < passwordLength) 
            {
                int x = R.Next(4);
                int y;
                
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
            passwordBox.Text = newPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            upper = upperCheck.Checked;
            useNums = numCheck.Checked;
            useSpecial = specialCheck.Checked;
            passwordLength = LengthBar.Value;
            GeneratePassword();
        }

        private void LengthBar_Scroll(object sender, EventArgs e)
        {
            passWordLengthLabel.Text = LengthBar.Value.ToString();
        }

        
    }
}
