using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour {
    Text points; 
	// Use this for initialization
	void Start () {
        points = GetComponent<Text>();
        points.text = PlayerPrefs.GetInt("TotalScore").ToString();
	}

}
