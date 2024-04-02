using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCKH.View
{
    public class Concretes
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
        private double fc;
        public double Fc
        {
            get { return fc; }
            set { fc = value; }
        }
        private double e;
        public double E
        {
            get { return e; }
            set { e = value; }
        }
    }
}
