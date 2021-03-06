using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUBall : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;
    public int timeout;

    private float timer;

    private void Start() {
        timer = 0;
    }

    private void Update() {
        timer += Time.deltaTime;

        if(timer > timeout)
        {
            manager.RemovePowerUp(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision == ball)
        {
            ball.GetComponent<BallController>().ManipulateSpeed(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
