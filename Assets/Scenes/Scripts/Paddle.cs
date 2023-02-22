using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    // unity automatically calls one time during lifecycle of script. do initialization work here
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
