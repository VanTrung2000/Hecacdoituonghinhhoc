using System;
using System.Collections.Generic;
using System.Text;

namespace Cacdoituonghinhhoc
{
    class Rectangle
    {
        public double width = 1.0;
        public double length = 1.0;
        public Rectangle() { }
        public Rectangle(double width,double length)
        {
            this.width = width;
            this.length = length;
        }

        public void setWidth(double width)
        {
            width = width;
        }
        public double getWidth()
        {
            return width;
        }


        public void setLength(double length)
        {
            length = length;
        }
        public double getLength()
        {
            return length;
        }
        public double getArea()
        {
            return width * length;
        }
        public double getPerimeter()
        {
            return (width + length)*2;
        }
        public override string ToString()
        {
            return "A Rectangle with width=" + getWidth() + " and length=" + getLength() + ", which is a subclass of " + base.ToString();
        }
    }
}
