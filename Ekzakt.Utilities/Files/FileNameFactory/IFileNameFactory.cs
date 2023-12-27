﻿namespace Ekzakt.Utilities.Files.FileNameFactory;

public interface IFileNameFactory
{
    CreateFileNameResult CreateFileName(string originalFileName, string contentType, Action<FileNameFactoryOptions>? options = null);
}
