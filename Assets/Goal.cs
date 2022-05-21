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
            }
        }
    }
}
