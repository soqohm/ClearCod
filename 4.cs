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


    // в работе


    6.


    // в работе


    7.


    // в работе


    8.


    // в работе


    9.


    // в работе


    10. 


    // в работе


    11. 


    // в работе


    12. 


    // в работе


    */
}