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
    IDictionary<int, int> PlayerScores = new Dictionary<int, int>(){
        {1,0},
        {2,0},
        {3,0},
        {4,0}
    };

    // Experimental
    public void PlayerScored(int scorer, int scored)
    {
        if (scorer == 0) {
            OwnGoal(scored);
            return;
        } else {
            PlayerScores[scorer]++;
            if (PlayerScores[scored] > 0) PlayerScores[scored]--;
        }

        GameObject ScorerBoard;
        switch (scorer)
        {
            case 1:
                ScorerBoard = Player1ScoreBoard;
                break;
            case 2:
                ScorerBoard = Player2ScoreBoard;
                break;
            case 3:
                ScorerBoard = Player3ScoreBoard;
                break;
            case 4:
                ScorerBoard = Player4ScoreBoard;
                break;            
            default:
                ScorerBoard = Player1ScoreBoard;
                break;
        }

        GameObject ScoredBoard;
        switch (scored)
        {
            case 1:
                ScoredBoard = Player1ScoreBoard;
                break;
            case 2:
                ScoredBoard = Player2ScoreBoard;
                break;
            case 3:
                ScoredBoard = Player3ScoreBoard;
                break;
            case 4:
                ScoredBoard = Player4ScoreBoard;
                break;            
            default:
                ScoredBoard = Player1ScoreBoard;
                break;
        }

        ScorerBoard.GetComponent<TextMeshProUGUI>().text = "Player " + scorer + ": " + PlayerScores[scorer].ToString();
        ScoredBoard.GetComponent<TextMeshProUGUI>().text = "Player " + scored + ": " + PlayerScores[scored].ToString();
        ResetPosition();
    }

    private void OwnGoal(int scored) {
        if (PlayerScores[scored] > 0) PlayerScores[scored]--;

        GameObject ScoredBoard;
        switch (scored)
        {
            case 1:
                ScoredBoard = Player1ScoreBoard;
                break;
            case 2:
                ScoredBoard = Player2ScoreBoard;
                break;
            case 3:
                ScoredBoard = Player3ScoreBoard;
                break;
            case 4:
                ScoredBoard = Player4ScoreBoard;
                break;            
            default:
                ScoredBoard = Player1ScoreBoard;
                Debug.Log("Scored to who?????");
                break;
        }
        ScoredBoard.GetComponent<TextMeshProUGUI>().text = "Player " + scored + ": " + PlayerScores[scored].ToString();
        ResetPosition();
    }

    public void ResetPosition()
    {
        this.ball.GetComponent<Ball>().Reset();
        this.player1.GetComponent<Player>().Reset();
        this.player2.GetComponent<Player>().Reset();
        this.player3.GetComponent<Player>().Reset();
        this.player4.GetComponent<Player>().Reset();
    }
}
