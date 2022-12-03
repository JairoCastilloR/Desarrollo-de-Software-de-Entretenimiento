using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuPasua : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    [SerializeField] private GameObject opciones;
    /*private FadeScript fade;
    private void Awake(){
        fade = FindObjectOfType<FadeScript>();
    }*/


    private bool juegopausado=false;

    public void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(juegopausado){
                Reanudar();
            }else
            {
                Pausa();
            }
        }
    }

    public void Pausa(){
        juegopausado=true;
        Time.timeScale=0f;
        AudioSource[] audios=FindObjectsOfType<AudioSource>();
        foreach(AudioSource a in audios){
            a.Pause();
        }
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
        opciones.SetActive(false);
    }
    public void Reanudar(){
        juegopausado=false;
        Time.timeScale=1f;
        AudioSource[] audios=FindObjectsOfType<AudioSource>();
        foreach(AudioSource a in audios){
            a.Play();
        }
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        opciones.SetActive(false);
    }
    public void Reiniciar(){
        juegopausado=false;
        Time.timeScale=1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        opciones.SetActive(false);
    }
     
    public void Cerrar(){
        Debug.Log("Cerrando juego");
        Application.Quit();
    }


    public void MainMenu(){

        //fade.HacerFade();
        SceneManager.LoadScene("IntroMenu");
    }


    //Apartado de botones de Opciones

    public void Options(){
    
        menuPausa.SetActive(false);
        botonPausa.SetActive(false);
        opciones.SetActive(true);


    }

    public void BackMenu(){

        menuPausa.SetActive(true);
        botonPausa.SetActive(false);
        opciones.SetActive(false);

    }



}
