using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCKH.View
{
    public class Section
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
       
    }
    public class Rec_Concreate : Section
    {
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        private Concretes concreate;
        public Concretes Concreate
        {
            get { return concreate; }
            set { concreate = value; }
        }
        private Steels long_Mat_Bar_Otop;
        public Steels Long_Mat_Bar_Otop
        {
            get { return long_Mat_Bar_Otop; }
            set { long_Mat_Bar_Otop = value; }
        }
        private Steels long_Mat_Bar_Obottom;
        public Steels Long_Mat_Bar_Obottom
        {
            get { return long_Mat_Bar_Obottom; }
            set { long_Mat_Bar_Obottom = value; }
        }
        private Steels con_Mat_Bar;
        public Steels Con_Mat_Bar
        {
            get { return con_Mat_Bar; }
            set { con_Mat_Bar = value; }
        }
        private int long_Size_Bar_Otop;
        public int Long_Size_Bar_Otop
        {
            get { return long_Size_Bar_Otop; }
            set { long_Size_Bar_Otop = value; }
        }
        private int long_Size_Bar_Obottom;
        public int Long_Size_Bar_Obottom
        {
            get { return long_Size_Bar_Obottom; }
            set { long_Size_Bar_Obottom = value; }
        }
        private int number_Long_Bar_Otop;
        public int Number_Long_Bar_Otop
        {
            get { return number_Long_Bar_Otop; }
            set { number_Long_Bar_Otop = value; }
        }
        private int number_Long_Bar_Obottom;
        public int Number_Long_Bar_Obottom
        {
            get { return number_Long_Bar_Obottom; }
            set { number_Long_Bar_Obottom = value; }
        }
        private double coverFCon;
        public double CoverFCon
        {
            get { return coverFCon; }
            set { coverFCon = value; }
        }
    }
}
