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
            // switch (this.scorer)
            // {
            //     case 1:
            //         Debug.Log("Player1Scored ...");
            //         GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            //         break;
            //     case 2:
            //         Debug.Log("Player2Scored ...");
            //         GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            //         break;
            //     case 3:
            //         Debug.Log("Player3Scored ...");
            //         GameObject.Find("GameManager").GetComponent<GameManager>().Player3Scored();
            //         break;
            //     case 4:
            //         Debug.Log("Player4Scored ...");
            //         GameObject.Find("GameManager").GetComponent<GameManager>().Player4Scored();
            //         break;
            //     default:
            //         Debug.Log("GOOOOOOOOOOOOOOOOL (Unknown BY who though)");
            //         GameObject.Find("GameManager").GetComponent<GameManager>().ResetPosition();
            //         // GameObject.Find("GameManager").GetComponent<GameManager>().PlayerScored(scorer, scored);
            //         break;
            // }
        }
    }

    private int getScoredPlayer (string tag) {
        switch (tag)
            {
                case "Player1Goal":
                    Debug.Log("Goal to Player1");
                    return 1;
                case "Player2Goal":
                    Debug.Log("Goal to Player2");
                    return 2;
                case "Player3Goal":
                    Debug.Log("Goal to Player3");
                    return 3;
                case "Player4Goal":
                    Debug.Log("Goal to Player4");
                    return 4;           
                default:
                    Debug.Log("GOOOAALLL (Unknown TO who though)");
                    return 0;
            }
    }
}
