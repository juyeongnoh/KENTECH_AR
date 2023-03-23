//using System.Collections;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class BackButtonToQuit : MonoBehaviour
//{
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Escape))
//        {
//            if (Application.platform == RuntimePlatform.Android)
//            {
//                if (Input.GetKeyDown(KeyCode.Escape))
//                {
//                    Application.Quit();
//                }
//            }
//        }
//    }
//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class BackButtonToQuit : MonoBehaviour
{

    //public string SceneToLoad;

    // Update is called once per frame
    int ClickCount = 0;
    void Update()
    {
        /* press to start 
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneToLoad);
        }
        */

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ClickCount++;
            if (!IsInvoking("DoubleClick"))
                Invoke("DoubleClick", 1.0f);

        }
        else if (ClickCount == 2)
        {
            CancelInvoke("DoubleClick");
            Application.Quit();
        }

    }

    void DoubleClick()
    {
        ClickCount = 0;
    }

}
