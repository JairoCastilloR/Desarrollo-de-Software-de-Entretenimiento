using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public GameObject options;
    public GameObject mainMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void option(){

        options.SetActive(true);
        mainMenu.SetActive(false);

    }

}
