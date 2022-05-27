using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int scored, scorer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            this.scored = getScoredPlayer(this.gameObject.tag);
            this.scorer = GameObject.Find("Ball").GetComponent<Ball>().lastHit;
            GameObject.Find("GameManager").GetComponent<GameManager>().PlayerScored(this.scorer, this.scored);
        }
    }

    private int getScoredPlayer (string tag) {
        switch (tag)
            {
                case "Player1Goal":
                    return 1;
                case "Player2Goal":
                    return 2;
                case "Player3Goal":
                    return 3;
                case "Player4Goal":
                    return 4;           
                default:
                    return 0;
            }
    }
}
