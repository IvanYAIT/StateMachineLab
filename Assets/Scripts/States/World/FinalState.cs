namespace State
{
    class FinalState : AState
    {
        private StateMachine playerStateMachine;

        public FinalState(IStateMachine owner, StateMachine playerStateMachine) : base(owner)
        {
            this.playerStateMachine = playerStateMachine;
        }

        public override void Enter()
        {
            playerStateMachine.ChangeState(typeof(FinalPlayerState));
        }

        public override void Exit() { }

        public override void Update() { }
    }
}