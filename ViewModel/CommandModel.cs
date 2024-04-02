using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using NCKH.View;
using NCKH.UserControlsElement;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Windows.Shapes;
using System.ComponentModel;
using LiveCharts;
using LiveCharts.Wpf;

namespace NCKH.ViewModel
{
    class CommandModel
    {
        double Strain_ct, Strain_cc = 1E-10, Strain_st, Strain_sc;
        double stress_cc, stress_st, stress_sc;
        double F_st, F_sc, F_cc;
        bool a_Mep = true;
        double b, h, a, a_c, a_t, Nc, Nt, L, a_Cat, D_c, D_t;
        double Es , fy_SteelC, fy_SteelT, fc, Ec, Esc, Est;
        double M_st, M_sc, M_cc;
        double Strain_Co;
        double value = 1E-9;
        double A_EIeff = 0, Delta_A, A_EIeffModify = 0, Delta_AEIeffModify;
        bool N1 = false;
        public static bool IsUscNode = false;
        public static bool IsUscElement = false;
        public static bool IsMat = false;
        public static bool IsSec = false; 
        public static bool isMatConcreate = false;
        public static bool isMatSteel = false;
        public static bool isMaterial = false;
        public static bool isSection = false;
        public static bool isRec_Con_Shape = false;
        public static bool isClickNode = false;
        public static int IDNode = 0;
        public static bool isEleFirstNode = false;
        public static bool isEleLastNode = false;
        public static bool isDesignLoad = false;
        public static double Scale = 0.1;
        public static int Tab_Index_Nodes = -1;
        public static int Tab_Index_Element = -1;
        public static string ChooseEle = "";
        public static double coefficient = 0.9;
        public static bool RunAna = false;
        private static ObservableCollection<string> pointNodeF = new ObservableCollection<string>();
        public static ObservableCollection<string> PointNodeF
        {
            get { return pointNodeF; }
            set { pointNodeF = value; }
        }
        private static ObservableCollection<string> pointNodeL = new ObservableCollection<string>();
        public static ObservableCollection<string> PointNodeL
        {
            get { return pointNodeL; }
            set { pointNodeL = value; }
        }
        private static ObservableCollection<string> position = new ObservableCollection<string>();
        public static ObservableCollection<string> Position
        {
            get { return position; }
            set { position = value; }
        }
        private static ObservableCollection<Analyze> resuilt = new ObservableCollection<Analyze>();
        public static ObservableCollection<Analyze> Resuilt
        {
            get { return resuilt; }
            set { resuilt = value; }
        }
        private static string unit = "--";
        public static string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
            }
        }
        private static string unitLoad = "--";
        public static string UnitLoad
        {
            get { return unitLoad; }
            set
            {
                unitLoad = value;
            }
        }
        private static string unitLenght = "--";
        public static string UnitLenght
        {
            get { return unitLenght; }
            set
            {
                unitLenght = value;
            }
        }
        private ObservableCollection<int> rebar = new ObservableCollection<int>() { 6,8,10,12,14,16,18,20,22,25,28,30,32,36};
        public ObservableCollection<int> Rebar
        {
            get { return rebar; }
            set { rebar = value; }
        }
        private static ObservableCollection<Nodes> listNode = new ObservableCollection<Nodes>();
        public static ObservableCollection<Nodes> ListNode
        {
            get { return listNode; }
            set { listNode = value; }
        }
        private static ObservableCollection<Element> listEle = new ObservableCollection<Element>();
        public static ObservableCollection<Element> ListEle
        {
            get { return listEle; }
            set { listEle = value; }
        }
        private List<string> comboUnitLoad = new List<string>() { "knf","tonf","N","kN"};
        public List<string> ComboUnitLoad
        {
            get { return comboUnitLoad; }
            set { comboUnitLoad = value; }
        }
        private List<string> comboUnitLenght = new List<string>() { "mm", "cm","m","in" };
        public List<string> ComboUnitLenght
        {
            get { return comboUnitLenght; }
            set { comboUnitLenght = value; }
        }
        private static  ObservableCollection<object> material = new ObservableCollection<object>();
        public static ObservableCollection<object> Material
        {
            get { return material; }
            set { material = value; }
        }
        private static ObservableCollection<object> section = new ObservableCollection<object>();
        public static ObservableCollection<object> Section
        {
            get { return section; }
            set { section = value; }
        }
        private static ObservableCollection<Rec_Concreate> rec_Concreates = new ObservableCollection<Rec_Concreate>();
        public static ObservableCollection<Rec_Concreate> Rec_Concreates
        {
            get { return rec_Concreates; }
            set { rec_Concreates = value; }
        }

        private static ObservableCollection<Concretes> listConcreates = new ObservableCollection<Concretes>();
        public static ObservableCollection<Concretes> ListConcreates
        {
            get { return listConcreates; }
            set { listConcreates = value; }
        }
        private static ObservableCollection<Steels> listSteels = new ObservableCollection<Steels>(); /*= new ObservableCollection<Concreates>(Material.OfType<Concreates>());*/
        public static ObservableCollection<Steels> ListSteels
        {
            get { return listSteels; }
            set { listSteels = value; }
        }
        public ICommand OpenFormPropertiesForm { get; set; }
        public ICommand OpenFormMaterialPropertieData { get; set; }
        public ICommand OpenModifyRebarForm { get; set; }
        public ICommand CreateNode { get; set; }
        public ICommand OpenShapeForm { get; set; }
        public ICommand OpenFormNodes { get; set; }
        public ICommand CloseFormNodes { get; set; }
        public ICommand ImportMaterial { get; set; }
        public ICommand OpenShapeDataForm { get; set; }
        public ICommand ImportSection { get; set; }
        public ICommand CreateElement { get; set; }
        public ICommand DesignLoad { get; set; }
        public ICommand RunAnalyze { get; set; }
        public CommandModel()
        {
            Window mainWindow = Application.Current.MainWindow;
            OpenFormPropertiesForm = new BaseCommand<object>((p) => true, (p) =>
            {
                unit = "-";
                if (mainWindow != null)
                {
                    // Tìm element theo tên và ép kiểu đối tượng cần thiết
                    var element = mainWindow.FindName("Grid_Unit") as Grid;

                    // Kiểm tra nếu element được tìm thấy
                    if (element != null)
                    {
                        //Lấy children của grid
                        UIElementCollection children = element.Children;
                        foreach (var item in children)
                        {
                            var a = item as ComboBox;
                            if (a.Name == "Cb_UnitLoad")
                            {
                                unitLoad = a.SelectedItem.ToString();
                                unit = a.SelectedItem.ToString();
                            }
                            if (a.Name == "Cb_Unit_Length")
                            {
                                unitLenght = a.SelectedItem.ToString();
                                unit = unit + "/" + a.SelectedItem.ToString() + "²";
                            }
                        }
                    }
                }
                PropertiesForm f = new PropertiesForm();
                f.ShowDialog();
            });
            OpenFormMaterialPropertieData = new BaseCommand<object>((p) => true, (p) =>
            {
                MaterialDataForm materialDataForm = new MaterialDataForm();
                materialDataForm.ShowDialog();
            });
            ImportMaterial = new BaseCommand<Window>(p => true, p =>
            {
                Window w = p as Window;
                if(w != null)
                {
                    TextBox tbid = w.FindName("txb_Id_Mat") as TextBox;
                    TextBox tbname = w.FindName("txb_Name_Mat") as TextBox;
                    int id = 0;
                    string name = "";
                    if(tbid!=null && tbname!=null)
                    {
                        id = int.Parse(tbid.Text);
                        name = tbname.Text;
                    }
                    Grid gridData = w.FindName("Grid_De_Pro_Data") as Grid;
                    if (isMatConcreate == true)
                    {
                        
                        if(gridData != null)
                        {
                            UIElementCollection ele = gridData.Children;
                            if(ele != null)
                            {
                                foreach (var item in ele)
                                {
                                    UserControl usc = item as UserControl;
                                    if(usc != null)
                                    {
                                        TextBox tbmodulus = usc.FindName("txb_Modulus_Concreate") as TextBox;
                                        TextBox tbfc = usc.FindName("txb_fc_Concreate") as TextBox;
                                        if(tbmodulus != null && fc !=null)
                                        {
                                            Concretes concretes = new Concretes
                                            {
                                                ID = id,
                                                Name = name,
                                                E = double.Parse(tbmodulus.Text),
                                                Fc = double.Parse(tbfc.Text),
                                            };
                                            material.Add(concretes);
                                            listConcreates.Add(concretes);
                                            
                                        }    
                                    }    
                                }
                            }    
                        }    
                    }  
                    if(isMatSteel == true)
                    {
                        if (gridData != null)
                        {
                            UIElementCollection ele = gridData.Children;
                            if (ele != null)
                            {
                                foreach (var item in ele)
                                {
                                    UserControl usc = item as UserControl;
                                    if (usc != null)
                                    {
                                        TextBox tbE = usc.FindName("txb_Modulus_Steel") as TextBox;
                                        TextBox tbFy = usc.FindName("txb_fy") as TextBox;
                                        TextBox tbFu = usc.FindName("txb_fu") as TextBox;
                                        if(tbE!=null&&tbFy!=null&& tbFu!=null)
                                        {
                                            Steels steels = new Steels
                                            {
                                                ID = id,
                                                Name = name,
                                                E = double.Parse(tbE.Text),
                                                Fy = double.Parse(tbFy.Text),
                                                Fu = double.Parse(tbFu.Text),
                                            };
                                            material.Add(steels);
                                            listSteels.Add(steels);
                                           
                                        }    
                                    }
                                }
                            }
                        }
                    }    
                }    
            });
            OpenShapeForm = new BaseCommand<object>((p) => true, (p) =>
            {
                ShapeForm shapeForm = new ShapeForm();
                shapeForm.ShowDialog();
            });
            OpenShapeDataForm = new BaseCommand<UserControl>((p) => true, (p) => {
                FrameworkElement windowCurrent = GetParentUser(p);
                var w = windowCurrent as Window;
                if (w != null)
                {
                    w.Close();
                    SectionFormData sectionFormData = new SectionFormData();
                    sectionFormData.ShowDialog();
                }
            });
            OpenModifyRebarForm = new BaseCommand<object>((p) => true, (p) =>
            {
                RebarProForm rebarProForm = new RebarProForm();
                rebarProForm.ShowDialog();
            });
            OpenFormNodes = new BaseCommand<object>((p) => true, (p) =>
                {
                    if (mainWindow != null)
                    {
                       // Tìm element theo tên và ép kiểu đối tượng sang grid
                       var element = mainWindow.FindName("GridElement") as Grid;
                       // Kiểm tra nếu element được tìm thấy
                       if (element != null)
                        {
                           //Lấy children của grid
                           UIElementCollection children = element.Children;
                            children.Clear();
                            UserControl usc = new UserControlsElement.UserControlsTreemenu();
                            children.Add(usc);
                        }
                    }
                });
            ImportSection = new BaseCommand<Window>(p => true, p => {
                Window w = p as Window;
                int ID = 0;
                string Name = "";
                Concretes concreates = new Concretes();
                if (w != null)
                {
                    Grid GridShapeType = w.FindName("GridShapeType") as Grid;
                    Grid Grid_Section = w.FindName("Grid_Section") as Grid;
                    if (Grid_Section != null)
                    {
                        UIElementCollection element = Grid_Section.Children;
                        foreach (var item in element)
                        {
                            TextBox txb = item as TextBox;
                            ComboBox cb = item as ComboBox;
                            if (txb != null)
                            {
                                switch (txb.Name)
                                {
                                    case "txb_ID":
                                        ID = int.Parse(txb.Text);
                                        break;
                                    case "txb_Name_Section":
                                        Name = txb.Text;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            if (cb != null)
                            {
                                if (cb.Name == "Cb_Concreate")
                                {
                                    concreates = ListConcreates.Where(x => x.Name == cb.SelectedValue.ToString()).FirstOrDefault();

                                }
                            }
                        }
                    }
                    if (GridShapeType != null)
                    {
                        UIElementCollection element = GridShapeType.Children;
                        foreach (var item in element)
                        {
                            UserControl usc = item as UserControl;
                            if (usc != null)
                            {
                                switch (usc.Name)
                                {
                                    case "Rec_Con_Dim_Form":
                                        double Height = 0;
                                        double Width = 0;
                                        TextBox txb_Height = usc.FindName("txb_Height") as TextBox;
                                        TextBox txb_Width = usc.FindName("txb_Width") as TextBox;  
                                        Grid grid = usc.FindName("Grid_Rec") as Grid;
                                        UIElementCollection elementusc = grid.Children;
                                        foreach (var itemusc in elementusc)
                                        {
                                            TextBox txb = itemusc as TextBox;
                                            if (txb != null)
                                            {
                                                switch (txb.Name)
                                                {
                                                    case "txb_Height":
                                                        Height = double.Parse(txb.Text);
                                                        continue;
                                                    case "txb_Width":
                                                        Width = double.Parse(txb.Text);
                                                        continue;
                                                    default:
                                                        break;
                                                }
                                            }
                                        }
                                        Rec_Concreate rec_Concreate = new Rec_Concreate();
                                        rec_Concreate.ID = ID;
                                        rec_Concreate.Name = Name;
                                        rec_Concreate.Height = Height;
                                        rec_Concreate.Width = Width;
                                        rec_Concreate.Concreate = concreates;
                                        rec_Concreate.Long_Mat_Bar_Otop = RebarProForm.Long_Mat_Bar_Otop;
                                        rec_Concreate.Long_Mat_Bar_Obottom = RebarProForm.Long_Mat_Bar_Obottom;
                                        rec_Concreate.Con_Mat_Bar = RebarProForm.Con_Mat_Bar;
                                        rec_Concreate.Long_Size_Bar_Otop = RebarProForm.Long_Size_Bar_Otop;
                                        rec_Concreate.Long_Size_Bar_Obottom = RebarProForm.Long_Size_Bar_Obottom;
                                        rec_Concreate.Number_Long_Bar_Otop = RebarProForm.Num_Long_Bar_Otop;
                                        rec_Concreate.Number_Long_Bar_Obottom = RebarProForm.Num_Long_Bar_Obottom;
                                        rec_Concreate.CoverFCon = RebarProForm.Cover_ForCon;
                                        section.Add(rec_Concreate);
                                        rec_Concreates.Add(rec_Concreate);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            });
            CreateNode = new BaseCommand<UserControl>((p) => true, (p) => {
                Point Node = new Point();
                UserControl usc = p as UserControl;
                TextBox txb = usc.FindName("txb_Coordinates") as TextBox;
                FrameworkElement windowCurrent = GetParentUser(p);
                var w = windowCurrent as Window;
                if (w != null && txb != null)
                {
                    string[] Position = txb.Text.Split(',');
                    Node.X = double.Parse(Position[0].Trim())*Scale;
                    Node.Y = double.Parse(Position[1].Trim()) * Scale;
                    Canvas cv = w.FindName("ViewFrame") as Canvas;
                    if (cv != null)
                    {
                        IDNode += 1;
                        cv.Children.Clear();
                        Nodes node = new Nodes
                        {
                            ID = IDNode,
                            Cir = CreateNodeMethod(Node),
                            Center = new Point(Node.X / Scale, Node.Y/Scale),
                        };
                        listNode.Add(node);
                       
                        foreach (var item in listNode)
                        {
                            
                            cv.Children.Add(item.Cir);
                        }
                    }
                }
            });
            CloseFormNodes = new BaseCommand<object>((p) => true, (p) =>
            {
                if (mainWindow != null)
                {
                    // Tìm element theo tên và ép kiểu đối tượng cần thiết
                    var element = mainWindow.FindName("GridElement") as Grid;
                    // Kiểm tra nếu element được tìm thấy
                    if (element != null)
                    {
                        //Lấy children của grid
                        UIElementCollection children = element.Children;
                        children.Clear();
                    }
                }
            });              
            CreateElement = new BaseCommand<UserControl>((p) => true, (p) => {           
                UserControl usc = p as UserControl;
                FrameworkElement windowCurrent = GetParentUser(p);
                var w = windowCurrent as Window;
                ComboBox Cb = usc.FindName("Cb_Section") as ComboBox;
                TextBox txbName = usc.FindName("txb_Name") as TextBox;
                TextBox txbFirstPoint = usc.FindName("txb_First_Node") as TextBox;
                TextBox txbLastPoint = usc.FindName("txb_Last_Node") as TextBox;                  
                if(txbName!=null&& txbFirstPoint!=null&& txbLastPoint!=null&& w != null && Cb!=null)
                {
                    string[] FirstPoint = txbFirstPoint.Text.Trim().Split(',');
                    string[] LastPoint = txbLastPoint.Text.Trim().Split(',');
                    object ShapeType = null;
                    Nodes FirstNode = ListNode.Where(item=>item.Center.X == double.Parse(FirstPoint[0]) && item.Center.Y == double.Parse(FirstPoint[1])).FirstOrDefault();
                    Nodes SecondNode = ListNode.Where(item => item.Center.X == double.Parse(LastPoint[0]) && item.Center.Y == double.Parse(LastPoint[1])).FirstOrDefault();
                    double Length = Math.Sqrt(Math.Pow(FirstNode.Center.X - SecondNode.Center.X , 2) + Math.Pow(FirstNode.Center.Y  - SecondNode.Center.Y , 2));
                    Canvas cv = w.FindName("ViewFrame") as Canvas;                    
                    if (cv!=null)
                    {
                        foreach (var item in Section)
                        {
                            if(item.GetType() == typeof(Rec_Concreate))
                            {
                                Rec_Concreate rec_Shape = (Rec_Concreate)item;
                                if (rec_Shape != null)
                                {
                                    if (rec_Shape.Name == Cb.Text)
                                    {
                                        ShapeType = item;
                                    }
                                }
                            }                         
                        }
                        cv.Children.Add(CreateLineMethod(new Point(double.Parse(FirstPoint[0])*Scale, double.Parse(FirstPoint[1]) * Scale),new Point(double.Parse(LastPoint[0]) * Scale, double.Parse(LastPoint[1]) * Scale),Brushes.Blue));
                        Element ele = new Element
                        {
                            
                            Name = txbName.Text,
                            FirstNode = FirstNode,
                            SecondNode = SecondNode,
                            LineEle = CreateLineMethod(new Point(double.Parse(FirstPoint[0]), double.Parse(FirstPoint[1])), new Point(double.Parse(LastPoint[0]), double.Parse(LastPoint[1])),Brushes.Blue),
                            ShapeType = ShapeType,
                            Length = Length
                            
                        };                      
                        listEle.Add(ele);
                    }    
                }    
            });   
            DesignLoad = new BaseCommand<Window>(p => true, p => {
                Window w = p as Window;
                if(w!=null)
                {         
                    Grid gridLoad = w.FindName("Grid_Load_Data") as Grid;
                    UIElementCollection element = gridLoad.Children;
                    double a1 = 0, a2 = 0;
                    foreach (var item in element)
                    {
                        TextBox txb = item as TextBox;
                        ComboBox cb = item as ComboBox;
                        if(txb != null)
                        {
                            if(txb.Name == "txb_a1")
                            {
                                a1 = double.Parse(txb.Text);
                            }    
                        }    
                        if(cb!=null)
                        {
                            if(cb.Name == "Cb_Coeffient")
                            {
                                coefficient = double.Parse(cb.Text);
                                
                            }    
                        }    
                    }
                    foreach (var item in listEle)
                    {
                        if (ChooseEle == item.Name)
                        {
                            item.A1 = a1;                        
                        }
                    }
                }
            });
            RunAnalyze = new BaseCommand<object>(p => true, p =>
               {

                   a_Mep = true;

                   foreach (var item in ListEle)
                   {
                       if (item.ShapeType.GetType() == typeof(Rec_Concreate))
                       {
                           Rec_Concreate shapetype = (Rec_Concreate)item.ShapeType;
                           b = shapetype.Width; h = shapetype.Height;
                           a = shapetype.CoverFCon;
                           a_c = a;
                           a_t = a;
                           Nc = shapetype.Number_Long_Bar_Otop;
                           Nt = shapetype.Number_Long_Bar_Obottom;
                           L = Math.Sqrt(Math.Pow(item.FirstNode.Center.X - item.SecondNode.Center.X, 2) + Math.Pow(item.FirstNode.Center.Y - item.SecondNode.Center.Y, 2));
                           a_Cat = item.A1;
                           D_c = shapetype.Long_Size_Bar_Otop;
                           D_t = shapetype.Long_Size_Bar_Obottom;
                           Esc = shapetype.Long_Mat_Bar_Otop.E;
                           Est = shapetype.Long_Mat_Bar_Obottom.E;
                           fy_SteelC = shapetype.Long_Mat_Bar_Otop.Fy;
                           fy_SteelT = shapetype.Long_Mat_Bar_Obottom.Fy;
                           fc = shapetype.Concreate.Fc;
                           Ec = shapetype.Concreate.E;
                           MessageBox.Show("Width " + b + "\nHeight " + h + "\nL " + L + "\na " + a + "\na_c " + a_c + "\nnt " + Nt + "\ndt " + D_t + "\nnc " + Nc + "\nD_c " + D_c
                                + "\nEsc " + Esc + "\nEst " + Est + "\nfysc " + fy_SteelC + "\nfyst " + fy_SteelT
                                + "\nfc " + fc + "\nEc " + Ec + "\nacat " + a_Cat + " HỆ SỐ : " + coefficient);
                           Strain_Co = (Math.Min(2.8, 0.7 * Math.Pow(fc, 0.31))) / 1000;
                           double Strain_Cu = (Math.Min(3.5, 2.8 + 27 * (Math.Pow((98 - fc) / 100, 4)))) / 1000;
                           for (; Strain_cc <= Strain_Cu; Strain_cc += Strain_Cu / 600)
                           {
                               for (double i = value; i <= 0.001; i = i + 1E-9)
                               {
                                   Strain_st = Math.Abs(Strain_stMethod(Strain_cc, i));
                                   Strain_sc = Math.Abs(Strain_scMethod(Strain_cc, i));
                                   Strain_ct = Math.Abs(Strain_ctMethod(Strain_cc, i));

                                   stress_st = Stress_steelMethod(Strain_st, fy_SteelT, "SteelT");
                                   stress_sc = Stress_steelMethod(Strain_sc, fy_SteelC, "SteelC");
                                   stress_cc = Stress_ConcreateMethod(Strain_cc);

                                   F_st = F_stMethod(stress_st);
                                   F_sc = F_scMethod(stress_sc);
                                   F_cc = F_ccMethod(stress_cc, Strain_cc, i);
                                   if (F_st == (F_sc + F_cc) || Math.Abs(F_sc + F_cc - F_st) <= (F_sc + F_cc) * 0.001)
                                   {
                                       M_st = Moment_st(F_st);
                                       M_sc = Moment_sc(F_sc);
                                       M_cc = Moment_cc(F_cc, Strain_cc, i);
                                       Analyze analyze = new Analyze();
                                       analyze.Strain_cc = Strain_cc;
                                       analyze.Strain_ct = Strain_ct;
                                       analyze.Strain_sc = Strain_sc;
                                       analyze.Strain_st = Strain_st;
                                       analyze.Stress_cc = stress_cc;
                                       analyze.Stress_sc = stress_sc;
                                       analyze.Stress_st = stress_st;
                                       analyze.Force_cc = F_cc;
                                       analyze.Force_sc = F_sc;
                                       analyze.Force_st = F_st;
                                       analyze.Disparity = Math.Abs(F_cc + F_sc - F_st);
                                       analyze.Phi = i;
                                       analyze.Moment_cc = M_cc;
                                       analyze.Moment_sc = M_sc;
                                       analyze.Moment_st = M_st;
                                       analyze.MomentF = M_cc + M_sc - M_st;
                                       if (analyze.Strain_ct <= 0.0002)
                                       {
                                           analyze.EIEff = (M_cc + M_sc - M_st) / i;
                                           analyze.Delta = (((M_cc + M_sc - M_st) / a_Cat) * a_Cat * (3 * L * L - 4 * a_Cat * a_Cat)) / (24 * analyze.EIEff);
                                           A_EIeff = (M_cc + M_sc - M_st) / i;
                                           Delta_A = (((M_cc + M_sc - M_st) / a_Cat) * a_Cat * (3 * L * L - 4 * a_Cat * a_Cat)) / (24 * A_EIeff);
                                           A_EIeffModify = coefficient * (M_cc + M_sc - M_st) / i;
                                           Delta_AEIeffModify = (((M_cc + M_sc - M_st) / a_Cat) * a_Cat * (3 * L * L - 4 * a_Cat * a_Cat)) / (24 * A_EIeffModify);
                                       }
                                       else
                                       {
                                           analyze.EIEff = coefficient * (M_cc + M_sc - M_st) / i;
                                           analyze.Delta = Delta_A + (((M_cc + M_sc - M_st) / a_Cat) * a_Cat * (3 * L * L - 4 * a_Cat * a_Cat)) / (24 * analyze.EIEff) - Delta_AEIeffModify;
                                       }
                                       analyze.P = 2 * (M_cc + M_sc - M_st) / a_Cat;
                                       if (i >= value && N1 == false)
                                       {
                                           resuilt.Add(analyze);
                                           //value = i;
                                           N1 = true;
                                           break;
                                       }
                                       if (i > 1 * value)
                                       {
                                           resuilt.Add(analyze);
                                           value = i;
                                           break;
                                       }
                                   }
                               }
                           }
                       }
                   }
                   if (mainWindow != null)
                   {
                       // Tìm element theo tên và ép kiểu đối tượng cần thiết
                       TabControl tab = mainWindow.FindName("Tab_Frame") as TabControl;
                       if(tab!=null)
                       {
                           tab.SelectedIndex = 1;
                       }    
                   }
               });
        }
        public static Line CreateLineMethod(Point FirstEle,Point LastEle,Brush brush)
        {
            Line line = new Line
            {
                X1 = FirstEle.X,
                Y1 = FirstEle.Y,
                X2 = LastEle.X,
                Y2 = LastEle.Y,
                Fill = brush,
                Stroke = brush, 
                StrokeThickness = 0.5
            };
            Canvas.SetLeft(line, 0); // X
            Canvas.SetTop(line, 0); // Y
            return line;
        }
        public static Ellipse CreateNodeMethod(Point Center)
        {
            Ellipse ellipse = new Ellipse
            {
                Width = 5, // Độ rộng của ellipse
                Height =5, // Độ cao của ellipse
                Fill = Brushes.Blue,
                Stroke = Brushes.Black, // Màu đường viền của ellipse
                StrokeThickness = 1 // Độ dày của đường viền
            };
            Canvas.SetLeft(ellipse, Center.X - ellipse.Width / 2); // X
            Canvas.SetTop(ellipse, Center.Y - ellipse.Height / 2); // Y
            return ellipse;
        }
        FrameworkElement GetParentUser(UserControl p)
        {
            FrameworkElement parent = p;
            while(parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }
            return parent;
        }
        //Công thức tính các thông số 
        public double F_stMethod(double Stress)
        {
            return (Stress * Math.PI * (Math.Pow(D_t, 2) / 4) * Nt);//fixed
        }
        public double F_scMethod(double Stress)
        {
            return (Stress * Math.PI * (Math.Pow(D_c, 2) / 4) * Nc);//fixed
        }
        public double F_ccMethod(double Stress, double Strain, double phi)
        {
            return (0.5 * Stress * (Strain / phi) * b);
        }
        public double Strain_stMethod(double Strain, double phi)
        {
            return (Strain - phi * (h - a_t));
        }
        public double Strain_scMethod(double Strain, double phi)
        {
            return (Strain - phi * a_c);
        }
        public double Strain_ctMethod(double Strain, double phi)
        {
            return (Strain - phi * h);
        }
        public double Stress_ConcreateMethod(double Strain)
        {
            if (Strain <= (0.4 * fc) / Ec)
            {
                return (Ec * Strain);
            }
            else
            {
                double k = 1.05 * Ec * (Math.Abs(Strain_Co) / fc);
                //double k = 1.05 * Ec * (Strain_Co / fc);
                double alpha = Strain / Strain_Co;
                return (fc * ((k * alpha - Math.Pow(alpha, 2)) / (1 + (k - 2) * alpha)));
            }
        }
        public double Stress_steelMethod(double Strain, double fy_Steel, string Steel)//TÍNH RA DƯỢC XÍCH MA ST,SC VỚI STRAIN ST,SC TƯƠNG ỨNG
        {//fixed            
            if (Steel == "SteelT")
            {
                Es = Est;
            }
            if (Steel == "SteelC")
            {
                Es = Esc;
            }
            if (0 < Strain && Strain <= fy_Steel / Es)//SỮA LẠI 
            {
                return (Es * Strain);
            }
            else if (Strain > fy_Steel / Es)
            {
                return (fy_Steel + 0.02 * Es * (Strain - (fy_Steel / Es)));
            }
            return 0;
        }
        public double Moment_st(double Fst)
        {
            if (a_Mep == true)
            {
                return (Fst * (a_t + D_t / 2));//fixed
            }
            else
            {
                return (Fst * a_t);//fixed
            }
        }
        public double Moment_sc(double Fsc)
        {
            if (a_Mep == true)
            {
                return (Fsc * (h - (a_c + D_c / 2)));//fixed  
            }
            else
            {
                return (Fsc * (h - a_c));//fixed  
            }
        }
        public double Moment_cc(double Fcc, double strain, double phi)
        {
            return (Fcc * (h - (strain / (3 * phi))));
        }
    }
}
