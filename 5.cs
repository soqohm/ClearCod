using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*
       

    1.


    было: StageNode
    стало: StageChanger


    2.


    было: MyConfiguration
    стало: GitConfiguration


    3.


    было: Button
    стало: TFlexCADButton


    4.


    было: Column
    стало: ExcelReportColumn


    5.


    было: HierarchyData
    стало: DepthWeights


    6. Использование Number как "Обозначение" (не Designation, не Denotation) 


    public string GetNumber()
    {
        return Source[СправочникЭлектроннаяСтруктура.Параметр.Обозначение].GetString();
    }


    7. Использование Recursive - т.е. на всю иерархию вниз


    public static void RecursiveDeleteVariables()

    public static IEnumerable<Fragment3D> RecursiveLoadHierarchy(this Document document, HierarchyData data)

    public static class RecursiveLoadChilds


    8. Использование Load вместо Get, где идет обращение к серверу


    public Reference LoadReference(string referenceName)

    public List<ReferenceObject> LoadTechs(params string[] namesOfTechTypes)

    public List<ReferenceObject> LoadFiles()

    public IEnumerable<NomenclatureHierarchyLink> LoadParents()

    public IEnumerable<NomenclatureHierarchyLink> LoadChilds()


    9. Использование Product как Сборочная единица (не отдельная деталь)


    public static string[] GetProductLinks(this Document doc)
    {
        return GetExternalLinks(doc.FileName, false)
            .Where(str => GetExternalLinks(str, true).FirstOrDefault() != null)
            .ToArray();
    }

    public static bool IsProduct(this Fragment3D f)
    {
        return GetExternalLinks(f.FullFilePath, false).FirstOrDefault() != null;
    }


    10. Использование MaterialObject (деталь, сборка и т.п.) как все, что не документация


    public static bool IsMaterialObj(this ReferenceObject obj)
    {
        return obj.Class.IsInherit(NomenclatureTypes.Keys.MaterialObject);
    }

    public static IEnumerable<NomenclatureHierarchyLink> OnlyMaterialChildObjects(this IEnumerable<NomenclatureHierarchyLink> links)
    {
        return links
            .Where(e => e.ChildObject.Class.IsInherit(NomenclatureTypes.Keys.MaterialObject));
    }


    11. Использование Reference как справочник (ReferenceObject - объект справочника)


    private void LoadESIReference(ConfigurationSettings configurationSettings)


    12. Использование мажорная, минорная часть; мажорная, минорная ревизия


    public MajorRevision MajorPart { get; private set; }
        
    public MinorRevision MinorPart { get; private set; }

    void SetMajorPart()

    void SetMinorPart()


    */
}