using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int finalCalcualtion;
        int opIndex;
        int result;
        string opValue;
        List<String> calArray = new List<String>();
        string firstNum;
        string secondNum;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string butSend = (string)((Button)sender).Content;

            if (butSend != "=" && butSend != "C") {

                calArray.Add(butSend);
                Screen.Text += $"{butSend}";

            } else
            {
                if (butSend != "C")
                {
                    if (calArray.IndexOf("*") != -1)
                    {
                        opIndex = calArray.IndexOf("*");
                        opValue = "*";
                    }
                    if (calArray.IndexOf("+") != -1)
                    {
                        opIndex = calArray.IndexOf("+");
                        opValue = "+";
                    }
                    if (calArray.IndexOf("-") != -1)
                    {
                        opIndex = calArray.IndexOf("-");
                        opValue = "-";
                    }
                    if (calArray.IndexOf("/") != -1)
                    {
                        opIndex = calArray.IndexOf("/");
                        opValue = "/";
                    }

                    for (int i = 0; i < opIndex; i++)
                    {
                        firstNum += calArray[i];

                    }
                    for (int i = opIndex + 1; i < (calArray.Count); i++)
                    {
                        secondNum += calArray[i];

                    }
                    Screen.Text = firstNum;
                    Screen.Text += secondNum;
                    long firstNumInt = Int64.Parse(firstNum);
                    long secondNumInt = Int64.Parse(secondNum);
                    calArray.Clear();

                    switch (opValue)
                    {
                        case "*":
                            Screen.Text = (firstNumInt * secondNumInt).ToString();
                            break;
                        case "+":
                            Screen.Text = (firstNumInt + secondNumInt).ToString();
                            break;
                        case "-":
                            Screen.Text = (firstNumInt - secondNumInt).ToString();
                            break;
                        case "/":
                            Screen.Text = (firstNumInt / secondNumInt).ToString();
                            break;

                    }
                }
                else
                {
                    calArray.Clear();
                    Screen.Text = "";
                }
            }
                //Screen.Text = opIndex.ToString();
                //Screen.Text = finalCalcualtion.ToString();
            }

        }
}

