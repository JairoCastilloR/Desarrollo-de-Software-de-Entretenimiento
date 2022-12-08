using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    private float scoreAmount;
    public float pointIncreasedPerSecond; 
    private string score = "score";
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        loadScore();
        pointIncreasedPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + " Score";
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    }
     private void OnDestroy()
    {
        saveScore();
    }
    private void saveScore()
    {
        PlayerPrefs.SetInt(score,(int)scoreAmount);
    }
    private void loadScore()
    {

        scoreAmount = PlayerPrefs.GetInt(score,(int)scoreAmount);
    }
}
