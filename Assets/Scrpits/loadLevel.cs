using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class loadLevel : MonoBehaviour
{
    public Slider progressBar;
    void Start()
    {
        StartCoroutine(Wait(1.5f));
    }
    IEnumerator starLoading(int level)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(level);
       while(!async.isDone)
        {
            progressBar.value = async.progress;
            yield return null;
        }
        

    }
    IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(starLoading(1));

    }



    void Update()
    {
        
    }
}
