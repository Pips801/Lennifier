using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace lennifier
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
                switch (args[0])
                {
                    case "-tableflip":
                        System.Windows.Forms.Clipboard.SetText(@"(╯°□°）╯︵ ┻━┻");
                        break;

                    case "-lenny":
                        System.Windows.Forms.Clipboard.SetText(@"( ͡° ͜ʖ ͡°)");
                        break;

                    case "-donger":
                        System.Windows.Forms.Clipboard.SetText(@"ヽ༼ຈل͜ຈ༽ﾉ");
                        break;

                    case "-tabledown":
                        System.Windows.Forms.Clipboard.SetText(@"┬─┬ノ( º _ ºノ)");
                        break;

                    case "-magic":
                        System.Windows.Forms.Clipboard.SetText(@"(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧ ✧ﾟ･: *ヽ(◕ヮ◕ヽ)");
                        break;

                    case "-bear":
                        System.Windows.Forms.Clipboard.SetText(@"ʕ•ᴥ•ʔ");
                        break;

                    case "-whatever":
                        System.Windows.Forms.Clipboard.SetText(@"¯\_(ツ)_/¯");
                        break;

                    case "-eyy":
                        System.Windows.Forms.Clipboard.SetText(@"(☞ﾟヮﾟ)☞");
                        break;

                    case "-interject":
                        System.Windows.Forms.Clipboard.SetText(@"(°ロ°)☝");
                        break;

                    case "-personflip":
                        System.Windows.Forms.Clipboard.SetText(@"（╯°□°）╯︵( .o.)");
                        break;

                    case "-disaproving":
                        System.Windows.Forms.Clipboard.SetText(@"ಠ_ಠ");
                        break;

                    case "-lennysnake":
                        System.Windows.Forms.Clipboard.SetText(@" 

╚═( ͡° ͜ʖ ͡°)═╝
╚═(███)═╝
╚═(███)═╝
.╚═(███)═╝
..╚═(███)═╝
…╚═(███)═╝
…╚═(███)═╝
..╚═(███)═╝
.╚═(███)═╝
╚═(███)═╝
.╚═(███)═╝
..╚═(███)═╝
…╚═(███)═╝
…╚═(███)═╝
…..╚(███)╝
……╚(██)╝
………(█)
……….*");

                        break;

                    case "-stronglenny":
                        System.Windows.Forms.Clipboard.SetText(@"ᕦ( ͡° ͜ʖ ͡°)ᕤ");
                        break;


                    default:
                        System.Windows.Forms.Clipboard.SetText(@"( ͡° ͜ʖ ͡°)");
                        break;
                }
            
                
            

        }
    }
}
