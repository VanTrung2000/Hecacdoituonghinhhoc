﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cacdoituonghinhhoc
{
    class Circle:Shape
    {
        public double radius=1.0;
        public Circle() { }
        public Circle(string color, bool filled,double radius):base(color,filled)
        {
            this.radius = radius;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }
        public double getPerimeter()
        {
            return Math.PI* 2 * radius ;
        }
        public override string ToString()
        {
            return "A Circle with radius=" + getRadius() + ", which is a subclass of " + base.ToString();
        }
    }
}
