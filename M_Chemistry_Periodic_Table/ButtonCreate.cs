using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;
using System.Resources;

namespace M_Chemistry_Periodic_Table
{
    class ButtonCreate
    {

        public ButtonCreate(Button[] btn, Form1 f1, Form f)
        {

            Label[] lblc = new Label[11];
          

            for (int m = 1; m <= 10; m++)
            {
                lblc[m] = new Label();
                lblc[m].Size = new Size(116, 28);

                if (m == 1)
                {
                    lblc[m].Location = new Point(73, 550);
                }

                if (m == 2)
                {
                    lblc[m].Location = new Point(204, 550);
                }
                if (m == 3)
                {
                    lblc[m].Location = new Point(73, 581);
                }
                if (m == 4)
                {
                    lblc[m].Location = new Point(204, 581);
                }
                if (m == 5)
                {
                    lblc[m].Location = new Point(73, 612);
                }
                if (m == 6)
                {
                    lblc[m].Location = new Point(204, 612);
                }
                if (m == 7)
                {
                    lblc[m].Location = new Point(73, 643);
                }
                if (m == 8)
                {
                    lblc[m].Location = new Point(204, 643);
                }
                if (m == 9)
                {
                    lblc[m].Location = new Point(73, 674);
                }
                if (m == 10)
                {
                    lblc[m].Location = new Point(204, 674);
                }


                

                f1.Controls.Add(lblc[m]);
                f.Controls.Add(lblc[m]);

                lblc[m].TextAlign = ContentAlignment.MiddleCenter;
                lblc[m].Font = new Font("Microsoft Sans Serif", 10);
                lblc[m].ForeColor = Color.White;

            }
            lblc[1].Text = "Alkali metals";
            lblc[1].BackColor = Color.Gray;

            lblc[2].Text = "Alkaline metals";
            lblc[2].BackColor = Color.DimGray;

            lblc[3].Text = "Semimetallics";
            lblc[3].BackColor = Color.MediumPurple;

            lblc[4].Text = "Post-transition";
            lblc[4].BackColor = Color.BlueViolet;

            lblc[5].Text = "Other Nonmetals";
            lblc[5].BackColor = Color.DarkTurquoise;

            lblc[6].Text = "Halogens";
            lblc[6].BackColor = Color.DeepSkyBlue;

            lblc[7].Text = "Lanthanides";
            lblc[7].BackColor = Color.CornflowerBlue;

            lblc[8].Text = "Actinides";
            lblc[8].BackColor = Color.RoyalBlue;

            lblc[9].Text = "Transition metals";
            lblc[9].BackColor = Color.Navy;

            lblc[10].Text = "Noble Gases";
            lblc[10].BackColor = Color.Black;



            for (int i = 1; i <= 2; i++)
            {
                btn[i] = new Button();
                btn[i].Size = new Size(65, 65);
                btn[i].Font = new Font("Impact", 18);

                f1.btn[i].Click += new System.EventHandler(f1.buttonClick);         //Registration between source(Button) & Listener(Method)

                f1.btn[i].TabStop = false;
                f.Controls.Add(btn[i]);
            }

            btn[1].Location = new Point(70, 55);
            btn[2].Location = new Point(1226, 55);                        //1st row end
      
            for (int i = 3; i <= 18; i++)
            {
                btn[i] = new Button();
                btn[i].Size = new Size(65, 65);
                btn[i].Font = new Font("Impact", 18);

                f1.btn[i].Click += new System.EventHandler(f1.buttonClick);         //Registration between source(Button) & Listener(Method)

                if (i == 3)
                    btn[i].Location = new Point(70, 123);

                if (i == 4)
                    btn[i].Location = new Point(138, 123);

                if (i >= 5 && i <= 10)
                    btn[i].Location = new Point(546 + i * 68, 123);            //2nd row end//Make 1226

                if (i == 11)
                    btn[i].Location = new Point(70, 191);

                if (i == 12)
                    btn[i].Location = new Point(138, 191);

                if (i >= 13 && i <= 18)
                    btn[i].Location = new Point(2 + i * 68, 191);       // 3rd row end

                f1.btn[i].TabStop = false;

                f.Controls.Add(btn[i]);
            }


            for (int i = 19; i <= 118; i++)
            {
                btn[i] = new Button();
                btn[i].Size = new Size(65, 65);

                btn[i].Font = new Font("Impact", 18);

                f1.btn[i].Click += new System.EventHandler(f1.buttonClick);         //Registration between source(Button) & Listener(Method)


                if (i >= 19 && i <= 36)
                {
                    btn[i].Location = new Point((-1222) + i * 68, 259);       // 4th row end
                }

                if (i >= 37 && i <= 54)
                {
                    btn[i].Location = new Point((-2446) + i * 68, 327);        // 5th row end
                }

                if ((i >= 55 && i <= 57))
                {
                    btn[i].Location = new Point((-3670) + i * 68, 395);
                }

                if ((i >= 72 && i <= 86))
                {
                    btn[i].Location = new Point((-4622) + i * 68, 395);         // 6th row end
                }

                if ((i >= 87 && i <= 89))
                {
                    btn[i].Location = new Point((-5846) + i * 68, 463);
                }

                if (i >= 104 && i <= 118)
                {
                    btn[i].Location = new Point((-6798) + i * 68, 463);         // 7th row end
                }

                if (i >= 58 && i <= 71)
                {
                    btn[i].Location = new Point((-3602) + i * 68, 561);         // 8th row end
                    btn[i].ForeColor = Color.CornflowerBlue;
                }

                if (i >= 90 && i <= 103)
                {
                    btn[i].Location = new Point((-5778) + i * 68, 629);         // 9th row end
                    btn[i].ForeColor = Color.RoyalBlue;
                }

                if (i >= 21 && i <= 30)
                {
                    btn[i].ForeColor = Color.Navy;
                }
                if (i >= 39 && i <= 48)
                {
                    btn[i].ForeColor = Color.Navy;
                }
                if (i >= 72 && i <= 80)
                {
                    btn[i].ForeColor = Color.Navy;
                }
                if (i >= 104 && i <= 118)
                {
                    btn[i].ForeColor = Color.Navy;
                }

                f1.btn[i].TabStop = false ;

                f.Controls.Add(btn[i]);
            }

            btn[1].Text = "H";
            btn[1].ForeColor = Color.DarkTurquoise;
            btn[2].Text = "He";
            btn[2].ForeColor = Color.Black;
            btn[3].Text = "Li";
            btn[3].ForeColor = Color.Gray;
            btn[4].Text = "Be";
            btn[4].ForeColor = Color.DimGray;
            btn[5].Text = "B";
            btn[5].ForeColor = Color.MediumPurple;
            btn[6].Text = "C";
            btn[6].ForeColor = Color.DarkTurquoise;
            btn[7].Text = "N";
            btn[7].ForeColor = Color.DarkTurquoise;
            btn[8].Text = "O";
            btn[8].ForeColor = Color.DarkTurquoise;
            btn[9].Text = "F";
            btn[9].ForeColor = Color.DeepSkyBlue;
            btn[10].Text = "Ne";
            btn[10].ForeColor = Color.Black;
            btn[11].Text = "Na";
            btn[11].ForeColor = Color.Gray;
            btn[12].Text = "Mg";
            btn[12].ForeColor = Color.DimGray;
            btn[13].Text = "Al";
            btn[13].ForeColor = Color.BlueViolet;
            btn[14].Text = "Si";
            btn[14].ForeColor = Color.MediumPurple;
            btn[15].Text = "P";
            btn[15].ForeColor = Color.DarkTurquoise;
            btn[16].Text = "S";
            btn[16].ForeColor = Color.DarkTurquoise;
            btn[17].Text = "Cl";
            btn[17].ForeColor = Color.DeepSkyBlue;
            btn[18].Text = "Ar";
            btn[18].ForeColor = Color.Black;
            btn[19].Text = "K";
            btn[19].ForeColor = Color.Gray;
            btn[20].Text = "Ca";
            btn[20].ForeColor = Color.DimGray;
            btn[21].Text = "Sc";
            btn[22].Text = "Ti";
            btn[23].Text = "V";
            btn[24].Text = "Cr";
            btn[25].Text = "Mn";
            btn[26].Text = "Fe";
            btn[27].Text = "Co";
            btn[28].Text = "Ni";
            btn[29].Text = "Cu";
            btn[30].Text = "Zn";
            btn[31].Text = "Ga";
            btn[31].ForeColor = Color.BlueViolet;
            btn[32].Text = "Ge";
            btn[32].ForeColor = Color.MediumPurple;
            btn[33].Text = "As";
            btn[33].ForeColor = Color.MediumPurple;
            btn[34].Text = "Se";
            btn[34].ForeColor = Color.DarkTurquoise;
            btn[35].Text = "Br";
            btn[35].ForeColor = Color.DeepSkyBlue;
            btn[36].Text = "Kr";
            btn[36].ForeColor = Color.Black;
            btn[37].Text = "Rb";
            btn[37].ForeColor = Color.Gray;
            btn[38].Text = "Sr";
            btn[38].ForeColor = Color.DimGray;
            btn[39].Text = "Y";
            btn[40].Text = "Zr";
            btn[41].Text = "Nb";
            btn[42].Text = "Mo";
            btn[43].Text = "Tc";
            btn[44].Text = "Ru";
            btn[45].Text = "Rh";
            btn[46].Text = "Pd";
            btn[47].Text = "Ag";
            btn[48].Text = "Cd";
            btn[49].Text = "In";
            btn[49].ForeColor = Color.BlueViolet;
            btn[50].Text = "Sn";
            btn[50].ForeColor = Color.BlueViolet;
            btn[51].Text = "Sb";
            btn[51].ForeColor = Color.MediumPurple;
            btn[52].Text = "Te";
            btn[52].ForeColor = Color.MediumPurple;
            btn[53].Text = "I";
            btn[53].ForeColor = Color.DeepSkyBlue;
            btn[54].Text = "Xe";
            btn[54].ForeColor = Color.Black;
            btn[55].Text = "Cs";
            btn[55].ForeColor = Color.Gray;
            btn[56].Text = "Ba";
            btn[56].ForeColor = Color.DimGray;
            btn[57].Text = "La";
            btn[57].ForeColor = Color.CornflowerBlue;
            btn[58].Text = "Ce";
            btn[59].Text = "Pr";
            btn[60].Text = "Nd";
            btn[61].Text = "Pm";
            btn[62].Text = "Sm";
            btn[63].Text = "Eu";
            btn[64].Text = "Gd";
            btn[65].Text = "Tb";
            btn[66].Text = "Dy";
            btn[67].Text = "Ho";
            btn[68].Text = "Er";
            btn[69].Text = "Tm";
            btn[70].Text = "Yb";
            btn[71].Text = "Lu";
            btn[72].Text = "Hf";
            btn[73].Text = "Ta";
            btn[74].Text = "W";
            btn[75].Text = "Re";
            btn[76].Text = "Os";
            btn[77].Text = "Ir";
            btn[78].Text = "Pt";
            btn[79].Text = "Au";
            btn[80].Text = "Hg";
            btn[81].Text = "Tl";
            btn[81].ForeColor = Color.BlueViolet;
            btn[82].Text = "Pb";
            btn[82].ForeColor = Color.BlueViolet;
            btn[83].Text = "Bi";
            btn[83].ForeColor = Color.BlueViolet;
            btn[84].Text = "Po";
            btn[84].ForeColor = Color.MediumPurple;
            btn[85].Text = "At";
            btn[85].ForeColor = Color.DeepSkyBlue;
            btn[86].Text = "Rn";
            btn[86].ForeColor = Color.Black;
            btn[87].Text = "Fr";
            btn[87].ForeColor = Color.Gray;
            btn[88].Text = "Ra";
            btn[88].ForeColor = Color.DimGray;
            btn[89].Text = "Ac";
            btn[89].ForeColor = Color.RoyalBlue;
            btn[90].Text = "Th";
            btn[91].Text = "Pa";
            btn[92].Text = "U";
            btn[93].Text = "Np";
            btn[94].Text = "Pu";
            btn[95].Text = "Am";
            btn[96].Text = "Cm";
            btn[97].Text = "Bk";
            btn[98].Text = "Cf";
            btn[99].Text = "Es";
            btn[100].Text = "Fm";
            btn[101].Text = "Md";
            btn[102].Text = "No";
            btn[103].Text = "Lr";
            btn[104].Text = "Rf";
            btn[105].Text = "Db";
            btn[106].Text = "Sg";
            btn[107].Text = "Bh";
            btn[108].Text = "Hs";
            btn[109].Text = "Mt";
            btn[110].Text = "Ds";
            btn[111].Text = "Rg";
            btn[112].Text = "Cn";
            btn[113].Text = "Uut";
            btn[114].Text = "Fl";
            btn[115].Text = "Uup";
            btn[116].Text = "Lv";
            btn[117].Text = "Uus";
            btn[118].Text = "Uuo";


        }
    }
}
