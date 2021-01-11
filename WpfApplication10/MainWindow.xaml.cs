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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Reflection;

namespace WpfApplication10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 1;
        SortedList<int, double> numberNames = new SortedList<int, double>();
        SortedList<int, double> number = new SortedList<int, double>();
        SortedList<int, double> numberNames1 = new SortedList<int, double>();
        SortedList<int, double> number1 = new SortedList<int, double>();
      
        SortedList<double, double> myangles = new SortedList<double, double>();
        SortedList<double, double> myangles1 = new SortedList<double, double>();

        List<QuestionAnalysis> testdata = new List<QuestionAnalysis>();

        public MainWindow()
        {
            InitializeComponent();
            


            LoadAllQuestions();

            //txtborder();



            this.DataContext = testdata;
            filldata();
            FillBrushes();
            name();
            getname();
            GetRandomBrush();

            filldata1();
            FillBrushes();
            name1();
            getname1();

            GetRandomBrush1();


            if (myangles.Count <= 10 && myangles1.Count<=10)
            {
                DrawPies(110, myangles, SelectedBrushes);
                DrawPies1(110, myangles1, SelectedBrushes);
            }
            else
            {
              DrawPies(110, myangles);
               DrawPies1(110, myangles1);
            }


        }



        public List<QuestionAnalysis> LoadAllQuestions()
        {

            testdata.Add(new QuestionAnalysis
            {
                TestId = "PHY1001",

                Subject = "PHYSICS",
                Questions = new List<Questions>
            {
                new Questions {QId=1,Qno=1,Question="firstbdfdbkjbfbdsjfbhkgbfdsghyhgygdhughggygygygyg hfgyfgyg yyf",Averagetimeforcorrect="10",Averagetimeforunans="10",Averagetimeforwrong="10",CorrectPercent="10",Difficultylevel="s",Discrimination="s0",TopicCorrectPercent="s",TopicUnansPercent="20",TopicwrongPercent="s",UnansPercent="ss",WrongPercent="s",Choices=new List<Choice>
                {

                    new Choice {
                        choiceid =1,choice="one",Attendpercent=15,isNonperform=true,issuspicious=false,Qid=1,AnserCorrect=false},
                    new Choice {choiceid=2,choice="two",Attendpercent=35,isNonperform=false,issuspicious=true,Qid=1,AnserCorrect=false},
                    new Choice {choiceid=3,choice="three",Attendpercent=40,isNonperform=false,issuspicious=false,Qid=1,AnserCorrect=true},
                    new Choice {choiceid=4,choice="four",Attendpercent=10,isNonperform=false,issuspicious=false,Qid=1,AnserCorrect=false}
                },
                Questionrecommendation=new List<questionrecommendation>
                {
                    new questionrecommendation {QLearn=true,QNone=false,QRevise=false}

                },Topicrecommendation=new List<topicrecommendation>
                {
                    new topicrecommendation {TLearn=false,TNone=true,TRevise=false }
                }

              }









            }


            });
            testdata.Add(new QuestionAnalysis
            {
                TestId = "PHY1002",
                Subject = "PHYSICS",
                Questions = new List<Questions>
            {
                new Questions {QId=1,Qno=2,Question="first",Averagetimeforcorrect="1",Averagetimeforunans="20",Averagetimeforwrong="19",CorrectPercent="10",Difficultylevel="ll",Discrimination="ii",TopicCorrectPercent="s",TopicUnansPercent="20",TopicwrongPercent="s",UnansPercent="ss",WrongPercent="s",Choices=new List<Choice>
                {
                    new Choice {choiceid=1,choice="one",Attendpercent=10,isNonperform=false,issuspicious=true,Qid=1,AnserCorrect=false},
                    new Choice {choiceid=2,choice="tewd",Attendpercent=30,isNonperform=false,issuspicious=false,Qid=1,AnserCorrect=true},
                    new Choice {choiceid=3,choice="threde",Attendpercent=50,isNonperform=true,issuspicious=false,Qid=1,AnserCorrect=false},
                    new Choice {choiceid=4,choice="fouyre",Attendpercent=10,isNonperform=false,issuspicious=false,Qid=1,AnserCorrect=false}
                },
                    Questionrecommendation =new List<questionrecommendation>
                {
                    new questionrecommendation {QLearn=false,QNone=true,QRevise=false}

                },Topicrecommendation=new List<topicrecommendation>
                {
                    new topicrecommendation {TLearn=false,TNone=false,TRevise=true }
                }

              }

            }


            });
            testdata.Add(new QuestionAnalysis
            {
                TestId = "PHY1003",
                Subject = "PHYSICS",
                Questions = new List<Questions>

            {

                new Questions {QId=1,Qno=3,Question="first",Averagetimeforcorrect="5",Averagetimeforunans="15",Averagetimeforwrong="10",CorrectPercent="10",Difficultylevel="sq",Discrimination="ee",TopicCorrectPercent="styui",TopicUnansPercent="20",TopicwrongPercent="s",UnansPercent="ss",WrongPercent="s",
                    Choices = new List<Choice>


                {
                    new Choice {choiceid=1,choice="one",Attendpercent=20,isNonperform=false,issuspicious=false,Qid=1,AnserCorrect=false},
                    new Choice {choiceid=2,choice="two",Attendpercent=40,isNonperform=false,issuspicious=true,Qid=1,AnserCorrect=false},
                    new Choice {choiceid=3,choice="three",Attendpercent=10,isNonperform=true,issuspicious=false,Qid=1,AnserCorrect=false},
                    new Choice {choiceid=4,choice="four",Attendpercent=30,isNonperform=false,issuspicious=false,Qid=1,AnserCorrect=true}
                }, Questionrecommendation=new List<questionrecommendation>
                {
                    new questionrecommendation {QLearn=false,QNone=false,QRevise=true}

                },Topicrecommendation=new List<topicrecommendation>
                {
                    new topicrecommendation {TLearn=true,TNone=false,TRevise=false }
                }

              }
            }


            });

            //this.DataContext = testdata;

            //testdata.TestId = "CHE1002";
            //testdata.Subject = "CHEMISTRY";
            //testdata.Questions = new List<Questions>
            //{
            //    new Questions {QId=2,Qno=2,Question="second",Averagetimeforcorrect="80",Averagetimeforunans="110",Averagetimeforwrong="10",CorrectPercent="10",Difficultylevel="s",Discrimination="s0",Questionrecommendation="s",TopicCorrectPercent="s",Topicrecommendation="s",TopicUnansPercent="20",TopicwrongPercent="60",UnansPercent="40",WrongPercent="10",Choices=new List<Choice>
            //    {
            //        new Choice {choiceid=1,choice="twp",Attendpercent=30,isNonperform=false,issuspicious=false,Qid=2},
            //        new Choice {choiceid=2,choice="two",Attendpercent=20,isNonperform=false,issuspicious=false,Qid=2},
            //        new Choice {choiceid=3,choice="twe",Attendpercent=10,isNonperform=false,issuspicious=false,Qid=2},
            //        new Choice {choiceid=4,choice="tws",Attendpercent=10,isNonperform=false,issuspicious=false,Qid=2}
            //    }
            //  }



            //};

            //testdata.TestId = "CHE1003";
            //testdata.Subject = "CHEMISTRY";
            //testdata.Questions = new List<Questions>
            //{
            //    new Questions {QId=3,Qno=3,Question="thridquestion",Averagetimeforcorrect="70",Averagetimeforunans="130",Averagetimeforwrong="20",CorrectPercent="40",Difficultylevel="hard",Discrimination="excellent",Questionrecommendation="s",TopicCorrectPercent="s",Topicrecommendation="s",TopicUnansPercent="20",TopicwrongPercent="60",UnansPercent="40",WrongPercent="10",Choices=new List<Choice>
            //    {
            //        new Choice {choiceid=1,choice="twp",Attendpercent=30,isNonperform=false,issuspicious=false,Qid=3},
            //        new Choice {choiceid=2,choice="two",Attendpercent=20,isNonperform=false,issuspicious=false,Qid=3},
            //        new Choice {choiceid=3,choice="twe",Attendpercent=10,isNonperform=false,issuspicious=false,Qid=3},
            //        new Choice {choiceid=4,choice="tws",Attendpercent=10,isNonperform=false,issuspicious=false,Qid=3}
            //    }
            //  }



            //};






            return testdata;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (testdata.Count > count)
            {
                
                this.DataContext = testdata[count];
                count = count + 1;
                
                //var cs = testdata[count];

                //foreach (var n in cs)
                //{
                //    var data = n.Questions;
                //    var data1 = data[0].Topicrecommendation;


                //    if (data1 == "Learn")
                //    {
                //        y.BorderThickness = new Thickness(0, 0, 0, 10);
                //        y1.Foreground = new SolidColorBrush(Color.FromRgb(38, 213, 18));
                //        y1.BorderBrush = new SolidColorBrush(Color.FromRgb(38, 213, 18));
                //    }
                //    else if (data1 == "Revise")
                //    {
                //        x.BorderThickness = new Thickness(0, 0, 0, 10);
                //        x1.Foreground = new SolidColorBrush(Color.FromRgb(38, 213, 18));
                //        x1.BorderBrush = new SolidColorBrush(Color.FromRgb(38, 213, 18));
                //    }
                //    else if (data1 == "None")
                //    {
                //        z.BorderThickness = new Thickness(0, 0, 0, 10);
                //        z1.Foreground = new SolidColorBrush(Color.FromRgb(38, 213, 18));
                //        z1.BorderBrush = new SolidColorBrush(Color.FromRgb(38, 213, 18));
                //    }
                //    else
                //    {
                //        BorderThickness = new Thickness(0, 0, 0, 0);
                //        Foreground = new SolidColorBrush(Colors.Black);
                //        break;

                //    }
                //}
            }


        }
        //public void a1()
        //{
        //    var data=testdata[count]

        //}

        //public void changeborder(List<string> te)
        //{



        //    foreach (var n in te)
        //    {
        //        var data= n.Questions;
        //        var data1 = data[0].Topicrecommendation;


        //        if (data1 == "Learn")
        //        {
        //            y.BorderThickness = new Thickness(0, 0, 0, 10);
        //            y1.Foreground = new SolidColorBrush(Color.FromRgb(38, 213, 18));
        //            y1.BorderBrush = new SolidColorBrush(Color.FromRgb(38, 213, 18));
        //        }
        //        else if (data1 == "Revise")
        //        {
        //            x.BorderThickness = new Thickness(0, 0, 0, 10);
        //            x1.Foreground = new SolidColorBrush(Color.FromRgb(38, 213, 18));
        //            x1.BorderBrush = new SolidColorBrush(Color.FromRgb(38, 213, 18));
        //        }
        //        else if (data1 == "None")
        //        {
        //            z.BorderThickness = new Thickness(0, 0, 0, 10);
        //            z1.Foreground = new SolidColorBrush(Color.FromRgb(38, 213, 18));
        //            z1.BorderBrush = new SolidColorBrush(Color.FromRgb(38, 213, 18));
        //        }
        //        else
        //        {
        //            BorderThickness = new Thickness(0, 0, 0, 0);
        //            Foreground = new SolidColorBrush(Colors.Black);
        //            break;

        //        }








        //    }
        //}

        //public void changeborder1()
        //{
        //    foreach (var n in testdata)
        //    {
        //        var sam = n.Questions;

        //        var dta = sam[0].Questionrecommendation;
        //        if (dta == "Learn")
        //        {
        //            a.BorderThickness = new Thickness(0, 0, 0, 10);
        //            a1.Foreground = new SolidColorBrush(Colors.Red);
        //            a1.BorderBrush = new SolidColorBrush(Color.FromRgb(38, 213, 18));
        //        }
        //        else if (dta == "Revise")
        //        {
        //            b.BorderThickness = new Thickness(0, 0, 0, 10);
        //            b1.Foreground = new SolidColorBrush(Colors.Gray);
        //            b1.BorderBrush = new SolidColorBrush(Color.FromRgb(38, 213, 18));
        //        }
        //        else if (dta == "None")
        //        {
        //            c.BorderThickness = new Thickness(0, 0, 0, 10);
        //            c1.Foreground = new SolidColorBrush(Colors.Gray);
        //            c1.BorderBrush = new SolidColorBrush(Color.FromRgb(38, 213, 18));
        //        }
        //    }

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


        //piechart 2
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
            Canvas.Children.Add(myPolygon);

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
            myCanvas.Children.Add(myPolygon);
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
            myCanvas.Children.Add(myPolygon);
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













        public void DrawPies1(int size, SortedList<double, double> mylist1)
        {
            foreach (KeyValuePair<double, double> entity in mylist1)
            {
                DrawPolyPies1((int)Math.Ceiling(entity.Key), (int)Math.Ceiling(entity.Value), size, size);
            }
        }

        public void DrawPies1(int size, SortedList<double, double> mylist1, List<Brush> mybrushes)
        {
            int i = 0;
            foreach (KeyValuePair<double, double> entity in mylist1)
            {
                DrawPolyPies1((int)Math.Ceiling(entity.Key), (int)Math.Ceiling(entity.Value), size, size, mybrushes[i]);
                i++;
            }
        }



        public void DrawPolyLines1(int FromAngle, int ToAngle, int Originx, int Originy, Brush Fill, Brush Stroke)
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
            Canvas.Children.Add(myPolygon);

        }

        public Brush GetRandomBrush1()
        {
            //pick a random color brush
            Random rand = new Random(DateTime.Now.Millisecond);
            int index = rand.Next(MyBrushes.Count);

            if (usedBrushIndex.Contains(index))
            {
                return GetRandomBrush1();
            }
            else
            {
                usedBrushIndex.Add(index);
                return MyBrushes[index];
            }
        }
        //piechart 2
        public void DrawPolyPies1(int FromAngle, int ToAngle, int Originx, int Originy)
        {

            Polygon myPolygon = new Polygon();
            myPolygon.Stroke = Brushes.Black;
            myPolygon.Fill = GetRandomBrush1();
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
            //myCanvas.Children.Add(myPolygon);
            Canvas.Children.Add(myPolygon);

        }

        public void DrawPolyPies1(int FromAngle, int ToAngle, int Originx, int Originy, Brush mybrush)
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
            //myCanvas.Children.Add(myPolygon);
            Canvas.Children.Add(myPolygon);

        }

        public SortedList<int, double> name1()
        {
            var total = numberNames1.Values.Sum();

            foreach (var data in numberNames1)
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

                number1.Add(data.Key, desc1);
                //}
            }
            return number1;
        }

        public SortedList<double, double> getname1()
        {
            double start = 0;
            // double end = 0;
            foreach (var div in number1)
            {
                var percent = div.Value * 3.6;
                var math = Math.Round((percent + start), 2);
                myangles1.Add(start, math);
                start = math;

            }
            return myangles1;

        }

        public void filldata1()
        {
            numberNames1.Add(1, 600);
            numberNames1.Add(2, 600);
            numberNames1.Add(3, 600);
            numberNames1.Add(4, 600);
            numberNames1.Add(5, 600);
            //numberNames1.Add(6, 600);
            //numberNames1.Add(7, 600);
            //numberNames1.Add(8, 100);
            //numberNames1.Add(9, 200);
            //numberNames1.Add(10, 50);
            //numberNames1.Add(11, 50);
            //numberNames1.Add(12, 20);
        }







    }

    public class QuestionAnalysis
    {
        public string TestId { get; set; }
        public string Subject { get; set; }
        public bool data { get; set; }
        public List<Questions> Questions { get; set; }


    }

    public class Questions
    {
        public int QId { get; set; }
        public int Qno { get; set; }
        public string Question { get; set; }
        public List<Choice> Choices { get; set; }
        public string CorrectPercent { get; set; }
        public string WrongPercent { get; set; }
        public string UnansPercent { get; set; }
        public string TopicCorrectPercent { get; set; }
        public string TopicwrongPercent { get; set; }
        public string TopicUnansPercent { get; set; }
        public string Difficultylevel { get; set; }
        public string Discrimination { get; set; }
        public List<questionrecommendation> Questionrecommendation { get; set; }
        public List<topicrecommendation> Topicrecommendation { get; set; }
        public string Averagetimeforcorrect { get; set; }
        public string Averagetimeforwrong { get; set; }
        public string Averagetimeforunans { get; set; }

    }
    public class Choice
    {
        public int Qid { get; set; }
        public int choiceid { get; set; }
        public string choice { get; set; }
        public int Attendpercent { get; set; }
        public bool AnserCorrect { get; set; }
        public bool issuspicious { get; set; }
        public bool isNonperform { get; set; }
    }
    public class questionrecommendation
    {
        public bool QLearn { get; set; }
        public bool QRevise { get; set; }
        public bool QNone { get; set; }
    }
    public class topicrecommendation
    {
        public bool TLearn { get; set; }
        public bool TRevise { get; set; }
        public bool TNone { get; set; }
    }
    

}




    

