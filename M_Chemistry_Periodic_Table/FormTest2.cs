using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M_Chemistry_Periodic_Table
{
    public partial class FormTest2 : Form
    {
        
        Random r;
        Button[] btn;
        Form1 f1;
        FormStart fs;
        Label l;
        Label l2;
        PictureBox pr, pw;
        TextBox t,tr,tw;

        int i,j,x=0,y=0;
        bool flag,check;


        public FormTest2(Button[] btn, Form1 f1, FormStart fs )
        {
            this.btn = btn;
            this.f1 = f1;
            this.fs = fs;
           
            

            InitializeComponent();
        }

        private void FormTest2_Load(object sender, EventArgs e)
        {
            t = new TextBox();
            t.Location = new Point(659, 65);
            t.Size = new Size(75, 70);
            t.Font = new Font("Impact", 21);
            t.TabStop = false;
            t.TextAlign = HorizontalAlignment.Center;

            rand();

            new ButtonCreate(btn, f1, this);   //to get all components of form1

            tr = new TextBox();
            tr.Location = new Point(439, 160);
            tr.Size = new Size(75, 70);
            tr.Font = new Font("Impact", 21);
            tr.TabStop = false;
            tr.TextAlign = HorizontalAlignment.Center;
            tr.ReadOnly = true;
            tr.BackColor = Color.White;


            tw = new TextBox();
            tw.Location = new Point(659, 160);
            tw.Size = new Size(75, 70);
            tw.Font = new Font("Impact", 21);
            tw.TabStop = false;
            tw.TextAlign = HorizontalAlignment.Center;
            tw.ReadOnly = true;
            tw.BackColor = Color.White;

            pr = new PictureBox();
            pr.Location = new Point(365, 150);
            pr.Size = new Size(65, 62);
            pr.SizeMode = PictureBoxSizeMode.StretchImage;
            pr.Image = M_Chemistry_Periodic_Table.Properties.Resources.tick;

            pw = new PictureBox();
            pw.Location = new Point(585, 150);
            pw.Size = new Size(65, 62);
            pw.SizeMode = PictureBoxSizeMode.StretchImage;
            pw.Image = M_Chemistry_Periodic_Table.Properties.Resources.cross;



            l = new Label();
            l.Location = new Point(335, 65);
            l.Size = new Size(320, 70);
            l.Font = new Font("Impact", 22);
            l.Text = "Which one Atomic no. is :";


          
            l2 = new Label();
            l2.Location = new Point(750, 52);
            l2.Size = new Size(180, 70);
            l2.Font = new Font("Impact", 26);
            l2.TextAlign = ContentAlignment.MiddleLeft;


            this.Controls.Add(l);
            this.Controls.Add(l2);
            this.Controls.Add(t);
            this.Controls.Add(pr);
            this.Controls.Add(pw);
            this.Controls.Add(tr);
            this.Controls.Add(tw);


            this.Disposed += new EventHandler(FormTest2_Disposed);

            for (i = 1; i <= 118; i++)
            {
                this.btn[i].Click += new System.EventHandler(this.buttonClick);
            }
        }

       

        void FormTest2_Disposed(object sender, EventArgs e)
        {
            fs.Show();
            
        }

        public void buttonClick(object sender, EventArgs e)
        {


            if (
                (sender.Equals(btn[1]) && t.Text.Equals("1")) ||
                (sender.Equals(btn[2]) && t.Text.Equals("2")) ||
                (sender.Equals(btn[3]) && t.Text.Equals("3")) ||
                (sender.Equals(btn[4]) && t.Text.Equals("4")) ||
                (sender.Equals(btn[5]) && t.Text.Equals("5")) ||
                (sender.Equals(btn[6]) && t.Text.Equals("6")) ||
                (sender.Equals(btn[7]) && t.Text.Equals("7")) ||
                (sender.Equals(btn[8]) && t.Text.Equals("8")) ||
                (sender.Equals(btn[9]) && t.Text.Equals("9")) ||
                (sender.Equals(btn[10]) && t.Text.Equals("10")) ||

                (sender.Equals(btn[11]) && t.Text.Equals("11")) ||
                (sender.Equals(btn[12]) && t.Text.Equals("12")) ||
                (sender.Equals(btn[13]) && t.Text.Equals("13")) ||
                (sender.Equals(btn[14]) && t.Text.Equals("14")) ||
                (sender.Equals(btn[15]) && t.Text.Equals("15")) ||
                (sender.Equals(btn[16]) && t.Text.Equals("16")) ||
                (sender.Equals(btn[17]) && t.Text.Equals("17")) ||
                (sender.Equals(btn[18]) && t.Text.Equals("18")) ||
                (sender.Equals(btn[19]) && t.Text.Equals("19")) ||
                (sender.Equals(btn[20]) && t.Text.Equals("20")) ||

                (sender.Equals(btn[21]) && t.Text.Equals("21")) ||
                (sender.Equals(btn[22]) && t.Text.Equals("22")) ||
                (sender.Equals(btn[23]) && t.Text.Equals("23")) ||
                (sender.Equals(btn[24]) && t.Text.Equals("24")) ||
                (sender.Equals(btn[25]) && t.Text.Equals("25")) ||
                (sender.Equals(btn[26]) && t.Text.Equals("26")) ||
                (sender.Equals(btn[27]) && t.Text.Equals("27")) ||
                (sender.Equals(btn[28]) && t.Text.Equals("28")) ||
                (sender.Equals(btn[29]) && t.Text.Equals("29")) ||
                (sender.Equals(btn[30]) && t.Text.Equals("30")) ||

                (sender.Equals(btn[31]) && t.Text.Equals("31")) ||
                (sender.Equals(btn[32]) && t.Text.Equals("32")) ||
                (sender.Equals(btn[33]) && t.Text.Equals("33")) ||
                (sender.Equals(btn[34]) && t.Text.Equals("34")) ||
                (sender.Equals(btn[35]) && t.Text.Equals("35")) ||
                (sender.Equals(btn[36]) && t.Text.Equals("36")) ||
                (sender.Equals(btn[37]) && t.Text.Equals("37")) ||
                (sender.Equals(btn[38]) && t.Text.Equals("38")) ||
                (sender.Equals(btn[39]) && t.Text.Equals("39")) ||
                (sender.Equals(btn[40]) && t.Text.Equals("40")) ||

                (sender.Equals(btn[41]) && t.Text.Equals("41")) ||
                (sender.Equals(btn[42]) && t.Text.Equals("42")) ||
                (sender.Equals(btn[43]) && t.Text.Equals("43")) ||
                (sender.Equals(btn[44]) && t.Text.Equals("44")) ||
                (sender.Equals(btn[45]) && t.Text.Equals("45")) ||
                (sender.Equals(btn[46]) && t.Text.Equals("46")) ||
                (sender.Equals(btn[47]) && t.Text.Equals("47")) ||
                (sender.Equals(btn[48]) && t.Text.Equals("48")) ||
                (sender.Equals(btn[49]) && t.Text.Equals("49")) ||
                (sender.Equals(btn[50]) && t.Text.Equals("50")) ||

                (sender.Equals(btn[51]) && t.Text.Equals("51")) ||
                (sender.Equals(btn[52]) && t.Text.Equals("52")) ||
                (sender.Equals(btn[53]) && t.Text.Equals("53")) ||
                (sender.Equals(btn[54]) && t.Text.Equals("54")) ||
                (sender.Equals(btn[55]) && t.Text.Equals("55")) ||
                (sender.Equals(btn[56]) && t.Text.Equals("56")) ||
                (sender.Equals(btn[57]) && t.Text.Equals("57")) ||
                (sender.Equals(btn[58]) && t.Text.Equals("58")) ||
                (sender.Equals(btn[59]) && t.Text.Equals("59")) ||
                (sender.Equals(btn[60]) && t.Text.Equals("60")) ||

                (sender.Equals(btn[61]) && t.Text.Equals("61")) ||
                (sender.Equals(btn[62]) && t.Text.Equals("62")) ||
                (sender.Equals(btn[63]) && t.Text.Equals("63")) ||
                (sender.Equals(btn[64]) && t.Text.Equals("64")) ||
                (sender.Equals(btn[65]) && t.Text.Equals("65")) ||
                (sender.Equals(btn[66]) && t.Text.Equals("66")) ||
                (sender.Equals(btn[67]) && t.Text.Equals("67")) ||
                (sender.Equals(btn[68]) && t.Text.Equals("68")) ||
                (sender.Equals(btn[69]) && t.Text.Equals("69")) ||
                (sender.Equals(btn[70]) && t.Text.Equals("70")) ||

                (sender.Equals(btn[71]) && t.Text.Equals("71")) ||
                (sender.Equals(btn[72]) && t.Text.Equals("72")) ||
                (sender.Equals(btn[73]) && t.Text.Equals("73")) ||
                (sender.Equals(btn[74]) && t.Text.Equals("74")) ||
                (sender.Equals(btn[75]) && t.Text.Equals("75")) ||
                (sender.Equals(btn[76]) && t.Text.Equals("76")) ||
                (sender.Equals(btn[77]) && t.Text.Equals("77")) ||
                (sender.Equals(btn[78]) && t.Text.Equals("78")) ||
                (sender.Equals(btn[79]) && t.Text.Equals("79")) ||
                (sender.Equals(btn[80]) && t.Text.Equals("80")) ||

                (sender.Equals(btn[81]) && t.Text.Equals("81")) ||
                (sender.Equals(btn[82]) && t.Text.Equals("82")) ||
                (sender.Equals(btn[83]) && t.Text.Equals("83")) ||
                (sender.Equals(btn[84]) && t.Text.Equals("84")) ||
                (sender.Equals(btn[85]) && t.Text.Equals("85")) ||
                (sender.Equals(btn[86]) && t.Text.Equals("86")) ||
                (sender.Equals(btn[87]) && t.Text.Equals("87")) ||
                (sender.Equals(btn[88]) && t.Text.Equals("88")) ||
                (sender.Equals(btn[89]) && t.Text.Equals("89")) ||
                (sender.Equals(btn[90]) && t.Text.Equals("90")) ||

                (sender.Equals(btn[91]) && t.Text.Equals("91")) ||
                (sender.Equals(btn[92]) && t.Text.Equals("92")) ||
                (sender.Equals(btn[93]) && t.Text.Equals("93")) ||
                (sender.Equals(btn[94]) && t.Text.Equals("94")) ||
                (sender.Equals(btn[95]) && t.Text.Equals("95")) ||
                (sender.Equals(btn[96]) && t.Text.Equals("96")) ||
                (sender.Equals(btn[97]) && t.Text.Equals("97")) ||
                (sender.Equals(btn[98]) && t.Text.Equals("98")) ||
                (sender.Equals(btn[99]) && t.Text.Equals("99")) ||
                (sender.Equals(btn[100]) && t.Text.Equals("100")) ||

                (sender.Equals(btn[101]) && t.Text.Equals("101")) ||
                (sender.Equals(btn[102]) && t.Text.Equals("102")) ||
                (sender.Equals(btn[103]) && t.Text.Equals("103")) ||
                (sender.Equals(btn[104]) && t.Text.Equals("104")) ||
                (sender.Equals(btn[105]) && t.Text.Equals("105")) ||
                (sender.Equals(btn[106]) && t.Text.Equals("106")) ||
                (sender.Equals(btn[107]) && t.Text.Equals("107")) ||
                (sender.Equals(btn[108]) && t.Text.Equals("108")) ||
                (sender.Equals(btn[109]) && t.Text.Equals("109")) ||
                (sender.Equals(btn[110]) && t.Text.Equals("110")) ||

                (sender.Equals(btn[111]) && t.Text.Equals("111")) ||
                (sender.Equals(btn[112]) && t.Text.Equals("112")) ||
                (sender.Equals(btn[113]) && t.Text.Equals("113")) ||
                (sender.Equals(btn[114]) && t.Text.Equals("114")) ||
                (sender.Equals(btn[115]) && t.Text.Equals("115")) ||
                (sender.Equals(btn[116]) && t.Text.Equals("116")) ||
                (sender.Equals(btn[117]) && t.Text.Equals("117")) ||
                (sender.Equals(btn[118]) && t.Text.Equals("118"))

                )
            {
                timer1.Enabled = true;
                flag = true;
                check = true;
                j = 0;
            }

            else
            {
                timer1.Enabled = true;
                flag = false;
                check = true;
                j = 0;
            }
            rand();
        }

        private void rand()
        {
            r = new Random();
            int k = r.Next(1, 118);
            t.Text = k.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (flag == true)
            {
                l2.Text = "Success";
                l2.ForeColor = Color.Green;
                if (j > 12)
                {
                    l2.Text = null;
                    timer1.Enabled = false;
                }
                ++j;
                if (check == true)
                {
                    ++x;
                    tr.Text = x.ToString();
                }
                check = false;
            }
            else
            {
                l2.Text = "Fail";
                l2.ForeColor = Color.Red;
                if (j > 12)
                {
                    l2.Text = null;
                    timer1.Enabled = false;
                }
                ++j;
                if (check == true)
                {
                    ++y;
                    tw.Text = y.ToString();
                }

                check = false;
            }
        }
    }
}

