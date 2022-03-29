using UnityEngine;
using UnityEditor;
using UnityEditor.PackageManager;
using AppodealStack.UnityEditor.SDKManager;
using AppodealStack.UnityEditor.PluginRemover;
using AppodealStack.UnityEditor.SettingsWindow;

// ReSharper Disable CheckNamespace
namespace AppodealStack.UnityEditor.TopBarMenu
{
    public class AppodealMenu : ScriptableObject
    {
        [MenuItem("Appodeal/SDK Documentation")]
        public static void OpenDocumentation()
        {
            Application.OpenURL("http://www.appodeal.com/sdk/choose_framework?framework=2&full=1&platform=1");
        }

        [MenuItem("Appodeal/Appodeal Homepage")]
        public static void OpenAppodealHome()
        {
            Application.OpenURL("http://www.appodeal.com");
        }
       
        [MenuItem("Appodeal/Manage Appodeal SDK")]
        public static void AppodealSdkManager()
        {
            AppodealAdapterManager.ShowSdkManager();
        }
        
        [MenuItem("Appodeal/Appodeal Settings")]
        public static void AppodealSettings()
        {
            AppodealSettingsWindow.ShowAppodealSettingsWindow();
        }

        [MenuItem("Appodeal/Remove Plugin")]
        public static void RemoveAppodealPlugin()
        {
            bool decision = RemoveHelper.RemovePlugin();
            if (decision)
            {
                Client.Remove("com.appodeal.appodeal-unity-plugin-upm");
            }
        }
    }
}
