using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    // unity calls it every frame game is running
    private void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.s) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        } else
        {
            _direction = Vector2.zero;
        }
    }
}
