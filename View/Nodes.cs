using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace NCKH.View
{
    public class Nodes
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private Point center;
        public Point Center
        {
            get { return center; }
            set { center = value; }
        }
        private Ellipse cir;
        public Ellipse Cir
        {
            get { return cir; }
            set { cir = value; }
        }
    }
}
