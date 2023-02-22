using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D _rigidbody;

    // unity automatically calls one time during lifecycle of script. do initialization work here
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector2.zero;
    }
}
