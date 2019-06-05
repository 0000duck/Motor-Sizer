using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Actuator
    {
        string name;
        bool rod; //1: rod actuator, 0=rodless
        double[] strokes; //a vector of stroke lengths {minimum, increment, maximum} in mm
        double lead; //mm
        double thrust;
        double speed;
        double mass;

        //Constructor
        public Actuator(string n, bool r, double[] str, double l, double th, double s, double m)
        {
            name = n;
            rod = r;
            strokes = str;
            lead = l;
            thrust = th;
            speed = s;
            mass = m;
        }
    }
}
