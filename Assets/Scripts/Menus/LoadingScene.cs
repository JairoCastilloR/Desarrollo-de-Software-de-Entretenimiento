using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public string sceneToLoad;
    //AsyncOperation loadingOperation;
    public TMP_Text percentLoaded;
    public Slider slider;
    void Start()
    {
        //StartCoroutine(LoadAsynchronously());
        StartCoroutine(FakeLoadingBar(100));

    }
    void Update()
    {
        //StartCoroutine(LoadAsynchronously);
        //float progressValue = Mathf.Clamp01(loadingOperation.progress / 0.9f);
        //percentLoaded.text = Mathf.Round(progressValue * 100) + "%";
    }

     IEnumerator LoadAsynchronously ()
    {
        yield return new WaitForSeconds(5);
        AsyncOperation loadingOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        //LoadingScene.SetActive(true);
        while(!loadingOperation.isDone){
            float progress = Mathf.Clamp01(loadingOperation.progress / .9f);
            slider.value = progress;
            yield return new WaitForSeconds(5);
            percentLoaded.text = progress * 100f + "%";
            Debug.Log(progress);
            yield return null;
        }
    }
    IEnumerator FakeLoadingBar(float seconds)
    {
        float currentTime = 0;
        while (seconds > currentTime)
        {
            currentTime += Time.deltaTime +  Random.Range(.01f, .05f);
            slider.value = 1f * currentTime / 100f;
            percentLoaded.text = (int)(1f * currentTime) + "%";
            yield return null;
      }
      SceneManager.LoadScene(sceneToLoad);
    }
    
}
