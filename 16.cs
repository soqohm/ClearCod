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


    5.


    //


    6.


    //


    7.


    //


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