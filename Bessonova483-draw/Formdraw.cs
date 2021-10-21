using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova483_draw
{
    public partial class Formdraw : Form
    {
        int old_x, old_y;
        List<Figure> lst = new List<Figure>();

        void buttonAdd_Click(object sender, EventArgs e)
        {
            
            Figure fig = Createfigure(comboBoxFigures.Text);
            if (fig == null) return;
            fig.pos_x = pictureBoxfigures.Width *0.5f;
            fig.pos_y = pictureBoxfigures.Height * 0.5f;
            listBoxfigures.Items.Add(fig.id);
            lst.Add(fig);
            pictureBoxfigures.Invalidate();

        }

       void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i<lst.Count)
            {
                if (listBoxfigures.SelectedIndex == i) lst.RemoveAt(i);
                listBoxfigures.Items.RemoveAt(i);
                i++;
            }
            pictureBoxfigures.Invalidate();
        }

        Figure Createfigure(string fig_type)
        {
            
        switch (fig_type)
            {
                case "circle": return new Circle(textBoxRad.Text);
                case "square": return new Square(textBoxside.Text);

            }
        
           return null;
        }
        

        public Formdraw()
        {
            InitializeComponent();
        }

        void pictureBoxfigures_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Figure fig in lst)
                fig.selected = false;
            for (int i = lst.Count-1; i >= 0; i--)
            {
                Figure fig = lst[i];
                fig.selected |= fig.test(e.X, e.Y);
                if (fig.selected == true) break;
            }
            pictureBoxfigures.Invalidate();
        }

        void pictureBoxfigures_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - old_x;
                int dy = e.Y - old_y;
                foreach (Figure fig in lst)
                {
                    if (fig.selected == false) continue;
                    fig.pos_x += dx;
                    fig.pos_y += dy;
                    
                }
                pictureBoxfigures.Invalidate();
               
            }
            old_x = e.X;
            old_y = e.Y;
        }

        private void Formdraw_Resize(object sender, EventArgs e)
        {
            int w = ClientRectangle.Width - 16;
            int h = ClientRectangle.Height - pictureBoxfigures.Top - 16;

            pictureBoxfigures.Width = w;
            pictureBoxfigures.Height = h;
        }

        private void Formdraw_Load(object sender, EventArgs e)
        {
            textBoxRad.Visible = false;
            labelforcircle.Visible = false;

            textBoxside.Visible = false;
            labelforsquare.Visible = false;

            

            Formdraw_Resize(null, null);

           
        }

        private void comboBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFigures.Text)
            {
                case "circle": textBoxRad.Visible = true; labelforcircle.Text = "Radius: "; labelforcircle.Visible = true; textBoxside.Visible = false;
                    labelforsquare.Visible = false; break;
                case "square": textBoxside.Visible = true; labelforsquare.Text = "Side: "; labelforsquare.Visible = true; textBoxRad.Visible = false;
                    labelforcircle.Visible = false; break;
            }
        }



        void pictureBoxfigures_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0, pictureBoxfigures.Width, pictureBoxfigures.Height);
            foreach (Figure fig in lst)
                fig.draw(e.Graphics);
        }

        
       



    }
}
