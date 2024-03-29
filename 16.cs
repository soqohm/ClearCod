﻿using System;
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


    8.  п.2 Бормотание


    было:


    //подгружаем необходимые параметры
    curRef.LoadSettings.Clear();
    curRef.LoadSettings.AddParameters(allStrParInfo.Select(pi => pi.Guid).ToArray());


    стало:


    curRef.LoadSettings.Clear();
    curRef.LoadSettings.AddParameters(allStrParInfo.Select(pi => pi.Guid).ToArray());


    9.  п.2 Бормотание


    было:


    //получаем ParInfo всех не системных строковых параметров 
    HashSet<ParameterInfo> allStrParInfo = Context.Reference.ParameterGroup.GetAllGroups()
        .SelectMany(parGroup => parGroup.Parameters)
        .Where(pi => !pi.IsSystem && pi.Type.IsString && string.IsNullOrEmpty(pi.UserControl))
        .ToHashSet();


    стало:


    HashSet<ParameterInfo> allStrParInfo = Context.Reference.ParameterGroup.GetAllGroups()
        .SelectMany(parGroup => parGroup.Parameters)
        .Where(pi => !pi.IsSystem && pi.Type.IsString && string.IsNullOrEmpty(pi.UserControl))
        .ToHashSet();


    10.  п.10 Обязательные комментарии


    было:


    /// <summary>
    /// Записывает лог в файл и загружает его в DOCs
    /// </summary>
    private void WriteLogs()


    стало:


    private void saveLogToDOCs()


    11.  п.2 Бормотание


    было:


    var parentFolder = fileReference.FindByRelativePath("Логи") as FolderObject; //задаем целевую папку для импорта файлов


    стало:


    var folderForImportFiles = fileReference.FindByRelativePath("Логи") as FolderObject;


    12.  п.2 Бормотание


    было:


    //создаем отдельный настойки конфигурирования от которых будет работать макрос
    //на случай если работает со стороны БП или пользователь указал иные настройки конфигурирования
    var newConfiguirationSettings = new ConfigurationSettings(Context.Connection)


    стало:


    var newConfiguirationSettings = new ConfigurationSettings(Context.Connection)


    13.  п.11 Закомментированный код


    было:


    //public override void Run()
    //{
    //    var reference = Context.GetReference(LiteralizationTasks.Reference.ToString());
    //    var task = reference.Find(1);
    //    RunTask(task);
    //}


    стало:


    (удалил ненужный код)


    14.  п.2 Бормотание


    было:


    // посылаем письмо пользователю
    new MailMessage(Context.Connection.Mail.DOCsAccount)
        .AddSubject("Результат задачи массовой замены")
        .AddBody(body)
        .AddTo(new List<User> { task.SystemFields.Author })
        .Send();


    стало:


    new MailMessage(Context.Connection.Mail.DOCsAccount)
        .AddSubject("Результат задачи массовой замены")
        .AddBody(body)
        .AddTo(new List<User> { task.SystemFields.Author })
        .Send();


    15.  п.5 Позиционные маркеры


    было:


        }

        // 
    }


    стало:


    (удалил все свои позиционные маркеры в одном макросе)


    */
}