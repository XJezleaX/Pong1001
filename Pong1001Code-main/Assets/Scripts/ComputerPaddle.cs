using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
   // public Rigidbody2D ball;

   /* private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
    }*/

    private Vector2 _direction;

    private void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if ( Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
