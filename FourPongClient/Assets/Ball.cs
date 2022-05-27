using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    public int lastHit;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    public void Reset()
    {
        this.rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    private void Launch()
    {
        this.lastHit = 0;
        float angle = Random.Range(0f, 2f * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        this.rb.velocity = direction * this.speed;
    } 

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        this.lastHit = getLastHitPlayer(collision.gameObject.tag);
    }   

    private int getLastHitPlayer (string tag) {
        switch (tag)
            {
                case "Player1":
                    return 1;
                case "Player2":
                    return 2;
                case "Player3":
                    return 3;
                case "Player4":
                    return 4;           
                default:
                    return 0;
            }
    }
}
