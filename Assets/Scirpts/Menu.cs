using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    public void StartLevel (string level)
    {
        SceneManager.LoadScene(level);
    }
    public void Settigs()
    {

    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("El juego se cerro");
    }
    
}
