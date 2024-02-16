using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*


    Рефакторинг кода коллег

    
    1. 2.


    было:


    if (listObject1.GetObject(new Guid("f0d0e7da-5b72-4ece-abaf-e958503f7b1e"))[new Guid("c768c8a8-efa6-4cd1-871a-43f302e7095b")].GetBoolean() == false || 
        материал2[new Guid("c768c8a8-efa6-4cd1-871a-43f302e7095b")].GetBoolean() == false)


    стало:


    var isPurchasedMaterial = материал2[new Guid("c768c8a8-efa6-4cd1-871a-43f302e7095b")].GetBoolean();
    var isPurchasedTechMaterial = listObject1.GetObject(new Guid("f0d0e7da-5b72-4ece-abaf-e958503f7b1e"))[new Guid("c768c8a8-efa6-4cd1-871a-43f302e7095b")].GetBoolean();
    if (isPurchasedMaterial == false || isPurchasedTechMaterial == false)


    3.


    было:


    var referenceName = "Технологические процессы";
    var findRouteFilterString = $"[Тип] = 'Маршрут' И [Обозначение ТП] = '{denotationTP}'";
    var routeObj = НайтиОбъект(referenceName, findRouteFilterString);


    стало:


    var routeObj = НайтиОбъект("Технологические процессы", $"[Тип] = 'Маршрут' И [Обозначение ТП] = '{denotationTP}'");


    4.


    было:


    диалог["Коэффициент умножения нормы расхода"]


    стало:


    string MULTIPLICATION_COEFFICIENT_OF_CONSUMPTION_RATE = "Коэффициент умножения нормы расхода"
    диалог[MULTIPLICATION_COEFFICIENT_OF_CONSUMPTION_RATE]


    5. 6.


    было:


    var containsStructLinks = link.StructureTypes.Any(structType => structType.Guid == new Guid("e56d2f86-11e1-4312-ad75-ca3f15896717") || structType.Guid == new Guid("6dd4ecc3-70bd-407d-8661-e2438c3e7287"));


    стало:


    var techStructGuid = new Guid("e56d2f86-11e1-4312-ad75-ca3f15896717");
    var designStructGuid = new Guid("6dd4ecc3-70bd-407d-8661-e2438c3e7287");
    var containsTechOrDesignStructs = link.StructureTypes.Any(e => e.Guid == techStructGuid || e.Guid == designStructGuid); 
    // типы структур входят в технологическую или конструкторскую


    7.


    было:


    if (referenceInfoDesignContext is null || referenceInfoDesignContext.ActivityStatus != GroupActivityStatus.Normal)


    стало:


    var isDeactivatedReference = referenceInfoDesignContext.ActivityStatus != GroupActivityStatus.Normal;
    if (referenceInfoDesignContext is null || isDeactivatedReference)
    // если справочник не найден или деактивирован


    8.


    было:


    if (currentObject is null || !currentObject.Reference.ParameterGroup.SupportsStages)


    стало:


    var stagesSupport = currentObject.Reference.ParameterGroup.SupportsStages;
    if (currentObject is null || stagesSupport == false)
    // если объект не выбран или справочник не поддерживает стадии


    9.


    было:


    ReferenceObject произвПодразд = (ReferenceObject)FindObject("Группы и пользователи", "[ID] = '211'");


    стало:


    var productionDivisionId = 211;
    var productionDivision = (ReferenceObject)FindObject("Группы и пользователи", $"[ID] = '{productionDivisionId}'");


    10.


    было:


    var referenceName = "Технологические процессы";
    var filterString = $"[Тип] = 'Технологический процесс' И [Обозначение ТП] = '{denotationTP}'";
    var techObj = НайтиОбъект(referenceName, filterString);


    стало:


    var techObj = НайтиОбъект("Технологические процессы", $"[Тип] = 'Технологический процесс' И [Обозначение ТП] = '{denotationTP}'");


    11.


    было:


    var pas = string.Join(",", list);
    var strfilter = "[Подключение].[ID] Входит в список '";
    strfilter = strfilter + pas + "'";
    var filter = Filter.Parse(strfilter, nomRef.ParameterGroup);


    стало:

    
    var idAnalogFilter = Filter.Parse(GetIdAnalogFilterString(ids), nomRef.ParameterGroup);

    string GetIdAnalogFilterString(List<int> ids)
    {
        return $"[Подключение].[ID] Входит в список '{string.Join(",", ids)}'";
    }


    12.


    было:


    var objs1 = refs.Find(Filter.Parse($"[Стадия] = 'Аннулировано' И [Последняя ревизия] не содержит данных И [Тип] Входит в список 'Деталь, Сборочная единица, Сертифицированная ЗЧ, Комплект, Комплекс, Изделие, Машинокомплект, Комплект ЗЧ, Стандартное изделие, Материал, Прочее изделие, Заготовка, Альтернативные изделия/установки, Исключение, Сборочный узел' И (([Технологические параметры ДСЕ] содержит какие-либо данные И ([Технологические параметры ДСЕ]->[Дата закрытия ТПП] >= '{dateS}' И [Технологические параметры ДСЕ]->[Дата закрытия ТПП] <= '{datePO}')) ИЛИ ([Техпроцессы] не содержит данных И ([Дата установки стадии] >= '{dateS}' И [Дата установки стадии] <= '{datePO}')))", refs.ParameterGroup));


    стало:


    var annuls = refs.Find(Filter.Parse(GetAnnulsFilterString(startDate, endDate), refs.ParameterGroup));

    string GetAnnulsFilterString(DateTime startDate, DateTime endDate)
    {
        return $"[Стадия] = 'Аннулировано' И " +
            $"[Последняя ревизия] не содержит данных И " +
            $"[Тип] Входит в список 'Деталь, Сборочная единица, Сертифицированная ЗЧ, Комплект, Комплекс, Изделие, Машинокомплект, Комплект ЗЧ, Стандартное изделие, Материал, Прочее изделие, Заготовка, Альтернативные изделия/установки, Исключение, Сборочный узел' И " +
            $"(([Технологические параметры ДСЕ] содержит какие-либо данные И ([Технологические параметры ДСЕ]->[Дата закрытия ТПП] >= '{startDate}' И [Технологические параметры ДСЕ]->[Дата закрытия ТПП] <= '{endDate}')) ИЛИ " +
            $"([Техпроцессы] не содержит данных И ([Дата установки стадии] >= '{startDate}' И [Дата установки стадии] <= '{endDate}')))";
    }


    */
}