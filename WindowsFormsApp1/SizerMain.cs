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
    public partial class SizerMain : Form
    {
        public SizerMain()
        {
            InitializeComponent();
        }

        Axis selected; //the selected axis
        int p = 0; //index of the selected axis within the axes list
        string protocol; //communication protocol for the application
        double temperature = 25; //temperature for the application -- default 25 C
        string moisture; //moisture level for the application
        int n = 1; //number of axes added to the axesListBox
        int n_sizing = 0; //number of axes that will be considered for sizing
        List<int> indices = new List<int> { }; //list of the locations of axes to be sized
        public List<Axis> axes = new List<Axis> { }; //list of axes objects containing all info

        /////////Axis selection change
        public void selection_change(object sender, EventArgs e)
        {
            if (axesListBox.SelectedItem != null)
            {
                for (int i = 0; i < axes.Count(); i++)
                {
                    if (axes[i].name == axesListBox.SelectedItem.ToString())
                    {
                        selected = axes[i]; //axis object of interest
                        p = i; //index of object of interest
                    }
                }
            }
        }

        /////////Add button
        public void Add_Click(object sender, EventArgs e)
        {
            //Add an axis
            Axis my_axis = new Axis();
            my_axis.name = "AXIS" + n.ToString();
            axesListBox.Items.Add(my_axis.name);
            axes.Add(my_axis);

            //Open edit window
            EditTool a = new EditTool(my_axis);
            a.ShowDialog();

            //Update the axis from the edit window info
            Axis updated_axis = a.return_axis;
            axes[n - 1] = updated_axis;

            //Update name of the last item added
            axesListBox.Items[axesListBox.Items.Count - 1] = axes[n - 1].name;

            n += 1;

        }

        /////////Delete button
        public void Del_Click(object sender, EventArgs e)
        {
            if (axesListBox.SelectedItem != null)
            {
                //Remove selected axis from the GUI list
                axesListBox.Items.RemoveAt(axesListBox.SelectedIndex);
                axes[p].exist = false; //turn off consideration of this axis for sizing
            }
        }

        /////////Edit button
        public void Edit_Click(object sender, EventArgs e)
        {
            if (axesListBox.SelectedItem != null)
            {

                //Open an edit dialog box
                EditTool a = new EditTool(selected);
                a.ShowDialog();

                //Update axis information in the object list
                Axis updated_axis = a.return_axis;
                axes[p] = updated_axis;

                //Update axis name in the list box
                axesListBox.Items[axesListBox.SelectedIndex] = updated_axis.name;

            }
        }

        /////////Other options
        //Set protocol
        public void Protocol_set(object sender, EventArgs e)
        {
            protocol = CommDropd.SelectedItem.ToString();
        }

        //Temperature
        public void Temperature_set(object sender, EventArgs e)
        {
            if (tempBox.Text != "")
            {
                string t_input = tempBox.Text.ToString();
                temperature = Convert.ToDouble(t_input);
            }
        }

        //Moisture
        public void Moisture_set(object sender, EventArgs e)
        {
            moisture = MoistureBox.Text.ToString();
        }

        /////////Sizer! Meat of calculations happens here
        public void Size_click(object sender, EventArgs e)
        {

            //Clear indices list
            while (indices.Count()>0)
            {
                indices.Remove(indices[0]);
            }

            //Take the important axes-- the ones that have not been deleted
            n_sizing = 0;
            for (int i = 0; i < axes.Count(); i++)
            {
                if (axes[i].exist)
                {
                    n_sizing += 1;
                    indices.Add(i);
                }
            }

            //If we have axes to size, do it
            if (n_sizing > 0)
            {
                //get product data
                get_data();

                //clear and display appropriate text
                outputBox.Clear();
                outputBox.Text = "\n";

                disclaimer.Visible = true;

                //size each axis
                for (int i = 0; i < indices.Count(); i++)
                {
                    string name_ext = ""; //PN extention for additional options
                    double best_feas = -10000000; // best feasibility for alternate solution
                    List<Motor> motors = new List<Motor> { }; //list of motors that are being evaluated for feasibility

                    //Check for special conditions limiting motor type 
                    ////Class 6 for ethernet protocols
                    if (protocol == "Ethernet/IP" || protocol == "EtherCAT" || protocol == "Profinet" && axes[indices[i]].actuate==false)
                    {
                        //Get the protocol code for motor PN 
                        if (protocol == "Ethernet/IP") { name_ext = "IP"; }
                        else if (protocol == "EtherCAT") { name_ext = "EC"; }
                        else if (protocol == "Profinet") { name_ext = "PN"; }
                        motors = Class6;
                    }

                    /////Class 5 for IP rating 
                    else if (moisture == "Splash/rain" || moisture == "Washdown" && axes[indices[i]].actuate == false)
                    {
                        if (axes[indices[i]].brake) { name_ext += "-BRK"; }
                        name_ext += "-IP";
                        if (protocol == "DeviceNet") { name_ext += "-DN"; }
                        motors = Class5M;
                    }

                    /////No special restriction==> Class 5 D
                    else
                    {
                        //check for special options & add to PN
                        if (axes[indices[i]].de) { name_ext += "-DE"; }
                        if (axes[indices[i]].brake) { name_ext += "-BRK"; }
                        if (protocol == "DeviceNet") { name_ext += "-DN"; }
                        else if (protocol == "Profibus") { name_ext += "-PB"; }
                        else if (protocol == "CANopen" && indices.Count()>1 || indices.Count() > 1) { name_ext += "-CDS7"; }
                        else if (protocol == "CANopen") { name_ext += "-C"; }
                        if (axes[indices[i]].io) { name_ext += "-AD1"; }
                        motors = Class5D;
                    }

                    //****Do the actual sizing calculations for each axis****
                    ///If actuator required
                    if (axes[indices[i]].actuate == true)
                    {
                        axes[indices[i]] = ActuatorSize(axes[indices[i]]); //size with actuator
                        if (axes[indices[i]].best_solution != null)
                        {
                            axes[indices[i]].best_solution += name_ext;
                        }
                    }
                    else
                    {
                        for (int k = 1; k < motors.Count(); k++)
                        {
                            double feas = Evaluate(motors[k], axes[indices[i]]);
                            if (feas == 1)
                            {
                                axes[indices[i]].best_solution = motors[k].name + name_ext;
                                break;
                            }
                            else if (feas > best_feas) //if not a solution, but better option, store its index
                            {
                                best_feas = feas;
                                axes[indices[i]].alt_soln = k;
                            }
                        }
                        //If no solution out of these, check for use with gearhead
                        if (axes[indices[i]].best_solution == null)
                        {
                            string choice = "";
                            string type = "SP";
                            double[] check_gearheads = OEM_ratios;

                            for (int f = 0; f < 2; f++)
                            {
                                for (int k = 0; k < motors.Count(); k++)
                                {
                                    for (int j = 0; j < check_gearheads.Count(); j++)
                                    {
                                        double feas = Reduction(motors[k], axes[indices[i]], check_gearheads[j]);
                                        if (feas > best_feas)
                                        {
                                            choice = Convert.ToString(check_gearheads[j]);
                                            if (type == "SP")
                                            {
                                                while (choice.Count() < 3) { choice = "0" + choice; }
                                            }
                                            choice = "GH" + type + choice;
                                            axes[indices[i]].gearhead = choice;
                                            if (motors[k].name == "SM34165DT")
                                            {
                                                axes[indices[i]].gearhead += "-0.5";
                                            }
                                            if (feas == 1)
                                            {
                                                axes[indices[i]].best_solution = motors[k].name + name_ext;
                                                break;
                                            }
                                            else
                                            {
                                                axes[indices[i]].reduction = check_gearheads[j];
                                                best_feas = feas;
                                                axes[indices[i]].alt_soln = k;
                                            }
                                        }
                                    }
                                    type = "P";
                                    check_gearheads = P_ratios;
                                }
                            }
                        }
                    }

                    //Print the answer
                    outputBox.AppendText("\n[" + axes[indices[i]].name + "]:\n");
                    if (axes[indices[i]] != null && axes[indices[i]].best_solution != null)
                    {
                        outputBox.AppendText("\tRecommended motor: " + axes[indices[i]].best_solution + "\n");
                        if (axes[indices[i]].gearhead != "")
                        {
                            outputBox.AppendText("\tGearhead: " + axes[indices[i]].gearhead);
                        }
                        if (axes[indices[i]].actuator != "")
                        {
                            outputBox.AppendText("\tActuator: " + axes[indices[i]].actuator+"\n");
                        }
                    }
                    else
                    {
                        outputBox.AppendText("\tNo solution found.\n");
                        outputBox.AppendText("\tBest option: ");
                        outputBox.AppendText(motors[axes[indices[i]].alt_soln].name+name_ext);
                        if (axes[indices[i]].gearhead != "")
                        {
                            outputBox.AppendText(", \n");
                            outputBox.AppendText("\twith gearhead: " + axes[indices[i]].gearhead+"\n");
                        }
                        else
                        {
                            outputBox.AppendText("\n");
                        }
                        if (axes[indices[i]].actuator == "")
                        {
                            outputBox.AppendText("\t\tTorque = " + Convert.ToInt16(motors[axes[indices[i]].alt_soln].torq_c * axes[indices[i]].reduction) + " oz-in \n");
                            outputBox.AppendText("\t\tSpeed = " + Convert.ToInt16(motors[axes[indices[i]].alt_soln].speed / axes[indices[i]].reduction) + " RPM \n");
                        }
                        else
                        {
                            outputBox.AppendText("\tActuator: " + axes[indices[i]].actuator + "\n");
                            //What specs they would get out of it
                        }
                    }
                }
            }

            //If no axes found
            else
            {
                outputBox.Text = "No axes to size.\nPlease click 'Add' to size an axis.";
            }
                
        }


/////////Finish
        private void finish_click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Data will be lost, are you sure you want to exit?", "Exit", buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
//***********************************************************************************************
/////////Part data and functions pertaining to sizing
        //Set arrays of parts classes
        public List<Motor> Class5D = new List<Motor> { }; //Class 5 D style motors
        public List<Motor> Class5M = new List<Motor> { }; //Class 5 M style motors
        public List<Motor> Class6 = new List<Motor> { }; //Class 6 motors
        public List<Gearhead> OEM_gears = new List<Gearhead> { }; //OEM gearheads
        public List<Gearhead> prec_gears =new List<Gearhead> { }; //Precision gearheads
        public List<Gearhead> RA_gears = new List<Gearhead> { }; //Right angle gearheads
        public List<Actuator> screw_acts= new List<Actuator> { }; //Screw style actuators
        public List<Actuator> belt_acts = new List<Actuator> { }; //Belt style actuators

        //Class 5 D style
        string[] names = { "SM17205D", "SM23165D","SM23165DT","SM34165D","SM34165DT","SM23375D","SM23375DT","SM23205D","SM23305D","SM23405D","SM34205D","SM34305D","SM34405D","SM34505D" };
        int[] frames = { 17, 23, 23, 34, 34, 23, 23, 23, 23, 23, 34, 34, 34, 34 }; //frame sizes
        double[] torq_cs = { 33, 40, 74, 155, 205, 46, 83, 47, 64, 78, 126, 174, 207, 261 }; //continuous torques, oz-in
        double[] torq_ps = { 61, 64, 118, 226, 480, 80, 157, 80, 110, 129, 399, 556, 646, 771 }; //peak torques, oz-in
        double[] speeds = { 7900, 10400, 5200, 3100, 5100, 8000, 4000, 8100, 5600, 5300, 4500, 4100, 3800, 3300 }; //no load speed in RPM
        double[] weights = { 1.2, 1.0, 1.3, 5.0, 5.5, 2.1, 2.2, 1.7, 2.3, 2.8, 3.5, 4.5, 5.5, 6.5 }; //weight of motor in lbs
        string[] protocols = { "CDS7","C","DN","PB" };
        string[] options = { "DE","BRK","SH","AD1","F1","F2","K","SL" };

        ////Class 5 M style
        string[] names2 = { "SM23165MT", "SM34165MT" };
        int[] frames2 = { 23, 34 };
        double[] torq_cs2 = { 68, 201 }; //continuous torques, oz-in
        double[] torq_ps2 = { 151, 558 }; //peak torques, oz-in
        double[] speeds2 = { 5000, 4900 }; //no load speed in RPM
        double[] weights2 = { 1.5, 6.0 }; //weight of motor in lbs
        double[] shafts2 = { 0.375, 0.5 };
        string[] protocols2 = { "DN" };
        string[] options2 = { "IP", "FB01" };

        /////Class 6 
        string[] names3 = { "SM23166MT-E", "SM23216MT-E" };
        int frames3 =  23 ;
        double[] torq_cs3 = { 68, 165 };
        double[] torq_ps3 = { 128, 300 };
        double[] speeds3 = { 4700, 2250 };
        double[] weights3 = { 1.7, 2.79 };
        double shafts3 = 0.375;
        string[] protocols3 = { "CT","IP","PB"};
        string[] options3 = { };

        //Gears
        string[] gh_names = { "SP","P","RA"};
        double[] OEM_ratios = { 4, 7, 10, 16, 28, 49, 70, 100 };
        double[] P_ratios = { 3, 4, 5.5, 7, 10, 16, 22, 28, 40, 49, 55, 70, 100 };

        /////////Data set up
        public void get_data()
        { 
            //Class5D Motors
            for(int i = 0; i < names.Count(); i++)
            {
                //Set shaft size
                double shaft;
                if (i == 4) { shaft = 0.5; }
                else if (frames[i] == 17) { shaft = 0.197; }
                else if (frames[i] == 23) { shaft = 0.25; }
                else { shaft = 0.375; }
                //create motor object
                Motor temp = new Motor(names[i], frames[i], torq_cs[i], torq_ps[i], shaft, speeds[i], weights[i], protocols, options);
                
                //append
                Class5D.Add(temp);
            }

            //Class5M Motors
            for (int i = 0; i < names2.Count(); i++)
            {
                //create motor object
                Motor temp2 = new Motor(names2[i], frames2[i], torq_cs2[i], torq_ps2[i], shafts2[i], speeds2[i], weights2[i], protocols2, options2);
                //append
                Class5M.Add(temp2);
            }

            //Class6 Motors
            for (int i = 0; i < names3.Count(); i++)
            {
                //create motor object
                Motor temp3 = new Motor(names3[i], frames3, torq_cs3[i], torq_ps3[i], shafts3, speeds3[i], weights3[i], protocols3, options3);
                //append
                Class6.Add(temp3);
            }

        }

        //Evaluate function
        public double Evaluate(Motor check_motor, Axis this_axis)
        {
            double torq_compare = this_axis.torque * this_axis.duty / 100;
            double feasibility=-100000;
            if (torq_compare<check_motor.torq_c && this_axis.speed < check_motor.speed)
            {
                feasibility = 1;
            }
            else
            {
                feasibility = -1*Math.Abs(check_motor.torq_c - torq_compare) - Math.Abs(check_motor.speed - this_axis.speed);
            }

            return feasibility;
        }

        //Pick a gearhead
        public double Reduction(Motor check_motor, Axis this_axis, double gear_ratio)
        {
            double weight;
            double new_torque = gear_ratio * check_motor.torq_c * 100 / this_axis.duty;
            double new_speed = check_motor.speed / gear_ratio;
            if (this_axis.torque <= new_torque && this_axis.speed < new_speed)
            {
                weight = 1;
            }
            else
            {
                weight = -1 * Math.Abs(new_torque - this_axis.torque) - Math.Abs(this_axis.speed - new_speed);
            }
            
            return weight;
        }

        //Actuator sizing
        public Axis ActuatorSize(Axis this_axis)
        {
            double max_speed = 977;
            double max_thrust = 587;
            double HLDThrust = 135;
            string pitch="";
            string stroke="";
            string extra = "";

            //Convert values to mm, kg, and mm/s
            if (this_axis.m_unit != "kg")
            {
                this_axis.mass /= 2.2;
            }
            if (this_axis.ps_unit != "mm")
            {
                this_axis.stroke *= 25.4;
                this_axis.pitch *= 25.4;
            }
            if (this_axis.s_unit == "m/s")
            {
                this_axis.speed *= 10;
            }
            else if(this_axis.s_unit == "in/s"){
                this_axis.speed *= 25.4;
            }
            if (this_axis.stroke != 0)
            {
                stroke = Convert.ToString((Math.Ceiling(this_axis.stroke/50))*50);
                while (stroke.Count() < 4)
                {
                    stroke = "0" + stroke;
                }
                stroke = "-" + stroke;
            }

            //Check for ability to be sized
            if (this_axis.speed > max_speed || this_axis.thrust > max_thrust)
            {
                this_axis.alt_soln = 2; //corresponds to SM23165DT
                //Max out on thrust using L70 5 mm pitch
                if (this_axis.thrust > max_thrust)
                {
                    this_axis.actuator = "L70";
                    pitch = "-050";
                }
                //Max out on speed with L70 10mm pitch for max thrust
                else if (this_axis.thrust > HLDThrust)
                {
                    this_axis.actuator = "L70";
                    pitch = "-100";
                }
                //If thrust is fine, use HLD60 12.5 mm pitch
                else
                {
                    this_axis.actuator = "H3";
                    pitch = "-125";
                }
            }
            //If appropriate actuator specs are available in product line
            else
            {
                this_axis.best_solution = "SM23165DT";
                if (this_axis.torque<max_thrust && this_axis.speed < 350)
                {
                    this_axis.actuator = "L70";
                    pitch = "-050";
                }
                else if (this_axis.torque<294 && this_axis.speed < 910)
                {
                    this_axis.actuator = "L70";
                    pitch = "-100";
                }
                else if (this_axis.torque < 450 && this_axis.speed < 200)
                {
                    this_axis.actuator = "H3";
                    pitch = "-025";
                }
                else if (this_axis.torque < 420 && this_axis.speed < 391)
                {
                    this_axis.actuator = "H3";
                    pitch = "-050";
                }
                else if (this_axis.torque < 185 && this_axis.speed < 782)
                {
                    this_axis.actuator = "H3";
                    pitch = "-100";
                }
                else if (this_axis.torque < 135 && this_axis.speed < 977)
                {
                    this_axis.actuator = "H3";
                    pitch = "-125";
                }
            }
            if (this_axis.actuator.Substring(0,1) == "L")
            {
                extra = "R-AN";
            }
            else
            {
                extra = "A-AL";
            }
            this_axis.actuator += stroke + pitch + extra;
            return this_axis;
        }
    }
}
