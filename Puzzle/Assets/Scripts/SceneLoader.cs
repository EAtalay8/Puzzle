using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public int lastLevel;

    void Start()
    {
        lastLevel = PlayerPrefs.GetInt("lastLevel", 1);

        if (SceneController.instance.firstLogin)
        {
            StartCoroutine(AsyncSceneLoader((lastLevel % 4) == 0 ? 4 : (lastLevel % 4)));
            SceneController.instance.firstLogin = false;
        }
        else
            StartCoroutine(AsyncSceneLoader(SceneController.instance.levelIndex));
    }

    IEnumerator AsyncSceneLoader(int BuildIndex)
    {
        AsyncOperation asyncLoadScene = SceneManager.LoadSceneAsync(BuildIndex, LoadSceneMode.Single);

        while (!asyncLoadScene.isDone)
        {
            yield return null;
        }
    }
}

