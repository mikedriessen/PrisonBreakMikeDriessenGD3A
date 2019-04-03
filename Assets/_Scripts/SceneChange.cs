using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{

    public static SceneChange singleton;



    void Awake()
    {
        if(SceneChange.singleton == null)
        {
            SceneChange.singleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);


    }
    public void OnButtonClickExit()
    {
       Application.Quit();
       Debug.Log("Exited Game");

    }
}
