using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BarraVida : MonoBehaviour
{
    
    public static BarraVida DatosBarra;
    public Image Vidabarra;
    public float vida;
    [SerializeField]
    private TMP_Text scoreText ;
    [SerializeField]
    private FloatSO scoreSo;
    //ScoreSystem scoreSystem;

    public float vidamaxima;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "";
        scoreText.text = scoreSo.Value + "";
        
    }

    // Update is called once per frame
    void Update()
    {
        Vidabarra.fillAmount=vida/vidamaxima;
        if(vida<=0){
            Debug.Log("vida disminuye todo");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(vida < 100){
            scoreSo.Value += 100;
            scoreText.text = scoreSo.Value + "";
            //scoreSystem.SetScore(score);
        }
    }

        private void OnTriggerEnter(Collider other){

        if(other.tag == "caida"){
            Debug.Log("aaaaah mi pichulaa");
            ContadorVidas.numVidas.Descontar(1);
        }
    } 

}
