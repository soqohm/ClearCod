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


    9.


    //


    10.


    //


    11.


    //


    12.


    //


    */
}