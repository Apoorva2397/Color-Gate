using UnityEngine;
using UnityEngine.UI;

public class PauseMen : MonoBehaviour {
    static bool isPause = false;
    public GameObject gamepause;
    public GameObject pauseButton;
	// Use this for initialization

    public void Pause()
    {
        isPause = true;
        if (isPause == true) {
            pauseButton.SetActive(false);
            gamepause.SetActive(true);
            Time.timeScale = 0;
        }   
    }
    public void Resume()
    {
        isPause = false;
        if (isPause == false) {
            gamepause.SetActive(false);
            pauseButton.SetActive(true);
            Time.timeScale = 1;
        }
    }
}
