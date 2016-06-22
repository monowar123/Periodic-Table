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
using System.IO;



namespace M_Chemistry_Periodic_Table
{

    public partial class Form1 : Form
    {
        public Button[] btn;
        Label lbl1 = new Label();
        PictureBox picb1 = new PictureBox();
        FormStart fs;
        CheckBox ch = new CheckBox();
        

        ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
        SoundPlayer gas, metal, liquid, r_active,nonmtl;
        


        public Form1(Button[] btn, FormStart fs)
        {
            this.btn = btn;
            this.fs = fs;
            
            
           

            InitializeComponent();
        }

     private void Form1_Load(object sender, EventArgs e)
        {
        

            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.Disposed += new EventHandler(Form1_Disposed);
            

            lbl1.Size = new System.Drawing.Size(300, 140);
            lbl1.Location = new System.Drawing.Point(285, 70);
            lbl1.Font = new System.Drawing.Font("Rockwell", 15,FontStyle.Bold );

            picb1.Size = new System.Drawing.Size(275, 220);
            picb1.Location = new System.Drawing.Point(565, 20);
            picb1.SizeMode = PictureBoxSizeMode.CenterImage;

           ch.Location = new Point(1235, 20);
            //ch.Location = new Point(73,527);
            ch.Text = "Mute";
            
            
            this.Controls.Add(lbl1);
            this.Controls.Add(picb1);
            this.Controls.Add(ch);


            new ButtonCreate(btn, this, this);

        }

        void Form1_Disposed(object sender, EventArgs e)
        {
            fs.Show();
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            lbl1.Text = null;
            picb1.Image = null;
           
        }


        public void buttonClick(object sender, EventArgs e)
        {
            int i;
    
            {

                gas = new SoundPlayer(M_Chemistry_Periodic_Table.Properties.Resources.gas);
                liquid = new SoundPlayer(M_Chemistry_Periodic_Table.Properties.Resources.liquid);
                metal = new SoundPlayer(M_Chemistry_Periodic_Table.Properties.Resources.metal);
                r_active = new SoundPlayer(M_Chemistry_Periodic_Table.Properties.Resources.r_active);
                nonmtl = new SoundPlayer(M_Chemistry_Periodic_Table.Properties.Resources.nonmtl);
            }


            if(ch.Checked==false)
            {
                if (sender.Equals(btn[1]) || sender.Equals(btn[2]) || sender.Equals(btn[7]) || sender.Equals(btn[8]) ||
                    sender.Equals(btn[9]) || sender.Equals(btn[10]) || sender.Equals(btn[17]) || sender.Equals(btn[18]) ||
                    sender.Equals(btn[36]) || sender.Equals(btn[54]) || sender.Equals(btn[86]))
                {

                    gas.Play();

                }

                for (i = 3; i <= 5; i++)
                {

                    if (sender.Equals(btn[i]))
                    {
                        metal.Play();
                    }
                }


                if (sender.Equals(btn[6]))
                {
                    nonmtl.Play();
                }


                for (i = 11; i <= 14; i++)
                {

                    if (sender.Equals(btn[i]))
                    {
                        metal.Play();
                    }
                }

                for (i = 15; i <= 16; i++)
                {

                    if (sender.Equals(btn[i]))
                    {
                        nonmtl.Play();
                    }
                }
                for (i = 19; i <= 33; i++)
                {

                    if (sender.Equals(btn[i]))
                    {
                        metal.Play();
                    }
                }
                if (sender.Equals(btn[34]))
                {
                    nonmtl.Play();
                }

                if (sender.Equals(btn[35]))
                {
                    liquid.Play();
                }

                for (i = 37; i <= 42; i++)
                {

                    if (sender.Equals(btn[i]))
                    {
                        metal.Play();
                    }
                }
                if (sender.Equals(btn[43]))
                {
                    r_active.Play();
                }
                for (i = 44; i <= 53; i++)
                {

                    if (sender.Equals(btn[i]))
                    {
                        metal.Play();
                    }
                }
                for (i = 55; i <= 60; i++)
                {

                    if (sender.Equals(btn[i]))
                    {
                        metal.Play();
                    }
                }
                if (sender.Equals(btn[61]))
                {
                    r_active.Play();
                }

                for (i = 62; i <= 79; i++)
                {

                    if (sender.Equals(btn[i]))
                    {
                        metal.Play();
                    }
                }
                if (sender.Equals(btn[80]))
                {
                    liquid.Play();
                }
                for (i = 81; i <= 83; i++)
                {

                    if (sender.Equals(btn[i]))
                    {
                        metal.Play();
                    }
                }
                for (i = 84; i <= 118; i++)
                {

                    if (sender.Equals(btn[i]))
                    {
                        r_active.Play();
                    }
                }

            }
            if (sender.Equals(btn[1]))
            {
                lbl1.Text = "Hydrogen \nAtomic no. 1\nAtomic mass: 1\nOrbital: 1s1\nValence: -1,1";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.H;
          
            }

            if (sender.Equals(btn[2]))
            {

                lbl1.Text = "Helium \nAtomic no. 2\nAtomic mass: 2\nOrbital: 1s2 ";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.He;
            }

            if (sender.Equals(btn[3]))
            {

                lbl1.Text = "Lithium  \nAtomic no. 3 \nAtomic mass: 6.94\nOrbital: He 2s1\nValence: 1 ";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Li;
            }

            if (sender.Equals(btn[4]))
            {

                lbl1.Text = "Beryllium \nAtomic no. 4 \nAtomic mass: 9 \nOrbital: He 2s2\nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Be;
            }

            if (sender.Equals(btn[5]))
            {

                lbl1.Text = "Boron \nAtomic no. 5\nAtomic mass: 10.81 \nOrbital: He 2s2 2p1 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.B;
            }

            if (sender.Equals(btn[6]))
            {

                lbl1.Text = "Carbon \nAtomic no. 6\nAtomic mass: 12\nOrbital: He 2s2 2p2 \nValence: -4,2,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.C;
            }
            if (sender.Equals(btn[7]))
            {

                lbl1.Text = "Nitrogen  \nAtomic no. 7 \nAtomic mass: 14 \nOrbital: He 2s2 2p3 \nValence: -3,2,3,4,5";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.N;
            }
            if (sender.Equals(btn[8]))
            {

                lbl1.Text = "Oxygen  \nAtomic no. 8 \nAtomic mass: 16 \nOrbital: He 2s2 2p4 \nValence: -2,-1";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.O;
            }
            if (sender.Equals(btn[9]))
            {

                lbl1.Text = "Flourine \nAtomic no. 9\nAtomic mass: 19 \nOrbital: He 2s2 2p5\nValence: -1";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.F;
            }
            if (sender.Equals(btn[10]))
            {

                lbl1.Text = "Neon \nAtomic no. 10 \nAtomic mass: 20\nOrbital: He 2s2 2p6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ne;
            }
            if (sender.Equals(btn[11]))
            {

                lbl1.Text = "Sodium   \nAtomic no. 11  \nAtomic mass: 22.989 \nOrbital: Ne 3s1\nValence: 1";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Na;
            }
            if (sender.Equals(btn[12]))
            {

                lbl1.Text = "Magnesium  \nAtomic no. 12 \nAtomic mass: 24.312 \nOrbital: Ne 3s2\nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Mg;

            }
            if (sender.Equals(btn[13]))
            {

                lbl1.Text = "Aluminum \nAtomic no. 13  \nAtomic mass: 26.982 \nOrbital: Ne 3s2 3p1\nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Al;
            }
            if (sender.Equals(btn[14]))
            {

                lbl1.Text = "Silicon  \nAtomic no. 14  \nAtomic mass: 28.086 \nOrbital: Ne 3s2 3p2\nValence: 4";
                picb1.Image =M_Chemistry_Periodic_Table.Properties.Resources.Si;
            }
            if (sender.Equals(btn[15]))
            {

                lbl1.Text = "Phosphorous\nAtomic no. 15\nAtomic mass: 30.974\nOrbital: Ne 3s2 3p3\nValence: -3,3,5";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.P;
            }
            if (sender.Equals(btn[16]))
            {

                lbl1.Text = "Sulphur\nAtomic no. 16\nAtomic mass: 32.064\nOrbital: Ne 3s2 3p4\nValence: -2,2,4,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.S;
            }
            if (sender.Equals(btn[17]))
            {

                lbl1.Text = "Chlorine\nAtomic no. 17\nAtomic mass: 35.46\nOrbital: Ne 3s2 3p5\nValence: -1,1,3,5,7";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Cl;
            }
            if (sender.Equals(btn[18]))
            {

                lbl1.Text = "Argon  \nAtomic no. 18  \nAtomic mass: 39.948\nOrbital: Ne 3s2 3p6  ";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ar;
            }
            if (sender.Equals(btn[19]))
            {

                lbl1.Text = "Potassium\nAtomic no. 19\nAtomic mass: 39.102\nOrbital: Ar 4s1\nValence: 1";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.K;
            }
            if (sender.Equals(btn[20]))
            {

                lbl1.Text = "Calcium\nAtomic no. 20\nAtomic mass: 40\nOrbital: Ar 4s2\nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ca;
            }

            if (sender.Equals(btn[21]))
            {

                lbl1.Text = "Scandium\nAtomic no. 21\nAtomic mass: 44.956\nOrbital: Ar 3d1 4s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Sc;
            }
            if (sender.Equals(btn[22]))
            {

                lbl1.Text = "Titanium\nAtomic no. 22\nAtomic mass: 47.67\nOrbital: Ar 3d2 4s2\nValence: 3,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ti;
            }
            if (sender.Equals(btn[23]))
            {

                lbl1.Text = "Vanadium \nAtomic no. 23\nAtomic mass: 50.942\nOrbital: Ar 3d3 4s2\nValence: 2,3,4,5";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.V;
            }
            if (sender.Equals(btn[24]))
            {

                lbl1.Text = "Chromium \nAtomic no. 24\nAtomic mass: 51.996\nOrbital: Ar 3d5 4s1\nValence: 2,3,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Cr;
            }
            if (sender.Equals(btn[25]))
            {

                lbl1.Text = "Manganese  \nAtomic no. 25\nAtomic mass: 54.938 \nOrbital: Ar 3d5 4s2  \nValence: 2,3,4,6,7";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Mn;
            }
            if (sender.Equals(btn[26]))
            {

                lbl1.Text = "Iron  \nAtomic no. 26\nAtomic mass: 55.845 \nOrbital: Ar 3d6 4s2  \nValence: 2,3,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Fe;
            }
            if (sender.Equals(btn[27]))
            {

                lbl1.Text = "Cobalt  \nAtomic no. 27\nAtomic mass: 58.933 \nOrbital: Ar 3d7 4s2 \nValence: 2,3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Co;
            }
            if (sender.Equals(btn[28]))
            {

                lbl1.Text = "Nickel  \nAtomic no. 28\nAtomic mass: 58.693 \nOrbital: Ar 3d8 4s2 \nValence: 2,3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ni;
            }
            if (sender.Equals(btn[29]))
            {

                lbl1.Text = "Copper  \nAtomic no. 29\nAtomic mass: 63.546 \nOrbital: Ar 3d10 4s1 \nValence: 1,2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Cu;
            }
            if (sender.Equals(btn[30]))
            {

                lbl1.Text = "Zinc  \nAtomic no. 30\nAtomic mass: 65.39 \nOrbital: Ar 3d10 4s2  \nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Zn;
            }
            if (sender.Equals(btn[31]))
            {

                lbl1.Text = "Gallium   \nAtomic no. 31\nAtomic mass: 69.723 \nOrbital: Ar 3d10 4s2 4p1 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ga;
            }
            if (sender.Equals(btn[32]))
            {

                lbl1.Text = "Germanium \nAtomic no. 32\nAtomic mass: 72.64 \nOrbital: Ar 3d10 4s2 4p2 \nValence: 4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ge;
            }
            if (sender.Equals(btn[33]))
            {

                lbl1.Text = "Arsenic  \nAtomic no. 33\nAtomic mass: 74.921 \nOrbital: Ar 3d10 4s2 4p3  \nValence: -3,3,5";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.As;
            }
            if (sender.Equals(btn[34]))
            {

                lbl1.Text = "Selenium  \nAtomic no. 34\nAtomic mass: 78.96 \nOrbital: Ar 3d10 4s2 4p4\nValence: -2,4,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Se;
            }
            if (sender.Equals(btn[35]))
            {

                lbl1.Text = "Bromine  \nAtomic no. 35\nAtomic mass: 79.904 \nOrbital: Ar 3d10 4s2 4p5\nValence: -1,1,3,5,7";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Br;
            }
            if (sender.Equals(btn[36]))
            {

                lbl1.Text = "Krypton  \nAtomic no. 36\nAtomic mass: 83.80\nOrbital: Ar 3d10 4s2 4p6 \nValence: 2,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Kr;
            }
            if (sender.Equals(btn[37]))
            {

                lbl1.Text = "Rubidium  \nAtomic no. 37\nAtomic mass: 85.467\nOrbital: Kr 5s1 \nValence: 1";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Rb;
            }
            if (sender.Equals(btn[38]))
            {

                lbl1.Text = "Strontium  \nAtomic no. 38\nAtomic mass: 87.62\nOrbital: Kr 5s2 \nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Sr;
            }
            if (sender.Equals(btn[39]))
            {

                lbl1.Text = "Yttrium  \nAtomic no. 39\nAtomic mass: 88.905\nOrbital: Kr 4d1 5s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Y;
            }
            if (sender.Equals(btn[40]))
            {

                lbl1.Text = "Zirconium  \nAtomic no. 40\nAtomic mass: 91.224\nOrbital: Kr 4d2 5s2 \nValence: 4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Zr;
            }
            if (sender.Equals(btn[41]))
            {

                lbl1.Text = "Niobium  \nAtomic no. 41\nAtomic mass: 92.906\nOrbital: Kr 4d4 5s1 \nValence: 3,5";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Nb;
            }
            if (sender.Equals(btn[42]))
            {

                lbl1.Text = "Molybdenum  \nAtomic no. 42\nAtomic mass: 95.94\nOrbital: Kr 4d5 5s1 \nValence: 2,3,4,5,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Mo;
            }
            if (sender.Equals(btn[43]))
            {

                lbl1.Text = "Technetium   \nAtomic no. 43\nAtomic mass: 98\nOrbital: Kr 4d6 5s1 \nValence: 7";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Tc;
            }
            if (sender.Equals(btn[44]))
            {

                lbl1.Text = "Ruthenium  \nAtomic no. 44\nAtomic mass: 101.07\nOrbital: Kr 4d7 5s1 \nValence: 3,4,8";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ru;
            }
            if (sender.Equals(btn[45]))
            {

                lbl1.Text = "Rhodium  \nAtomic no. 45\nAtomic mass: 102.905\nOrbital: Kr 4d8 5s1 \nValence: 1,2,3,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Rh;
            }
            if (sender.Equals(btn[46]))
            {

                lbl1.Text = "Palladium  \nAtomic no. 46\nAtomic mass: 106.42\nOrbital: Kr 4d10 \nValence: 2,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Pd;
            }
            if (sender.Equals(btn[47]))
            {

                lbl1.Text = "Silver  \nAtomic no. 47\nAtomic mass: 107.868\nOrbital: Kr 4d10 5s1 \nValence: 1,2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ag;
            }
            if (sender.Equals(btn[48]))
            {

                lbl1.Text = "Cadmium  \nAtomic no. 48\nAtomic mass: 112.411\nOrbital: Kr 4d10 5s2 \nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Cd;
            }
            if (sender.Equals(btn[49]))
            {

                lbl1.Text = "Indium  \nAtomic no. 49\nAtomic mass: 114.818\nOrbital: Kr 4d10 5s2 5p1 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.In;
            }
            if (sender.Equals(btn[50]))
            {

                lbl1.Text = "Tin  \nAtomic no. 50\nAtomic mass: 118.710\nOrbital: Kr 4d10 5s2 5p2 \nValence: 2,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Sn;
            }
            if (sender.Equals(btn[51]))
            {

                lbl1.Text = "Antimony \nAtomic no. 51\nAtomic mass: 121.760\nOrbital: Kr 4d10 5s2 5p3 \nValence: -3,3,5";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Sb;
            }
            if (sender.Equals(btn[52]))
            {

                lbl1.Text = "Tellurium  \nAtomic no. 52\nAtomic mass: 127.60\nOrbital: Kr 4d10 5s2 5p4 \nValence: -2,4,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Te;
            }
            if (sender.Equals(btn[53]))
            {

                lbl1.Text = "Iodine  \nAtomic no. 53\nAtomic mass: 126.904\nOrbital: Kr 4d10 5s2 5p5 \nValence: -1,1,3,5,7";

                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.I;
            }
            if (sender.Equals(btn[54]))
            {

                lbl1.Text = "Xenon  \nAtomic no. 54\nAtomic mass: 131.293\nOrbital: Kr 4d10 5s2 5p6 \nValence: 2,4,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Xe;
            }
            if (sender.Equals(btn[55]))
            {

                lbl1.Text = "Cesium   \nAtomic no. 55\nAtomic mass: 132.905\nOrbital: Xe 6s1 \nValence: 1";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Cs;
            }
            if (sender.Equals(btn[56]))
            {

                lbl1.Text = "Barium  \nAtomic no. 56\nAtomic mass: 137.327\nOrbital: Xe 6s2 \nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ba;
            }
            if (sender.Equals(btn[57]))
            {

                lbl1.Text = "Lanthanum  \nAtomic no. 57\nAtomic mass: 138.905\nOrbital: Xe 5d1 6s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.La;
            }
            if (sender.Equals(btn[58]))
            {

                lbl1.Text = "Cerium  \nAtomic no. 58\nAtomic mass: 140.116\nOrbital: Xe 4f2 6s2 \nValence: 3,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ce;
            }
            if (sender.Equals(btn[59]))
            {

                lbl1.Text = "Praseodymium  \nAtomic no. 59 \nAtomic mass: 140.907\nOrbital: Xe 4f3 6s2 \nValence: 3,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Pr;
            }
            if (sender.Equals(btn[60]))
            {

                lbl1.Text = "Neodymium  \nAtomic no. 60 \nAtomic mass: 144.24\nOrbital: Xe 4f4 6s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Nd;
            }
            if (sender.Equals(btn[61]))
            {

                lbl1.Text = "Promethium \nAtomic no. 61\nAtomic mass: 145\nOrbital: Xe 4f5 6s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Pm;
            }
            if (sender.Equals(btn[62]))
            {

                lbl1.Text = "Samarium  \nAtomic no. 62\nAtomic mass: 150.36\nOrbital: Xe 4f6 6s2 \nValence: 2,3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Sm;
            }
            if (sender.Equals(btn[63]))
            {

                lbl1.Text = "Europium  \nAtomic no. 63\nAtomic mass: 151.964\nOrbital: Xe 4f7 6s2 \nValence: 2,3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Eu;
            }
            if (sender.Equals(btn[64]))
            {

                lbl1.Text = "Gadolinium  \nAtomic no. 64\nAtomic mass: 157.25\nOrbital: Xe 4f7 5d1 6s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Gd;
            }
            if (sender.Equals(btn[65]))
            {

                lbl1.Text = "Terbium  \nAtomic no. 65\nAtomic mass: 158.925\nOrbital: Xe 4f9 6s2 \nValence: 3,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Tb;
            }
            if (sender.Equals(btn[66]))
            {

                lbl1.Text = "Dysprosium  \nAtomic no. 66\nAtomic mass: 162.50\nOrbital: Xe 4f10 6s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Dy;
            }
            if (sender.Equals(btn[67]))
            {

                lbl1.Text = "Holmium \nAtomic no. 67\nAtomic mass: 164.930\nOrbital: Xe 4f11 6s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ho;
            }
            if (sender.Equals(btn[68]))
            {

                lbl1.Text = "Erbium  \nAtomic no. 68\nAtomic mass: 167.259\nOrbital: Xe 4f12 6s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Er;
            }
            if (sender.Equals(btn[69]))
            {

                lbl1.Text = "Thulium  \nAtomic no. 69\nAtomic mass: 168.934\nOrbital: Xe 4f13 6s2 \nValence: 2,3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Tm;
            }
            if (sender.Equals(btn[70]))
            {

                lbl1.Text = "Ytterbium  \nAtomic no. 70\nAtomic mass: 173.04\nOrbital: Xe 4f14 6s2 \nValence: 2,3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Yb;
            }
            if (sender.Equals(btn[71]))
            {

                lbl1.Text = "Lutetium  \nAtomic no. 71\nAtomic mass: 174.967\nOrbital: Xe 4f14 5d1 6s2\nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Lu;
            }
            if (sender.Equals(btn[72]))
            {

                lbl1.Text = "Hafnium  \nAtomic no. 72\nAtomic mass: 178.49\nOrbital: Xe 4f14 5d2 6s2 \nValence: 4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Hf;
            }
            if (sender.Equals(btn[73]))
            {

                lbl1.Text = "Tantalum  \nAtomic no. 73\nAtomic mass: 180.947\nOrbital: Xe 4f14 5d3 6s2 \nValence: 5";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ta;
            }
            if (sender.Equals(btn[74]))
            {

                lbl1.Text = "Tungsten  \nAtomic no. 74\nAtomic mass: 183.84\nOrbital: Xe 4f14 5d4 6s2 \nValence: 2,3,4,5,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.W;
            }
            if (sender.Equals(btn[75]))
            {

                lbl1.Text = "Rhenium  \nAtomic no. 75\nAtomic mass: 186.207\nOrbital: Xe 4f14 5d5 6s2 \nValence: 2,4,7";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Re;
            }
            if (sender.Equals(btn[76]))
            {

                lbl1.Text = "Osmium  \nAtomic no. 76\nAtomic mass: 190.23\nOrbital: Xe 4f14 5d6 6s2 \nValence: 2,3,4,6,8";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Os;
            }
            if (sender.Equals(btn[77]))
            {

                lbl1.Text = "Iridium  \nAtomic no. 77\nAtomic mass: 192.217 \nOrbital: Xe 4f14 5d7 6s2 \nValence: 1,2,3,4,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ir;
            }
            if (sender.Equals(btn[78]))
            {

                lbl1.Text = "Platinum  \nAtomic no. 78\nAtomic mass: 195.078\nOrbital: Xe 4f14 5d9 6s1 \nValence: 2,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Pt;
            }
            if (sender.Equals(btn[79]))
            {

                lbl1.Text = "Gold  \nAtomic no. 79\nAtomic mass: 196.966\nOrbital: Xe 4f14 5d10 6s1 \nValence: 1,3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Au;
            }
            if (sender.Equals(btn[80]))
            {

                lbl1.Text = "Mercury  \nAtomic no. 80\nAtomic mass: 200.59\nOrbital: Xe 4f14 5d10 6s2\nValence: 1,2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Hg;
            }
            if (sender.Equals(btn[81]))
            {

                lbl1.Text = "Thallium  \nAtomic no. 81\nAtomic mass: 204.38\nOrbital: Xe 4f14 5d10 6s2 6p1\nValence: 1,3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Tl;
            }
            if (sender.Equals(btn[82]))
            {

                lbl1.Text = "Lead  \nAtomic no. 82\nAtomic mass: 207.2\nOrbital: Xe 4f14 5d10 6s2 6p2\nValence: 2,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Pb;
            }
            if (sender.Equals(btn[83]))
            {

                lbl1.Text = "Bismuth\nAtomic no. 83\nAtomic mass: 208.98\nOrbital: Xe 4f14 5d10 6s2 6p3\nValence: 3,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Bi;
            }
            if (sender.Equals(btn[84]))
            {

                lbl1.Text = "Polonium \nAtomic no. 84\nAtomic mass: 209\nOrbital: Xe 4f14 5d10 6s2 6p4\nValence: 2,4,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Po;
            }
            if (sender.Equals(btn[85]))
            {

                lbl1.Text = "Astatine  \nAtomic no. 85\nAtomic mass: 210\nOrbital: Xe 4f14 5d10 6s2 6p5\nValence: -1,1,3,5,7";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.At;
            }
            if (sender.Equals(btn[86]))
            {

                lbl1.Text = "Radon  \nAtomic no. 86\nAtomic mass: 222\nOrbital: Xe 4f14 5d10 6s2 6p6\nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Rn;
            }
            if (sender.Equals(btn[87]))
            {

                lbl1.Text = "Francium  \nAtomic no. 87\nAtomic mass: 223\nOrbital: Rn 7s1\nValence: 1";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Fr;
            }
            if (sender.Equals(btn[88]))
            {

                lbl1.Text = "Radium  \nAtomic no. 88\nAtomic mass: 226\nOrbital: Rn 7s2\nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ra;
            }
            if (sender.Equals(btn[89]))
            {

                lbl1.Text = "Actinium  \nAtomic no. 89\nAtomic mass: 227\nOrbital: Rn 6d1 7s2\nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ac;
            }
            if (sender.Equals(btn[90]))
            {

                lbl1.Text = "Thorium  \nAtomic no. 90\nAtomic mass: 232.038\nOrbital: Rn 6d2 7s2\nValence: 4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Th;
            }
            if (sender.Equals(btn[91]))
            {

                lbl1.Text = "Protactinium  \nAtomic no. 91\nAtomic mass: 231.035\nOrbital: Rn 5f2 6d1 7s2 \nValence: 4,5";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Pa;
            }
            if (sender.Equals(btn[92]))
            {

                lbl1.Text = "Uranium  \nAtomic no. 92\nAtomic mass: 238.028 \nOrbital: Rn 5f3 6d1 7s2 \nValence: 3,4,5,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.U;
            }
            if (sender.Equals(btn[93]))
            {

                lbl1.Text = "Neptunium  \nAtomic no. 93\nAtomic mass: 237\nOrbital: Rn 5f4 6d1 7s2 \nValence: 3,4,5,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Np;
            }
            if (sender.Equals(btn[94]))
            {

                lbl1.Text = "Plutonium  \nAtomic no. 94\nAtomic mass: 244\nOrbital: Rn 5f6 7s2 \nValence: 3,4,5,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Pu;
            }
            if (sender.Equals(btn[95]))
            {

                lbl1.Text = "Americium  \nAtomic no. 95\nAtomic mass: 243\nOrbital: Rn 5f7 7s2 \nValence: 3,4,5,6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Am;
            }
            if (sender.Equals(btn[96]))
            {

                lbl1.Text = "Curium  \nAtomic no. 96\nAtomic mass: 247\nOrbital: Rn 5f7 6d1 7s2 \nValence: 3,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Cm;
            }
            if (sender.Equals(btn[97]))
            {

                lbl1.Text = "Berkelium  \nAtomic no. 97\nAtomic mass: 247\nOrbital: Rn 5f9 7s2 \nValence: 3,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Bk;
            }
            if (sender.Equals(btn[98]))
            {

                lbl1.Text = "Californium  \nAtomic no. 98\nAtomic mass: 251\nOrbital: Rn 5f10 7s2 \nValence: 3,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Cf;
            }
            if (sender.Equals(btn[99]))
            {

                lbl1.Text = "Einsteinium  \nAtomic no. 99\nAtomic mass: 252\nOrbital: Rn 5f11 7s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Es;
            }
            if (sender.Equals(btn[100]))
            {

                lbl1.Text = "Fermium  \nAtomic no. 100\nAtomic mass: 257\nOrbital: Rn 5f12 7s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Fm;
            }
            if (sender.Equals(btn[101]))
            {

                lbl1.Text = "Mendelevium  \nAtomic no. 101\nAtomic mass: 258\nOrbital: Rn 5f13 7s2\nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Md;
            }
            if (sender.Equals(btn[102]))
            {

                lbl1.Text = "Nobelium  \nAtomic no. 102\nAtomic mass: 259\nOrbital: Rn 5f14 7s2 \nValence: 2,3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.No;
            }
            if (sender.Equals(btn[103]))
            {

                lbl1.Text = "Lawrencium  \nAtomic no. 103\nAtomic mass: 262\nOrbital: Rn 5f14 6d1 7s2 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Lr;
            }
            if (sender.Equals(btn[104]))
            {

                lbl1.Text = "Rutherfordium  \nAtomic no. 104\nAtomic mass: 261\nOrbital: Rn 5f14 6d2 7s2\nValence: 4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Rf;
            }
            if (sender.Equals(btn[105]))
            {

                lbl1.Text = "Dubnium  \nAtomic no. 105\nAtomic mass: 262\nOrbital: Rn 5f14 6d3 7s2\nValence: 5 ";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Db;
            }
            if (sender.Equals(btn[106]))
            {

                lbl1.Text = "Seaborgium  \nAtomic no. 106\nAtomic mass: 266\nOrbital: Rn 5f14 6d4 7s2\nValence: 6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Sg;
            }
            if (sender.Equals(btn[107]))
            {

                lbl1.Text = "Bohrium  \nAtomic no. 107\nAtomic mass: 264\nOrbital: Rn 5f14 6d5 7s2\nValence: 7";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Bh;
            }
            if (sender.Equals(btn[108]))
            {
                lbl1.Text = "Hassium  \nAtomic no. 108\nAtomic mass: 277\nOrbital: Rn 5f14 6d6 7s2 \nValence: 8";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Hs;
            }

            if (sender.Equals(btn[109]))
            {

                lbl1.Text = "Meitnerium  \nAtomic no. 109 \nAtomic mass: 268\nOrbital: Rn 5f14 6d7 7s2\nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Mt;
            }

            if (sender.Equals(btn[110]))
            {
                lbl1.Text = "Darmstadtium \nAtomic no. 110 \nAtomic mass: 281 \nOrbital: Rn 5f14 6d8 7s2\nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Ds;
            }

            if (sender.Equals(btn[111]))
            {
                lbl1.Text = "Roentgenium\nAtomic no. 111 \nAtomic mass: 272 \nOrbital: Rn 5f14 6d9 7s2\nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Rg;
            }
            
            if (sender.Equals(btn[112]))
            {
                lbl1.Text = "Copernicium\nAtomic no. 112 \nAtomic mass: 285 \nOrbital: Rn 5f14 6d10 7s2\nValence: 2";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Cn;
            }
            if (sender.Equals(btn[113]))
            {
                lbl1.Text = "Ununtrium\nAtomic no. 113 \nAtomic mass: 287 \nOrbital: Rn 5f14 6d10 7s2 7p1 \nValence: 3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Uut;
            }
            if (sender.Equals(btn[114]))
            {
                lbl1.Text = "Flerovium\nAtomic no. 114 \nAtomic mass: 289 \nOrbital: Rn 5f14 6d10 7s2 7p2\nValence: 2,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Fl;
            }
            if (sender.Equals(btn[115]))
            {
                lbl1.Text = "Ununpentium\nAtomic no. 115 \nAtomic mass: 288 \nOrbital: Rn 5f14 6d10 7s2 7p3 \nValence: 1,3";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Uup;
            }
            if (sender.Equals(btn[116]))
            {
                lbl1.Text = "Livermorium\nAtomic no. 116 \nAtomic mass: 293\nOrbital: Rn 5f14 6d10 7s2 7p4 \nValence: 2,4";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Lv;
            }
            if (sender.Equals(btn[117]))
            {
                lbl1.Text = "Ununseptium\nAtomic no. 117 \nAtomic mass: 294 \nOrbital: Rn 5f14 6d10 7s2 7p5 \nValence: −1,+1,+3,+5";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Uus;
            }
            if (sender.Equals(btn[118]))
            {
                lbl1.Text = "Ununoctium\nAtomic no. 118 \nAtomic mass: 294 \nOrbital: Rn 5f14 6d10 7s2 7p6 \nValence: −1,0,+1,+2,+4,+6";
                picb1.Image = M_Chemistry_Periodic_Table.Properties.Resources.Uuo;
            }

        }

              
    }
}
