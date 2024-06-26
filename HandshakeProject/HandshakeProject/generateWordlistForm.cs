using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandshakeProject
{
    public partial class generateWordlistForm : Form
    {
        public generateWordlistForm()
        {
            InitializeComponent();
        }

        private void generateWordlist_Load(object sender, EventArgs e)
        {

        }

        private void passwordLength_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (passwordLength.Value == 0 || passwordLength.Value == 1 || passwordLength.Value == 2 || passwordLength.Value == 3)
            {
                MessageBox.Show("Password is too Short! \nMinimum length should be 4.");
            }
            else if (passwordLength.Value > 10)
            {
                MessageBox.Show("The password length is not supported by the program... YET :)");
            }

            else
            {

                int nbOfCharactersOfPassword = 8;

                if (passwordLength.Value == 4)
                    nbOfCharactersOfPassword = 4;

                else if (passwordLength.Value == 5)
                    nbOfCharactersOfPassword = 5;

                else if (passwordLength.Value == 6)
                    nbOfCharactersOfPassword = 6;

                else if (passwordLength.Value == 7)
                    nbOfCharactersOfPassword = 7;

                else if (passwordLength.Value == 8)
                    nbOfCharactersOfPassword = 8;

                else if (passwordLength.Value == 9)
                    nbOfCharactersOfPassword = 9;

                else if (passwordLength.Value == 10)
                    nbOfCharactersOfPassword = 10;









                if (numbersCheckbox.Checked && lowercaseCheckbox.Checked == false && uppercaseCheckbox.Checked == false && ponctuationCheckbox.Checked == false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\text files\\Wordlist1.txt");

                    char[] letters = "1234567890".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 8)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }

                if (lowercaseCheckbox.Checked && numbersCheckbox.Checked == false && uppercaseCheckbox.Checked == false && ponctuationCheckbox.Checked == false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist2.txt");

                    char[] letters = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();

                    Random r = new Random();
                    string randomString = "";

                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 25)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }

                if (uppercaseCheckbox.Checked && numbersCheckbox.Checked == false && lowercaseCheckbox.Checked == false && ponctuationCheckbox.Checked == false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist3.txt");

                    char[] letters = "QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 25)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }

                if (ponctuationCheckbox.Checked && numbersCheckbox.Checked == false && lowercaseCheckbox.Checked == false && uppercaseCheckbox.Checked == false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist4.txt");

                    char[] letters = ",./;:'[]~`!@#$%^&*()".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 19)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }


                if (numbersCheckbox.Checked && lowercaseCheckbox.Checked && uppercaseCheckbox.Checked == false && ponctuationCheckbox.Checked == false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist5.txt");

                    char[] letters = "1234567890qwertyuiopasdfghjklzxcvbnm".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 35)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }

                if (numbersCheckbox.Checked && uppercaseCheckbox.Checked && lowercaseCheckbox.Checked == false && ponctuationCheckbox.Checked == false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist6.txt");

                    char[] letters = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 35)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }

                if (numbersCheckbox.Checked && ponctuationCheckbox.Checked && lowercaseCheckbox.Checked == false && uppercaseCheckbox.Checked == false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist7.txt");

                    char[] letters = "1234567890,./;:'[]~`!@#$%^&*()".ToCharArray();

                    Random r = new Random();
                    string randomString = "";

                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 29)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }


                if (lowercaseCheckbox.Checked && uppercaseCheckbox.Checked && numbersCheckbox.Checked == false && ponctuationCheckbox.Checked == false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist8.txt");

                    char[] letters = "qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM".ToCharArray();

                    Random r = new Random();
                    string randomString = "";

                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 51)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }

                if (lowercaseCheckbox.Checked && ponctuationCheckbox.Checked && numbersCheckbox.Checked == false && uppercaseCheckbox.Checked == false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist9.txt");

                    char[] letters = ",./;:'[]~`!@#$%^&*()qwertyuioplkjhgfdsazxcvbnm".ToCharArray();

                    Random r = new Random();
                    string randomString = "";

                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 45)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }

                if (uppercaseCheckbox.Checked && ponctuationCheckbox.Checked && numbersCheckbox.Checked==false && lowercaseCheckbox.Checked==false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist10.txt");

                    char[] letters = ",./;:'[]~`!@#$%^&*()QWERTYUIOPLKJHGFDSAZXCVBNM".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 45)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }

                if (numbersCheckbox.Checked && lowercaseCheckbox.Checked && uppercaseCheckbox.Checked && ponctuationCheckbox.Checked == false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist11.txt");

                    char[] letters = "1234567890qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 61)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }

                if (numbersCheckbox.Checked && lowercaseCheckbox.Checked && ponctuationCheckbox.Checked && uppercaseCheckbox.Checked == false )
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist12.txt");

                    char[] letters = "1234567890qwertyuioplkjhgfdsazxcvbnm,./;:'[]~`!@#$%^&*()".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 55)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }

                

                if (numbersCheckbox.Checked && uppercaseCheckbox.Checked && ponctuationCheckbox.Checked && lowercaseCheckbox.Checked==false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist13.txt");

                    char[] letters = "1234567890QWERTYUIOPLKJHGFDSAZXCVBNM,./;:'[]~`!@#$%^&*()".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 55)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }


                if (lowercaseCheckbox.Checked && uppercaseCheckbox.Checked && ponctuationCheckbox.Checked && numbersCheckbox.Checked==false)
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist14.txt");

                    char[] letters = "qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM,./;:'[]~`!@#$%^&*()".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 71)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }


                if (numbersCheckbox.Checked && lowercaseCheckbox.Checked && uppercaseCheckbox.Checked && ponctuationCheckbox.Checked )
                {

                    TextWriter txt = new StreamWriter("C:\\Users\\96176\\Desktop\\HandshakeProject\\HandshakeProject\\bin\\Debug\\text files\\Wordlist15.txt");

                    char[] letters = "1234567890qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM,./;:'[]~`!@#$%^&*()".ToCharArray();

                    Random r = new Random();
                    string randomString = "";
                    for (int i = 0; i < wordlistLength.Value; i++)
                    {
                        for (int j = 0; j < nbOfCharactersOfPassword; j++)
                        {
                            randomString += letters[r.Next(0, 81)].ToString();
                        }
                        txt.WriteLine(randomString);
                        randomString = "";
                    }

                    MessageBox.Show("Wordlist Created");
                    txt.Close();

                }








            }

        }
    }
}
