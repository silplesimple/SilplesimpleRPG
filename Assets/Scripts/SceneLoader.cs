using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance { get; private set; }
    public GameObject mainScene;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }


    public void OnMainScene()
    {
        SceneManager.LoadScene(TransSceneName(mainScene));
    }

    public string TransSceneName(GameObject mainScene)
    {
        string scenename=mainScene.name;        
        return scenename;
    }

}
