using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Ball")]
    public GameObject ball;
    [Header("Player 1")]
    public GameObject player1;
    public GameObject player1Goal;
    [Header("Player 2")]
    public GameObject player2;
    public GameObject player2Goal;
    [Header("Player 3")]
    public GameObject player3;
    public GameObject player3Goal;
    [Header("Player 4")]
    public GameObject player4;
    public GameObject player4Goal;

    [Header("Score UI")]
    public GameObject Player1ScoreBoard;
    public GameObject Player2ScoreBoard;
    public GameObject Player3ScoreBoard;
    public GameObject Player4ScoreBoard;

    private int Player1Score;
    private int Player2Score;
    private int Player3Score;
    private int Player4Score;

    public void Player1Scored()
    {
        Player1Score++;
        Player1ScoreBoard.GetComponent<TextMeshProUGUI>().text = "Player 1: " + Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2ScoreBoard.GetComponent<TextMeshProUGUI>().text = "Player 2: " + Player2Score.ToString();
        ResetPosition();
    }

    public void Player3Scored()
    {
        Player3Score++;
        Player3ScoreBoard.GetComponent<TextMeshProUGUI>().text = "Player 3: " + Player3Score.ToString();
        ResetPosition();
    }

    public void Player4Scored()
    {
        Player4Score++;
        Player4ScoreBoard.GetComponent<TextMeshProUGUI>().text = "Player 4: " + Player4Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        this.ball.GetComponent<Ball>().Reset();
        this.player1.GetComponent<Player>().Reset();
        this.player2.GetComponent<Player>().Reset();
        this.player3.GetComponent<Player>().Reset();
        this.player4.GetComponent<Player>().Reset();
    }
}
