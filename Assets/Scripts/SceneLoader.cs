using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

   //static int currentLevel;
    private void Start()
    {
        //currentLevel = SceneManager.GetActiveScene().buildIndex;
        //int nextLevel = SceneManager.sceneCountInBuildSettings % currentLevel; 
    }

    public static void reloadLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
	}

    public void setScene() {
        SceneManager.LoadScene(1);
    }
    /* Loads the next Level in the scene
    public static void nextLevel() {
        SceneManager.LoadScene()
    }*/
}
