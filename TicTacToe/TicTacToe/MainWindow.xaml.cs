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

namespace TicTacToe
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Spieler = 1;
        Label label; //Deklariert neues Objekt aus der Klasse Label

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Spielzug(object sender, MouseButtonEventArgs e)//jeder Label hat dieses Ereignis
        {
          
            label = (Label)sender;//weist dem label das Ereignis sender zu
           // label= sender as Label;

            if (label.Content.ToString() == "")
            {
     
                if (Spieler == 1)
                {
                    label.Content="X";
                    Spieler = 2;
                }
                else
	            {
                    label.Content="O";//großes O und nicht Null!!!
                    Spieler = 1;
	            }
	        }
            if (Box11.Content.ToString() == "X" && Box12.Content.ToString() == "X" && Box13.Content.ToString() == "X" ||
                Box21.Content.ToString() == "X" && Box22.Content.ToString() == "X" && Box23.Content.ToString() == "X" ||
                Box31.Content.ToString() == "X" && Box32.Content.ToString() == "X" && Box33.Content.ToString() == "X" ||
                Box11.Content.ToString() == "X" && Box21.Content.ToString() == "X" && Box31.Content.ToString() == "X" ||
                Box12.Content.ToString() == "X" && Box22.Content.ToString() == "X" && Box32.Content.ToString() == "X" ||
                Box13.Content.ToString() == "X" && Box23.Content.ToString() == "X" && Box33.Content.ToString() == "X" ||
                Box11.Content.ToString() == "X" && Box22.Content.ToString() == "X" && Box33.Content.ToString() == "X" ||
                Box13.Content.ToString() == "X" && Box22.Content.ToString() == "X" && Box31.Content.ToString() == "X") 
            {
                MessageBox.Show("GEWINNER Spieler 1");
                Box11.Content = "";
                Box12.Content = "";
                Box13.Content = "";
                Box21.Content = "";
                Box22.Content = "";
                Box23.Content = "";
                Box31.Content = "";
                Box32.Content = "";
                Box33.Content = "";
            }

            if (Box11.Content.ToString() == "O" && Box12.Content.ToString() == "O" && Box13.Content.ToString() == "O" ||
                Box21.Content.ToString() == "O" && Box22.Content.ToString() == "O" && Box23.Content.ToString() == "O" ||
                Box31.Content.ToString() == "O" && Box32.Content.ToString() == "O" && Box33.Content.ToString() == "O" ||
                Box11.Content.ToString() == "O" && Box21.Content.ToString() == "O" && Box31.Content.ToString() == "O" ||
                Box12.Content.ToString() == "O" && Box22.Content.ToString() == "O" && Box32.Content.ToString() == "O" ||
                Box13.Content.ToString() == "O" && Box23.Content.ToString() == "O" && Box33.Content.ToString() == "O" ||
                Box11.Content.ToString() == "O" && Box22.Content.ToString() == "O" && Box33.Content.ToString() == "O" ||
                Box13.Content.ToString() == "O" && Box22.Content.ToString() == "O" && Box31.Content.ToString() == "O")
            {
                MessageBox.Show("GEWINNER Spieler 2");
                Box11.Content = "";
                Box12.Content = "";
                Box13.Content = "";
                Box21.Content = "";
                Box22.Content = "";
                Box23.Content = "";
                Box31.Content = "";
                Box32.Content = "";
                Box33.Content = "";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Box11.Content = "";
            Box12.Content = "";
            Box13.Content = "";
            Box21.Content = "";
            Box22.Content = "";
            Box23.Content = "";
            Box31.Content = "";
            Box32.Content = "";
            Box33.Content = "";
        }
    }
}
