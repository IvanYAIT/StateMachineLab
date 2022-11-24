namespace State
{
    class FinalState : AState
    {
        public FinalState(StateMachine owner) : base(owner)
        {
        }

        public override void Enter()
        {
            owner.ChangeState(typeof(FinalPlayerState));
        }

        public override void Exit() { }

        public override void Update() { }
    }
}