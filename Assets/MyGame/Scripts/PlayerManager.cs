﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public collectFruit collectFruit;
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("bear");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (collectFruit.missionCompleted)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }*/
    }
}
