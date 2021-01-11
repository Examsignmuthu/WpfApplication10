using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection;

namespace WpfApplication10
{
    /// <summary>
    /// Interaction logic for nextpage.xaml
    /// </summary>
    public partial class nextpage : Window
    {
        int count = 1;
        List<classA> txtdata = new List<classA>();
        List<string> list = new List<string>();

        SortedList<int, double> numberNames = new SortedList<int, double>();
        SortedList<int, double> number = new SortedList<int, double>();
        SortedList<double, double> myangles = new SortedList<double, double>();


        public nextpage()
        {
            InitializeComponent();
            loadtxt();
            this.DataContext = txtdata[0];

           
       
            mylist.ItemsSource = txtdata;
            filldata();
            FillBrushes();
            name();
            getname();
            GetRandomBrush();
            if (myangles.Count <= 10)
            {
                DrawPies(110, myangles, SelectedBrushes);

            }
            else
            {
                DrawPies(110, myangles);

                }


                list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            this.DataContext = list;

        }






        public List<classA> loadtxt()
        {
            txtdata.Add(new classA
            {
                TestId = "01",
                Subject = "PHYSICS",
                rollno = 12345678,
                name = "QWERTYUSDFGHJFGH",
                visits = 3,
                time = 95,
                Topicrecommendation = new List<topicrecom>
                {
                    new topicrecom { TLearn=true,TNone=false,TRevise=false}
                },
                Questionrecommendation = new List<questionrecom>
                {
                    new questionrecom {QLearn=false,QNone=false,QRevise=true }
                },
                
                
                question = new List<Question>
                {
                    new Question { QId=1, Qno=1, Quest="QWERTYUIOSDFGHJKASDFGHJK SDFGHJKDSFGHJ SDFGHJKDFG FVG TGFHJ HV HGVTYGYUGYG GTFTYFF HGVDTYUETYUDFE GFWYDEVGFEWEDBN TYWDEBVN ",
                    Choises=new List<Choise>
                    {
                        new Choise { Qid=1, choiceid=1, choice="APPLE", AnserCorrect=false },
                         new Choise { Qid=1, choiceid=2, choice="ORANGE", AnserCorrect=false },
                          new Choise { Qid=1, choiceid=3, choice="PULBMS", AnserCorrect=false },
                           new Choise { Qid=1, choiceid=4, choice="HOT", AnserCorrect=true }
                          
                    }

                    }
                   
                }
                

            });
            txtdata.Add(new classA
            {
                TestId = "02",
                Subject = "PHYSICS",
                rollno = 976545678,
                name = "ZXCVBNMCVB",
                visits = 1,
                time = 45,
                Topicrecommendation = new List<topicrecom>
                {
                    new topicrecom { TLearn=false,TNone=false,TRevise=true}
                },
                Questionrecommendation = new List<questionrecom>
                {
                    new questionrecom {QLearn=false,QNone=true,QRevise=false }
                },
                question = new List<Question>
                {
                    new Question { QId=2, Qno=2, Quest="QWERTYUIOSDFGHJKASDFGHJK SDFGHJKDSFGHJ SDFGHJKDFG FVG TGFHJ HV HGVTYGYUGYG GTFTYFF HGVDTYUETYUDFE GFWYDEVGFEWEDBN TYWDEBVN ",
                    Choises=new List<Choise>
                    {
                        new Choise { Qid=2, choiceid=1, choice="PINK", AnserCorrect=false },
                         new Choise { Qid=2, choiceid=2, choice="WHITE", AnserCorrect=false },
                          new Choise { Qid=2, choiceid=3, choice="ORANGE", AnserCorrect=true },
                           new Choise { Qid=2, choiceid=4, choice="HOT", AnserCorrect=false }

                    }

                    }
                }

            });
            txtdata.Add(new classA
            {
                TestId = "03",
                Subject = "PHYSICS",
                rollno = 976543454,
                name = "ZXCVBB",
                visits = 3,
                time = 25,
                Topicrecommendation = new List<topicrecom>
                {
                    new topicrecom { TLearn=false,TNone=true,TRevise=false}
                },
                Questionrecommendation = new List<questionrecom>
                {
                    new questionrecom {QLearn=false,QNone=true,QRevise=false }
                },
                question = new List<Question>
                {
                    new Question { QId=3, Qno=3, Quest="QWERTYUIOSDFGHJKASDFGHJK SDFGHJKDSFGHJ SDFGHJKDFG FVG TGFHJ HV HGVTYGYUGYG GTFTYFF HGVDTYUETYUDFE GFWYDEVGFEWEDBN TYWDEBVN ",
                    Choises=new List<Choise>
                    {
                        new Choise { Qid=2, choiceid=1, choice="PINK", AnserCorrect=false },
                         new Choise { Qid=2, choiceid=2, choice="WHITE", AnserCorrect=true },
                          new Choise { Qid=2, choiceid=3, choice="ORANGE", AnserCorrect=false },
                           new Choise { Qid=2, choiceid=4, choice="HOT", AnserCorrect=false }

                    }

                    }
                }

            });



            return txtdata;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtdata.Count > count)
            {
                this.DataContext = txtdata[count];
                count = count + 1;
            }

        }











        public List<Brush> MyBrushes = new List<Brush>();

        public List<int> usedBrushIndex = new List<int>();

        public List<Brush> SelectedBrushes = new List<Brush>();

        public void FillBrushes()
        {
            Type brushesType = typeof(System.Windows.Media.Brushes);

            // Get all static properties
            var properties = brushesType.GetProperties(BindingFlags.Static | BindingFlags.Public);

            foreach (var prop in properties)
            {
                string name = prop.Name;
                SolidColorBrush brush = (SolidColorBrush)prop.GetValue(null, null);
                MyBrushes.Add(brush);

            }

            MyBrushes.Remove(Brushes.AntiqueWhite);
            MyBrushes.Remove(Brushes.White);
            MyBrushes.Remove(Brushes.WhiteSmoke);
            MyBrushes.Remove(Brushes.Transparent);
            MyBrushes.Remove(Brushes.FloralWhite);
            MyBrushes.Remove(Brushes.Black);
            MyBrushes.Remove(Brushes.GhostWhite);



            SelectedBrushes.Add(Brushes.Green);
            SelectedBrushes.Add(Brushes.Orange);
            SelectedBrushes.Add(Brushes.SteelBlue);
            SelectedBrushes.Add(Brushes.Red);
            SelectedBrushes.Add(Brushes.LawnGreen);
            SelectedBrushes.Add(Brushes.MediumSlateBlue);
            SelectedBrushes.Add(Brushes.MediumVioletRed);
            SelectedBrushes.Add(Brushes.Turquoise);
            SelectedBrushes.Add(Brushes.MediumPurple);
            SelectedBrushes.Add(Brushes.Blue);


        }


        public void DrawPies(int size, SortedList<double, double> mylist)
        {
            foreach (KeyValuePair<double, double> entity in mylist)
            {
                DrawPolyPies((int)Math.Ceiling(entity.Key), (int)Math.Ceiling(entity.Value), size, size);
            }
        }

        public void DrawPies(int size, SortedList<double, double> mylist, List<Brush> mybrushes)
        {
            int i = 0;
            foreach (KeyValuePair<double, double> entity in mylist)
            {
                DrawPolyPies((int)Math.Ceiling(entity.Key), (int)Math.Ceiling(entity.Value), size, size, mybrushes[i]);
                i++;
            }
        }



        public void DrawPolyLines(int FromAngle, int ToAngle, int Originx, int Originy, Brush Fill, Brush Stroke)
        {


            Polygon myPolygon = new Polygon();
            myPolygon.Stroke = Stroke;
            myPolygon.Fill = Fill;
            myPolygon.StrokeThickness = 0.25;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            PointCollection myPointCollection = new PointCollection();

            myPointCollection.Add(new Point(Originx, Originy));

            for (int i = FromAngle; i <= ToAngle; i = i + 1)
            {
                PolarPoint p1 = new PolarPoint(110.0, i);
                myPointCollection.Add(new Point(Originx + p1.X, Originy + p1.Y));
            }

            myPointCollection.Add(new Point(Originx, Originy));

            myPolygon.Points = myPointCollection;
            //    myCanvas.Children.Add(myPolygon);
            Canvas2.Children.Add(myPolygon);

        }

        public Brush GetRandomBrush()
        {
            //pick a random color brush
            Random rand = new Random(DateTime.Now.Millisecond);
            int index = rand.Next(MyBrushes.Count);

            if (usedBrushIndex.Contains(index))
            {
                return GetRandomBrush();
            }
            else
            {
                usedBrushIndex.Add(index);
                return MyBrushes[index];
            }
        }

        public void DrawPolyPies(int FromAngle, int ToAngle, int Originx, int Originy)
        {

            Polygon myPolygon = new Polygon();
            myPolygon.Stroke = Brushes.Black;
            myPolygon.Fill = GetRandomBrush();
            myPolygon.StrokeThickness = 0.25;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            PointCollection myPointCollection = new PointCollection();

            myPointCollection.Add(new Point(Originx, Originy));

            for (int i = FromAngle; i <= ToAngle; i = i + 1)
            {
                PolarPoint p1 = new PolarPoint(Originx, i);
                myPointCollection.Add(new Point(Originx + p1.X, Originy + p1.Y));
            }

            myPointCollection.Add(new Point(Originx, Originy));

            myPolygon.Points = myPointCollection;
            Canvas2.Children.Add(myPolygon);
            // Canvas.Children.Add(myPolygon);

        }

        public void DrawPolyPies(int FromAngle, int ToAngle, int Originx, int Originy, Brush mybrush)
        {

            Polygon myPolygon = new Polygon();
            myPolygon.Stroke = Brushes.Black;
            myPolygon.Fill = mybrush;
            myPolygon.StrokeThickness = 0.25;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            PointCollection myPointCollection = new PointCollection();

            myPointCollection.Add(new Point(Originx, Originy));

            for (int i = FromAngle; i <= ToAngle; i = i + 1)
            {
                PolarPoint p1 = new PolarPoint(Originx, i);
                myPointCollection.Add(new Point(Originx + p1.X, Originy + p1.Y));
            }

            myPointCollection.Add(new Point(Originx, Originy));

            myPolygon.Points = myPointCollection;
            Canvas2.Children.Add(myPolygon);
            //  Canvas.Children.Add(myPolygon);

        }

        //public SortedList<int, double> name()
        //{
        //    var total = numberNames.Values.Sum();

        //    foreach (var data in numberNames)
        //    {
        //        var getdata = data.Value   / total * 100;
        //        var desc = Math.Round(Convert.ToDouble(getdata));
        //        number.Add(data.Key, desc);

        //    }
        //    return number;
        //}

        //public SortedList<double, double> getname()
        //{
        //    double start = 0;
        //    // double end = 0;
        //    foreach (var div in number)
        //    {
        //        var percent = div.Value * 3.6;
        //        var math = Math.Round((percent + start), 2);
        //        myangles.Add(start, math);
        //        start = math;

        //    }
        //    return myangles;

        //}
        public SortedList<int, double> name()
        {
            var total = numberNames.Values.Sum();

            foreach (var data in numberNames)
            {
                var getdata = (data.Value * 1.0) / total * 100;
                //if (getdata > 0)
                //{
                //    var desc = Math.Round(Convert.ToDouble(getdata));
                //    number.Add(data.Key, desc);
                //}
                // var desc1 = getdata;

                //else
                //{
                var desc1 = Math.Round(Convert.ToDouble(getdata));
                //var c1=Math.Truncate(desc1);

                number.Add(data.Key, desc1);
                //}




            }
            return number;
        }

        public SortedList<double, double> getname()
        {
            double start = 0;
            // double end = 0;
            foreach (var div in number)
            {
                var percent = div.Value * 3.6;
                var math = Math.Round((percent + start), 2);
                myangles.Add(start, math);
                start = math;

            }
            return myangles;

        }

        public void filldata()
        {
            numberNames.Add(1, 100);
            numberNames.Add(2, 800);
            numberNames.Add(3, 200);
            numberNames.Add(4, 400);
            numberNames.Add(5, 700);
            //numberNames.Add(6, 500);
            //numberNames.Add(7, 600);
            //numberNames.Add(8, 100);
            //numberNames.Add(9, 200);
            //numberNames.Add(10, 50);
            //numberNames.Add(11, 50);
            //numberNames.Add(12, 20);
        }






















        public class classA
        {
            public string TestId { get; set; }
            public string Subject { get; set; }
            public int rollno { get; set; }
            public string name { get; set; }
            public int visits { get; set; }
            public int time { get; set; }
            public List<Question> question { get; set; }
            public List<questionrecom> Questionrecommendation { get; set; }
            public List<topicrecom> Topicrecommendation { get; set; }


        }
        public class Question
        {
            public int QId { get; set; }
            public int Qno { get; set; }
            public string Quest { get; set; }
            public List<Choise> Choises { get; set; }
        }
        public class Choise
        {
            public int Qid { get; set; }
            public int choiceid { get; set; }
            public string choice { get; set; }
            public bool AnserCorrect { get; set; }

        }
        public class questionrecom
        {
            public bool QLearn { get; set; }
            public bool QRevise { get; set; }
            public bool QNone { get; set; }
        }
        public class topicrecom
        {
            public bool TLearn { get; set; }
            public bool TRevise { get; set; }
            public bool TNone { get; set; }
        }

    }
}
