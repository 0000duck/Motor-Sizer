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
            pitchBox.Value = Convert.ToDecimal(axis_in.pitch);
            dutyBox.Value = Convert.ToDecimal(axis_in.duty);
            strokeBox.Value = Convert.ToDecimal(axis_in.stroke);
            //Fill in the units
            if (axis_in.t_unit != null) { torqueUnit.SelectedValue = axis_in.t_unit; }
            if (axis_in.s_unit != null) { speedUnit.SelectedValue = axis_in.s_unit; }
            if (axis_in.p_unit != null) { pitchUnit.SelectedValue = axis_in.p_unit; }
            if (axis_in.th_unit != null) { thrustUnit.SelectedValue = axis_in.th_unit; }
            //Check the boxes and buttons
            if (axis_in.type) { linearButton.Checked = true; } else { rotateButton.Checked=true; }
            if (axis_in.actuate) { actuatorBox.CheckState=CheckState.Checked; }
            if (axis_in.brake) { brakeCheck.CheckState = CheckState.Checked; }
            if (axis_in.de) { DEBox.CheckState = CheckState.Checked; }
            if (axis_in.io) { IOBox.CheckState = CheckState.Checked; }
        }

        //Change to rotation
        public void Rotate(object sender, EventArgs e)
        {
            if (rotateButton.Checked == true){
                actuatorBox.CheckState = CheckState.Unchecked;
            }
        }


        //Exit button
        public void Exit(object sender, EventArgs e)
        {
            //Capture all the data from the form
            return_axis = new Axis();
            return_axis.name = nameBox.Text;
            return_axis.torque = Convert.ToDouble(torqueBox.Value);
            return_axis.speed = Convert.ToDouble(speedBox.Value);
            return_axis.pitch = Convert.ToDouble(pitchBox.Value);
            return_axis.duty = Convert.ToDouble(dutyBox.Value);
            return_axis.stroke = Convert.ToDouble(strokeBox.Value);
            return_axis.type = linearButton.Checked;
            return_axis.actuate = actuatorBox.Checked;
            return_axis.brake = brakeCheck.Checked;
            return_axis.io = IOBox.Checked;
            return_axis.de = DEBox.Checked;

            //Close window
            this.Close();
        }

    }
}
