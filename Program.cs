using Microsoft.Win32;
using System;

namespace ThemeAutoSwitcher
{
    class Program
    {
        static void SetDarkTheme()
        {
            var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            key.SetValue("AppsUseLightTheme", 0, RegistryValueKind.DWord);
            key.SetValue("SystemUsesLightTheme", 0, RegistryValueKind.DWord);
        }

        static void SetLightTheme()
        {
            var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            key.SetValue("AppsUseLightTheme", 1, RegistryValueKind.DWord);
            key.SetValue("SystemUsesLightTheme", 1, RegistryValueKind.DWord);
        }

        static void Main(string[] args)
        {
            if (DateTime.Now.Hour >= 18)
                SetDarkTheme();
            else
                SetLightTheme();
        }
    }
}
