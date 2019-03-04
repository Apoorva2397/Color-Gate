using UnityEngine;
using System.Collections;

public class Home : MonoBehaviour {

    public void LoadMenu()
    {
        Time.timeScale = 1;
        Application.LoadLevel(0);
    }
}
