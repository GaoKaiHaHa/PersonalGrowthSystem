﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class PathTool
{
    public static string GetStartupPath()
    {
        return Application.StartupPath;
    }

    public static string GetFullPath()
    {
        return Application.ExecutablePath;
    }

    public static string GetApplicationName()
    {
        return System.IO.Path.GetFileName(Application.ExecutablePath);
    }
}
