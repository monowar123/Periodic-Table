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
    public partial class FormStart : Form
    {
        
        public Button[] btn;
        PictureBox [] pb = new PictureBox [5];
        PictureBox p;
        PictureBox p2;
        Label l2;
      

        public FormStart()
        {
            
            InitializeComponent();
            
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < 5; i++)
            {
                pb[i] = new PictureBox ();
                pb[i].Size = new Size(230, 58);            
                pb[i].Location = new Point(65, (i + 2) * 72);

                pb[i].MouseClick += new MouseEventHandler(FormStart_MouseClick);
                pb[i].MouseHover += new EventHandler(FormStart_MouseHover);
                pb[i].MouseLeave += new EventHandler(FormStart_MouseLeave);
                pb[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pb[i]);
            }
            
            pb[0].Image = M_Chemistry_Periodic_Table.Properties.Resources.ptt2 ;
            pb[1].Image = M_Chemistry_Periodic_Table.Properties.Resources.tss2;
            pb[2].Image = M_Chemistry_Periodic_Table.Properties.Resources.taa2;
            pb[3].Image = M_Chemistry_Periodic_Table.Properties.Resources.abb2;
            pb[4].Image = M_Chemistry_Periodic_Table.Properties.Resources.exx2;

           


            p2  = new PictureBox ();
            p2.Size = new Size(250, 80);
            p2.Location = new Point(55, 32);
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            p2.Image = M_Chemistry_Periodic_Table.Properties.Resources.hnn2;
            this.Controls.Add(p2);


            l2 = new Label();
            l2.Size = new Size(328,20);
            l2.Location = new Point(16,650);
            l2.Text = "Copyright © 2012. All Rights Reserved to Musabbir Mamun.";
            l2.Font = new Font("Microsoft Tai Le",9);
            l2.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(l2);

            p = new PictureBox();
            p.Size = new Size(280, 145);
            p.Location = new Point(39, 500);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.Image = M_Chemistry_Periodic_Table.Properties.Resources.nw2;
            this.Controls.Add(p);

           

        }

        void FormStart_MouseLeave(object sender, EventArgs e)
        {
            if (sender.Equals(pb[0]))
            {
                pb[0].Image = M_Chemistry_Periodic_Table.Properties.Resources.ptt2;
            }
            if (sender.Equals(pb[1]))
            {
                pb[1].Image = M_Chemistry_Periodic_Table.Properties.Resources.tss2;
            }
            if (sender.Equals(pb[2]))
            {
                pb[2].Image = M_Chemistry_Periodic_Table.Properties.Resources.taa2;
            }
            if (sender.Equals(pb[3]))
            {
                pb[3].Image = M_Chemistry_Periodic_Table.Properties.Resources.abb2;
            }
            if (sender.Equals(pb[4]))
            {
                pb[4].Image = M_Chemistry_Periodic_Table.Properties.Resources.exx2;
            }
        }

        void FormStart_MouseHover(object sender, EventArgs e)
        {
            if (sender.Equals(pb[0]))
            {
                pb[0].Image = M_Chemistry_Periodic_Table.Properties.Resources.ptt;
            }
            if (sender.Equals(pb[1]))
            {
                pb[1].Image = M_Chemistry_Periodic_Table.Properties.Resources.tss;
            }
            if (sender.Equals(pb[2]))
            {
                pb[2].Image = M_Chemistry_Periodic_Table.Properties.Resources.taa;
            }
            if (sender.Equals(pb[3]))
            {
                pb[3].Image = M_Chemistry_Periodic_Table.Properties.Resources.abb;
            }
            if (sender.Equals(pb[4]))
            {
                pb[4].Image = M_Chemistry_Periodic_Table.Properties.Resources.exx;
            }
        }

        void FormStart_MouseClick(object sender, MouseEventArgs e)
        {
            btn = new Button[119];

            Form1 f1 = new Form1(btn, this);

            if (sender.Equals(pb[0]))
            {
                this.Hide();
                f1.Show();

            }
            if (sender.Equals(pb[1]))
            {
                this.Hide();
                new FormTest1(btn, f1, this ).Show();

            }
            if (sender.Equals(pb[2]))
            {
                this.Hide();
                new FormTest2(btn, f1, this ).Show();

            }
            if (sender.Equals(pb[3]))
            {
                System.Diagnostics.Process.Start("http://www.facebook.com/musabbir.mamun");
            }
            if (sender.Equals(pb[4]))
            {
                Application.Exit();
            }

           
        }
        
    }
}
