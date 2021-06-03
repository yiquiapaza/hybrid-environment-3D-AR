using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

#if WINDOWS_UWP
    using Windows.Storage;
    using Windows.Storage.Pickers;
    using System.Threading.Tasks;
#endif

public class UtilIO
{
    public static void CreatFolder(string nameFolder)
    {
#if UNITY_EDITOR
        if(AssetDatabase.IsValidFolder(nameFolder))
        {
            AssetDatabase.CreateFolder("Assets", nameFolder);
            Debug.Log("Create folder Success");
        }
        
#endif
#if WINDOWS_UWP
        /*
        Task directory = new Task(
            async() => 
            {
                StorageFolder localFolder = ApplicationData.Current.LocalFolder;
                
                StorageFolder newFolder = await localFolder.CreateFolderAsync(folderName, CreationCollisionOption.FailIfExists);
            }
        );
        directory.Start();
        */
#endif
    }
    //TODO Delete the parameter gameObject when update code 
    public static string ReadFile(string NameFolder, string NameFile, GameObject gameObject)
    {
        string jsonData = "";
#if UNITY_EDITOR
        CreatFolder(NameFolder);
        Debug.Log(Directory.GetCurrentDirectory() + "\\Assets\\" + NameFolder + "\\" + NameFile);
        if (File.Exists(Directory.GetCurrentDirectory() + "\\Assets\\" + NameFolder + "\\" + NameFile))
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\Assets\\" + NameFolder + "\\" + NameFile);
            jsonData = sr.ReadToEnd();
        }
#endif
#if WINDOWS_UWP
        jsonData = Path.Combine(ApplicationData.Current.LocalFolder.Path, NameFile);
        if(string.IsNullOrEmpty(jsonData))
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        else
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        Debug.Log(jsonData);
#endif

        return jsonData;
    }

    public static GenericObject GenericObjectJson(string JsonString)
    {
        return JsonUtility.FromJson<GenericObject>(JsonString);
    }

    public static GenericObjects GenericObjecsJson(string JsonString)
    {
        return JsonUtility.FromJson<GenericObjects>(JsonString);
    }
}
