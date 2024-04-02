using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCKH.View
{
    class Analyze
    {
        private double strain_cc;
        public double Strain_cc
        {
            get { return strain_cc; }
            set { strain_cc = value; }
        }
        private double strain_ct;
        public double Strain_ct
        {
            get { return strain_ct; }
            set { strain_ct = value; }
        }
        private double strain_sc;
        public double Strain_sc
        {
            get { return strain_sc; }
            set { strain_sc = value; }
        }
        private double strain_st;
        public double Strain_st
        {
            get {return strain_st; }
            set { strain_st = value; }
        }
        private double stress_cc;
        public double Stress_cc
        {
            get { return stress_cc; }
            set { stress_cc = value; }
        }
        private double stress_sc;
        public double Stress_sc
        {
            get { return stress_sc; }
            set { stress_sc = value; }
        }
        private double stress_st;
        public double Stress_st
        {
            get { return stress_st; }
            set { stress_st = value; }
        }
        private double force_cc;
        public double Force_cc
        {
            get { return force_cc; }
            set { force_cc = value; }
        }
        private double force_sc;
        public double Force_sc
        {
            get { return force_sc; }
            set { force_sc = value; }
        }
        private double force_st;
        public double Force_st
        {
            get { return force_st; }
            set { force_st = value; }
        }
        private double disparity;
        public double Disparity
        {
            get { return disparity; }
            set { disparity = value; }
        }
        private double phi;
        public double Phi
        {
            get { return phi; }
            set { phi = value; }
        }
        private double moment_cc;
        public double Moment_cc
        {
            get { return moment_cc; }
            set { moment_cc = value; }
        }
        private double moment_sc;
        public double Moment_sc
        {
            get { return moment_sc; }
            set { moment_sc = value; }
        }
        private double moment_st;
        public double Moment_st
        {
            get { return moment_st; }
            set { moment_st = value; }
        }
        private double momentF;
        public double MomentF
        {
            get { return momentF; }
            set { momentF = value; }
        }
        private double EIeff;
        public double EIEff
        {
            get { return EIeff; }
            set { EIeff = value; }
        }
        private double p;
        public double P
        {
            get { return p; }
            set { p = value; }
        }
        private double delta;
        public double Delta
        {
            get { return delta; }
            set { delta = value; }
        }
    }
}
