using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TFlex.DOCs.Model.Macros;
using TFlex.DOCs.Model.Macros.ObjectModel;

namespace __Ясный_код
{
    // ниже, код коллег "как есть"
    // представленные переменные являются глобальными в рамках макроса
    // попробую минимизировать область видимости этих переменных

    public class Macro : MacroProvider
    {
        //Guid данного макроса "a00bcfd7-91b9-4c5d-9ef7-1538d448a31a"

        #region Штамп

        private string _fontName = "Times-New-Roman"; //Times-New-Roman-Bold
        private int _stampBorderWidth = 2;

        private int _stampColor;
        private double _stampOpacity;
        private double _stampGlobalX;
        private double _stampGlobalY;
        private int _stampGlobalAngle;

        #endregion

        #region Guids

        private static class Guids
        {
            /// <summary> Guid типа "Печать файлов" справочника "Пользовательские диалоги" </summary>
            public static readonly Guid UserDialogClass = new Guid("4491b3e4-eb87-47ae-be32-d5df1af1a30f");

            /// <summary> Guid справочника "Форматы" </summary>
            public static readonly Guid PageFormatsReferenceId = new Guid("17816113-feb7-44a1-9024-7052eb3d9b52");

            /// <summary> Guid параметра "Наименование" справочника "Форматы" </summary>
            public static readonly Guid NameFormat = new Guid("a8ccef51-1d3c-4f5f-9c6b-b4fd55ff4dcf");

            /// <summary> Guid параметра "Высота" справочника "Форматы" </summary>
            public static readonly Guid HeightFormat = new Guid("0541757d-5a38-401b-a234-e073a35f509d");

            /// <summary> Guid параметра "Ширина" справочника "Форматы" </summary>
            public static readonly Guid WidthFormat = new Guid("2e1fdaf1-9d7e-4496-9da0-0c73fe85cc40");


            public static class Parameters
            {
                public static Guid СокращенноеНазваниеПодразделения { get; } =
                    new Guid("d834e736-141a-42fa-b2d8-c14f58505686");

                public static readonly Guid КодПодразделения = new Guid("6d58df61-2a43-45b2-b8f6-34f3507107fd");
                public static readonly Guid ИсходныйФайл = new Guid("66ac7676-e3f5-4e6c-9b62-44213996ccc1");
                public static readonly Guid ФайлДляПечати = new Guid("03f339ed-39c3-463d-93f1-4825f3635396");
            }


            public static class Links
            {
                public static readonly Guid Подразделение = new Guid("378a7fd0-4490-490f-991a-22237e06defc");
                public static readonly Guid Форматы = new Guid("5e535c0a-309d-4975-b554-fe35659774f0");
                public static readonly Guid ДокументУчетнаяКарточка = new Guid("d708e1b4-2a1a-499c-aaaf-be5828e6377e");
            }
        }

        #endregion

        /// <summary> Путь к файлу 'magick.exe' в справочнике 'Файлы' </summary>
        public const string MagickExePath = @"Служебные файлы\Библиотека dll\magick.exe";

        /// <summary> Поддерживаемые расширения файлов </summary>
        private static readonly string[] SupportedExtensions = { ".tif", ".tiff", ".pdf" };

        DateTime _currentDateTime = DateTime.Now;

        private static string _папкаДляВременныхФайлов = Path.Combine(Path.GetTempPath(), "Temp DOCs");
        private static string _логОшибок = Path.Combine(_папкаДляВременныхФайлов, "TFlex.DOCs.PDM.Print.log");

        private string _localMagickFilePath;

        private string _сотрудник;
        private Объект _подразделениеПользователя;
        private Объекты _принтеры;
        private readonly Dictionary<string, string> _списокФорматПринтер = new Dictionary<string, string>();
        private int _текущийНомерПечатаемогоФайла;
        private List<Объект> _файлыНаПечать = new List<Объект>();

        private List<int> _списокИдентификаторовДокументов = new List<int>(0);
        private List<int> _списокИдентификаторовФайлов = new List<int>(0);

        private static string _номерИзменения { get; set; }

        public Macro(MacroContext context) : base(context) { }
    }


    /*


    1.


    переменная MagickExePath используется всего в одном месте
    перенес ее внутрь соответствующей функции

    private void LoadBinaryFiles()
    {
        string MagickExePath = @"Служебные файлы\Библиотека dll\magick.exe";
        _localMagickFilePath = GetFileLocalPathFromFileReference(MagickExePath);
    }

    
    2. 
    
    
    тоже самое с переменной SupportedExtensions
    она используется только в одном месте
    перенес ее внутрь соответствующей функции


    private bool ТипФайлаПоддерживается(string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
            return false;

        var extension = Path.GetExtension(filePath).ToLower();
        var supportedExtensions = new string[] { ".tif", ".tiff", ".pdf" };
        return supportedExtensions.Contains(extension);
    }

    
    3. 
    
    
    переменную _currentDateTime (которая всегда равна DateTime.Now)
    минимизировал до размеров атома
    теперь ее просто нет

    
    4. 
    

    переменная _папкаДляВременныхФайлов имеет огромное количество использований в разных методах
    ПРОПУСКАЮ ЭТУ ПЕРЕМЕННУЮ

    
    переменная _сотрудник используется только в свойстве КороткоеИмяПользователя
    если переменная пуста, то она вычисляется, если не пуста, то выдается
    между переменной и свойством много методов
    разместил их рядом

    
    private string _сотрудник;
    public string КороткоеИмяПользователя
    {
        get
        {
            if (String.IsNullOrEmpty(_сотрудник))
            {
                _сотрудник = ТекущийПользователь[User.Fields.LastName.ToString()] + " " + ПолучитьИнициалы(ТекущийПользователь[User.Fields.FirstName.ToString()]);
            }
            return _сотрудник;
        }
    }
    
    
    5.


    аналогично с переменной _подразделениеПользователя
    разместил ее рядом со свойствами, в которых она используется


    private Объект _подразделениеПользователя;
    public string НаименованиеПодразделения
    {
        get
        {
            return _подразделениеПользователя != null ? (string)_подразделениеПользователя[Guids.Parameters.СокращенноеНазваниеПодразделения.ToString()] : String.Empty;
        }
    }

    public string КодПодразделения
    {
        get
        {
            return _подразделениеПользователя != null ? (string)_подразделениеПользователя[Guids.Parameters.КодПодразделения.ToString()] : String.Empty;
        }
    }
    

    6. 
    

    переменная _принтеры имеет одно место, где она присваивается и одно место, где она используется
    между присваиванием и использованием несколько сотен строчек
    но место это многовложенный цикл
    смысл этой глобальной переменной - микрооптимизация
    в месте присваивания - мы делаем запрос на сервер, в месте использования (многовложенный цикл) - берем готовое значение (вместо запроса на сервер)
    ПРОПУСКАЮ ЭТУ ПЕРЕМЕННУЮ


    переменная _списокФорматПринтер используется только в одном месте
    но там рекурсивный вызов функции и многовложенный цикл
    ПРОПУСКАЮ ЭТУ ПЕРЕМЕННУЮ


    переменная _текущийНомерПечатаемогоФайла является глобальным счетчиком
    в местах, где она используется, нет рекурсии и есть один цикл
    внутри каждой итерации цикла переменная обнуляется
    вот сюда я ее и перенес, сделав локальной переменной метода
    также пришлось добавить ее в аргументы некоторым вложенным функциям


    стало


    var текущийНомерПечатаемогоФайла = 0;
    printDocument.PrintPage += PD_PrintPage(текущийНомерПечатаемогоФайла);
    
    
    7. 
    

    //

    
    8.


    //


    9.


    //


    10.


    //


    11. 
    
    
    //

    
    12. 
    
    
    //

    
    13.


    //


    14. 
    
    
    //

    
    15.


    //


    */
}