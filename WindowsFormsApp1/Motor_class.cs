using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Motor
    {
        public string name;
        int frame;
        public double torq_c;
        double torq_p;
        public double speed; //no load speed, RPM
        double weight; //pounds
        double shaft;
        public string[] protocols;
        string[] options;
        public int feasibility = 0;

        //Constructor
        public Motor(string n, int f, double tc, double tp, double sh, double s, double w, string[] pr, string[] op)
        {
            name = n;
            frame = f;
            torq_c = tc;
            torq_p = tp;
            shaft = sh;
            speed = s;
            weight = w;
            protocols = pr;
            options = op;
        }

    }
}
