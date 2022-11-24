using System;
using UnityEngine;

class InvisibleState : AState
{
    private PlayerCombat playerCombat;
    private KeyCode attackInput;
    private bool isActive;
    private Color playerSpriteColor;

    public InvisibleState(StateMachine owner, KeyCode attackInput, PlayerCombat playerCombat) : base(owner)
    {
        this.attackInput = attackInput;
        this.playerCombat = playerCombat;
        playerSpriteColor = playerCombat.GetPlayerSprite().color;
        isActive = false;
    }

    public override void Enter()
    {
        
    }

    public override void Exit()
    {
        playerSpriteColor.a = 1;
    }

    public override void Update()
    {
        if (Input.GetKeyDown(attackInput))
        {
            if (!isActive)
            {
                playerSpriteColor.a /= 2;
                isActive = true;
            }
            else
            {
                playerSpriteColor.a *= 2;
                isActive = false;
            }
        }
        playerCombat.SetPlayerSpriteColor(playerSpriteColor);
    }
}
