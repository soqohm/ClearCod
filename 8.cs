using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*
    

    Все, что ниже, это рефакторинг кода коллег

    
    1.


    int POINTS_TO_INCHES_COEFFICIENT = 72
    было int CoefficientInch = 72
    дал более наглядное имя
    коэффициент для приведения точек в дюймы


    2.


    double INCHES_TO_MM_COEFFICIENT = 25.42
    было double CoefficientMm = 25.42
    дал более наглядное имя
    коэффициент для приведения дюймов в мм


    3.


    DateTime CURRENT_DATE_TIME
    было DateTime currentDateTime


    4.


    int CURRENT_NUMBER_OF_PRINTED_FILE
    было int текущийНомерПечатаемогоФайла


    5.


    string FOLDER_FOR_TEMPORARY_FILES
    было string папкаДляВременныхФайлов


    6.


    string LOCAL_MAGICK_FILE_PATH
    было string localMagickFilePath


    7.


    int DPI = 300
    вынес в константу
    кол-во точек на дюйм для PDF страниц по умолчанию


    8.


    int NUMBER_OF_LAST_CHANGE
    было int номерПоследнегоИзменения


    9.


    int NUMBER_OF_USER_DEPARTMENT
    было int подразделениеПользователя


    10.


    string MAGICK_EXE_PATH
    было string MagickExePath
    путь к файлу 'magick.exe' в справочнике 'Файлы'


    11.


    Guid USER_DIALOG_CLASS = new Guid("4491b3e4-eb87-47ae-be32-d5df1af1a30f")
    guid встречается в нескольких местах, вынес в константу


    12.


    Guid PAGE_FORMATS_REFERENCE_ID = new Guid("17816113-feb7-44a1-9024-7052eb3d9b52")
    guid встречается в нескольких местах, вынес в константу


    */
}