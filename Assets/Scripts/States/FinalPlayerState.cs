﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class FinalPlayerState : AState
{
    private PlayerCombat playerCombat;
    private GameObject redZone;
    private Color playerSpriteColor;

    public FinalPlayerState(StateMachine owner,PlayerCombat playerCombat) : base(owner)
    {
        this.playerCombat = playerCombat;
        redZone = playerCombat.GetRedZone();
        playerSpriteColor = playerCombat.GetPlayerSprite().color;
    }

    public override void Enter()
    {
        redZone.SetActive(false);
        playerSpriteColor = Color.green;
        playerSpriteColor.a = 1;
        playerCombat.SetPlayerSpriteColor(playerSpriteColor);
    }

    public override void Exit()
    {
        
    }

    public override void Update()
    {
        
    }
}
