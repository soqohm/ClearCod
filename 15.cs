using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*
    

    1.  п.1 Информативные комментарии


    // Такая же папка как в DOCsCommonLibrary.DOCsPaths.TempFolder
    private static readonly string DOCsRootFolder = Path.Combine(Path.GetTempPath(), "TFlexDOCs");


    2.  п.1 Информативные комментарии


    //приходится задавать имя здесь, потому что невозможно определить имя выполняемого макроса
    //кодом Context[nameof(MacroKeys.MacroSource)] as CodeMacro
    //из контекста после того как выполнился RunMacros().
    //это косяк TFlex DOCs
    LogFileName = $"Лог макроса Git - {DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss")}.txt",


    3.  п.2 Представление намерений


    //показываем поля логина и пароля, если они незаполнены
    dialog.SetElementVisibility("Login", string.IsNullOrEmpty(_gitConfiguration.GitFlicLogin));
    dialog.SetElementVisibility("Password", string.IsNullOrEmpty(_gitConfiguration.GitFlicPassword));


    4.  п.1 Информативные комментарии


    dialog.AddSelectFromList(SelectedActionDialogKey, DialogActionButtonTexts[DialogActions.Clone], 
        true, new List<string> { DialogActionButtonTexts[DialogActions.Clone] });
    dialog.SetElementEnabled(SelectedActionDialogKey, false); //пока что можем только клонировать


    5.  п.6 Комментарии TODO


    // TODO - удалить после обновления библиотеки
    public static bool FileExistsCaseSensitive(string fullPath)
    {
        string name = Path.GetDirectoryName(fullPath);
        return name != null && Array.Exists(Directory.GetFiles(name), s => s == Path.GetFullPath(fullPath));
    }


    6.  п.6 Комментарии TODO


    var exists = FileExistsCaseSensitive(fileName);// TODO: Использовать метод SystemIOHelper.FileExistsCaseSensitive из либы после ее обновления на сервере


    7.  п.1 Информативные комментарии


    // макросы, взятые на редактирование текущим пользователем нужно применить, чтобы
    // гит-репозиторий и сервер TFlex содержали одни и те же версии файлов
    var macrosCheckedOutByMe = exportResult.SelectedMacros.Where(m => m.IsCheckedOutByCurrentUser).ToList();
    if (macrosCheckedOutByMe.Any())
    {
        try
        {
            logger.LogInfo($"У следующих макросов нужно применить изменения:\n   {string.Join("\n   ", macrosCheckedOutByMe)}");
            Desktop.CheckIn(macrosCheckedOutByMe, "Применение изменений перед экспортом", false);
        }
        catch (Exception ex)
        {
            logger.LogException($"Ошибка при применении изменений макросов: {ex.Message}", ex);
        }
    }


    8.  п.1 Информативные комментарии


    //если в первый раз пул зафакался - значит у нас есть конфликтующие измененные файлы
    //значит нужно попробовать после комита еще раз выполнить пулл, в надежде что сработает автомердж
    if (!firstPullResult.Success)
    {
        result = gitService.Pull();
        if (!result.Success)
        {
            Error($"Ошибка при загрузке обновлений (git pull)!" +
                $"Вероятно, нужно выполнить мердж вручную, запушить его, и импортировать макросы из папки!");
            return;
        }
    }


    9.  п.1 Информативные комментарии


    ImportAllMacros(logger, exportResult.ChangedButNotSelectedMacros, false); //после пуша обновляем макросы в справочнике (кто-то свои макросы уже мог закомитить)


    10.  п.5 Усиление


    // обязательно учитываем регистр имен файлов!
    var filesToRemove = allFiles.Where(f => !allMacros.Any(m => m.Name == Path.GetFileNameWithoutExtension(f.Name)))
        .ToList();


    11.  п.1 Информативные комментарии


    //удаляем макросы в справочнике если они отсутствуют в синхронизируемой папке
    var allMacros = _macroReference.Objects.OfType<CodeMacro>().ToList();
    var macrosToRemove = allMacros.Where(m => !allFiles.Any(f => m.Name == f.NameWithoutExtension())).ToList();
    foreach (var macro in macrosToRemove)
        ...


    12.  п.1 Информативные комментарии


    //пропускаем импорт файлов, которые не были отмечены для экспорта перед этим
    if (ignoreSelected != null)
        updatedFiles = updatedFiles.Where(f => !ignoreSelected.Any(i => f.NameWithoutExtension() == i.Name)).ToList();


    */
}