using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

#if WINDOWS_UWP
    using Windows.Storage;
    using Windows.Storage.Pickers;
    using System.Threading.Tasks;
#endif

public class LoadFile : MonoBehaviour
{

    public string folder_name;

    // Start is called before the first frame update
    void Start()
    {
        CreatFolder(folder_name);
    }

    private void CreatFolder(string folderName)
    {

#if UNITY_EDITOR
        string path_test = AssetDatabase.CreateFolder("Assets", folderName);
        Debug.Log(AssetDatabase.GUIDToAssetPath(path_test));
#endif
#if WINDOWS_UWP
        Task directory = new Task(
            async() => 
            {
                StorageFolder localFolder = ApplicationData.Current.LocalFolder;
                StorageFolder newFolder = await localFolder.CreateFolderAsync(folderName, CreationCollisionOption.FailIfExists);
            }
        );
        directory.Start();
#endif
    }
}