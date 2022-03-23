using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder
{
    namespace Circle_Class
    {
        internal class Circle
        {
            //declare attributes/properties
            protected int _radius;

            //contructor
            public Circle()
            {
                _radius = 0;
            }

            //accessor Radius can be accessed as it is public, you can alter the contents of Radius, and it will change the value of _radius
            public int Radius
            {
                set { _radius = value; }
                get { return _radius; }
            }
            //define methods
            public double Area()
            {
                return Math.Pow(_radius, 2) * Math.PI;
            }
            public double Circumference()
            {
                return Math.PI * (_radius * 2);
            }



            class Cylinder : Circle
            {
                //declare attributes/properties
                protected int _height;

                //constructor

                public Cylinder()
                    :base()//call the constructor from the base class
                {
                    //initialise the variable
                    _height = 0;
                }

                public int height
                {
                    set { _height = value; } get { return _height; } 
                }
            }
        }
    }
}
