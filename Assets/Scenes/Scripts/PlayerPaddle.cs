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
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        } else
        {
            _direction = Vector2.zero;
        }
    }

    // called at specific time variable, associated with physics. don't want physics based on framerate of game. use fixed time interval instead. rigid body makes sprite a physics object
    private void FixedUpdate()
    {
        if(_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * speed);
        }
    }
}
