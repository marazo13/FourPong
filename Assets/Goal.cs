using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int scorer, scored;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log(collision);
            Debug.Log(collision.gameObject);
            Debug.Log(collision.ToString());
            Debug.Log(collision.gameObject.ToString());
            // Debug.Log("GOOOOOOOOOOOOOOOOL");
            // GameObject.Find("GameManager").GetComponent<GameManager>().PlayerScored(scorer, scored);
            switch (this.scorer)
            {
                case 1:
                    Debug.Log("Player1Scored ...");
                    GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
                    break;
                case 2:
                    Debug.Log("Player2Scored ...");
                    GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
                    break;
                case 3:
                    Debug.Log("Player3Scored ...");
                    GameObject.Find("GameManager").GetComponent<GameManager>().Player3Scored();
                    break;
                case 4:
                    Debug.Log("Player4Scored ...");
                    GameObject.Find("GameManager").GetComponent<GameManager>().Player4Scored();
                    break;
                default:
                    Debug.Log("GOOOOOOOOOOOOOOOOL");
                    GameObject.Find("GameManager").GetComponent<GameManager>().ResetPosition();
                    // GameObject.Find("GameManager").GetComponent<GameManager>().PlayerScored(scorer, scored);
                    break;
            }
        }
    }
}
