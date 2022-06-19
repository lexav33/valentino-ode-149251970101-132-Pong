using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULongerPaddle : PUPaddle
{
    public Vector2 magnitude;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision == ball_collider){
            if(ball.GetComponent<BallController>().GetLastBumped() == "left")
            {
                paddle_left.GetComponent<PaddleController>().ManipulateTransform(magnitude);
                manager.RemovePowerUp(gameObject);
            }
            else if(ball.GetComponent<BallController>().GetLastBumped() == "right")
            {
                paddle_right.GetComponent<PaddleController>().ManipulateTransform(magnitude);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
