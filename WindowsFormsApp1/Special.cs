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
    //Form for special considerations: communication protocols and environment
    public partial class Special : Form
    {

    public Special()
        {
            InitializeComponent();
            //Protocol options
            string[] protocols = new string[] { "RS232/485", "CANopen", "DEVICENET", "PROFIBUS", "ETHERNET/IP", "PROFINET", "ETHERCAT" };
            comboBox1.Items.AddRange(protocols);

            //Temperature units
            string[] Temp_units = new string[] { "C", "F" };
            comboBox2.Items.AddRange(Temp_units);

            //Moisture options
            string[] moisture = new string[] { "Outdoor/humid", "Rain/splash", "Washdown" };
            comboBox3.Items.AddRange(moisture);
        }
        //Continue click moves forward
        private void continue_Click(object sender, EventArgs e)
        {
                LinSpecs m = new LinSpecs();
                m.Show();

                this.Hide();
        }
        //Back click moves backward-- try to keep previously entered info?
        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Axes l = new Axes();
            l.Show();

        }
    }
}
