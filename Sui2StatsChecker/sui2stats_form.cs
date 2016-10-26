using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sui2StatsChecker
{
    public partial class StatCheckerForm : Form
    {

        int minStat = 0;
        int maxStat = 0;
        double avgStat = 0;
        int[] myranks = { 0, 0, 0, 0, 0, 0, 0, 0 };
        bool initialized = false;

        private const string resxFile = "Sui2StatsChecker.Resources.resx";

        public StatCheckerForm()
        {
            InitializeComponent();

            //for(int i = 0; i < 13; i++)
            //{
            //    statBox.Items.Add("Rank " + i);
            //}

            initialized = false;

            statBox.Items.Add("Magic");
            statBox.Items.Add("Strength");
            statBox.Items.Add("M Def");
            statBox.Items.Add("Prot");
            statBox.Items.Add("Speed");
            statBox.Items.Add("Tech");
            statBox.Items.Add("Luck");
            statBox.Items.Add("HP");

            for (int i = 0; i < 99; i++)
                levelBox.Items.Add(i+1 + "");

            for(int i = 0; i < 83; i++)
            {
                charBox.Items.Add(characters.names[i]);
            }

            statBox.SelectedIndex = 0;
            levelBox.SelectedIndex = 0;
            charBox.SelectedIndex = 0;
            initialized = true;
            LoadChar();
            CalculateStats();

            pdfChart.Titles.Add("Probability Density of Specific Stat Values");
            //pdfChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
        }

        private void LoadChar()
        {
            int myindex = charBox.SelectedIndex;

            myranks[0] = characters.magic[myindex];
            myranks[1] = characters.strength[myindex];
            myranks[2] = characters.mdef[myindex];
            myranks[3] = characters.prot[myindex];
            myranks[4] = characters.speed[myindex];
            myranks[5] = characters.tech[myindex];
            myranks[6] = characters.luck[myindex];
            myranks[7] = characters.hp[myindex];

            charGrid.Rows.Clear();

            string myname = characters.names[myindex];
            myname = myname.ToLower();
            myname = myname.Replace(" ", string.Empty);
            myname = myname.Replace(".", string.Empty);
            myname = myname + "02";


            ResourceManager rm = Properties.Resources.ResourceManager;
            var image = (Bitmap)rm.GetObject(myname);
                if(image != null)
                    picBox.Image = image;


            int mylevel = levelBox.SelectedIndex+1;

            int mychar = charBox.SelectedIndex;
            if (mychar == 1 || mychar == 13 || mychar == 60 || mychar == 68)//Big monsters
                for (int i = 0; i < 7; i++)
                {
                    
                    CalculateRange(mylevel, myranks[i]);
                    if (i == 1)
                        charGrid.Rows.Add(new object[5] { statBox.Items[i], myranks[i], string.Format("{0:0.00}", avgStat*3.1), Math.Floor(minStat*3.1), Math.Floor(maxStat*3.1) });
                    else if(i==3)
                        charGrid.Rows.Add(new object[5] { statBox.Items[i], myranks[i], string.Format("{0:0.00}", avgStat*1.5), Math.Floor(minStat*1.5), Math.Floor(maxStat*1.5) });
                    else
                        charGrid.Rows.Add(new object[5] { statBox.Items[i], myranks[i], string.Format("{0:0.00}", avgStat), minStat, maxStat });
                }
            else if (mychar == 10 || mychar == 18 || mychar == 42 || mychar == 46 || mychar == 48 || mychar == 51 || mychar == 53 || mychar == 65)
                for (int i = 0; i < 7; i++)
                {

                    CalculateRange(mylevel, myranks[i]);
                    if (i == 1 || i==3)
                        charGrid.Rows.Add(new object[5] { statBox.Items[i], myranks[i], string.Format("{0:0.00}", avgStat * 2.2), Math.Floor(minStat * 2.2), Math.Floor(maxStat * 2.2) });
                    else
                        charGrid.Rows.Add(new object[5] { statBox.Items[i], myranks[i], string.Format("{0:0.00}", avgStat), minStat, maxStat });
                }
            else
                for (int i = 0; i < 7; i++)
                {
                    CalculateRange(mylevel, myranks[i]);
                    charGrid.Rows.Add(new object[5] { statBox.Items[i], myranks[i], string.Format("{0:0.00}",avgStat), minStat, maxStat });
                }

            CalculateHPRange(mylevel, myranks[7]);
            charGrid.Rows.Add(new object[5] { statBox.Items[7], myranks[7], string.Format("{0:0.00}", avgStat), minStat, maxStat });

        }

        void CalculateStats()
        {
            int mylevel = levelBox.SelectedIndex + 1;
            int rankindex = statBox.SelectedIndex;

            double modifier = 1;
            int extra = 0;

            if (rankindex != 7)
            {

                double[] stats = new double[mylevel];

                for (int i = 0; i < mylevel; i++)
                    stats[i] = 0;


                StatRoll(mylevel, myranks[rankindex], stats);

                CalculateRange(mylevel, myranks[rankindex]);

                statGrid.Rows.Clear();
                double cumulative = 0;
                int mychar = charBox.SelectedIndex;
                if(mychar == 1 || mychar == 13 || mychar == 60 || mychar == 68)//Big monsters
                {
                    if(rankindex==1)//STR
                        for (int i = 0; i < mylevel; i++)
                        {
                            modifier = 3.1;
                            statGrid.Rows.Add(new object[3] { Math.Floor((i + minStat)*3.1), FormatStrings(stats[i]), FormatStrings(1 - cumulative) });
                            cumulative += stats[i];
                        }
                    else if(rankindex==3)//PROT
                        for (int i = 0; i < mylevel; i++)
                        {
                            modifier = 1.5;
                            statGrid.Rows.Add(new object[3] { Math.Floor((i + minStat)*1.5), FormatStrings(stats[i]), FormatStrings(1 - cumulative) });
                            cumulative += stats[i];
                        }
                    else
                        for (int i = 0; i < mylevel; i++)
                        {
                            statGrid.Rows.Add(new object[3] { i + minStat, FormatStrings(stats[i]), FormatStrings(1 - cumulative) });
                            cumulative += stats[i];
                        }
                }
                else if (mychar == 10 || mychar == 18 || mychar == 42 || mychar == 46 || mychar == 48 || mychar == 51 || mychar == 53 || mychar == 65)//Small monsters
                {
                    if (rankindex == 1 || rankindex == 3)//STR
                        for (int i = 0; i < mylevel; i++)
                        {
                            modifier = 2.2;
                            statGrid.Rows.Add(new object[3] { Math.Floor((i + minStat) * 2.2), FormatStrings(stats[i]), FormatStrings(1 - cumulative) });
                            cumulative += stats[i];
                        }
                    else
                        for (int i = 0; i < mylevel; i++)
                        {
                            statGrid.Rows.Add(new object[3] { i + minStat, FormatStrings(stats[i]), FormatStrings(1 - cumulative) });
                            cumulative += stats[i];
                        }
                }
                else
                    for (int i = 0; i < mylevel; i++)
                    {
                        statGrid.Rows.Add(new object[3] { i + minStat, FormatStrings(stats[i]), FormatStrings(1 - cumulative) });
                        cumulative += stats[i];
                    }

                PlotChart(stats,modifier);
            }
            else //HP
            {
                double[] stats = new double[mylevel*2];

                for (int i = 0; i < (mylevel*2)-1; i++)
                    stats[i] = 0;

                
                HPRoll(mylevel, myranks[rankindex], stats);

                CalculateHPRange(mylevel, myranks[rankindex]);

                statGrid.Rows.Clear();
                double cumulative = 0;
                

                for (int i = 0; i < (mylevel*2)-1; i++)
                {
                    statGrid.Rows.Add(new object[3] { i + minStat+extra, FormatStrings(stats[i]), FormatStrings(1 - cumulative) });
                    cumulative += stats[i];
                }

                PlotChart(stats,modifier);
            }

            

        }

        private string FormatStrings(double val)
        {
            return string.Format("{0:0.####%}", val);
        }

        private void PlotChart(double[] stats, double modifier)
        {
            pdfChart.Series.Clear();
            pdfChart.Series.Add("Probability");
            for (int i = 0; i <= maxStat-minStat; i++)
            {
                pdfChart.Series[0].Points.AddXY(Math.Floor((i+minStat)*modifier), stats[i]);
            }
            pdfChart.ResetAutoValues();

            pdfChart.Update();
        }

        private void CalculateRange(int mylevel, int myrank)
        {

            if (myrank == 9 || myrank == 10)
            {
                if (mylevel > 14)
                {
                    if (mylevel > 59)
                    {
                        minStat = 13 * ranks.growths[myrank, 0] + 45 * ranks.growths[myrank, 1] + (mylevel - 59) * ranks.growths[myrank, 2];
                        avgStat = 13 * (ranks.growths[myrank, 0] + ranks.probs[myrank, 0] / 256) + 45 * (ranks.growths[myrank, 1] + ranks.probs[myrank, 1] / 256) + (mylevel - 59) * (ranks.growths[myrank, 2] + ranks.probs[myrank, 2] / 256);
                    }
                    else
                    {
                        minStat = 13 * ranks.growths[myrank, 0] + (mylevel - 14) * ranks.growths[myrank, 1];
                        avgStat = 13 * (ranks.growths[myrank, 0] + ranks.probs[myrank, 0] / 256) + (mylevel - 14) * (ranks.growths[myrank, 1] + ranks.probs[myrank, 1] / 256);
                    }
                }
                else
                {
                    minStat = (mylevel - 1) * ranks.growths[myrank, 0];
                    avgStat = (mylevel - 1) * (ranks.growths[myrank, 0] + ranks.probs[myrank, 0] / 256);
                }
            }
            else
            {
                if (mylevel > 19)
                {
                    if (mylevel > 59)
                    {
                        minStat = 18 * ranks.growths[myrank, 0] + 40 * ranks.growths[myrank, 1] + (mylevel - 59) * ranks.growths[myrank, 2];
                        avgStat = 18 * (ranks.growths[myrank, 0] + ranks.probs[myrank, 0] / 256) + 40 * (ranks.growths[myrank, 1] + ranks.probs[myrank, 1] / 256) + (mylevel - 59) * (ranks.growths[myrank, 2] + ranks.probs[myrank, 2] / 256);
                    }
                    else
                    {
                        minStat = 18 * ranks.growths[myrank, 0] + (mylevel - 19) * ranks.growths[myrank, 1];
                        avgStat = 18 * (ranks.growths[myrank, 0] + ranks.probs[myrank, 0] / 256) + (mylevel - 19) * (ranks.growths[myrank, 1] + ranks.probs[myrank, 1] / 256);
                    }
                }
                else
                {
                    minStat = (mylevel - 1) * ranks.growths[myrank, 0];
                    avgStat = (mylevel - 1) * (ranks.growths[myrank, 0] + ranks.probs[myrank, 0] / 256);
                }
            }

            minStat += ranks.bases[myrank];
            maxStat = minStat + mylevel-1;
            avgStat += ranks.bases[myrank];
        }

        private void CalculateHPRange(int mylevel, int myrank)
        {
            int modifier = 1;
            if (mylevel > 19)
            {
                if (mylevel > 59)
                {
                    minStat = 18 * ranks.HPgrowths[myrank, 0] + 40 * ranks.HPgrowths[myrank, 1] + (mylevel - 59) * ranks.HPgrowths[myrank, 2];
                    avgStat = 18 * (ranks.HPgrowths[myrank, 0] + ranks.HPprobs[myrank, 0] / 256) + 40 * (ranks.HPgrowths[myrank, 1] + ranks.HPprobs[myrank, 1] / 256) + (mylevel - 59) * (ranks.HPgrowths[myrank, 2] + ranks.HPprobs[myrank, 2] / 256);
                }
                else
                {
                    minStat = 18 * ranks.HPgrowths[myrank, 0] + (mylevel - 19) * ranks.HPgrowths[myrank, 1];
                    avgStat = 18 * (ranks.HPgrowths[myrank, 0] + ranks.HPprobs[myrank, 0] / 256) + (mylevel - 19) * (ranks.HPgrowths[myrank, 1] + ranks.HPprobs[myrank, 1] / 256);
                }
            }
            else
            {
                minStat = (mylevel - 1) * ranks.HPgrowths[myrank, 0];
                avgStat = (mylevel - 1) * (ranks.HPgrowths[myrank, 0] + ranks.HPprobs[myrank, 0] / 256);
            }

            int mychar = charBox.SelectedIndex;
            if (mychar == 38 || mychar == 80)
                modifier = 10;

            minStat += ranks.HPbases[myrank]*modifier;
            maxStat = minStat + (mylevel - 1)*2;
            avgStat += ranks.HPbases[myrank]*modifier+(mylevel-1)/2;
        }

        private void StatRoll(int mylevel, int myrank, double[] results)
        {
            int i, j, k;
            int imax, jmax, kmax;

            double t1mass = 0;
            double t2mass = 0;
            double t3mass = 0;

            if (mylevel > 59)
            {
                if (myrank == 9 || myrank == 10)//Viktor
                {
                    imax = 13;
                    jmax = 45;
                }
                else
                {
                    imax = 18;
                    jmax = 40;
                }

                kmax = mylevel - 59;



                for (i = 0; i <= imax; i++)
                {
                    for (j = 0; j <= jmax; j++)
                    {
                        for (k = 0; k <= kmax; k++)
                        {
                            t1mass = Choose(imax, i) * Math.Pow(ranks.probs[myrank, 0] / 256, i) * Math.Pow(1 - (ranks.probs[myrank, 0] / 256), imax - i);
                            t2mass = Choose(jmax, j) * Math.Pow(ranks.probs[myrank, 1] / 256, j) * Math.Pow(1 - (ranks.probs[myrank, 1] / 256), jmax - j);
                            t3mass = Choose(kmax, k) * Math.Pow(ranks.probs[myrank, 2] / 256, k) * Math.Pow(1 - (ranks.probs[myrank, 2] / 256), kmax - k);

                            results[i + j + k] += t1mass * t2mass * t3mass;
                        }
                    }
                }
            }
            else if (mylevel > 19)
            {
                if (myrank == 9 || myrank == 10) //Viktor
                {
                    imax = 13;
                    jmax = mylevel - 14;
                }
                else
                {
                    imax = 18;
                    jmax = mylevel - 19;
                }
                kmax = 0;

                for (i = 0; i <= imax; i++)
                {
                    for (j = 0; j <= jmax; j++)
                    {
                        t1mass = Choose(imax, i) * Math.Pow(ranks.probs[myrank, 0] / 256, i) * Math.Pow(1 - (ranks.probs[myrank, 0] / 256), imax - i);
                        t2mass = Choose(jmax, j) * Math.Pow(ranks.probs[myrank, 1] / 256, j) * Math.Pow(1 - (ranks.probs[myrank, 1] / 256), jmax - j);
                        results[i + j] += t1mass * t2mass;
                    }
                }

            }
            else
            {
                if (myrank == 9 || myrank == 10) //Viktor
                {
                    if (mylevel > 14)
                    {
                        imax = 13;
                        jmax = mylevel - 14;

                        for (i = 0; i <= imax; i++)
                        {
                            for (j = 0; j <= jmax; j++)
                            {
                                t1mass = Choose(imax, i) * Math.Pow(ranks.probs[myrank, 0] / 256, i) * Math.Pow(1 - (ranks.probs[myrank, 0] / 256), imax - i);
                                t2mass = Choose(jmax, j) * Math.Pow(ranks.probs[myrank, 1] / 256, j) * Math.Pow(1 - (ranks.probs[myrank, 1] / 256), jmax - j);
                                results[i + j] += t1mass * t2mass;
                            }
                        }

                        return;
                    }
                }
                else
                {

                }
            
                imax = mylevel-1;
                jmax = 0;
                kmax = 0;

                for (i = 0; i <= imax; i++)
                {
                    t1mass = Choose(imax, i) * Math.Pow(ranks.probs[myrank, 0]/256, i) * Math.Pow(1 - (ranks.probs[myrank, 0]/256), imax - i);
                    results[i] += t1mass;
                }
            }
            
        }

        private void HPRoll(int mylevel, int myrank, double[] results)
        {
            int i, j, k, m;
            int imax, jmax, kmax;

            double t1mass = 0;
            double t2mass = 0;
            double t3mass = 0;
            double t4mass = 0;

            if (mylevel > 59)
            {
                imax = 18;
                jmax = 40;
                kmax = mylevel - 59;


                for (m = 0; m <= mylevel - 1;m++) {
                    for (i = 0; i <= imax; i++)
                    {
                        for (j = 0; j <= jmax; j++)
                        {
                            for (k = 0; k <= kmax; k++)
                            {
                                t1mass = Choose(imax, i) * Math.Pow(ranks.HPprobs[myrank, 0] / 256, i) * Math.Pow(1 - (ranks.HPprobs[myrank, 0] / 256), imax - i);
                                t2mass = Choose(jmax, j) * Math.Pow(ranks.HPprobs[myrank, 1] / 256, j) * Math.Pow(1 - (ranks.HPprobs[myrank, 1] / 256), jmax - j);
                                t3mass = Choose(kmax, k) * Math.Pow(ranks.HPprobs[myrank, 2] / 256, k) * Math.Pow(1 - (ranks.HPprobs[myrank, 2] / 256), kmax - k);

                                t4mass = Choose(mylevel - 1, m) * Math.Pow(0.5, mylevel - 1);

                                results[i + j + k + m] += t1mass * t2mass * t3mass*t4mass;
                            }
                        }
                    }
                }
            }
            else if (mylevel > 19)
            {
                imax = 18;
                jmax = mylevel - 19;
                kmax = 0;

                for (m = 0; m <= mylevel - 1; m++)
                {
                    for (i = 0; i <= imax; i++)
                    {
                        for (j = 0; j <= jmax; j++)
                        {
                            t1mass = Choose(imax, i) * Math.Pow(ranks.HPprobs[myrank, 0] / 256, i) * Math.Pow(1 - (ranks.HPprobs[myrank, 0] / 256), imax - i);
                            t2mass = Choose(jmax, j) * Math.Pow(ranks.HPprobs[myrank, 1] / 256, j) * Math.Pow(1 - (ranks.HPprobs[myrank, 1] / 256), jmax - j);

                            t4mass = Choose(mylevel - 1, m) * Math.Pow(.5, mylevel-1);

                            results[i + j+m] += t1mass * t2mass*t4mass;
                        }
                    }
                }

            }
            else
            {
                imax = mylevel - 1;
                jmax = 0;
                kmax = 0;

                for (m = 0; m <= mylevel - 1; m++)
                {
                    for (i = 0; i <= imax; i++)
                    {
                        t1mass = Choose(imax, i) * Math.Pow(ranks.HPprobs[myrank, 0] / 256, i) * Math.Pow(1 - (ranks.HPprobs[myrank, 0] / 256), imax - i);

                        t4mass = Choose(mylevel - 1, m) * Math.Pow(.5, mylevel - 1);

                        results[i+m] += t1mass*t4mass;
                    }
                }
            }

        }

        double Choose(long n, long k)
        {
            if ((k < 0) || (k > n)) return 0;
            k = (k > n / 2) ? n - k : k;
            double a = 1;
            for (long i = 1; i <= k; i++) a = (a * (n - k + i)) / i;
            return a;
        }

        private void levelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialized)
            {
                LoadChar();
                CalculateStats();
            }
        }

        private void charBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialized)
            {
                LoadChar();
                CalculateStats();
            }
        }

        private void statBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialized)
            {
                LoadChar();
                CalculateStats();
            }
        }
    }
}
