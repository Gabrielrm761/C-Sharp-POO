using System;
using System.Collections.Generic;
using System.Text;
using Course_POO_Abstract_Exec01.Entities;
using Course_POO_Abstract_Exec01.Entities.Enums;

namespace Course_POO_Abstract_Exec01.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
