using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCKH.View
{
    public class Steels
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double fy;
        public double Fy
        {
            get { return fy; }
            set { fy = value; }
        }
        private double fu;
        public double Fu
        {
            get { return fu; }
            set { fu = value; }
        }
        private double e;
        public double E
        {
            get { return e; }
            set { e = value; }
        }
    }
}
