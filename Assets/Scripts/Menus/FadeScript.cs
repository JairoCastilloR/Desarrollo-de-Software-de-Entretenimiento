using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    private Animator anim;
    [SerializeField] string nivel;
    // Start is called before the first frame update
    private void Awake(){
        anim = GetComponent <Animator>();
    }
    public void PasarNivel() {
        SceneManager.LoadScene(nivel);
        Debug.Log(nivel);
    }
    public void HacerFade(){
        anim.SetTrigger("FadeOutScene");
    }
    public void setNivel(string nivel){
        this.nivel = nivel;
    }

}
