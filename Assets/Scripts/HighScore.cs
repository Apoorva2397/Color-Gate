using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public Text highScore;
    void Start()
    {
        highScore = GetComponent<Text>();
        //highScore = GameObject.Find("highScore").GetComponent<Text>();
        //highScore.text = S.highscore.ToString();
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

	
}
