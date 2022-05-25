using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int number;
    public float speed;
    public Rigidbody2D rb;
    private float movement;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (number)
        {
            case 1:
                this.movement = Input.GetAxisRaw("Vertical");
                this.rb.velocity = new Vector2(0, this.movement * this.speed);
                break;
            case 2:
                this.movement = Input.GetAxisRaw("Vertical2");
                this.rb.velocity = new Vector2(0, this.movement * this.speed);
                break;
            case 3:
                this.movement = Input.GetAxisRaw("Horizontal");
                this.rb.velocity = new Vector2(this.movement * this.speed, 0);
                break;
            case 4:
                this.movement = Input.GetAxisRaw("Horizontal2");
                this.rb.velocity = new Vector2(this.movement * this.speed, 0);
                break;
            default:
                this.movement = Input.GetAxisRaw("Vertical");
                this.rb.velocity = new Vector2(0, this.movement * this.speed);
                break;
        }
    }

    public void Reset()
    {
        this.rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }

    // private void OnCollisionEnter2D(Collision2D collision) 
    // {
    //     Debug.Log(collision.gameObject);
    //     if (collision.gameObject.CompareTag("Ball"))
    //     {
    //         Debug.Log("Ball Collided with " + this.gameObject.tag);
    //     }
    // }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     Debug.Log(collision.gameObject);
    //     if (collision.gameObject.CompareTag("Ball"))
    //     {
    //         Debug.Log("Ball Collided with " + this.gameObject.tag);
    //     }
    // }
}
