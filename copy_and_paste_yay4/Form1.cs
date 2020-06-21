using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace copy_and_paste_yay4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Properties.Settings.Default.ButtonKind = 1;
            InitializeComponent();
        }

        void Load1()
        {
            if (Properties.Settings.Default.ButtonKind == 1)
            {
                button1.BackColor = Color.DeepSkyBlue;
                button2.BackColor = Color.DarkGray;
                button3.BackColor = Color.DarkGray;


                button4.Text = Properties.Settings.Default.Title1;
                button5.Text = Properties.Settings.Default.Title2;
                button6.Text = Properties.Settings.Default.Title3;
                button7.Text = Properties.Settings.Default.Title4;
                button8.Text = Properties.Settings.Default.Title5;
                button9.Text = Properties.Settings.Default.Title6;
                button10.Text = Properties.Settings.Default.Title7;
                button11.Text = Properties.Settings.Default.Title8;
            }
            else if(Properties.Settings.Default.ButtonKind == 2)
            {
                button1.BackColor = Color.DarkGray;
                button2.BackColor = Color.DeepSkyBlue;
                button3.BackColor = Color.DarkGray;


                button4.Text = Properties.Settings.Default.Title9;
                button5.Text = Properties.Settings.Default.Title10;
                button6.Text = Properties.Settings.Default.Title11;
                button7.Text = Properties.Settings.Default.Title12;
                button8.Text = Properties.Settings.Default.Title13;
                button9.Text = Properties.Settings.Default.Title14;
                button10.Text = Properties.Settings.Default.Title15;
                button11.Text = Properties.Settings.Default.Title16;
            }
            else if (Properties.Settings.Default.ButtonKind == 3)
            {
                button1.BackColor = Color.DarkGray;
                button2.BackColor = Color.DarkGray;
                button3.BackColor = Color.DeepSkyBlue;


                button4.Text = Properties.Settings.Default.Title17;
                button5.Text = Properties.Settings.Default.Title18;
                button6.Text = Properties.Settings.Default.Title19;
                button7.Text = Properties.Settings.Default.Title20;
                button8.Text = Properties.Settings.Default.Title21;
                button9.Text = Properties.Settings.Default.Title22;
                button10.Text = Properties.Settings.Default.Title23;
                button11.Text = Properties.Settings.Default.Title24;
            }
            button1.Text = Properties.Settings.Default.TabName1;
            button2.Text = Properties.Settings.Default.TabName2;
            button3.Text = Properties.Settings.Default.TabName3;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 1;
            
            //左クリックの場合
            if(e.Button.ToString() == "Left")
            {
                //tab1の時
                if(Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents1);
                }
                //tab2
                else if(Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents9);
                }
                //tab3
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents17);
                }
            }
            //右クリックの場合
            else if(e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 2;

            //左クリックの場合
            if (e.Button.ToString() == "Left")
            {
                //tab1の時
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents2);
                }
                //tab2
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents20);
                }
                //tab3
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents18);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }

        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 3;

            //左クリックの場合
            if (e.Button.ToString() == "Left")
            {
                //tab1の時
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents3);
                }
                //tab2
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents11);
                }
                //tab3
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents19);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 4;

            //左クリックの場合
            if (e.Button.ToString() == "Left")
            {
                //tab1の時
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents4);
                }
                //tab2
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents12);
                }
                //tab3
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents20);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 5;

            //左クリックの場合
            if (e.Button.ToString() == "Left")
            {
                //tab1の時
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents5);
                }
                //tab2
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents13);
                }
                //tab3
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 6;

            //左クリックの場合
            if (e.Button.ToString() == "Left")
            {
                //tab1の時
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents6);
                }
                //tab2
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents14);
                }
                //tab3
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents22);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 7;

            //左クリックの場合
            if (e.Button.ToString() == "Left")
            {
                //tab1の時
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents7);
                }
                //tab2
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents15);
                }
                //tab3
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents23);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 8;

            //左クリックの場合
            if (e.Button.ToString() == "Left")
            {
                //tab1の時
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents8);
                }
                //tab2
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents16);
                }
                //tab3
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Contents24);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //TOPがアクティブになったときに、更新(Load）
            Load1();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button.ToString() == "Left")
            {
                Properties.Settings.Default.ButtonKind = 1;
                Load1();
            }
            else if(e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                Properties.Settings.Default.ButtonKind = 2;
                Load1();
            }
            else if (e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                Properties.Settings.Default.ButtonKind = 3;
                Load1();
            }
            else if (e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }
    }
}
