using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Transform playerTransform;

    void Update()
    {
        playerMovement.Move(playerTransform);
    }

    public void Constructor(PlayerMovement playerMovement, Transform playerTransform)
    {
        this.playerMovement = playerMovement;
        this.playerTransform = playerTransform;
    }
}
