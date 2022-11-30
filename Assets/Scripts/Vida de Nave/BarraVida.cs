using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraVida : MonoBehaviour
{
    public static BarraVida DatosBarra;
    public Image Vidabarra;
    public float vida;

    public float vidamaxima;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Vidabarra.fillAmount=vida/vidamaxima;
        if(vida<=0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
