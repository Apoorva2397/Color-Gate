using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
    // Use this for initialization
    public Text score;
    void Start()
    {
        score = GetComponent<Text>();
        score.text = PlayerPrefs.GetInt("Score", 0).ToString();
    }

}
