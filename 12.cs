using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Ясный_код
{
    /*


    1.


    переменная MagickExePath используется всего в одном месте
    перенес ее внутрь соответствующей функции

    private void LoadBinaryFiles()
    {
        string MagickExePath = @"Служебные файлы\Библиотека dll\magick.exe";
        _localMagickFilePath = GetFileLocalPathFromFileReference(MagickExePath);
    }

    
    2. 
    
    
    тоже самое с переменной SupportedExtensions
    она используется только в одном месте
    перенес ее внутрь соответствующей функции


    private bool ТипФайлаПоддерживается(string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
            return false;

        var extension = Path.GetExtension(filePath).ToLower();
        var supportedExtensions = new string[] { ".tif", ".tiff", ".pdf" };
        return supportedExtensions.Contains(extension);
    }

    
    3. 
    
    
    переменную _currentDateTime (которая всегда равна DateTime.Now)
    минимизировал до размеров атома
    теперь ее просто нет


    */
}