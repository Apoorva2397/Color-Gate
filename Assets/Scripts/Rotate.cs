using UnityEngine;

using System.Collections;


public class Rotate : MonoBehaviour {
    //Rotating Speed
    public float rSpeed = 120f;
    
    void Update () {
        transform.Rotate(0, 0, rSpeed * Time.deltaTime);
	}
}
