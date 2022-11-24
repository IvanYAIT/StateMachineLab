using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class GameState : AState
{
    public GameState(StateMachine owner) : base(owner)
    {
    }

    public override void Enter()
    {
        Time.timeScale = 1;
    }

    public override void Exit()
    {
        Time.timeScale = 0;
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            owner.ChangeWorldState(typeof(PauseState));
        if (Input.GetKeyDown(KeyCode.Escape))
            owner.ChangeWorldState(typeof(FinalState));
    }
}
