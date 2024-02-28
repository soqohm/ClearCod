using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*


    1.


    переменные связываются в конструкторе
    следую рекомендациям из предыдущих занятий 
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
    

    переменная templateFileId - id файла шаблона, на основе которого создается отчет
    переменная templateFileId используется только внутри специального метода LoadTemplateFileDOCs

    
    FileObject LoadTemplateFileDOCs()
    {
        var fileReference = LoadReference("Файлы");
        var templateFileId = 736044;
        return fileReference.Find(templateFileId) as FileObject;
    }

    
    3. 
    

    переменные filePath и basicPartOfFileName тоже используются только внутри метода SaveAsNewDocument

    
    void SaveAsNewDocument(Document savedDoc, SAPRTeamReferenceObject sourceOfFileName)
    {
        var filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        var basicPartOfFileName = sourceOfFileName.GetVar(СправочникИзвещенияОбИзменениях.Параметр.Обозначение);

        SaveAsNewDocument(savedDoc, filePath, basicPartOfFileName);
    }


    */
}