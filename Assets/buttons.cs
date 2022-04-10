using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttons : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene(3);
    }

    public void dance1()
    {
        SceneManager.LoadScene(8);
    }

    public void dance2()
    {
        SceneManager.LoadScene(9);
    }
}
