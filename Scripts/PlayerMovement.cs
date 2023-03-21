﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ensures a rigidbody2d is attached to object
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //stores instance of collider and rigidbody
    private Rigidbody2D playerRigidbody;
    private Collider2D playerCollider;

    //stores how fast and how high a character can jump or move and if they can jump or move
    public float moveSpeed = 50f;
    public float maxRunSpeed = 5f;
    public float standingContactDistance = 0.1f;
    public bool velocityCapEnabled = true;
    //sets rigidbody and collider variables to the attached components
    public void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //if there is a rigidbody
        if (playerRigidbody != null)
        {
            //listen to controls and apply the input
            ApplyInput();
            //if there is a max speed only go to the max speed
            if (velocityCapEnabled)
            {
                CapVelocity();
            }
        }
        //if no rigidbody is found then say that rigid body isn't attached to the gameobject
        else
        {
            Debug.LogWarning("Rigid body not attached to player " + gameObject.name);
        }
    }

     // Check to see if any player keys are down, and if so... perform relevant actions
    public void ApplyInput()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        // Left and Right
        float xForce = xInput * moveSpeed * Time.deltaTime;
        float yForce = 0;

        //calculates the force the character should use in the direction
        Vector2 force = new Vector2(xForce, yForce);
        //adds the force to the character
        playerRigidbody.AddForce(force, ForceMode2D.Impulse);

    }
    //sets a maximum speed for the character
    public void CapVelocity()
    {
        float cappedXVelocity = Mathf.Min(Mathf.Abs(playerRigidbody.velocity.x), maxRunSpeed) * Mathf.Sign(playerRigidbody.velocity.x);
        float cappedYVelocity = playerRigidbody.velocity.y;
        //calculates the new velocity that it should have
        playerRigidbody.velocity = new Vector3(cappedXVelocity, cappedYVelocity);
    }

}       