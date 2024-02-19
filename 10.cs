using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*
    

    Рефакторинг кода коллег


    1. 2. 3.


    // явно объявил все переменные

    public void ИсправитьИмяМакроса()
    {
        ReferenceObject объект = Context.ReferenceObject;

        if (объект.LockStateDescription == "Удалён") 
            return;

        объект.Reload();
        string macroName = объект[Macroses.Parameters.Name].ToString();
        string macroNameNew = macroName.Remove(nameCheckSymbols).Trim();

        if (macroName != macroNameNew)
            объект[Macroses.Parameters.Name].Value = macroNameNew;
    }


    4. 5. 6. 7. 8.


    // явно объявил все переменные

    int номерПоследнегоИзменения = 0;
    foreach (Объект изменение in объектНоменклатуры.СвязанныеОбъекты["Изменения"])
    {
        string наименование = изменение["91486563-d044-4045-814b-3432b67812f1"];
        if (наименование.ToLower().StartsWith("ии."))
        {
            string строка = наименование.Substring(3);
            int номерИзменения;
            if (int.TryParse(строка, out номерИзменения))
            {
                if (номерИзменения > номерПоследнегоИзменения)
                    номерПоследнегоИзменения = номерИзменения;
            }
        }
    }


    9.


    если значение важной переменной недопустимо, вывожу предупреждение


    ReferenceInfo referenceInfo = Context.Connection.ReferenceCatalog.Find(new Guid("3e6df4d0-b1d8-4375-978c-4da676604cca"));
    if (referenceInfo == null)
        throw new MacroException("На найден справочник макросов");


    10.


    если значение важной переменной недопустимо, вывожу предупреждение


    StructureTypesReferenceObject constructStructure = structTypes
        .FirstOrDefault(t => t.Guid == new Guid("6dd4ecc3-70bd-407d-8661-e2438c3e7287"))
        ?? throw new MacroException(" Не найдена \"Конструкторская структура\"");


    11. 12.


    проинициализировал переменные там, где они используются


    было:


    var parentFolder = fileReference.FindByRelativePath(parentFolderPath);
    string nameWORev = fileName.Substring(0, fileName.Length - 4);
    string revName = fileName.Substring(fileName.Length - 4, 4);

    if (parentFolder == null)
        throw new MacroException(String.Format("Не найдена родительская папка с именем '{0}'", parentFolderPath));

    parentFolder.Children.Load();
    var uploadingFileName = String.Format("{0}{1}{2}.{3}", nameWORev, _extensionFile, revName, _extensionDoc);


    стало:


    FolderObject parentFolder = fileReference.FindByRelativePath(parentFolderPath);
    if (parentFolder == null)
        throw new MacroException(string.Format("Не найдена родительская папка с именем '{0}'", parentFolderPath));
    parentFolder.Children.Load();

    string nameWORev = fileName.Substring(0, fileName.Length - 4);
    string revName = fileName.Substring(fileName.Length - 4, 4);
    string uploadingFileName = string.Format("{0}{1}{2}.{3}", nameWORev, _extensionFile, revName, _extensionDoc);


    13. 14. 15


    инициализировал все поля класса в его конструкторе, сделал их readonly


    public class TFlexPluginButton
    {
        public readonly int Id;
        public readonly string Name;
        public readonly string Description;
        public readonly Ico Ico;
        public readonly string Tab;
        public readonly string Group;
        public readonly Action Macro;

        public TFlexPluginButton(int id, string name, string description, Ico ico, string tab, string group, Action macro)
        {
            Id = id;
            Name = name;
            Description = description;
            Ico = ico;
            Tab = tab;
            Group = group;
            Macro = macro;
        }

        public bool IsApplicationTab
        {
            get { return Tab == "Приложения"; }
        }
    }


    */
}