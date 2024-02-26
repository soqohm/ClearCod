using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*


    1.


    Переменные связываются в конструкторе
    Следую рекомендациям из предыдущих занятий 
    ("Инициализируйте все без исключения атрибуты/поля класса в его конструкторе")


    var stampParams = new StampParameters(
        ТекущийОбъект["Цвет"], 
        ТекущийОбъект["Видимость"],
        ТекущийОбъект["X"],
        ТекущийОбъект["Y"],
        ТекущийОбъект["Угол поворота"]);


    public class StampParameters
    {
        public readonly int Color;
        public readonly double Opacity;
        public readonly double GlobalX;
        public readonly double GlobalY;
        public readonly int GlobalAngle;

        public StampParameters(int color, double opacity, double globalX, double globalY, int globalAngle)
        {
            Color = color;
            Opacity = opacity;
            GlobalX = globalX;
            GlobalY = globalY;
            GlobalAngle = globalAngle;
        }
    }

    
    2. 
    
    
    //
    //
    //

    
    3. 
    
    
    //
    //
    //


    */
}