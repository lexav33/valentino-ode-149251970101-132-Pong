using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    public string last_bumped;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    private void Update() {
        if(rig.velocity.x == 0){
            if(last_bumped == "left"){
                rig.velocity = new Vector2(-5,0);
            }
            if(last_bumped == "right"){
                rig.velocity = new Vector2(5,0);
            }
        }
    }

    public void ResetBall()
    {
        last_bumped = null;
        transform.position = new Vector3(resetPosition.x, resetPosition.y, -2);
        rig.velocity = new Vector2(Random.Range(-10, 10), Random.Range(-2,2));
        while(Mathf.Abs(rig.velocity.x) <3)
        {
            rig.velocity = new Vector2(Random.Range(-10, 10), Random.Range(-2,2));
        }
    }

    public void ManipulateSpeed(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "Paddle_left"){
            last_bumped = "left";
        }
        else if(collision.gameObject.name == "Paddle_right"){
            last_bumped = "right";
        }
    }

    public string GetLastBumped(){
        return last_bumped;
    }
}
