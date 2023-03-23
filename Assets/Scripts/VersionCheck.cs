using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class VersionCheck : MonoBehaviour
{
    public string URL = "";
    public string CurVersion;
    string latestVersion;
    public GameObject newVersionAvailable;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadTxtData(URL)); 
    }

    public void CheckVersion()
    {
        if(CurVersion != latestVersion)
        {
            newVersionAvailable.SetActive(true);
        }
        else
        {
            newVersionAvailable.SetActive(false);
        }
        Debug.Log("Cur Version: " + CurVersion + " Latest Version: " + latestVersion);
    }

    IEnumerator LoadTxtData(string url)
    {
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();
        if(www.isNetworkError)
        {
            Debug.Log("error get page");
        }
        else
        {
            latestVersion = www.downloadHandler.text;
        }
        CheckVersion();
    }

    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }
}
