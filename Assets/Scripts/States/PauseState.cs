using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class PauseState : AState
{
    public PauseState(StateMachine owner) : base(owner)
    {
    }

    public override void Enter()
    {

    }

    public override void Exit()
    {

    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            owner.ChangeWorldState(typeof(GameState));
    }
}
