using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeedUp : PUPaddle
{
    public int magnitude;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision == ball_collider){
            if(ball.GetComponent<BallController>().GetLastBumped() == "left")
            {
                paddle_left.GetComponent<PaddleController>().ManipulateSpeed(magnitude);
                manager.RemovePowerUp(gameObject);
            }
            else if(ball.GetComponent<BallController>().GetLastBumped()== "right")
            {
                paddle_right.GetComponent<PaddleController>().ManipulateSpeed(magnitude);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
