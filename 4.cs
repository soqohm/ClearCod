using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*
       

    1.


    в моей предметной области есть понятие "Обозначение"
    по англ. можно назвать Designation, Denotation или Number
    иногда, все три слова можно встретить в одном методе
    
    было:
    
    var designation = producedProduct.Denotation;
    var productionUnitNumber = productionUnit[UserAndGroupsGuids.ProductionUnitNumberGuid].GetString();

    стало:

    var productNumber = productOfTechProcess.Denotation;
    var productionUnitNumber = productionUnit[UserAndGroupsGuids.ProductionUnitNumberGuid].GetString();


    2.


    переменная передается в Диалог Ожидания

    было:

    var mes = $"Обработка подключений объекта {index + 1}/{rootObjects.Count}. ";

    стало:

    var waitDialogMessage = $"Обработка подключений объекта {index + 1}/{rootObjects.Count}. ";


    3.


    заменил variables и deleted на allVariables и deletedVariables

    было:

    var variables = startDocument.GetVariables().Select(e => e.Name).ToList();
    var dialog = new MultiselectListForm(variables);
    if (dialog.ShowDialog() != DialogResult.OK || dialog.MultiselectBox.CheckedItems.Count == 0)
        return;
    var deleted = dialog.MultiselectBox.CheckedItems.Cast<string>().ToList();

    стало:

    var allVariables = startDocument.GetVariables().Select(e => e.Name).ToList();
    var dialog = new MultiselectListForm(allVariables);
    if (dialog.ShowDialog() != DialogResult.OK || dialog.MultiselectBox.CheckedItems.Count == 0)
        return;
    var deletedVariables = dialog.MultiselectBox.CheckedItems.Cast<string>().ToList();


    4.


    заменил button на buttonOk

    было:

    button.Text = "OK";
    button.Dock = DockStyle.Bottom;
    button.DialogResult = DialogResult.OK;
    Controls.Add(button);

    стало:

    buttonOk.Text = "OK";
    buttonOk.Dock = DockStyle.Bottom;
    buttonOk.DialogResult = DialogResult.OK;
    Controls.Add(buttonOk);


    5.


    name1 - nameToSet
    // имя для установки


    6.


    name2 - nameToDisplay
    // имя для отображения пользователю


    7. 


    image - signatureImage
    // изображение подписи


    8.


    row - rowCount
    // количество строк в отчете


    9.


    col - columnCount
    // количество колонок в отчете


    10.


    c1 - firstRangeCell
    // первая ячейка диапазона


    11. 


    c2 - lastRangeCell
    // последняя ячейка диапазона


    12. 


    range - rewriteRange
    // диапазон ячеек для перезаписи


    */
}