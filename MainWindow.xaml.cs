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
using System.Diagnostics;



namespace Lennifier_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // declare the sets. No more than 9.
        string[] Common = new string[] 
        {

            @"( ͡° ͜ʖ ͡°)",
            @"ヽ༼ຈل͜ຈ༽ﾉ",
            @"¯\__(ツ)__/¯",
            @"(☞ﾟヮﾟ)☞",
            @"ಠ__ಠ",
            @"ʕ•ᴥ•ʔ",
            @"(╯°□°）╯︵ ┻━┻",
            @"(ง ͠° ͟ل͜ ͡°)ง",
            @"ᕕ(ᐛ)ᕗ"

        };

        // declare the sets. No more than 9.
        string[] Lenny = new string[] 
        {

            @"( ͡° ͜ʖ ͡°)",
            @"ᕦ( ͡° ͜ʖ ͡°)ᕤ",
            @"ʕ ͡° ͜ʖ ͡°ʔ",
            @"( ͡o ͜ʖ ͡o)",
            @"(ง ͠° ͟ل͜ ͡°)ง",
            @"( ͡~ ͜ʖ ͡°)",
            @"[̲̅$̲̅(̲̅ ͡° ͜ʖ ͡°̲̅)̲̅$̲̅]",
            @"(ง ͡° ͜ʖ ͡°)=/̵͇̿̿/'̿'̿̿̿ ̿ ̿̿",
            @"/\/( ͡°͡° ͜ʖ ͡°͡°)\/\"

        };

        IDictionary<string, string[]> faceSets = new Dictionary<string, string[]>();
        string currentSet = null;

        public MainWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            Debug.WriteLine("Program loaded.");

            // add new face sets to list
            faceSets.Add("Lenny", Lenny);
            faceSets.Add("Common", Common);

            // load the requested face set.
            loadFaces("Common");
            //frame.Title += currentSet; // for another time


        }

        private void loadFaces(String set)
        {

            if (faceSets.ContainsKey(set))
            {


                currentSet = set;

                // load up the faces
                b1.Content = b1.ToolTip = faceSets[set][0];
                b2.Content = b2.ToolTip = faceSets[set][1];
                b3.Content = b3.ToolTip = faceSets[set][2];
                b4.Content = b4.ToolTip = faceSets[set][3];
                b5.Content = b5.ToolTip = faceSets[set][4];
                b6.Content = b6.ToolTip = faceSets[set][5];
                b7.Content = b7.ToolTip = faceSets[set][6];
                b8.Content = b8.ToolTip = faceSets[set][7];
                b9.Content = b9.ToolTip = faceSets[set][8];


            }

            else
            {


                Debug.WriteLine("Requested face set \"" + set + "\" could not be loaded.");

            }

        }

        private void closeProgram(object sender, EventArgs e)
        {

            Debug.WriteLine("Focus lost, exiting...");
            Application.Current.Shutdown();

        }

        // one of the buttons was pressed
        private void buttonPress(object sender, RoutedEventArgs e)
        {

            Clipboard.SetText((sender as Button).Content.ToString());
            closeProgram(null, null);


        }

        private void numpadPress(object sender, KeyEventArgs e)
        {

            // the numpad is upside down and the array starts at 0. It's annoying and confusing.
            // I also got a bit sloppy here.

            if (e.Key == Key.NumPad7)
            {
                Clipboard.SetText(faceSets[currentSet][0]);
                closeProgram(null, null);
            }

            else if (e.Key == Key.NumPad8)
            {
                Clipboard.SetText(faceSets[currentSet][1]);
                closeProgram(null, null);
            }

            else if (e.Key == Key.NumPad9)
            {
                Clipboard.SetText(faceSets[currentSet][2]);
                closeProgram(null, null);
            }

            else if (e.Key == Key.NumPad4)
            {
                Clipboard.SetText(faceSets[currentSet][3]);
                closeProgram(null, null);
            }

            else if (e.Key == Key.NumPad5)
            {
                Clipboard.SetText(faceSets[currentSet][4]);
                closeProgram(null, null);
            }

            else if (e.Key == Key.NumPad6)
            {
                Clipboard.SetText(faceSets[currentSet][5]);
                closeProgram(null, null);
            }

            else if (e.Key == Key.NumPad1)
            {
                Clipboard.SetText(faceSets[currentSet][6]);
                closeProgram(null, null);
            }

            else if (e.Key == Key.NumPad2)
            {
                Clipboard.SetText(faceSets[currentSet][7]);
                closeProgram(null, null);
            }

            else if (e.Key == Key.NumPad3)
            {
                Clipboard.SetText(faceSets[currentSet][8]);
                closeProgram(null, null);
            }

            // for swapping face sets
            else if (e.Key == Key.D1)
            {
                loadFaces("Common");
            }

            else if (e.Key == Key.D2)
            {
                loadFaces("Lenny");
            }

            else if (e.Key == Key.Escape)
            {
                closeProgram(null, null);
            }
            


        }

        // code to get the window dead center. Might dissable this, 
        //but if you have multiple monitors, it will open the window on the active monitor
        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }
    }
}
