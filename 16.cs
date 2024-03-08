using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*
    
    
    1.  п.4 Шум


    было:


    public List<CodeMacro> AddedMacros { get; set; } = new(); // новые макросы


    стало:


    public List<CodeMacro> AddedMacros { get; set; } = new();


    2.  п.4 Шум


    было:


    public List<CodeMacro> UpdatedMacros { get; set; } = new(); // обновленные макросы


    стало:


    public List<CodeMacro> UpdatedMacros { get; set; } = new();


    3.  п.11 Закомментированный код


    было:


    //result = gitService.StageAll();
    //if (!result.Success)
    //{
    //    Error($"Добавление файлов не было успешно выполнено!");
    //    return;
    //}


    стало:


    (удалил ненужный код)


    4.  п.11 Закомментированный код


    было:


    //result = gitService.Commit($"{Context.Connection.ClientView.UserName}: перед экспортом изменений");
    //if (!result.Success)
    //{
    //    if (!result.NothingToCommit)
    //    {
    //        Error("Коммит не был успешно выполнен! Выполните коммит вручную!");
    //        return;
    //    }
    //}


    стало:


    (удалил ненужный код)


    5.  п.10 Обязательные комментарии


    было:


    /// <summary>
    /// Вызывается на сохранении объекта
    /// </summary>
    public void ИсправитьИмяМакроса()


    стало:


    public void ИсправитьИмяМакроса()


    6.  п.4 Шум


    было:


    if (!ДиалогОжидания.СледующийШаг($"Макрос {++counter} из {allMacroses.Count}")) // возвращает false, если нажата кнопка "Отмена"
        return;


    стало:


    if (!ДиалогОжидания.СледующийШаг($"Макрос {++counter} из {allMacroses.Count}"))
        return;


    7.  п.11 Закомментированный код


    было:


    if (macroName != macroNameNew)
    {
        //var needToEndChanges = false;
        //if (!объект.Changing)
        //{
        //    объект.BeginChanges();
        //    needToEndChanges = true;
        //}

        объект[Macroses.Parameters.Name].Value = macroNameNew;

        //if (needToEndChanges)
        //    объект.EndChanges();
    }


    стало:


    if (macroName != macroNameNew)
        объект[Macroses.Parameters.Name].Value = macroNameNew;


    8.


    //


    9.


    //


    10.


    //


    11.


    //


    12.


    //


    13.


    //


    14.


    //


    15.


    //


    */
}