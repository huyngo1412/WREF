using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using NCKH.View;
namespace NCKH.ViewModel
{
    class Element
    {
        private object shapeType;
        public object ShapeType
        {
            get { return shapeType; }
            set { shapeType = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Nodes firstNode;
        public Nodes FirstNode
        {
            get { return firstNode; }
            set { firstNode = value; }
        }
        private Nodes secondNode;
        public Nodes SecondNode
        {
            get { return secondNode; }
            set { secondNode = value; }
        }
        private double length;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        private Line lineEle;
        public Line LineEle
        {
            get { return lineEle; }
            set { lineEle = value; }
        }
        private double a1;
        public double A1
        {
            get { return a1; }
            set { a1 = value; }
        }
        private ObservableCollection<Analyze> resuilt;
        public ObservableCollection<Analyze>  Reuilt
        {
            get { return resuilt; }
            set { resuilt = value; }
        }    
    }
}
