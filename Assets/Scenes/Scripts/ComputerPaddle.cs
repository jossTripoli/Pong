using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate()
    {
        // if to check which direction ball is moving
        if (ball.velocity.x > 0.0f) // moving towards right, towards computer
        {
            // ball is above computer
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            } else if (this.ball.position.y < this.transform.position.y) {
                _rigidbody.AddForce(Vector2.down * speed);
            }
            // if perfectly equal, don't need to move at all
        }
        else // ball is moving away from us
        {
            // paddle idle in the middle
            if (this.transform.position.y > 0.0f) // above center line
            {
                _rigidbody.AddForce(Vector2.down * speed);
            } else if (this.transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }
        }
        
    }
}
