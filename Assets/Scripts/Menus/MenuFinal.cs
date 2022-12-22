using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFinal : MonoBehaviour
{

    //[SerializeField] private GameObject MainMenu;
    [SerializeField] private FadeScript panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenu(){

        //fade.HacerFade();
        panel.setNivel("IntroMenu");
        panel.HacerFade();
        //Reanudar();
        //SceneManager.LoadScene("IntroMenu");
    }
}
