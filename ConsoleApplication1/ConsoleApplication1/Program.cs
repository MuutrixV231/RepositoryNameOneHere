using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Plane
    {
        public int Heigh
        {
            get { return _height; }

            set
            {
                if (value < 0)
                {
                    return;
                }
                _height = value;
            }

        }
        private int _height = 1;


    }

    public class Paper
    {
        public string YourColorHere;
        public string YourMaterialHere;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _height = value;
            }

        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _width = value;
            }

        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if(YourColorHere == string.Empty)
                {
                    return;
                }
                _color = YourColorHere;

            }

        }
        public string Material
        {
            get
            {
                return _material;
            }
            set
            {
                if(YourMaterialHere == string.Empty)
                {
                    return;
                }
                _material = YourMaterialHere;
            }

        }
        public double Thicc
        {
            get
            {
                return _thicc;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _thicc = value;
            }

        }

        private double _height = 1000;
        private double _width = 50;
        private string _color = "Pink";
        private string _material = "Cotton";
        private double _thicc = 0.1;

        public Paper()
        {
            this.Height = 1000;
            this.Width = 50;
            this.YourColorHere = "Pink";
            this.YourMaterialHere = "Cotton";
            this.Thicc = 0.05;
            

        }

        public Paper(double Height, double Width, string Color, string Material, double Thicc)
        {
            this.Height = Height;
            this.Width = Width;
            this.YourColorHere = Color;
            this.YourMaterialHere = Material;
            this.Thicc = Thicc;
            




        }

        public string AllPaperInfo
        {
            get
            {
                return "  Paper's height is " + this.Height + "cm, and width is " + this.Width +
                "cm.\n  It's color is [" + this.YourColorHere + "] and Material is " + this.YourMaterialHere +
                ".\n  Most importantly, it's thiccness is " + this.Thicc + "\n\n";
            }
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Paper Nothing = new Paper();
            Paper Something = new Paper(10, 30, "blue", "bmboo", 0.0098);
            Paper BadPaper = new Paper(-36, -4, "not Black", "not dirt", -5.25);

            Console.WriteLine(Nothing.AllPaperInfo);
            Console.WriteLine(Something.AllPaperInfo);
            Console.WriteLine(BadPaper.AllPaperInfo);

            Console.ReadLine();


        }
    }
}

// Ankh-svn plugin
// tortoise SVN on PC