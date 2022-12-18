using UnityEngine;

namespace State
{
    class PauseState : AState
    {
        public PauseState(IStateMachine owner) : base(owner)
        {
        }

        public override void Enter() { }

        public override void Exit() { }

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                owner.ChangeState(typeof(GameState));
        }
    }
}