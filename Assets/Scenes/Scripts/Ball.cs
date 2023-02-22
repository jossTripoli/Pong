using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // called first frame script is executed 
    private void Start()
    {
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        // make ball start going in random direction left or right like a coin flip
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        // random so angle always different when ball shoots off. don't want to do zero because would be perfectly horizontal
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * speed);
    }

}
