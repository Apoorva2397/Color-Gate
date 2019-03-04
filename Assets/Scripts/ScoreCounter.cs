using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour {

    int score;
    public Text textScore;

    private void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        textScore = GameObject.Find("Score").GetComponent<Text>();
        score = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
            if (collision.tag == "point")
            {
                score++;
                SetScore();
                SetHighScore(); 
                Destroy(collision.gameObject);
            }
        
        
    }
    public void SetHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore")) {
            PlayerPrefs.SetInt("HighScore", score);
        }

    }
    public void SetScore()
    {   
        textScore.text = score.ToString();
        PlayerPrefs.SetInt("Score", score);
        //Stores the total points earned throughout entire game play.
        PlayerPrefs.SetInt("TotalScore", PlayerPrefs.GetInt("TotalScore") + 1);
    }

}
