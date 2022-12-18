using Player;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    class StateInitializer
    {
        public void Init(StateMachine stateMachine, KeyCode attackInput, PlayerCombat playerCombat, out Dictionary<Type, AState> states, out AState currentState)
        {
            states = new Dictionary<Type, AState>();
            states.Add(typeof(ShootState), new ShootState(stateMachine, attackInput, playerCombat));
            states.Add(typeof(ZoneState), new ZoneState(stateMachine, attackInput, playerCombat));
            states.Add(typeof(InvisibleState), new InvisibleState(stateMachine, attackInput, playerCombat));
            states.Add(typeof(FinalPlayerState), new FinalPlayerState(stateMachine, playerCombat));
            
            currentState = new ShootState(stateMachine, attackInput, playerCombat);
            
        }

        public void WorldInit(WorldStateMachine worldStateMachine, StateMachine playerStateMachine, out Dictionary<Type, AState> states, out AState currentWorldState)
        {
            states = new Dictionary<Type, AState>();
            states.Add(typeof(GameState), new GameState(worldStateMachine));
            states.Add(typeof(PauseState), new PauseState(worldStateMachine));
            states.Add(typeof(FinalState), new FinalState(worldStateMachine, playerStateMachine));
            currentWorldState = new GameState(worldStateMachine);
        }
    }
}