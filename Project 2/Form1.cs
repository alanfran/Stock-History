// By Antonio Lanfranchi

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.IO;
using System.Collections;


namespace Project_2
{
    public partial class aStockForm : Form
    {
        public aStockForm()
        {
            InitializeComponent();

            // sets the default From date to yesterday. Yahoo gives you a 404 if you send the same values for both dates
            DateTime f = DateTime.Today.AddDays(-1);
            fromdate.Value = f;

            // have a default for the radio button group
            rDay.Checked = true;

            // set chart type to candlestick
            chart1.Series[0].ChartType = SeriesChartType.Candlestick;
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series[0]["PriceUpColor"] = "Green";
            chart1.Series[0]["PriceDownColor"] = "Red";
            chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            // pressing enter will GO!
            AcceptButton = goButton;
        }

        /// <summary>
        /// "GO!" event handler. This downloads the requested stock information and loads it into the chart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void clickGo(object sender, EventArgs e)
        {
            string tick = tickerbox.Text;
            int tm = todate.Value.Month - 1;     // yahoo's months are 0-indexed
            int td = todate.Value.Day;
            int ty = todate.Value.Year;
            int fm = fromdate.Value.Month - 1;   // convert date to 0-index
            int fd = fromdate.Value.Day;
            int fy = fromdate.Value.Year;
            char fmt = ' ';

            if (rDay.Checked)
            {
                fmt = 'd';
            }
            if (rMonth.Checked)
            {
                fmt = 'm';
            }
            if (rWeek.Checked)
            {
                fmt = 'w';
            }

            // download stock data

            //a = from month -1
            //b = from day
            //c = from year
            //d = to month -1
            //e = to day
            //f = to year
            //g = interval {d,w,m}

            List<aCandleStick> cList = new List<aCandleStick>;

            string dladdress = string.Format("http://ichart.yahoo.com/table.csv?s={0}&a={1}&b={2}&c={3}&d={4}&e={5}&f={6}&g={7}", tick, fm, fd, fy, tm, td, ty, fmt);

            using (WebClient wc = new WebClient())
            {
                try
                {
                    string dlstring = wc.DownloadString(dladdress);

                    // turn each line into a candlestick and append to cList
                    string[] data = dlstring.Split('\n');

                    int len = data.Length - 1;
                    string[] tmp = new string[len];

                    // Splitting the string on the newline character leaves an empty string at the end.
                    // Copy all but the last, empty string to a new array
                    for (int i=0; i<len; i++)
                    {
                        tmp[i] = data[i];
                    }

                    double highest=0;
                    double lowest=0;

                    // turns the data into candlestick objects
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        // ignore the column names at index 0
                        if (j != 0)
                        {
                            // split the string by ,
                            string[] attr = new string[7];
                            attr = tmp[j].Split(',');

                            DateTime d = DateTime.Parse(attr[0]);
                            double o = Double.Parse(attr[1]);
                            double h = Double.Parse(attr[2]);
                            double l = Double.Parse(attr[3]);
                            double c = Double.Parse(attr[4]);
                            double v = Double.Parse(attr[5]);
                            double ac = Double.Parse(attr[6]);

                            cList.Add(new aCandleStick(d,o,h,l,c,v,ac));

                            // save the highest and lowest encountered values so we can adjust the Y axis' range
                            if (j==1)
                            {
                                highest = h;
                                lowest = l;
                            }
                            else
                            {
                                if (h > highest)
                                {
                                    highest = h;
                                }
                                if (l < lowest)
                                {
                                    lowest = l;
                                }
                            }
                        }
                    }

                    // clear out any previous data sets in the chart
                    foreach (var series in chart1.Series)
                    {
                        series.Points.Clear();
                    }

                    // adjust Y range
                    chart1.ChartAreas[0].AxisY.Maximum = highest+5;
                    chart1.ChartAreas[0].AxisY.Minimum = lowest-5;


                   // load candlesticks into chart
                    for (int i=0; i<cList.Count; i++)
                    {
                        chart1.Series[0].Points.AddXY(cList[i].date, cList[i].high);
                        chart1.Series[0].Points[i].YValues[1] = cList[i].low;
                        chart1.Series[0].Points[i].YValues[2] = cList[i].open;
                        chart1.Series[0].Points[i].YValues[3] = cList[i].close;
                    }
                }
                catch (WebException ex)
                {
                    if (tick == "")
                    {
                        MessageBox.Show("Please enter a stock name.");
                    }
                    else
                    {
                        MessageBox.Show("There was an error downloading stock history. Make sure you entered a valid ticker name.");
                    }
                }
            }
        }
    }
}
