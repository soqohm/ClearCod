using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    

    //3.1


    class Shape
    {
        public double Area { get; set; }

        private Shape(double radius)
        {
            Area = Math.PI * radius * radius;
        }

        private Shape(int side1, int side2)
        {
            Area = side1 * side2;
        }

        private Shape(double angle1, double angle2, double angle3)
        {
            Area = 0.5 * angle1 * angle2 * Math.Sin(angle3);
        }

        public static Shape CreateCircle(double radius)
        {
            return new Shape(radius);
        }

        public static Shape CreateRectangle(int side1, int side2)
        {
            return new Shape(side1, side2);
        }

        public static Shape CreateTriangle(double angle1, double angle2, double angle3)
        {
            return new Shape(angle1, angle2, angle3);
        }
    }

    class Program
    {
        void Main()
        {
            var circle = Shape.CreateCircle(5.0);
            var rectangle = Shape.CreateRectangle(10, 20);
            var triangle = Shape.CreateTriangle(3.0, 4.0, Math.PI / 6);
        }
    }


    /*
    
    
    3.2


    // интерфейс, который реализует взаимодействие "Сражаться с армией"
    interface IArmy { Army Army { get; set; } }
    interface FightWithArmy { Army Army { get; set; } }


    // интерфейс, который реализует взаимодействие "Собирать сокровища"
    interface ITreasure { Treasure Treasure { get; set; } }
    interface TreasureCollector { Treasure Treasure { get; set; } }


    // интерфейс, который реализует взаимодействие "Присваивать объект себе"
    interface IOwner { int Owner { get; set; } }
    interface AssignToYourself { int Owner { get; set; } }


    */
}