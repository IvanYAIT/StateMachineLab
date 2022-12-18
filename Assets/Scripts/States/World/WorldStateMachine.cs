using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class WorldStateMachine : IStateMachine
    {
        private Dictionary<Type, AState> states;
        private AState currentState;
        private StateInitializer stateInitializer;

        public WorldStateMachine(StateMachine playerStateMachine)
        {
            stateInitializer = new StateInitializer();
            stateInitializer.WorldInit(this, playerStateMachine, out states, out currentState);
        }

        public void ChangeState(Type type)
        {
            currentState.Exit();
            states.TryGetValue(type, out currentState);
            currentState.Enter();
        }

        public void Update()
        {
            currentState.Update();
        }
    }
}