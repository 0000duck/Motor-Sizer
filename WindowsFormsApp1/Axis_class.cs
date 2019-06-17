using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Axis
    {
        public string name;
        public double torque;
        public string t_unit;
        public double speed;
        public string s_unit;
        public double accel;
        public string accel_unit;
        public double duty = 100;
        public double pitch;
        public string ps_unit; //unit of pitch or stroke
        public double thrust;
        public string th_unit;
        public bool type=true; //true for linear, false for rotation
        public bool actuate=true; //true for an actuator being sized
        public bool io;
        public bool brake;
        public bool de;
        public bool exist=true;
        public double stroke;
        public double mass;
        public string m_unit;

        //sizing tool output
        public string best_solution; //PN of the motor that fits all parameters
        public int alt_soln;    //index within list of motors of the next-best solution
        public string gearhead="";
        public double reduction=1; //ratio of the gearhead part number 
        public string actuator="";
    }
}
