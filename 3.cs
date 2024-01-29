using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*
    
    
    7.1


    isShowLog - showLog
    
    isDifferentAbstractTypes - containsDifferentAbstractTypes
    
    applicationTab - isApplicationTab
    
    DOCsDisabled - isDOCsEnabled
    
    hierarchy - hasHierarchy
    
    notMaterialObject - isMaterialObject


    7.2


    public static void ChangeStageTo(this ReferenceObject obj, string newName, MacroProvider macro)
    {
        var success = macro.BusinessProcesses.Run("Смена стадии объекта ЭСИ", obj.ToRefObj(macro.Context), SetStageName(newName), false);

        if (!success)
            macro.Error("Не удалось сменить стадию объекта-приемника");
    }
    
    public static string FindResultPath(this Document doc)
    {
        var path = doc.FilePath + "!RENAME";

        if (!Directory.Exists(path))
            return path + @"\";

        var i = 1;
        var found = Directory.Exists(path + " (" + i + ")");

        while (found)
            i++;

        return path + " (" + i + ")" + @"\";
    }


    7.3


    public int SeekSlot(string value)
    {
        var indexByHashFun = HashFun(value);

        var freeIndex = indexByHashFun;
        for (; freeIndex < size; freeIndex += step)
            if (slots[freeIndex] == null)
                return freeIndex;

        freeIndex -= size;
        for (; freeIndex < indexByHashFun; freeIndex += step)
            if (slots[freeIndex] == null)
                return freeIndex;

        return -1;
    }


    7.4


    head - tail
    source - receiver
    childs - parents
    skipped - added


    7.5


    *


    */
}
