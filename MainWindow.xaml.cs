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
//yhhyydmmmmmddddmmmmmmmmmmmmmddddddddddddddsoysoooooooooooooooooooooooooo++++++++++++//++////////////
//yyhhhdmmmmmdddmmmmmmmmmmmmmmmmdmddddddddddy+yyooooooooooooooooooooooooooooo+++++++++++//////////////
//yhddddmdmmmdddmmmmmmmmmmmmmmmmmddddddddddhh+syooooooooooooooooooooooooooooo++++++++++++/////////////
//yhdddmmdddddddmmmmmmdhyyssoo+++///////:::::::------------------------:::::///++++++++++//++/////////
//hddddmmdddddddmmmmdo///://///////////////////////////////////:::::-------------++++++++/////////////
//dddddmdddddddmmmmmy//++++++++/////////+++++++++++++++++++///////////:::::::::::/++++++//////////////
//hhdddddddddddmmmmmy++++++++++///////////////+++++++++++++++///////////:::::::-:/++++++++////////////
//ddhddhddddddmmmmmmh//++++++++//////////+++//+++++++++++++++++/////////:::::::::/+++++++++/+/////////
//dyoddhddddddmmmmmmh/++++++++oooooooooossssoooooo+++++++++++++++///////:::::::::/++++++++++//////////
//hhhdyhddhddddmmmmmh:+++++++oooooooooooooooooooooo+++++++++++++++///////::/:::::/o++++++++++/////////
//hhhdhhhhddhhddmmmmh/+ooooooooooooooooooooossssssoooooooooooooo++++++////////////o+++++++++++////////
//y/shhddddhddddddddh+++ooooooooooooooososoososssssosooooooooo+o++++++//////////:+ooo++++++++++++/////
//+-syhdddyyhdddddddh+++++ooooooooooooooooooooooooooo+o+o+++++++++++++/////////::oooo++++++++++++/////
//-+sohddhssyhhdddhhho+++++oooooooooooooooooooooooo+o+o++++++++++++//+/////////:/ooooo++++++++++/++///
//+yohddhysyhhhhhhhyhs+++++oooooooooooooooooooooooo+o+o+++++++++++++/+/////////:/ooooo++++++++++//////
//hhhdddhyyhhddddhhyhs++++ooooooooooooooooooooooooo+o+o+++++++++++++///////////:/oooo++++++++++++/////
//hhhdddhdddddmmdddddy++++ooooooooooooooooooooooooo+o+o+++++++++++++//////////::+ooooo+o+++++++++++///
//hhhddhhddmmmmmmmmmmd+++++oooooooooooooooooooooooo+o+o++++++++++//+//////////::+oooooo+++++++++++++//
//hhdddddmmmmmmmNNNNmmso++ooooooooooooooooooooooo+o+o+++++++/++/+//+////////////ooooooo++++++++++++///
//ddmmmmmmmmNNNNNNmmmmdyooooooooooooooooooooooooooooo+o+++++++++++++///////////oooooooo+++++++++++++//
//mmmmmmmmmmNNNNmmmmmmmhssssssssyyysssssssssssssssssssssssssssssoooooooo+++//:/ooooooooooo+++++++++++/
//mmmmmmmmmmNNmmmmmmmmmmdhysoooosssssssssyyyyyyyyyyyyyssssssssoo+++/////////+ooooooooooooo++++++++++//
//NNNNNNNNNNNNNNNNNNNNNNmmhyysssssssssssossssssssssssssooooosssssssssssoo+/+oosoooooooooo+++++++++++//
//NNNNNNNNNNNNNNNNNNmdhsoooooossssssssssoosoyyyyyyyyyyyyyyyyyysssoo++///:::::/++ooooooooo++++++++++++/
//NNNNNNNNNNNNNmmhyo++++++/++++oooooosossssssssssssssssoooo+++//::::::::------:::::/+ooooo++++++++++++
//NmmNNNNNNNmmhs+////////+/////+++++++++++++//////////::::::::::::::----.------------:/++++++++++++++/
//NNNNNNNNmdy+//:-:::::://///////////////////::::::::::::::::::::::::::-::--------------:/++++++++////
//NNNNNNNds+//:::::::::::://:::::::::::::::::::::::::::::::::::::::::::::----------.--..---/++++++++//
//NNNNNmy+///://:::::-::::::///////////::::::::::::::::::::::::::::::::::----......----.----:/+++/////
//NNmmms+/:///::::---:://:///////////////////////::::::///////::::::--------.........---------:+++++//
//ysss+/////:///////////////+++++++++++++++++++++++++++++++//////////////////:::::-------------:++++++
//ooo/./////////+++++++++++++++oooooooooooooooooooooooooooooooooooo+++++++++++++///////:::::----:+++//
//ooo//////+++++ooo+ooooosssssssssssssssssyyyyyyyyyyyyyyyyyyssssssssssssooooooooo+++++++////::::-:////
//oo+///++++oooooossssssssssssyyyyyyyyyyyyhhhhhhhhhhhhhhhhhhhhyyyyyysssssoooooooo++++++++++////:::////
//o++/+++ooooooossssssssssssyyhhhdddddddmmmmmmmmmmmmmmmmmmmmmmmmmddddddddhhyyssoo++++++++++++////::/+/
//o++++oooooooossossssyhhdddmmmmmmmmmdmmmmmmmmmmmmmmmmmmmmmddddddddddddddddddddddhhyso+++++++/////:/+/
//o+++ooooooooosssyhdddmmmmmmmmmmdddddddmmmmmmmmmmmdddddddddddddddddddddddddddddddddddhyo+++///////://
//o++oooooooooyhddddmmmmmmmmmmmdddddhyhhddddmmmmmddddddddddddddddddhhyyddddddddddddddddddhs+//////////
//o+ooooooooshddddddmmmmmmmmmmmmddyooooooooossssyyyyyyyyyyyysssooo+++++osddddddddddddddddddho/////////
//ooooooooosddddddddmmmmmmmmmmmddoso++++++oo++++++++++++++++///////////+++ddddddddddddddddddh/////////
//sooooooooydddmmmmmmmmmmmmmmmmmdyoo++sds+ddo+shsyo/os+++///////++++///++yddddddddddddddddddd+////////
//hooooooooydddmmmmmmmmmmmmmmmmmmdos++ymy+ddo+dh+dh+ydoyh+oyoso/dysy+/++ydddddddddddddddddddd+////////
//msoooooooydmdmmmmmmmmmmmmmmmmmmmso++ymysmdo+dhodh+hdohh+sdsoo+ds+///+/ddddddddddddddddddddy/////////
//Nhooooooosdmmmmmmmmdddddddhhhhhhos++ymy+mdo+dh+dh+hd+dh+/ydy/odso+//o/yyyyyyhhhhhdddddddddo/////////
//Nmsoooooooyhhhyyyyssssssssoooooo+s++ymy+ddo+osoyo/shody+yosdosdoys//+//+++++++++++ooossyyy//////////
//NNysooooooosoooooooo++++++++++++o+++oso+oo+yo++++//++o+/ooos+osoo////+::::::::::::://///////////////
//NNhssoooooooo+++++++++++++++++++s+++syyyyyssyo+shyoysoosooossyshs////+:::::::::::::::::://///ossoooo
//NNdssssooooooo++++++++++++++++++oo++ysooyso++++osyohyossssoyo+oo+++/+/:::::::::::::::://////syyhhhhh
//NNmsoossoooooooo+++++++++++++++++ooooooooooo+++++////++++++++++++++//::::::::::::::::///////oshmNNNN
//NNNyooosooooooooo+++++++++++++++++++++++++++++++++++++++////////////:::::::::::::::///:--:oydmNNNNNN
//NNNhooosso++++ooso++++++++++++++++++++++++++//////////////////////////::::::::::::///+///odmmmNNNNNN
//NNNdooosyoooooooooso++++++++++ooossssso++++++//////////////////osoooo++///:::::://++/:::+yhmmNNNNmmm
//NNNmsoosysooo+++oosso+++oossyysssssssss++++++++++++++++++++++++ooooooooooo++/::/++///://hdmmmmmmdddd
//NNNmyssssysoooooooosso+ossyyyyssyyssysssssssssssysssssssoossoososooss+oooo+/::/++++///:yNNNNNmmddddd
//NNNNhsssyhyoooooooossss+++osyyssyyoos+ss+ooss+osso/osso/o++s/+o/o++so+oo+/:::/+++/::::/mNmmmmmmddhhh
//NNNNdsoosyyoooooooooosss+++++syoyysoo+ys+osss+osso/oss+/s++s/+//+/ss+oo/::://+++++//::ommmmmmddddddd
//mNNNmsooshho+oooooooossss++++syssyyy+oyy+osss+osso/sss++s/os//o//oso+so/:://++++////::smmmmmmmmddddd
//mmNNmyoossso++ooooo++ossso++oyyysyyyooyyoooos+oooo+ooso+++ss++o+oss+oos/::/++++//:::::smmmmmmmmmmddd
//mmNNNdsossso+++oooooooosss++osoooyyyssssssssssssssssooooooooooooooo/////::/+++o+/:::::ommmmmmmmmmddd
//mmNNNNmdhys++++oooossssssso+++++++++++++++++++++++////////////////////:::/+++++//:::::/dmmmmmmmmmddd
//mmmNNNNNNNy+++++oooo+++osso+++++sso+ss+oo+o++ooo++ooo+/o+//ooo+/o+o+//:::/+++++/:::::--ymmmmmmmmmddd
//mmmNNNNNNms+++++ooo+ooosss++++++sysoyy+ss+yoos+oo+os++oss/+s+o++s/o+//::://++o+//::::--smmmmmmmmdddd
//mmddmmmmmho+++++o+ooooosso++++++ssyssy+ss+yo+oso++os//sos++s+s++o/o+//::://++oo+/-::---+dmmmmmmmdddd
//Nmmmddhyhso++++o++oooooss+++++++ssssoy+ssoyooooso+os/osos+os/o++o++//:::::/+++o+/:-::-:/ymmmmmmmdddd
//NNmmmmddhsoo+++++ooooooso+++++++++++++++oo+++oo++/++/++/++///////////::::::/++++//:-::::ommmmmdddddd
//NNNmmmmNho++o+++oo+oosso++++++++++++++++++++++/++++//////////////////:::::::/++++//:::::+shdmmdddddd
//NNNNmmmmyo++++oooooosso++++++++++++++++++++o+++++++///////////////////:::::::+++++//::::/sssshdddddd
//NNNMNNNNyo++++ooosssso++++++++++++++++++++oooo++o+o+o+++o+/////////////::::::/++++////::/yhhyssyhddd
//NNMMMMMMho+++ooooosso++++++++++++++++++++++++++++++++++/+//////////////:::::::/++////////hdhyyssssyh
//NNMMMNNNho++oooooooo++++++++++++++++++++++++++/+++////////////////////:::::::::/+////////yyhhhhhhhys
//NNNMMMNNdoooooooooo++++++++++++++++++++++++++++////////////////////////::::::::://///////yhddmmmdddy
//mNNNNMNNmsoooooooo++++++++++++++++++++++++++++++//////////////////////:::::::::::///////odddmmmmdddd
//mmmmNNNNNhoooooo++++++++++++++++++++++++++++++++/+////////////////////:::::::::::://////ymmmdddddddd
//mmNNNNMMMmooooo+++++++++++++++++++++++++++++++++/+////////////////////:::::::::::://///+dmmmmmdddddd
//mmNNNMMMMNyoooo+++++++++++++++++++++++++++++++++/////////////////////::::::::::::://///smmmmmmmddddd
//mmNmNMMMMNdoooo++++++++++++++++++++++++++++++++++//+/+/+++++////////::::::::::::::////+dmmmmmmdddddd
//mmmdNNMMMNNyooo+++++++++++++++++++++++omshohhssdy++dodsdohh+////////::::::::::::::////ymmmmmmmdddddd
//NNmmNNNNNNNdooo+++++++++++++++++++++++omhNsmho+ms//hmhmy/hs/////////:::::::::::::////odmdmmmmmmmmddd
//NNmmmNNNNNNNhooo++/++++++++++++++o+++++s+s+sso+s+//+s+o+/+/////++//:::::::::::::////+hmdyhmddmmmdmdd
//mmmmmhmNNNNNNyooo+++++++++++++++odhy+shyyoyh++yooss+oh+oyy/+ssooy:::::::::::::://::/hdddddhhhhhhhddd
//mmmmmmmNNNNNNmsooo++++++++++++++ohhy+shydsds++d+ohs+yy+oy//ohhoo+::::::::::::::::::smmdddmdhyyhhhhdd
//mmmdmmmmmmmmNNms++++++++++++++++++++++oo+ooo++s+oo++o+/+////++//::::://////::::://sddmddmmmmddhhhyyy
//hdhddddmmmmNNNNms+/////+++++ooo+++++++++++++++/////////////////////////::::////+ohmmdhddmmdyhyyyhhhd
//yhhdmmmNNmmmNNNNmhoo++///////++++++++++++++++++++++++++++/////////////////++oshmmmmmddddddhhhhdddhdd
//shhddhhddhhdmmmNNNmhyssoooo++++++++///////////////////////////////++++osyhmNNmmmmdhhysyhddmddhyyhdhy
//ossssysyhysyhdmNmNMMMNmmdhyyssssoooooo++++++++++++++++++++++oooosyhdmNNNNNNmNNmmhhyhyyddmdddysosssss
//+oooossysyhdmNdddmNNNNNNNMMMNNNmmddhhhyyyyyssssssyyyyyhhhddmddmNNNNMNNNNNmdddddddmdmmhhdmdhyyssssssy
//hysssysooyhdmdyhmmNmNNNNNNNNmNNMMMMMMMMMMNNNNNMMMMMMMMMMMMMMNmdddmmNNNNmddhhdmNNmmdddddhhhyyyysyyydd
//mdyssssyydddhyyydmNNNNmmNNNNmdNNNNNNmNMNNNNNNNNNNMMMNMMMMMMMMNNdhhhhhyhdddmmmmmmddsosyyyhysyyddmdhhh
//mdhssosyyhyhddhyddmmNmmmmmmmmdhdmNNNmdNNNmmNmmmNNNNNNNNNNNNNNNNNmhyyyssshhdmmdyyyyhyssyyhdmmmmmmdddh

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
