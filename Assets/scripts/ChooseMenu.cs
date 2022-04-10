using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMenu : MonoBehaviour
{
    public void DanceOptions()
    {
        SceneManager.LoadScene(4);
    }

    public void MedicalOptions()
    {
        SceneManager.LoadScene(5);
    }

    public void back()
    {
        SceneManager.LoadScene(2);
    }

}
