using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndResult : MonoBehaviour
{

    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private FloatSO scoreSo;

    private void Start(){
        scoreText.text = scoreSo.Value + "";
    }

}
