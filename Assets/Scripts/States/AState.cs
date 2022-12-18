namespace State
{
    abstract class AState : UnityEngine.Object
    {
        protected IStateMachine owner;

        public AState(IStateMachine owner)
        {
            this.owner = owner;
        }

        public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();
    }
}