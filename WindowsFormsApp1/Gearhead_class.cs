using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Gearhead
    {
        string name;
        char type; //either O=OEM, P=precision, R=right angle
        int ratio;
        int backlash; //arc minutes
        int efficiency; //out of 100%
        int[] cont_torq;
        int[] rpm;

        //Constructor
        public Gearhead(string n, char t, int r, int b, int e, int[] ct, int[] rpm_in)
        {
            name = n;
            type = t;
            ratio = r;
            backlash = b;
            efficiency = e;
            cont_torq = ct;
            rpm = rpm_in;
        }
    }
}
