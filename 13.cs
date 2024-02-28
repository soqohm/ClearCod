using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*
    

    у меня практически всегда работа с массивами идет без прямой индексации
    в основном используется метод Contains
    более безопасная структура данных в данном контексте, наверное, IEnumerable

    
    1.


    var supportedExtensions = new string[] { ".tif", ".tiff", ".pdf" };

    //

    var extension = Path.GetExtension(filePath).ToLower();
    return supportedExtensions.Contains(extension);


    2.


    public static bool IsType(this ReferenceObject obj, params string[] types)
    {
        return types.Contains(obj.Class.Name);
    }

    //

    return link.ChildObject.IsType("Материал", "Сборочный узел");


    3.


    FieldValueChangedEventHandler SelectedValueChanged(InputDialog dialog, string selectedValueKey, string changedValueKey)
    {
        return (fieldKey, oldValue, newValue) =>
        {
            if (fieldKey == selectedValueKey)
            {
                if (newValue == "Плоская")
                    dialog[changedValueKey] = new string[]
                    {
                        "К-структура",
                        "Т-структура",
                        "Т-структура + материалы"
                    };
                if (newValue == "Иерархическая")
                    dialog[changedValueKey] = new string[]
                    {
                        "К-структуру",
                        "Т-структуру",
                        "Т-структуру + техпроцессы",
                        "Т-структуру + техпроцессы + материалы"
                    };
            }
        };
    }

    //

    var key = dialog["Тип "] + dialog["Выгружать "];
    if (key == "Иерархическая" + "К-структуру") MacroКСтруктураИерарх();


    4.


    public static StructureTypesReferenceObject[] GetActiveStructs(this MacroContext context)
    {
        return context.Connection.ConfigurationSettings.ActiveStructures
            .Where(e => e.Value == true)
            .Select(e => e.Key)
            .ToArray();
    }

    //

    var structs = Context.GetActiveStructs();


    5.


    public static IEnumerable<NomenclatureHierarchyLink> LoadChildLinks(this ReferenceObject obj)
    {
        var loader = obj.Reference.CreateLoader(null, obj);
        loader.Load();
        return loader.GetLoadedHierarchyLinks().Select(e => (NomenclatureHierarchyLink)e);
    }

    //

    var childs = obj.LoadChildLinks()
        .Where(e => e.ContainsStruct("К"));

    foreach (var e in childs)
    {
        ...
    }


    */
}