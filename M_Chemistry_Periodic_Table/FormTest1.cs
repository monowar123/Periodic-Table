using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Resources;


namespace M_Chemistry_Periodic_Table
{
    public partial class FormTest1 : Form
    {
        string[] s = { 
                     "","Hydrogen","Helium","Lithium","Berelium","Boron","Carbon","Nitrogen",
                     "Oxygen","Fluorine","Neon","Sodium","Magnesium","Aluminium","Silicon","Phosphorus",
                     "Sulfur","Chlorine","Argon","Potassium","Calcium","Scandium","Titanium","Vanadium", 
                     "Chromium","Manganese","Iron","Cobalt","Nickel","Copper","Zinc","Gallium","Germanium",
                     "Arsenic","Selenium","Bromine","Krypton","Rubidium","Strontium","Yttrium","Zirconium",
                     "Niobium","Molybdenum","Technetium","Ruthenium","Rhodium","Palladium","Silver","Cadmium",
                     "Indium","Tin","Antimony","Tellurium","Iodine","Xenon","Caesium","Barium","Lanthanum",
                     "Cerium","Praseodymium","Neodymium","Promethium","Samarium","Europium","Gadolinium",
                     "Terbium","Dysprosium","Holmium","Erbium","Thulium","Ytterbium","Lutetium","Hafnium",
                     "Tantalum","Tungsten","Rhenium","Osmium","Iridium","Platinum","Gold","Mercury",
                     "Thallium","Lead","Bismuth","Polonium","Astatine","Radon","Francium","Radium",
                     "Actinium","Thorium","Protactinium","Uranium","Neptunium","Plutonium","Americium",
                     "Curium","Berkelium","Californium","Einsteinium","Fermium","Mendelevium","Nobelium",
                     "Lawrencium","Rutherfordium","Dubnium","Seaborgium","Bohrium","Hassium","Meitnerium",
                     "Darmstadtium","Roentgenium","Copernicium","Ununtrium","Flerovium","Ununpentium",
                     "Livermorium","Ununseptium","Ununoctium"
                     };


        Random r;
        Button[] btn;
        Form1 f1;
        Label l;
        Label l2;
        PictureBox pr,pw;
        TextBox t,tr,tw;
        Timer tm = new Timer();

        FormStart fs;
       

        ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
      

        int i,j,x=0,y=0;
        bool flag,check;

        public FormTest1(Button[] btn, Form1 f1, FormStart fs )
        {
            this.btn = btn;
            this.f1 = f1;
            this.fs = fs;
         

            InitializeComponent();
            

        }

        private void FormTest1_Load(object sender, EventArgs e)
        {
            

            t = new TextBox();
            t.Location = new Point(439, 65);
            t.Size = new Size(180, 70);
            t.Font = new Font("Impact",21);
            t.TabStop = false;
            t.TextAlign = HorizontalAlignment.Center;
            t.ReadOnly = true;
            t.BackColor = Color.White;

            tr = new TextBox();
            tr.Location = new Point(439,160);
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


            rand();

            new ButtonCreate(btn, f1, this);

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
            l.Location = new Point(310, 65);
            l.Size = new Size(128, 70);
            l.Font = new Font("Impact", 22);
            l.Text = "Click on :";

            l2 = new Label();
            l2.Location = new Point(653, 52);
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

            this.Disposed += new EventHandler(FormTest1_Disposed);

            for (i = 1; i <= 118; i++)
            {
                this.btn[i].Click += new System.EventHandler(this.buttonClick);
            }
        }

        void FormTest1_Disposed(object sender, EventArgs e)
        {
            fs.Show();
         
        }

        public void buttonClick(object sender, EventArgs e)
        {
            

            if (
                (sender.Equals(btn[1]) && t.Text.Equals("Hydrogen")) ||
                (sender.Equals(btn[2]) && t.Text.Equals("Helium")) ||
                (sender.Equals(btn[3]) && t.Text.Equals("Lithium")) ||
                (sender.Equals(btn[4]) && t.Text.Equals("Berelium")) ||
                (sender.Equals(btn[5]) && t.Text.Equals("Boron")) ||
                (sender.Equals(btn[6]) && t.Text.Equals("Carbon")) ||
                (sender.Equals(btn[7]) && t.Text.Equals("Nitrogen")) ||
                (sender.Equals(btn[8]) && t.Text.Equals("Oxygen")) ||
                (sender.Equals(btn[9]) && t.Text.Equals("Fluorine")) ||
                (sender.Equals(btn[10]) && t.Text.Equals("Neon")) ||

                (sender.Equals(btn[11]) && t.Text.Equals("Sodium")) ||
                (sender.Equals(btn[12]) && t.Text.Equals("Magnesium")) ||
                (sender.Equals(btn[13]) && t.Text.Equals("Aluminium")) ||
                (sender.Equals(btn[14]) && t.Text.Equals("Silicon")) ||
                (sender.Equals(btn[15]) && t.Text.Equals("Phosphorus")) ||
                (sender.Equals(btn[16]) && t.Text.Equals("Sulfur")) ||
                (sender.Equals(btn[17]) && t.Text.Equals("Chlorine")) ||
                (sender.Equals(btn[18]) && t.Text.Equals("Argon")) ||
                (sender.Equals(btn[19]) && t.Text.Equals("Potassium")) ||
                (sender.Equals(btn[20]) && t.Text.Equals("Calcium")) ||

                (sender.Equals(btn[21]) && t.Text.Equals("Scandium")) ||
                (sender.Equals(btn[22]) && t.Text.Equals("Titanium")) ||
                (sender.Equals(btn[23]) && t.Text.Equals("Vanadium")) ||
                (sender.Equals(btn[24]) && t.Text.Equals("Chromium")) ||
                (sender.Equals(btn[25]) && t.Text.Equals("Manganese")) ||
                (sender.Equals(btn[26]) && t.Text.Equals("Iron")) ||
                (sender.Equals(btn[27]) && t.Text.Equals("Cobalt")) ||
                (sender.Equals(btn[28]) && t.Text.Equals("Nickel")) ||
                (sender.Equals(btn[29]) && t.Text.Equals("Copper")) ||
                (sender.Equals(btn[30]) && t.Text.Equals("Zinc")) ||

                (sender.Equals(btn[31]) && t.Text.Equals("Gallium")) ||
                (sender.Equals(btn[32]) && t.Text.Equals("Germanium")) ||
                (sender.Equals(btn[33]) && t.Text.Equals("Arsenic")) ||
                (sender.Equals(btn[34]) && t.Text.Equals("Selenium")) ||
                (sender.Equals(btn[35]) && t.Text.Equals("Bromine")) ||
                (sender.Equals(btn[36]) && t.Text.Equals("Krypton")) ||
                (sender.Equals(btn[37]) && t.Text.Equals("Rubidium")) ||
                (sender.Equals(btn[38]) && t.Text.Equals("Strontium")) ||
                (sender.Equals(btn[39]) && t.Text.Equals("Yttrium")) ||
                (sender.Equals(btn[40]) && t.Text.Equals("Zirconium")) ||

                (sender.Equals(btn[41]) && t.Text.Equals("Niobium")) ||
                (sender.Equals(btn[42]) && t.Text.Equals("Molybdenum")) ||
                (sender.Equals(btn[43]) && t.Text.Equals("Technetium")) ||
                (sender.Equals(btn[44]) && t.Text.Equals("Ruthenium")) ||
                (sender.Equals(btn[45]) && t.Text.Equals("Rhodium")) ||
                (sender.Equals(btn[46]) && t.Text.Equals("Palladium")) ||
                (sender.Equals(btn[47]) && t.Text.Equals("Silver")) ||
                (sender.Equals(btn[48]) && t.Text.Equals("Cadmium")) ||
                (sender.Equals(btn[49]) && t.Text.Equals("Indium")) ||
                (sender.Equals(btn[50]) && t.Text.Equals("Tin")) ||

                (sender.Equals(btn[51]) && t.Text.Equals("Antimony")) ||
                (sender.Equals(btn[52]) && t.Text.Equals("Tellurium")) ||
                (sender.Equals(btn[53]) && t.Text.Equals("Iodine")) ||
                (sender.Equals(btn[54]) && t.Text.Equals("Xenon")) ||
                (sender.Equals(btn[55]) && t.Text.Equals("Caesium")) ||
                (sender.Equals(btn[56]) && t.Text.Equals("Barium")) ||
                (sender.Equals(btn[57]) && t.Text.Equals("Lanthanum")) ||
                (sender.Equals(btn[58]) && t.Text.Equals("Cerium")) ||
                (sender.Equals(btn[59]) && t.Text.Equals("Praseodymium")) ||
                (sender.Equals(btn[60]) && t.Text.Equals("Neodymium")) ||

                (sender.Equals(btn[61]) && t.Text.Equals("Promethium")) ||
                (sender.Equals(btn[62]) && t.Text.Equals("Samarium")) ||
                (sender.Equals(btn[63]) && t.Text.Equals("Europium")) ||
                (sender.Equals(btn[64]) && t.Text.Equals("Gadolinium")) ||
                (sender.Equals(btn[65]) && t.Text.Equals("Terbium")) ||
                (sender.Equals(btn[66]) && t.Text.Equals("Dysprosium")) ||
                (sender.Equals(btn[67]) && t.Text.Equals("Holmium")) ||
                (sender.Equals(btn[68]) && t.Text.Equals("Erbium")) ||
                (sender.Equals(btn[69]) && t.Text.Equals("Thulium")) ||
                (sender.Equals(btn[70]) && t.Text.Equals("Ytterbium")) ||

                (sender.Equals(btn[71]) && t.Text.Equals("Lutetium")) ||
                (sender.Equals(btn[72]) && t.Text.Equals("Hafnium")) ||
                (sender.Equals(btn[73]) && t.Text.Equals("Tantalum")) ||
                (sender.Equals(btn[74]) && t.Text.Equals("Tungsten")) ||
                (sender.Equals(btn[75]) && t.Text.Equals("Rhenium")) ||
                (sender.Equals(btn[76]) && t.Text.Equals("Osmium")) ||
                (sender.Equals(btn[77]) && t.Text.Equals("Iridium")) ||
                (sender.Equals(btn[78]) && t.Text.Equals("Platinum")) ||
                (sender.Equals(btn[79]) && t.Text.Equals("Gold")) ||
                (sender.Equals(btn[80]) && t.Text.Equals("Mercury")) ||

                (sender.Equals(btn[81]) && t.Text.Equals("Thallium")) ||
                (sender.Equals(btn[82]) && t.Text.Equals("Lead")) ||
                (sender.Equals(btn[83]) && t.Text.Equals("Bismuth")) ||
                (sender.Equals(btn[84]) && t.Text.Equals("Polonium")) ||
                (sender.Equals(btn[85]) && t.Text.Equals("Astatine")) ||
                (sender.Equals(btn[86]) && t.Text.Equals("Radon")) ||
                (sender.Equals(btn[87]) && t.Text.Equals("Francium")) ||
                (sender.Equals(btn[88]) && t.Text.Equals("Radium")) ||
                (sender.Equals(btn[89]) && t.Text.Equals("Actinium")) ||
                (sender.Equals(btn[90]) && t.Text.Equals("Thorium")) ||

                (sender.Equals(btn[91]) && t.Text.Equals("Protactinium")) ||
                (sender.Equals(btn[92]) && t.Text.Equals("Uranium")) ||
                (sender.Equals(btn[93]) && t.Text.Equals("Neptunium")) ||
                (sender.Equals(btn[94]) && t.Text.Equals("Plutonium")) ||
                (sender.Equals(btn[95]) && t.Text.Equals("Americium")) ||
                (sender.Equals(btn[96]) && t.Text.Equals("Curium")) ||
                (sender.Equals(btn[97]) && t.Text.Equals("Berkelium")) ||
                (sender.Equals(btn[98]) && t.Text.Equals("Californium")) ||
                (sender.Equals(btn[99]) && t.Text.Equals("Einsteinium")) ||
                (sender.Equals(btn[100]) && t.Text.Equals("Fermium")) ||

                (sender.Equals(btn[101]) && t.Text.Equals("Mendelevium")) ||
                (sender.Equals(btn[102]) && t.Text.Equals("Nobelium")) ||
                (sender.Equals(btn[103]) && t.Text.Equals("Lawrencium")) ||
                (sender.Equals(btn[104]) && t.Text.Equals("Rutherfordium")) ||
                (sender.Equals(btn[105]) && t.Text.Equals("Dubnium")) ||
                (sender.Equals(btn[106]) && t.Text.Equals("Seaborgium")) ||
                (sender.Equals(btn[107]) && t.Text.Equals("Bohrium")) ||
                (sender.Equals(btn[108]) && t.Text.Equals("Hassium")) ||
                (sender.Equals(btn[109]) && t.Text.Equals("Meitnerium")) ||
                (sender.Equals(btn[110]) && t.Text.Equals("Darmstadtium")) ||

                (sender.Equals(btn[111]) && t.Text.Equals("Roentgenium")) ||
                (sender.Equals(btn[112]) && t.Text.Equals("Copernicium")) ||
                (sender.Equals(btn[113]) && t.Text.Equals("Ununtrium")) ||
                (sender.Equals(btn[114]) && t.Text.Equals("Flerovium")) ||
                (sender.Equals(btn[115]) && t.Text.Equals("Ununpentium")) ||
                (sender.Equals(btn[116]) && t.Text.Equals("Livermorium")) ||
                (sender.Equals(btn[117]) && t.Text.Equals("Ununseptium")) ||
                (sender.Equals(btn[118]) && t.Text.Equals("Ununoctium"))

                )
            {

                timer1.Enabled = true;
                flag = true;
                check = true;
                j = 0;
                //l2.Text = "Success";
            }
            else
            {
                timer1.Enabled = true;
                flag = false;
                check = true;
                j = 0;
                //l2.Text = "Fail";
            }
            

            rand();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                if (flag == true)
                {
                    l2.Text = "Success";
                    l2.ForeColor   = Color.Green;
                   
                  
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

        

        private void rand()
        {
            
            r = new Random();
            int k = r.Next(1, 118);
            
            t.Text = s[k];

        }

    }
}
