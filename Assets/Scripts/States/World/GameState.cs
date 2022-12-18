using UnityEngine;
namespace State
{
    class GameState : AState
    {
        public GameState(IStateMachine owner) : base(owner)
        {
        }

        public override void Enter() =>
            Time.timeScale = 1;

        public override void Exit() =>
            Time.timeScale = 0;

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                owner.ChangeState(typeof(PauseState));
            if (Input.GetKeyDown(KeyCode.Escape))
                owner.ChangeState(typeof(FinalState));
        }
    }
}