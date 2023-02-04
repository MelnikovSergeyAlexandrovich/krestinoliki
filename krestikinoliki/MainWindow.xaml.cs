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

namespace krestikinoliki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static List<Button> buttons;
        static int krest_or_nolik = 0;
        public MainWindow()
        {
          
            InitializeComponent();
            buttons = new List<Button>() { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
        }
        
        private void Click_for_start(object sender, RoutedEventArgs e)
        {
            textik.Text = "крестики-нолики)";
            krest_or_nolik++;
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].IsEnabled = true;
                buttons[i].Content = " ";
            }
        }
        private void end_of_game()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].IsEnabled = false;
            }
            
        }
        private void button_rnd()
        {
            
            Random robot = new Random();
            int button_rnd = robot.Next(0, 8);
            for (int i = 0; i < buttons.Count; i++)
            {
                    if (krest_or_nolik % 2 == 0)
                    {
                        if ((buttons[i].IsEnabled == false) && (buttons[button_rnd].IsEnabled == true))
                        {
                            buttons[button_rnd].Content = "O";
                            buttons[button_rnd].IsEnabled = false;

                        }
                    }
                    else if (krest_or_nolik % 2 == 1)
                    {
                        if ((buttons[i].IsEnabled == false) && (buttons[button_rnd].IsEnabled == true))
                        {
                            buttons[button_rnd].Content = "X";
                            buttons[button_rnd].IsEnabled = false;
                        }                      
                    }
                proverka(b1, b2, b3);
                proverka(b4, b5, b6);
                proverka(b7, b8, b9);
                proverka(b1, b4, b7);
                proverka(b2, b5, b8);
                proverka(b3, b6, b9);
                proverka(b1, b5, b9);
                proverka(b3, b5, b7);
            }
        }
        private void proverka(Button bu1,Button bu2,Button bu3)
        {       
            for (int i = 0; i < buttons.Count; i++)
            {
                if (((bu1.Content == "X") && (krest_or_nolik % 2 == 0)) || ((bu1.Content == "O") && (krest_or_nolik % 2 == 1)))
                {
                    if ((bu1.Content == bu2.Content) && (bu2.Content == bu3.Content)) 
                    {
                        if (buttons[i].IsEnabled != true)
                        {
                            textik.Text = "Вы победили";
                            end_of_game();
                        }
                    }
                }
                else if (((bu1.Content == "X") && (krest_or_nolik % 2 == 1)) || ((bu1.Content == "O") && (krest_or_nolik % 2 == 0)))
                {
                    if ((bu1.Content == bu2.Content) && (bu2.Content == bu3.Content)) 
                    {
                        if (buttons[i].IsEnabled != true)
                        {
                            textik.Text = "Вы Проиграли";
                            end_of_game();
                        }
                    }
                }
            }
        }
        private void button_func(Button button)
        {
            if (krest_or_nolik % 2 == 0)
            {
                button.Content = "X";
                button.IsEnabled = false;
                button_rnd();
            }
            else
            {
                button.Content = "O";
                button.IsEnabled = false;
                button_rnd();
            }
        }
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            button_func(b1);
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            button_func(b2);
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            button_func(b3);
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            button_func(b4);
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            button_func(b5);
        }
                                                                
        private void b6_Click(object sender, RoutedEventArgs e)
        {
            button_func(b6);
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            button_func(b7);
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            button_func(b8);
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            button_func(b9);

        }

    }
}
