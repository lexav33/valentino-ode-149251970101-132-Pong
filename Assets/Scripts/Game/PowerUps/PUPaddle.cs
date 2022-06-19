using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddle : MonoBehaviour
{
    public PowerUpManager manager;
    public GameObject ball;
    public GameObject paddle_right;
    public GameObject paddle_left;
    public int timeout;

    protected Collider2D ball_collider;
    protected Rigidbody2D ball_rig;

    protected float timer;

    private void Start() {
        timer = 0;
        ball_collider = ball.GetComponent<Collider2D>();
        ball_rig = ball.GetComponent<Rigidbody2D>();
    }

    private void Update() {
        timer += Time.deltaTime;

        if(timer > timeout)
        {
            manager.RemovePowerUp(gameObject);
        }
    }
}
