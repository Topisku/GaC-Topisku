using UnityEngine;

public class GhostScript:MonoBehaviour
{
    public Rigidbody2D myRigidbody2d;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive )
        {
            myRigidbody2d.linearVelocity = Vector2.up * flapStrength;
            AudioManager.instance.PlaySFX("Jump");
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        AudioManager.instance.PlaySFX("Game over");
    }
}
