﻿using System;
using System.IO;

namespace Microsoft.Web.Administration
{
    public static class CertificateInstallerLocator
    {
        public static string FileName
        {
            get
            {
                var defaultPath = Path.Combine(Environment.CurrentDirectory, "certificateinstaller.exe");
                if (File.Exists(defaultPath))
                {
                    return defaultPath;
                }

                var debugBuild = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\CertificateInstaller\bin\Debug\netcoreapp3.0\certificateinstaller.exe");
                if (File.Exists(debugBuild))
                {
                    return debugBuild;
                }

                var releaseBuild = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\CertificateInstaller\bin\Release\netcoreapp3.0\certificateinstaller.exe");
                if (File.Exists(releaseBuild))
                {
                    return releaseBuild;
                }

                var debugBuildFx = Path.Combine(Environment.CurrentDirectory, @"..\..\..\CertificateInstaller\bin\Debug\certificateinstaller.exe");
                if (File.Exists(debugBuildFx))
                {
                    return debugBuildFx;
                }

                var releaseBuildFx = Path.Combine(Environment.CurrentDirectory, @"..\..\..\CertificateInstaller\bin\Release\certificateinstaller.exe");
                if (File.Exists(releaseBuildFx))
                {
                    return releaseBuildFx;
                }

                throw new ApplicationException("cannot find certificateinstaller.exe");
            }
        }
    }
}
