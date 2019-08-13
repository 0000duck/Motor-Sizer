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
    public partial class EditTool : Form
    {
        //the object instance that will be accessed from parent form
        public Axis return_axis
        { get; set; }


        public EditTool(Axis axis_in)
        {
            InitializeComponent();

            //Fill in the text boxes with info
            nameBox.Text = axis_in.name;
            torqueBox.Value = Convert.ToDecimal(axis_in.torque);
            speedBox.Value = Convert.ToDecimal(axis_in.speed);
            thrustBox.Value = Convert.ToDecimal(axis_in.thrust);
            dutyBox.Value = Convert.ToDecimal(axis_in.duty);
            if (axis_in.actuate == true) { pitchStrokeBox.Value = Convert.ToDecimal(axis_in.stroke); }
            else { pitchStrokeBox.Value = Convert.ToDecimal(axis_in.pitch); }
            accelBox.Value = Convert.ToDecimal(axis_in.accel);

            //Fill in the units
            if (axis_in.t_unit != null) { torqueUnit.SelectedValue = axis_in.t_unit; }
            if (axis_in.s_unit != null) { speedUnit.SelectedValue = axis_in.s_unit; }
            if (axis_in.ps_unit != null) { pitchStrokeUnit.SelectedValue = axis_in.ps_unit; }
            if (axis_in.th_unit != null) { thrustUnit.SelectedValue = axis_in.th_unit; }
            if (axis_in.m_unit != null) { MassUnit.SelectedValue = axis_in.m_unit; }
            if (axis_in.accel_unit != null) { ADUnit.SelectedValue = axis_in.accel_unit; }

            //Check the boxes and buttons
            if (axis_in.type){linearButton.Checked = true;}
            else {
                rotateButton.Checked=true;
                thrustBox.Visible = false;
                ThrustLabel.Visible = false;
                thrustUnit.Visible = false;
            }
            if (axis_in.actuate) { actuatorBox.CheckState=CheckState.Checked; }
            if (axis_in.brake) { brakeCheck.CheckState = CheckState.Checked; }
            if (axis_in.de) { DEBox.CheckState = CheckState.Checked; }
            if (axis_in.io) { IOBox.CheckState = CheckState.Checked; }

            toolBrake.SetToolTip(brakeCheck, "Internal brakes can be added so that the motor maintains position on power loss, particularly in vertical applications.");
            toolDE.SetToolTip(DEBox, "Drive enable allows the 'brains' of the motor to remain powered separately from the 'muscle'.");
            toolTipIO.SetToolTip(IOBox, "Check box if 24V I/O is preferred (over 5V).");
        }

        //Change to rotation
        public void Rotate(object sender, EventArgs e)
        {
            //When rotational motion is selected, uncheck the actuator box, and hide linear motion prompts
            if (rotateButton.Checked == true)
            {
                actuatorBox.CheckState = CheckState.Unchecked;
                thrustBox.Visible = false;
                ThrustLabel.Visible = false;
                thrustUnit.Visible = false;
                pitchStrokeBox.Visible = false;
                PitchLabel.Visible = false;
                StrokeLabel.Visible = false;
                pitchStrokeUnit.Visible = false;
            }
        }

        public void Linear(object sender, EventArgs e)
        {
            if (linearButton.Checked == true)
            {
                actuatorBox.Checked = true;
                thrustBox.Visible = true;
                ThrustLabel.Visible = true;
                thrustUnit.Visible = true;
                pitchStrokeUnit.Visible = true;
                pitchStrokeBox.Visible = true;
                StrokeLabel.Visible = true;
            }
        }

        public void Actuator(object sender,EventArgs e)
        {
            if (actuatorBox.Checked == true)
            {
                pitchStrokeBox.Visible = true;
                StrokeLabel.Visible = true;
                PitchLabel.Visible = false;
            }
            else
            {
                pitchStrokeBox.Visible = true;
                StrokeLabel.Visible = false;
                PitchLabel.Visible = true;
            }
        }


        //Exit button
        public void Exit(object sender, EventArgs e)
        {

            //Capture all the data from the form
            return_axis = new Axis();
            return_axis.name = nameBox.Text;

            //convert input torque value to oz-in in axis class for sizing
            switch (torqueUnit.Text)
            {
                case "oz-in":
                    return_axis.torque = Convert.ToDouble(torqueBox.Value);
                    break;
                case "Nm":
                    return_axis.torque = Convert.ToDouble(torqueBox.Value) * 141.6;
                    break;
                case "ft-lb":
                    return_axis.torque = Convert.ToDouble(torqueBox.Value) * 16.0 * 12.0;
                    break;
                case "in-lb":
                    return_axis.torque = Convert.ToDouble(torqueBox.Value) * 16.0;
                    break;
                default:
                    return_axis.torque = Convert.ToDouble(torqueBox.Value);
                    break;
            }

            return_axis.speed = Convert.ToDouble(speedBox.Value);

            if (PitchLabel.Visible == true)
            {
                return_axis.pitch = Convert.ToDouble(pitchStrokeBox.Value);
                return_axis.actuate = false;
                return_axis.stroke = -1.0;
            }
            else if (StrokeLabel.Visible == true)
            {
                return_axis.stroke = Convert.ToDouble(pitchStrokeBox.Value);
                return_axis.actuate = true;
                return_axis.pitch = -1.0;
            }

            return_axis.duty = Convert.ToDouble(dutyBox.Value);
            return_axis.type = linearButton.Checked;
            return_axis.actuate = actuatorBox.Checked;
            return_axis.brake = brakeCheck.Checked;
            return_axis.io = IOBox.Checked;
            return_axis.de = DEBox.Checked;
            return_axis.ps_unit = pitchStrokeUnit.Text;

            //Check for errors in the data entered
            if (actuatorBox.Checked && pitchStrokeBox.Value <= 0)
            {
                MessageBox.Show("Please provide a stroke length or de-select actuator sizing.");
            }
            //If all is good, store data and close
            else
            {
                //Close window
                this.Close();
            }
        }

    }
}
