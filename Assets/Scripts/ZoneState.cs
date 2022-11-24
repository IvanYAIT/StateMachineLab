using System;
using UnityEngine;

class ZoneState : AState
{
    private PlayerCombat playerCombat;
    private KeyCode attackInput;
    private bool isActive;
    private GameObject redZone;

    public ZoneState(StateMachine owner, KeyCode attackInput, PlayerCombat playerCombat) : base(owner)
    {
        this.playerCombat = playerCombat;
        redZone = playerCombat.GetRedZone();
        isActive = false;
        this.attackInput = attackInput;
    }

    public override void Enter()
    {
        redZone.SetActive(true);
        isActive = true;
    }

    public override void Exit()
    {
        redZone.SetActive(false);
        isActive = false;
    }

    public override void Update()
    {
        if (Input.GetKeyDown(attackInput))
        {
            if (!isActive)
            {
                redZone.SetActive(true);
                isActive = true;
            }
            else
            {
                redZone.SetActive(false);
                isActive = false;
            }
                
        }
    }
}
