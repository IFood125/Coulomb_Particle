//Franky Jiang
//Jan 9th 2017
//Demonstrating Coulomb's Law
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coulomb_Particle
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Particle location and charge
        /// </summary>
        PointF particle1Location = new PointF();
        SizeF particleSize = new SizeF();
        PointF particle2Location = new PointF();
        bool clicked1, clicked2, clicked, keepDistance;
        float tempX;
        float tempY;
        float charge1, charge2;
        bool start;
        int previousTime;
        const int FRAME_TIME = 5;
        float electricForce;
        const long K = 89900000000;
        float distance;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            lblInfo.Text = "Coulomb’s law: This law states that there is a magnitude of force between two charged particles.\r\nThis force will remain unless the particles are infinitely far apart. In this demonstration,\r\nyou will explore how the charge and distance of the particles affect the force.\r\nThis demo has two particles that can have their charges changed and dragged around the screen. As the particles move around,\r\ntheir force change and you can begin to understand the effects of distance and charge on the force.\r\n The equation that is used is F=|KQq/r^2|\r\nK is a constant which is 8.99*10^9\r\nQ and q are the charges of the the particles\r\nris the distance between centre of the particles";

        }

        private void Graphics(object sender, PaintEventArgs e)
        {
            
            e.Graphics.FillRectangle(Brushes.Red, particle1Location.X, particle1Location.Y, particleSize.Width, particleSize.Height);
            e.Graphics.FillRectangle(Brushes.Blue, particle2Location.X, particle2Location.Y, particleSize.Width, particleSize.Height);
            e.Graphics.FillRectangle(Brushes.GhostWhite, this.Width - 500, 0, 500, this.Height);
            e.Graphics.Dispose();
        }
        /// <summary>
        /// Tracks location of mouse after it left clicks
        /// </summary>
        private Point MouseDownLocation;

        private void Particle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                if (keepDistance == false)
                {
                    if (e.X >= particle1Location.X && e.X < particle1Location.X + particleSize.Width & e.Y >= particle1Location.Y - 3 && e.Y < particle1Location.Y + particleSize.Width)
                    {

                        tempX = e.X - particle1Location.X;
                        tempY = e.Y - particle1Location.Y;
                        keepDistance = true;
                        clicked = true;

                    }

                    if (e.X >= particle2Location.X && e.X < particle2Location.X + particleSize.Width & e.Y >= particle2Location.Y - 3 && e.Y < particle2Location.Y + particleSize.Width)
                    {
                        tempX = e.X - particle2Location.X;
                        tempY = e.Y - particle2Location.Y;
                        keepDistance = true;

                        clicked = true;

                    }
                    
                }
            }
        }
        //Prevent particle movement when left click is released
        private void Particle_MouseUp(object sender, MouseEventArgs e)
        {
            clicked1 = false;
            clicked2 = false;
            clicked = false;
            keepDistance = false;

        }

        /// <summary>
        /// Moves particles if mouse is clicked while within the boundaries of the particle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Particle_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                if (clicked == true)
                {

                    if (e.X >= particle1Location.X && e.X < particle1Location.X + particleSize.Width & e.Y >= particle1Location.Y - 3 && e.Y < particle1Location.Y + particleSize.Width)
                    {
                        clicked1 = true;


                    }

                    else if (e.X >= particle2Location.X && e.X < particle2Location.X + particleSize.Width & e.Y >= particle2Location.Y - 3 && e.Y < particle2Location.Y + particleSize.Width)
                    {
                        clicked2 = true;

                    }

                }
                if (clicked1 == true)
                {

                    particle1Location.X = e.X - tempX;
                    particle1Location.Y = e.Y - tempY;
                    CheckCollisions();


                }
                if (clicked2 == true)
                {

                    particle2Location.X = e.X - tempX;
                    particle2Location.Y = e.Y - tempY;
                    CheckCollisions();

                }
            }
            distance = (float)Math.Sqrt(Math.Pow(Math.Abs(particle1Location.X - particle2Location.X), 2.0) + Math.Pow(Math.Abs(particle1Location.Y - particle2Location.Y), 2.0));
            if (distance <= 0)
            {
                distance = 1;
            }
            lbldistance.Text = "Distance is: " + distance.ToString() + "m";
            electricForce = (float)Math.Abs(K * charge1 * charge2 / Math.Pow(distance, 2.0));
            label1.Text = "Force is: " + electricForce.ToString() + "N";
            
            
            this.Refresh();

        }
        /// <summary>
        /// Prevents particles from intersecting each other
        /// Pushes particles back out if intersecting
        /// </summary>
        private void CheckCollisions()
        {
            if (clicked1 == true)
            {
                if (Math.Abs(particle1Location.X - particle2Location.X) >= Math.Abs(particle1Location.Y - particle2Location.Y))
                {
                    if (particle1Location.X <= particle2Location.X + particleSize.Width &&
                        particle1Location.X + particleSize.Width / 4 > particle2Location.X &&
                        particle1Location.Y + particleSize.Height > particle2Location.Y
                        && particle1Location.Y < particle2Location.Y + particleSize.Height)
                    {
                        particle1Location.X = particle2Location.X + particleSize.Width;
                        if (particle1Location.X + particleSize.Width > this.Width)
                        {
                            particle1Location.X = particle2Location.X - particleSize.Width;
                        }
                    }
                    if (particle1Location.X + particleSize.Width >= particle2Location.X &&
                        particle1Location.X < particle2Location.X + particleSize.Width / 4 &&
                        particle1Location.Y + particleSize.Height > particle2Location.Y
                        && particle1Location.Y < particle2Location.Y + particleSize.Height)
                    {
                        particle1Location.X = particle2Location.X - particleSize.Width;
                        if (particle1Location.X < 0)
                        {
                            particle1Location.X = particle2Location.X + particleSize.Width;
                        }
                    }
                }
                if (particle1Location.Y <= particle2Location.Y + particleSize.Height &&
                    particle1Location.Y + particleSize.Height / 4 > particle2Location.Y &&
                    particle1Location.X + particleSize.Width > particle2Location.X
                    && particle1Location.X < particle2Location.X + particleSize.Width)
                {
                    particle1Location.Y = particle2Location.Y + particleSize.Width;
                    if (particle1Location.Y + particleSize.Width > this.Height)
                    {
                        particle1Location.Y = particle2Location.Y - particleSize.Height;
                    }
                }
                if (particle1Location.Y + particleSize.Width >= particle2Location.Y &&
                    particle1Location.Y < particle2Location.Y + particleSize.Width / 4 &&
                    particle1Location.X + particleSize.Height > particle2Location.X
                    && particle1Location.X < particle2Location.X + particleSize.Height)
                {
                    particle1Location.Y = particle2Location.Y - particleSize.Width;
                    if (particle1Location.Y < 0)
                    {
                        particle1Location.Y = particle2Location.Y + particleSize.Width;
                    }
                }
                if (particle1Location.X + particleSize.Width > this.Width - 500)
                {
                    particle1Location.X = this.Width - particleSize.Width - 500;
                }
                if (particle1Location.X < 0)
                {
                    particle1Location.X = 0;
                }
                if (particle1Location.Y + particleSize.Height > this.Height - 40)
                {
                    particle1Location.Y = this.Height - particleSize.Height - 40;
                }
                if (particle1Location.Y < 0)
                {
                    particle1Location.Y = 0;
                }
                clicked2 = false;
                clicked = false;
            }

            else if (clicked2 == true)
            {
                if (Math.Abs(particle1Location.X - particle2Location.X) >= Math.Abs(particle1Location.Y - particle2Location.Y))
                {
                    if (particle2Location.X <= particle1Location.X + particleSize.Width &&
                        particle2Location.X + particleSize.Width / 4 > particle1Location.X &&
                        particle2Location.Y + particleSize.Height > particle1Location.Y
                        && particle2Location.Y < particle1Location.Y + particleSize.Height)
                    {
                        particle2Location.X = particle1Location.X + particleSize.Width;
                        if (particle1Location.X + particleSize.Width > this.Width)
                        {
                            particle2Location.X = particle1Location.X - particleSize.Width;

                        }
                    }
                    if (particle2Location.X + particleSize.Width >= particle1Location.X &&
                        particle2Location.X < particle1Location.X + particleSize.Width / 4 &&
                        particle2Location.Y + particleSize.Height > particle1Location.Y
                        && particle2Location.Y < particle1Location.Y + particleSize.Height)
                    {
                        particle2Location.X = particle1Location.X - particleSize.Width;
                        if (particle1Location.X < 0)
                        {
                            particle2Location.X = particle1Location.X + particleSize.Width;
                        }
                    }
                }
                if (particle2Location.Y <= particle1Location.Y + particleSize.Height &&
                    particle2Location.Y + particleSize.Height / 4 > particle1Location.Y &&
                    particle2Location.X + particleSize.Width > particle1Location.X
                    && particle2Location.X < particle1Location.X + particleSize.Width)
                {
                    particle2Location.Y = particle1Location.Y + particleSize.Width;
                    if (particle1Location.Y + particleSize.Width > this.Height)
                    {
                        particle2Location.Y = particle1Location.Y - particleSize.Height;
                    }
                }
                if (particle2Location.Y + particleSize.Width >= particle1Location.Y &&
                    particle2Location.Y < particle1Location.Y + particleSize.Width / 4 &&
                    particle2Location.X + particleSize.Height > particle1Location.X
                    && particle2Location.X < particle1Location.X + particleSize.Height)
                {
                    particle2Location.Y = particle1Location.Y - particleSize.Width;
                    if (particle1Location.Y < 0)
                    {
                        particle2Location.Y = particle1Location.Y + particleSize.Width;
                    }
                }
                if (particle2Location.X + particleSize.Width > this.Width - 500)
                {
                    particle2Location.X = this.Width - particleSize.Width-500;
                }
                if (particle2Location.X < 0)
                {
                    particle2Location.X = 0;
                }
                if (particle2Location.Y + particleSize.Width > this.Height -40)
                {
                    particle2Location.Y = this.Height - particleSize.Height- 40;
                }
                if (particle2Location.Y < 0)
                {
                    particle2Location.Y = 0;
                }
                clicked1 = false;
                clicked = false;
            }
        }
        //Starts simulation
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Restart";
            particle1Location = new PointF(((this.Width - 500) / 2) + 100, (this.Height / 2));
            particle2Location = new PointF(((this.Width - 500) / 2) - 100, (this.Height / 2));
            particleSize = new Size(50, 50);
            this.Refresh();
            chartEvsD.Series["ForceDistance"].Points.Clear();
            lblInfo.Hide();
        }

        /// <summary>
        /// Changes charge of each particle
        /// accepts only numerical inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCharge1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtCharge.Text, out charge1) == false)
            {
                txtCharge.Text = "Invalid value, decimals and numbers only";
            }
            else
            {
                txtCharge.Text = "";
                lblCharge1.Text = "Charge Red is: " + charge1.ToString() + "C";
            }
            chartEvsD.Series["ForceDistance"].Points.Clear();
            lbltable.Text = "Distance    Electric Force";
        }

        private void btnCharge2_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtCharge.Text, out charge2) == false)
            {
                txtCharge.Text = "Invalid value, decimals and numbers only";
            }
            else
            {
                txtCharge.Text = "";
                lblCharge2.Text = "Charge Blue is: " + charge2.ToString() + "C";
            }
            chartEvsD.Series["ForceDistance"].Points.Clear();
            lbltable.Text = "Distance    Electric Force";
        }
        //Creates datapoin on graph
        //Adds entry to table of distance, charge and electric force
        private void btnAddPoint_Click(object sender, EventArgs e)
        {

            chartEvsD.Series["ForceDistance"].Points.AddXY(distance, electricForce);
            lbltable.Text = lbltable.Text + "\r\n" + distance.ToString() + "M" + "          " + electricForce.ToString() + "N";

        }

               
        
    }
    
}
