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


    Я взял код коллег и попытался дать выразительные имена временным переменным (и аргументам функции)


    StructuredTechnologicalProcess CreateTechnologicalProcess(
        ReferenceObject productionUnit,
        ReferenceObject productionUnitStep,
        MaterialObject productOfTechProcess, 
        HashSet<string> registeredProductionUnits,
        ClassObject typeOfTechProcess)
    {
        var productNumber = productOfTechProcess.Denotation;
        var productionUnitNumber = productionUnit[UserAndGroupsGuids.ProductionUnitNumberGuid].GetString();
        var techProcess = productionUnitStep.Reference.CreateReferenceObject(typeOfTechProcess) as StructuredTechnologicalProcess;
        techProcess.Name.Value = productOfTechProcess.Name;
        var techProcessNumber = string.Empty;
        var successToFindUniqueName = false;
        var index = 0;

        while (!successToFindUniqueName)
        {
            techProcessNumber = index == 0 ? $"{productNumber}_{productionUnitNumber}" : $"{productNumber}_{productionUnitNumber}_{index}";

            if (registeredProductionUnits.Contains(techProcessNumber))
            {
                index++;
                continue;
            }
            successToFindUniqueName = true;
        }

        techProcess.Denotation.Value = techProcessNumber;
        techProcess.AddLinkedObject(TechnologicalProcess.OneToManyGroups.ProducedDSE, productOfTechProcess);
        techProcess.ProductionUnit.SetLinkedObject(productionUnit);
        techProcess.DseMass.Value = productOfTechProcess.Mass;
        var list = productOfTechProcess.GetAllLinkedFiles();
        list.AddRange(productOfTechProcess.LinkedObject.GetAllLinkedFiles());
        techProcess.SketchFileLink.SetLinkedObject(list.FirstOrDefault());
        techProcess.EndChanges();

        return techProcess;
    }


    */
}