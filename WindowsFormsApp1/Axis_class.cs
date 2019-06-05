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
        public double duty = 100;
        public double pitch;
        public string p_unit;
        public double thrust;
        public string th_unit;
        public bool type; //type 0 = rotation, type 1 = linear
        public bool actuate;
        public bool io;
        public bool brake;
        public bool de;
        public bool exist=true;
        public double stroke;

        //sizing tool output
        public string best_solution;
        public string gearhead;
        public string actuator;
    }
}
