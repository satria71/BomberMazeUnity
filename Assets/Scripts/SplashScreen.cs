using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    public int DelayTime;
    public string chooseScene;
    // Start is called before the first frame update
    void Start()
    {
        if (chooseScene != "")
        {
            StartCoroutine(LoadNextScene());
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(DelayTime);
        if (chooseScene != "")
        {
            Application.LoadLevel(chooseScene);
        }
    }
}
