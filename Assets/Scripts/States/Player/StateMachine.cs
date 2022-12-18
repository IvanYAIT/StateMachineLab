using Player;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class StateMachine : IStateMachine
    {
        private Dictionary<Type, AState> states;
        private AState currentState;
        private StateInitializer stateInitializer;

        private Dictionary<int, Type> stateTypes;
        private Type type;

        public StateMachine(KeyCode attackInput, PlayerCombat playerCombat)
        {
            stateInitializer = new StateInitializer();
            stateInitializer.Init(this, attackInput, playerCombat, out states, out currentState);

            stateTypes = new Dictionary<int, Type>()
        {
            {0, typeof(ShootState) },
            {1, typeof(ZoneState) },
            {2, typeof(InvisibleState) }
        };

            PlayerInput.onStateChange += ChangeStateBYPlayer;
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

        public void ChangeStateBYPlayer(int stateCount)
        {
            stateTypes.TryGetValue(stateCount, out type);
            ChangeState(type);
        }
    }
}