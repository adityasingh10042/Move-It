﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class options : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene(3);
    }


    public void exercise()
    {
        SceneManager.LoadScene(6);
    }

    public void exercise2()
    {
        SceneManager.LoadScene(7);
    }
}
