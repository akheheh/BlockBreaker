﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //We want to bind our ball to a paddle...type is Paddle because we created such a class
    [SerializeField] Paddle paddle1;
    //State is distance between paddle and ball
    Vector2 paddle2BallVector;
    // Start is called before the first frame update
    void Start()
    {
        //The distance is the distance between the ball and the paddle (a vector delta)
        paddle2BallVector = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //We then want to get the position of the paddle, so we store that into a new Vector2
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        //We want the ball to now actually move with the paddle, so essentially, we set it to the paddle
        //positon, then offset it with the paddle2BallVector vector
        transform.position = paddle2BallVector + paddlePos;
    }
}