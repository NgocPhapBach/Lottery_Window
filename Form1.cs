using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace XSKT_Phap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlKiemTra.Enabled = false;
            pnlSave.Enabled = false;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            timerlbltimer.Start();           
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        Thread t;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();            
        }

        void Play()
        {
            pnlPlay.Enabled = false;
            giaiNhat();
            timerGiaiNhi_1.Start();
            timerGiaiNhi_2.Start();
            timerGiaiBa_1.Start();
            timerGiaiBa_2.Start();
            timerGiaiBa_3.Start();
            timerGiaiBa_4.Start();
            timerGiaiBa_5.Start();
            timerGiaiBa_6.Start();
            timerGiaiBon_1.Start();
            timerGiaiBon_2.Start();
            timerGiaiBon_3.Start();
            timerGiaiBon_4.Start();
            timerGiaiNam_1.Start();
            timerGiaiNam_2.Start();
            timerGiaiNam_3.Start();
            timerGiaiNam_4.Start();
            timerGiaiNam_5.Start();
            timerGiaiNam_6.Start();
            timerGiaiSau_1.Start();
            timerGiaiSau_2.Start();
            timerGiaiSau_3.Start();
            timerGiaiBay_1.Start();
            timerGiaiBay_2.Start();
            timerGiaiBay_3.Start();
            timerGiaiBay_4.Start();
            timerGiaiDB.Start();
            timerKetQua.Start();
        }

        void giaiDB()
        {
            int min = 0;
            int max = 99999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiDB);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiDB.Text != lengthMax.ToString())
            {
                timerGiaiDB.Stop();
            }
            else
            {
                timerGiaiDB.Start();
            }

        }

        void giaiNhat()
        {
            int min = 0;
            int max = 99999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiNhat);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);

        }

        void giaiNhi_1()
        {
            int min = 0;
            int max = 99999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiNhi_1);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if(lblGiaiNhi_1.Text != lengthMax.ToString())
            {
                timerGiaiNhi_1.Stop();
            }
            else
            {
                timerGiaiNhi_1.Start();
            }
        }

        void giaiNhi_2()
        {
            int min = 0;
            int max = 99999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiNhi_2);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiNhi_2.Text != lengthMax.ToString())
            {
                timerGiaiNhi_2.Stop();
            }
            else
            {
                timerGiaiNhi_2.Start();
            }
        }

        void giaiBa_1()
        {
            int min = 0;
            int max = 99999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBa_1);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBa_1.Text != lengthMax.ToString())
            {
                timerGiaiBa_1.Stop();
            }
            else
            {
                timerGiaiBa_1.Start();
            }
        }

        void giaiBa_2()
        {
            int min = 0;
            int max = 99999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBa_2);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBa_2.Text != lengthMax.ToString())
            {
                timerGiaiBa_2.Stop();
            }
            else
            {
                timerGiaiBa_2.Start();
            }
        }

        void giaiBa_3()
        {
            int min = 0;
            int max = 99999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBa_3);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBa_3.Text != lengthMax.ToString())
            {
                timerGiaiBa_3.Stop();
            }
            else
            {
                timerGiaiBa_3.Start();
            }
        }

        void giaiBa_4()
        {
            int min = 0;
            int max = 99999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBa_4);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBa_4.Text != lengthMax.ToString())
            {
                timerGiaiBa_4.Stop();
            }
            else
            {
                timerGiaiBa_4.Start();
            }
        }

        void giaiBa_5()
        {
            int min = 0;
            int max = 99999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBa_5);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBa_5.Text != lengthMax.ToString())
            {
                timerGiaiBa_5.Stop();
            }
            else
            {
                timerGiaiBa_5.Start();
            }
        }

        void giaiBa_6()
        {
            int min = 0;
            int max = 99999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBa_6);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBa_6.Text != lengthMax.ToString())
            {
                timerGiaiBa_6.Stop();
            }
            else
            {
                timerGiaiBa_6.Start();
            }
        }

        void giaiBon_1()
        {
            int min = 0;
            int max = 9999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBon_1);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBon_1.Text != lengthMax.ToString())
            {
                timerGiaiBon_1.Stop();
            }
            else
            {
                timerGiaiBon_1.Start();
            }
        }

        void giaiBon_2()
        {
            int min = 0;
            int max = 9999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBon_2);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBon_2.Text != lengthMax.ToString())
            {
                timerGiaiBon_2.Stop();
            }
            else
            {
                timerGiaiBon_2.Start();
            }
        }

        void giaiBon_3()
        {
            int min = 0;
            int max = 9999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBon_3);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBon_3.Text != lengthMax.ToString())
            {
                timerGiaiBon_3.Stop();
            }
            else
            {
                timerGiaiBon_3.Start();
            }
        }

        void giaiBon_4()
        {
            int min = 0;
            int max = 9999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBon_4);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBon_4.Text != lengthMax.ToString())
            {
                timerGiaiBon_4.Stop();
            }
            else
            {
                timerGiaiBon_4.Start();
            }
        }

        void giaiNam_1()
        {
            int min = 0;
            int max = 9999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiNam_1);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiNam_1.Text != lengthMax.ToString())
            {
                timerGiaiNam_1.Stop();
            }
            else
            {
                timerGiaiNam_1.Start();
            }
        }

        void giaiNam_2()
        {
            int min = 0;
            int max = 9999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiNam_2);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiNam_2.Text != lengthMax.ToString())
            {
                timerGiaiNam_2.Stop();
            }
            else
            {
                timerGiaiNam_2.Start();
            }
        }

        void giaiNam_3()
        {
            int min = 0;
            int max = 9999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiNam_3);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiNam_3.Text != lengthMax.ToString())
            {
                timerGiaiNam_3.Stop();
            }
            else
            {
                timerGiaiNam_3.Start();
            }
        }

        void giaiNam_4()
        {
            int min = 0;
            int max = 9999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiNam_4);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiNam_4.Text != lengthMax.ToString())
            {
                timerGiaiNam_4.Stop();
            }
            else
            {
                timerGiaiNam_4.Start();
            }
        }

        void giaiNam_5()
        {
            int min = 0;
            int max = 9999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiNam_5);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiNam_5.Text != lengthMax.ToString())
            {
                timerGiaiNam_5.Stop();
            }
            else
            {
                timerGiaiNam_5.Start();
            }
        }

        void giaiNam_6()
        {
            int min = 0;
            int max = 9999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiNam_6);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiNam_6.Text != lengthMax.ToString())
            {
                timerGiaiNam_6.Stop();
            }
            else
            {
                timerGiaiNam_6.Start();
            }
        }

        void giaiSau_1()
        {
            int min = 0;
            int max = 999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiSau_1);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiSau_1.Text != lengthMax.ToString())
            {
                timerGiaiSau_1.Stop();
            }
            else
            {
                timerGiaiSau_1.Start();
            }
        }

        void giaiSau_2()
        {
            int min = 0;
            int max = 999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiSau_2);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiSau_2.Text != lengthMax.ToString())
            {
                timerGiaiSau_2.Stop();
            }
            else
            {
                timerGiaiSau_2.Start();
            }
        }

        void giaiSau_3()
        {
            int min = 0;
            int max = 999;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiSau_3);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiSau_3.Text != lengthMax.ToString())
            {
                timerGiaiSau_3.Stop();
            }
            else
            {
                timerGiaiSau_3.Start();
            }
        }

        void giaiBay_1()
        {
            int min = 0;
            int max = 99;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBay_1);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBay_1.Text != lengthMax.ToString())
            {
                timerGiaiBay_1.Stop();
            }
            else
            {
                timerGiaiBay_1.Start();
            }
        }

        void giaiBay_2()
        {
            int min = 0;
            int max = 99;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBay_2);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBay_2.Text != lengthMax.ToString())
            {
                timerGiaiBay_2.Stop();
            }
            else
            {
                timerGiaiBay_2.Start();
            }
        }

        void giaiBay_3()
        {
            int min = 0;
            int max = 99;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBay_3);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBay_3.Text != lengthMax.ToString())
            {
                timerGiaiBay_3.Stop();
            }
            else
            {
                timerGiaiBay_3.Start();
            }
        }

        void giaiBay_4()
        {
            int min = 0;
            int max = 99;
            int NumberRandom = RandomNumber(min, max);
            int lengthMax = max.ToString().Length;
            string formatNumber = "#";
            for (int i = 0; i < lengthMax; i++)
            {
                formatNumber += "0";
            }
            var intList = NumberRandom.ToString(formatNumber).Select(digit => int.Parse(digit.ToString()));
            t = new Thread(GiaiBay_4);
            var lstNumRnd = new Number();
            lstNumRnd.Array = intList.ToArray();
            if (t.IsAlive)
            {
                t.Abort();

            }
            t.Start(lstNumRnd);
            if (lblGiaiBay_4.Text != lengthMax.ToString())
            {
                timerGiaiBay_4.Stop();
            }
            else
            {
                timerGiaiBay_4.Start();
            }
        }

        public string speartor(int number)
        {
            string result = "";
            for (int i = 0; i < number; i++)
            {
                result += "X";
            }
            return result;
        }

        public void GiaiDB(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiDB.BeginInvoke(new Action(() =>
                            {
                                lblGiaiDB.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiDB.BeginInvoke(new Action(() =>
                            {
                                lblGiaiDB.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiNhat(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiNhat.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNhat.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiNhat.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNhat.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiNhi_1(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiNhi_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNhi_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiNhi_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNhi_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiNhi_2(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiNhi_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNhi_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiNhi_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNhi_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBa_1(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBa_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBa_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBa_2(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBa_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBa_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBa_3(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBa_3.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_3.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBa_3.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_3.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBa_4(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBa_4.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_4.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBa_4.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_4.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBa_5(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBa_5.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_5.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBa_5.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_5.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBa_6(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBa_6.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_6.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBa_6.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBa_6.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBon_1(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBon_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBon_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBon_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBon_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBon_2(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBon_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBon_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBon_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBon_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBon_3(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBon_3.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBon_3.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBon_3.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBon_3.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBon_4(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBon_4.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBon_4.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBon_4.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBon_4.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiNam_1(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiNam_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiNam_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiNam_2(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiNam_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiNam_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiNam_3(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiNam_3.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_3.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiNam_3.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_3.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiNam_4(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiNam_4.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_4.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiNam_4.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_4.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiNam_5(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiNam_5.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_5.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiNam_5.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_5.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiNam_6(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiNam_6.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_6.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiNam_6.BeginInvoke(new Action(() =>
                            {
                                lblGiaiNam_6.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiSau_1(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiSau_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiSau_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiSau_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiSau_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiSau_2(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiSau_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiSau_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiSau_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiSau_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiSau_3(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiSau_3.BeginInvoke(new Action(() =>
                            {
                                lblGiaiSau_3.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiSau_3.BeginInvoke(new Action(() =>
                            {
                                lblGiaiSau_3.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBay_1(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBay_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBay_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBay_1.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBay_1.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBay_2(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBay_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBay_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBay_2.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBay_2.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBay_3(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBay_3.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBay_3.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBay_3.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBay_3.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }

        public void GiaiBay_4(object lstNumber)
        {
            Number list = (Number)lstNumber;
            int k = 1;
            string prefix = "";
            string nextFix = "";
            foreach (var item in list.Array)
            {
                int sp = list.Array.Length - k;
                prefix = speartor(sp);
                int timeSleep = 15;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == item)
                            {
                                k++;
                                nextFix += item;
                                prefix = speartor(list.Array.Length - k);
                                break;
                            }
                            lblGiaiBay_4.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBay_4.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            lblGiaiBay_4.BeginInvoke(new Action(() =>
                            {
                                lblGiaiBay_4.Text = nextFix + j + prefix;
                            }));

                            timeSleep += 6;
                            Thread.Sleep(timeSleep);
                        }
                    }

                }
            }
            t.Abort();
        }


        private void timerGiaiNhi_1_Tick(object sender, EventArgs e)
        {
            giaiNhi_1();
        }

        private void timerGiaiNhi_2_Tick(object sender, EventArgs e)
        {
            giaiNhi_2();
        }

        private void timerGiaiBa_1_Tick(object sender, EventArgs e)
        {
            giaiBa_1();
        }

        private void timerGiaiBa_2_Tick(object sender, EventArgs e)
        {
            giaiBa_2();
        }

        private void timerGiaiBa_3_Tick(object sender, EventArgs e)
        {
            giaiBa_3();
        }

        private void timerGiaiBa_4_Tick(object sender, EventArgs e)
        {
            giaiBa_4();
        }

        private void timerGiaiBa_5_Tick(object sender, EventArgs e)
        {
            giaiBa_5();
        }

        private void timerGiaiBa_6_Tick(object sender, EventArgs e)
        {
            giaiBa_6();
        }

        private void timerGiaiBon_1_Tick(object sender, EventArgs e)
        {
            giaiBon_1();
        }

        private void timerGiaiBon_2_Tick(object sender, EventArgs e)
        {
            giaiBon_2();
        }

        private void timerGiaiBon_3_Tick(object sender, EventArgs e)
        {
            giaiBon_3();
        }

        private void timerGiaiBon_4_Tick(object sender, EventArgs e)
        {
            giaiBon_4();
        }

        private void timerGiaiNam_1_Tick(object sender, EventArgs e)
        {
            giaiNam_1();
        }

        private void timerGiaiNam_2_Tick(object sender, EventArgs e)
        {
            giaiNam_2();
        }

        private void timerGiaiNam_3_Tick(object sender, EventArgs e)
        {
            giaiNam_3();
        }

        private void timerGiaiNam_4_Tick(object sender, EventArgs e)
        {
            giaiNam_4();
        }

        private void timerGiaiNam_5_Tick(object sender, EventArgs e)
        {
            giaiNam_5();
        }

        private void timerGiaiNam_6_Tick(object sender, EventArgs e)
        {
            giaiNam_6();
        }

        private void timerGiaiSau_1_Tick(object sender, EventArgs e)
        {
            giaiSau_1();
        }

        private void timerGiaiSau_2_Tick(object sender, EventArgs e)
        {
            giaiSau_2();
        }

        private void timerGiaiSau_3_Tick(object sender, EventArgs e)
        {
            giaiSau_3();
        }

        private void timerGiaiBay_1_Tick(object sender, EventArgs e)
        {
            giaiBay_1();
        }

        private void timerGiaiBay_2_Tick(object sender, EventArgs e)
        {
            giaiBay_2();
        }

        private void timerGiaiBay_3_Tick(object sender, EventArgs e)
        {
            giaiBay_3();
        }

        private void timerGiaiBay_4_Tick(object sender, EventArgs e)
        {
            giaiBay_4();
        }

        private void timerGiaiDB_Tick(object sender, EventArgs e)
        {
            giaiDB();
        }

        private void timerKetQua_Tick(object sender, EventArgs e)
        {
            pnlKiemTra.Enabled = true;
            pnlSave.Enabled = true;
        }

        private void timerlbltimer_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToShortTimeString();
        }


        private void btnKT_Click(object sender, EventArgs e)
        {
            

            if (txtKQ.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dãy số dự thưởng!", "Thông báo");
            }
            else
            {
                if (lblGiaiNhat.Text == txtKQ.Text)
                {
                    MessageBox.Show("Chúc mừng bạn đã trúng giải Nhất!", "Thông báo");
                }
                if (lblGiaiNhi_1.Text == txtKQ.Text || lblGiaiNhi_2.Text == txtKQ.Text)
                {
                    MessageBox.Show("Chúc mừng bạn đã trúng giải Nhì!", "Thông báo");
                }
                if (lblGiaiBa_1.Text == txtKQ.Text || lblGiaiBa_2.Text == txtKQ.Text
                    || lblGiaiBa_3.Text == txtKQ.Text || lblGiaiBa_4.Text == txtKQ.Text
                    || lblGiaiBa_5.Text == txtKQ.Text || lblGiaiBa_6.Text == txtKQ.Text)
                {
                    MessageBox.Show("Chúc mừng bạn đã trúng giải Ba!", "Thông báo");
                }
                if (lblGiaiBon_1.Text == txtKQ.Text || lblGiaiBon_2.Text == txtKQ.Text
                    || lblGiaiBon_3.Text == txtKQ.Text || lblGiaiBon_4.Text == txtKQ.Text)
                {
                    MessageBox.Show("Chúc mừng bạn đã trúng giải Bốn!", "Thông báo");
                }
                if (lblGiaiNam_1.Text == txtKQ.Text || lblGiaiNam_2.Text == txtKQ.Text
                    || lblGiaiNam_3.Text == txtKQ.Text || lblGiaiNam_4.Text == txtKQ.Text
                    || lblGiaiNam_5.Text == txtKQ.Text || lblGiaiNam_6.Text == txtKQ.Text)
                {
                    MessageBox.Show("Chúc mừng bạn đã trúng giải Năm!", "Thông báo");
                }
                if (lblGiaiSau_1.Text == txtKQ.Text || lblGiaiSau_2.Text == txtKQ.Text || lblGiaiSau_3.Text == txtKQ.Text)
                {
                    MessageBox.Show("Chúc mừng bạn đã trúng giải Sáu!", "Thông báo");
                }
                if (lblGiaiBay_1.Text == txtKQ.Text || lblGiaiBay_2.Text == txtKQ.Text
                    || lblGiaiBay_3.Text == txtKQ.Text || lblGiaiBay_4.Text == txtKQ.Text)
                {
                    MessageBox.Show("Chúc mừng bạn đã trúng giải Bảy!", "Thông báo");
                }
                if (lblGiaiDB.Text == txtKQ.Text)
                {
                    MessageBox.Show("Chúc mừng bạn đã trúng giải Đặc Biệt!", "Thông báo");
                }
                if (lblGiaiNhat.Text != txtKQ.Text && lblGiaiNhi_1.Text != txtKQ.Text && lblGiaiNhi_2.Text != txtKQ.Text
                    && lblGiaiBa_1.Text != txtKQ.Text && lblGiaiBa_2.Text != txtKQ.Text && lblGiaiBa_3.Text != txtKQ.Text
                    && lblGiaiBa_4.Text != txtKQ.Text && lblGiaiBa_5.Text != txtKQ.Text && lblGiaiBa_6.Text != txtKQ.Text
                    && lblGiaiBon_1.Text != txtKQ.Text && lblGiaiBon_2.Text != txtKQ.Text && lblGiaiBon_3.Text != txtKQ.Text
                    && lblGiaiBon_4.Text != txtKQ.Text && lblGiaiNam_1.Text != txtKQ.Text && lblGiaiNam_2.Text != txtKQ.Text
                    && lblGiaiNam_3.Text != txtKQ.Text && lblGiaiNam_4.Text != txtKQ.Text && lblGiaiNam_5.Text != txtKQ.Text
                    && lblGiaiNam_6.Text != txtKQ.Text && lblGiaiSau_1.Text != txtKQ.Text && lblGiaiSau_2.Text != txtKQ.Text
                    && lblGiaiSau_3.Text != txtKQ.Text && lblGiaiBay_1.Text != txtKQ.Text && lblGiaiBay_2.Text != txtKQ.Text
                    && lblGiaiBay_3.Text != txtKQ.Text && lblGiaiBay_4.Text != txtKQ.Text && lblGiaiDB.Text != txtKQ.Text && txtKQ.Text != "")
                {
                    MessageBox.Show("Chúc bạn may mắn lần sau.", "Thông báo");
                }
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dt = dtNgayXo.Text;
            string fileName = ("KQXS-"+dt);
            string path = (@"D:\LTWINDOWS\XSKT_Phap\KQ\"+fileName+".txt");
            StreamWriter write = new StreamWriter(path);
            write.WriteLine("Ngày xổ: " + dtNgayXo.Text);
            write.WriteLine("Giải Đặc Biệt: " + lblGiaiDB.Text);
            write.WriteLine("Giải Nhất: " + lblGiaiNhat.Text);
            write.WriteLine("Giải Nhì: " + lblGiaiNhi_1.Text + "\t" + lblGiaiNhi_2.Text);
            write.WriteLine("Giải Ba: " + lblGiaiBa_1.Text + "\t" + lblGiaiBa_2.Text + "\t" + lblGiaiBa_3.Text
                                + "\t" + lblGiaiBa_4.Text + "\t" + lblGiaiBa_5.Text + "\t" + lblGiaiBa_6.Text);
            write.WriteLine("Giải Bốn: " + lblGiaiBon_1.Text + "\t" + lblGiaiBon_2.Text + "\t" + lblGiaiBon_3.Text + "\t" + lblGiaiBon_4.Text);
            write.WriteLine("Giải Năm: " + lblGiaiNam_1.Text + "\t" + lblGiaiNam_2.Text + "\t" + lblGiaiNam_3.Text
                                + "\t" + lblGiaiNam_4.Text + "\t" + lblGiaiNam_5.Text + "\t" + lblGiaiNam_6.Text);
            write.WriteLine("Giải Sáu: " + lblGiaiSau_1.Text + "\t" + lblGiaiSau_2.Text + "\t" + lblGiaiSau_3.Text);
            write.WriteLine("Giải Bảy: " + lblGiaiBay_1.Text + "\t" + lblGiaiBay_2.Text + "\t" + lblGiaiBay_3.Text + "\t" + lblGiaiBay_4.Text);
            write.Close();
        }

        
    }
}
