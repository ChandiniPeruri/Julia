using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Julia
{
    public partial class Form1 : Form
    {
        //variable declarations
        //test values -0.70176-0.3842i
        Boolean readyToGraph= false;
        double c0, c1;
        double dx;
        double x0, y0, newX, newY;

        Color col;
        Brush b;
        public Form1()
        {
            
            dx = 0.005;
            InitializeComponent();
        }

        private void PictureBox_PaintEvent(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // loop through every pixel
            if (readyToGraph)
            {
                
                //loop through every pixel
                for(float i=0; i<800; i++)
                    for(float j =0; j<800; j++)
                    {
                        //calculate the initial real and imaginary parts based on pixel location, position values
                        x0 = (i*dx)-2;
                        y0 = -((j*dx)-2);
                        int k;
                        for(k =0; k<1024; k++) { 
                        //new values
                        newX = x0 * x0 - y0 * y0 +c0;
                        newY = 2 * x0 * y0 +c1;
                        //set values
                        x0 = newX;
                        y0 = newY;
                            //if the point is outside the circle with radius 2, stop
                            if ((newX * newX + newY * newY) > 16)
                                break;
                        }
                            int c = k % 256;
                            col = Color.FromArgb(0, c, 0);
                            b = new SolidBrush(col);
                            //draw the pixel
                            g.FillRectangle(b, i, j, 1, 1);
                    }
            }
        }
        private void Graph_Button_Click(object sender, EventArgs e)
        {
            // Take c0 and c1 inputs
            try
            {
                //read and save the c0 and c1 values from user input 
                c0 = Convert.ToDouble(textBox1.Text);
                c1 = Convert.ToDouble(textBox2.Text);
                readyToGraph = true;
                //calls the picturebox
                pictureBox1.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exeption occurs:" + ex);
            }
           
        } 
        
    }
}
