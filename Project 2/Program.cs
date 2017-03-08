// By Antonio Lanfranchi

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Project_2
{
    class aCandleStick
    {
        /// Holds candlestick data
        /// 
        public aCandleStick(DateTime indate, double inopen, double inhigh, double inlow, double inclose, double involume, double inadjClose)
        {
            date = indate;
            open = inopen;
            high = inhigh;
            low = inlow;
            close = inclose;
            volume = involume;
            adjClose = inadjClose;
        }

        public DateTime date { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public double volume { get; set; }
        public double adjClose { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new aStockForm());
        }
    }
}

/*

 * wc.downloadstringcompleted += new downloadstringcompletedeventhandler
 * wc.downloadstringasync(uri)

*/