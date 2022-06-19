using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public int speed;

    private float transform_timer = 0;
    private float speed_timer = 0;
    private bool transform_modified = false;
    private bool speed_modified = false;

    private Rigidbody2D rig;
    private Transform trf;
    private int speedModifier;
    private SpriteRenderer sprite;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        trf = GetComponent<Transform>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        MoveObject(GetInput());
        if(transform_modified){
            transform_timer += Time.deltaTime;
            if(transform_timer >= 5)
            {
                ResetTransform();
                transform_modified = false;
                Debug.Log("test");
            }
        }
        if(speed_modified){
            speed_timer += Time.deltaTime;
            if(speed_timer >=5){
                ResetSpeed();
                speed_modified=false;
            }
        }
    }

    private Vector2 GetInput(){
        if(Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if(Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement){
        // Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }

    public void ManipulateTransform(Vector2 magnitude)
    {
        sprite.color = Color.red;
        transform_timer = 0;
        if(!transform_modified)
        {
        transform_modified = true;
        trf.localScale = magnitude;
        }
    }

    public void ManipulateSpeed(int magnitude){
        sprite.color = Color.green;
        speed_timer = 0;
        if(!speed_modified){
            speed_modified = true;
            speedModifier = magnitude;
            speed *= speedModifier;
        }
    }

    private void ResetTransform()
    {
        sprite.color = Color.white;
        trf.localScale = new Vector2(0.4f, 2.5f);
    }

    private void ResetSpeed(){
        sprite.color = Color.white;
        speed /= speedModifier;
    }
}
