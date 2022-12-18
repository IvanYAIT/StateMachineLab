using System;

namespace State
{
    interface IStateMachine
    {
        void ChangeState(Type type);
        void Update();
    }
}
