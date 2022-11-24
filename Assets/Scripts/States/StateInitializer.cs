using Player;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    class StateInitializer
    {
        private Dictionary<Type, AState> states;
        private AState currentWorldState;

        public void Init(StateMachine stateMachine, KeyCode attackInput, PlayerCombat playerCombat, out Dictionary<Type, AState> states, out AState currentState, out AState currentWorldState)
        {
            states = new Dictionary<Type, AState>();
            states.Add(typeof(ShootState), new ShootState(stateMachine, attackInput, playerCombat));
            states.Add(typeof(ZoneState), new ZoneState(stateMachine, attackInput, playerCombat));
            states.Add(typeof(InvisibleState), new InvisibleState(stateMachine, attackInput, playerCombat));
            states.Add(typeof(FinalPlayerState), new FinalPlayerState(stateMachine, playerCombat));
            states.Add(typeof(GameState), new GameState(stateMachine));
            states.Add(typeof(PauseState), new PauseState(stateMachine));
            states.Add(typeof(FinalState), new FinalState(stateMachine));
            currentState = new ShootState(stateMachine, attackInput, playerCombat);
            currentWorldState = new GameState(stateMachine);
        }
    }
}