using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    private int _playerScore;
    private int _computerScore;

    public TMPro.TMP_Text displayPlayerScore;
    public TMPro.TMP_Text displayComputerScore;

    public void PlayerScores()
    {
        _playerScore++;
        displayPlayerScore.text = _playerScore.ToString();
        playerPaddle.ResetPosition();

        ball.ResetPosition();
        ball.AddStartingForce();
    }

    public void ComputerScores()
    {
        _computerScore++;
        displayPlayerScore.text = _computerScore.ToString();

        ball.ResetPosition();
        ball.AddStartingForce();

    }

}
