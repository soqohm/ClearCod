using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*
    

    1.


    //Сбрасываем глобальный параметр, чтобы разрешить другим выполнять свои задачи
    public void OnWorkFinished() => MacrosParametersReference.Set(
        Context, Constants.LongRunningTaskParameterName, 0, "Операция остановлена", "Разблокируем запуск длительных процессов");


    2.


    //Сложные фильтры со скобками метод mainDialog.AddMatchReferenceObject() не понимает,
    //поэтому придется фильтровать последнии ревизии позже
    //var objectsToChangeFilter = "([Актуальная Ревизия 2] = 'True' ИЛИ [Последняя ревизия] не содержит текст) И [Тип] Порождён от 'Изделие' И [Стадия] != 'Аннулировано'";
    var objectsToChangeFilter = "[Тип] Порождён от 'Изделие' И [Стадия] != 'Аннулировано' И [Актуальная Ревизия 2] = 'True'";


    3.


    // Рассчитать размеры заготовок с припусками и площадь сечения, если нет информации из материала
    switch (userDialog.Class.Name)
    {
        case "Круг":


    4.


    //13.04.2023 производить особое вычисление обозначение ТП если только не найден объект ТП по коду изделия
    if (!_tpObjectsDictionary.TryGetValue(обозначениеТпБыло, out var tpReferenceObject))


    5.


    // Папка "Аннулированные ДСЕ"
    var folderCanceledESI = nomenclatureReference.Find(new Guid("e9f7a4c7-eada-47b9-9655-81cfad6f8af1")); 


    6.


    // Запуск макроса "АЗ Урал. Комплектности"
    ВыполнитьМакрос("b6afb298-ff92-4689-98d8-0ab99270ab58", "ЗапуститьИзБП", ТекущийОбъект); 


    7.


    // требуется, если пользователь отсортировал данные в справочнике вручную, тогда данные модели и данные вью модели будут синхронизированы
    RefreshReferenceWindow(); 

    
    */
}