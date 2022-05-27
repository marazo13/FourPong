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
    public TMP_Text Player1ScoreBoard;
    public TMP_Text Player2ScoreBoard;
    public TMP_Text Player3ScoreBoard;
    public TMP_Text Player4ScoreBoard;

    private IDictionary<int, TMP_Text> PlayerScoreBoards;

    private IDictionary<int, int> PlayerScores = new Dictionary<int, int>(){
        {1,0},
        {2,0},
        {3,0},
        {4,0}
    };

    void Start()
    {
        PlayerScoreBoards = new Dictionary<int, TMP_Text>(){
            {1, Player1ScoreBoard},
            {2, Player2ScoreBoard},
            {3, Player3ScoreBoard},
            {4, Player4ScoreBoard}
        };
    }

    public void PlayerScored(int scorer, int scored)
    {
        if (scorer == 0) {
            OwnGoal(scored);
            return;
        } else {
            PlayerScores[scorer]++;
            if (PlayerScores[scored] > 0) PlayerScores[scored]--;
        }

        PlayerScoreBoards[scorer].text = "Player " + scorer.ToString() + ": " + PlayerScores[scorer].ToString();
        PlayerScoreBoards[scored].text = "Player " + scored.ToString() + ": " + PlayerScores[scored].ToString();
        ResetPosition();
    }

    private void OwnGoal(int scored) {
        if (PlayerScores[scored] > 0) PlayerScores[scored]--;

        PlayerScoreBoards[scored].text = "Player " + scored + ": " + PlayerScores[scored].ToString();
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
