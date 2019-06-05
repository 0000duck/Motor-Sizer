using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Axes : Form
    {

        //Form initialization
        public Axes()
        {
            //Initialize
            InitializeComponent();
            //Display the current information on the axes
        }

    

        //Check box changes for each axis
        public void axisBox1_CheckChanged(object sender, EventArgs e)
        {
            ax_1.exist = !ax_1.exist;
            Console.WriteLine("Axis 1: ", ax_1.exist);
        }
        public void axisBox2_CheckChanged(object sender, EventArgs e)
        {
            ax_2.exist = !ax_2.exist;
        }
        public void axisBox3_CheckChanged(object sender, EventArgs e)
        {
            ax_3.exist = !ax_3.exist;
        }
        public void axisBox4_CheckChanged(object sender, EventArgs e)
        {
            ax_4.exist = !ax_4.exist;
        }
        public void axisBox5_CheckChanged(object sender, EventArgs e)
        {
            ax_5.exist = !ax_5.exist;
        }
        public void axisBox6_CheckChanged(object sender, EventArgs e)
        {
            ax_6.exist = !ax_6.exist;
        }

        //Create names for axes
        public void axis1_name(object sender, EventArgs e)
        {
            //ax_1.name; //= //name equal to what is entered
        }

        //Define movement type for axes
        public void axis1_type(object sender, EventArgs e)
        {

        }

        //Continue button is pressed -- go to the special considerations form
        private void button1_Click(object sender, EventArgs e)
        {
            Special m = new Special();
            m.Show();

            this.Hide();

        }
    }
}
