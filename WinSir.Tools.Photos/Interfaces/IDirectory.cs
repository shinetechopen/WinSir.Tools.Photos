﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public interface IDirectory : IFileSystemEntry
    {
        IDirectory LetDirectoryFiles(Action<IFile> command);
    }
}