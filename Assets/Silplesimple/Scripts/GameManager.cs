using Completed;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BoardManager boardScript;
    
    private int level = 3;
    // Start is called before the first frame update
    void Start()
    {
        boardScript = GetComponent<BoardManager>();
        InitGame();
    }

    private void InitGame()
    {
        boardScript.SetupScene(level);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
