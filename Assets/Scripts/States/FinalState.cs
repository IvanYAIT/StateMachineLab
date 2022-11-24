using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FinalState : AState
{
    public FinalState(StateMachine owner) : base(owner)
    {
    }

    public override void Enter()
    {
        owner.ChangeState(typeof(FinalPlayerState));
    }

    public override void Exit()
    {
        
    }

    public override void Update()
    {
        
    }
}