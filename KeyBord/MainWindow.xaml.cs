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
using System.Windows.Threading;

namespace KeyBord
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool flagCapsLock = true;
        bool flagBackspase = true;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void CapitalLetters()
        {
            this.LetterY.Content = "Ё";
            this.Q.Content = "Й";
            this.W.Content = "Ц";
            this.E.Content = "У";
            this.R.Content = "К";
            this.T.Content = "Е";
            this.Y.Content = "Н";
            this.U.Content = "Г";
            this.I.Content = "Ш";
            this.O.Content = "Щ";
            this.P.Content = "З";
            this.A.Content = "Ф";
            this.S.Content = "Ы";
            this.D.Content = "В";
            this.F.Content = "А";
            this.G.Content = "П";
            this.H.Content = "Р";
            this.J.Content = "О";
            this.K.Content = "Л";
            this.L.Content = "Д";
            this.Z.Content = "Я";
            this.X.Content = "Ч";
            this.C.Content = "С";
            this.V.Content = "М";
            this.B.Content = "И";
            this.N.Content = "Т";
            this.M.Content = "Ь";
            this.OpenBrackets.Content = "Х";
            this.CloseBrackets.Content = "Ъ";
            this.Semicolon.Content = "Ж";
            this.Apostrophe.Content = "Э";
            this.Comma.Content = "Б";
            this.Dot.Content = "Ю";

        }
        private void LoverLetters()
        {
            this.LetterY.Content = "ё";
            this.Q.Content = "й";
            this.W.Content = "ц";
            this.E.Content = "у";
            this.R.Content = "к";
            this.T.Content = "е";
            this.Y.Content = "н";
            this.U.Content = "г";
            this.I.Content = "ш";
            this.O.Content = "щ";
            this.P.Content = "з";
            this.A.Content = "ф";
            this.S.Content = "ы";
            this.D.Content = "в";
            this.F.Content = "а";
            this.G.Content = "п";
            this.H.Content = "р";
            this.J.Content = "о";
            this.K.Content = "л";
            this.L.Content = "д";
            this.Z.Content = "я";
            this.X.Content = "ч";
            this.C.Content = "с";
            this.V.Content = "м";
            this.B.Content = "и";
            this.N.Content = "т";
            this.M.Content = "ь";
            this.OpenBrackets.Content = "х";
            this.CloseBrackets.Content = "ъ";
            this.Semicolon.Content = "ж";
            this.Apostrophe.Content = "э";
            this.Comma.Content = "б";
            this.Dot.Content = "ю";
        }
        private void CapitalSymbol()
        {

            this.D1.Content = "!";
            this.D2.Content = "\"";
            this.D3.Content = "№";
            this.D4.Content = ";";
            this.D5.Content = "%";
            this.D6.Content = ":";
            this.D7.Content = "?";
            this.D8.Content = "*";
            this.D9.Content = "(";
            this.D0.Content = ")";
            this.Minus.Content = "_";
            this.Plus.Content = "+";
            this.Backslash.Content = "/";
            this.Slash.Content = ",";
        }
        private void LoverSymbol()
        {

            this.D1.Content = "1";
            this.D2.Content = "2";
            this.D3.Content = "3";
            this.D4.Content = "4";
            this.D5.Content = "5";
            this.D6.Content = "6";
            this.D7.Content = "7";
            this.D8.Content = "8";
            this.D9.Content = "9";
            this.D0.Content = "0";
            this.Minus.Content = "-";
            this.Plus.Content = "=";
            this.Backslash.Content = "\\";
            this.Slash.Content = ".";
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (UIElement it in (this.Content as Grid).Children)
            {
                if (it is Grid)
                {
                    foreach (var item in (it as Grid).Children)
                    {
                        if (item is Button)
                        {
                            if ((item as Button).Name == e.Key.ToString())
                            {
                                (item as Button).Opacity = 0.5;
                                if (e.Key.ToString() == "LeftShift" || e.Key.ToString() == "RightShift")
                                {
                                    CapitalSymbol();
                                    if (flagCapsLock)
                                    {
                                        CapitalLetters();
                                    }
                                    else
                                    {
                                        LoverLetters();
                                    }
                                }
                                else if (e.Key.ToString() == "Capital")
                                {
                                    if (flagCapsLock)
                                    {
                                        CapitalLetters();
                                        flagCapsLock = false;
                                    }
                                    else
                                    {
                                        LoverLetters();
                                        flagCapsLock = true;
                                    }
                                }
                                else if (e.Key.ToString() == "Back")
                                {
                                    flagBackspase = false;
                                }
                                else
                                {
                                    flagBackspase = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void Form_PreviewKeyUp(object sender, KeyEventArgs e)
        {

            foreach (UIElement it in (this.Content as Grid).Children)
            {
                if (it is Grid)
                {
                    foreach (var item in (it as Grid).Children)
                    {
                        if (item is Button)
                        {

                            if ((item as Button).Name == e.Key.ToString())
                            {
                                (item as Button).Opacity = 1;
                                if (e.Key.ToString() == "LeftShift" || e.Key.ToString() == "RightShift")
                                {
                                    LoverSymbol();
                                    if (!flagCapsLock)
                                    {
                                        CapitalLetters();
                                    }
                                    else
                                    {
                                        LoverLetters();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void InputText_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            InputText.Text = "";
        }
    }
}