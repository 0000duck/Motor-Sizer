using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Axis
    {
        bool exist = false;
        string name = ""; //axis name
        bool linear = false;
        double torque = 0; //oz-in
        string t_unit; //torque input unit
        double speed = 0; //RPM, or linear speed
        string s_unit; //speed unit
        double pitch = 0; //pitch(screw)
        string p_unit;  //pitch input unit
        double thrust = 0; //thrust force
        double th_unit; //thrust input unit
        double eff = 1; //efficiency
        double duty = 100; //default to 100% duty cycle
        string protocol; //communication protocol
        double temp; //operating temperature (C)
        double IP = 0; //IP rating 
    }
}
