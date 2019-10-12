using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ballMovement : MonoBehaviour {
    private Rigidbody2D ball;
    public float upForce = 6f;
    SpriteRenderer bRenderer;
    public Color Cyan;
    public Color Yellow;
    public Color Pink;
    public Color Purple;
    public ParticleSystem explode;
    string color;
	// Use this for initialization
	void Start () {
        if (explode.playOnAwake)
            explode.Pause();
        bRenderer = GetComponent<SpriteRenderer>();
        ball = GetComponent<Rigidbody2D>();
        RandColor();
	}
    
	
	// Update is called once per frame
	void Update () {
        Freeze();
        if (Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire1")){
            ball.velocity = Vector2.up * upForce;
        }
	}
    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if(collider.tag == "ColorChanger")
        {
            RandColor();
            DestroyObject(collider.gameObject);
        }
        if((collider.tag != color) && (collider.tag != "point") && (collider.tag != "ColorChanger"))
        {
            StartCoroutine("playExplode");
        }
        
    }
    // Assigns Random color to the ball
    void RandColor() {
        int rno = Random.Range(0, 4);
        switch (rno)
        {
            case 0:
                bRenderer.color = Cyan;
                color = "Cyan";
                break;
            case 1:
                bRenderer.color = Yellow;
                color = "Yellow";
                break;
            case 2:
                bRenderer.color = Pink;
                color = "Pink";
                break;
            case 3:
                bRenderer.color = Purple;
                color = "Purple";
                break;
            default:
                Debug.Log("color is not assigned");
                break;
        }
    }
    // Prevents ball from moving downwards from the initial coordinates ( y axis )
    void Freeze() {
        if (transform.position.y <= -3.01f)
        {
            ball.velocity = new Vector2(0, 0);
            ball.gravityScale = 0f;

        }
        else {
            ball.gravityScale = 3;
        }
        
    }
    IEnumerator playExplode() {
        ball.velocity = new Vector2(0, 0);
        ball.gravityScale = 0f;
        bRenderer.sprite = null;
        if(!explode.isPlaying)
            explode.Play();
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(2);
    }
}
