using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour
{   
    public Transform player;
    void Update()
    {
        if (transform.position.y < player.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }
    }
}

