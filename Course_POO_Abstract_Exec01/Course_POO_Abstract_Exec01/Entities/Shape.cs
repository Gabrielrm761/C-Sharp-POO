using System;
using System.Collections.Generic;
using System.Text;
using Course_POO_Abstract_Exec01.Entities.Enums;

namespace Course_POO_Abstract_Exec01.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        protected Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();
    }
}
