using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private Dictionary<Type, AState> states;
    private AState currentState;
    private AState currentWorldState;
    private StateInitializer stateInitializer;

    public StateMachine(KeyCode attackInput, PlayerCombat playerCombat)
    {
        stateInitializer = new StateInitializer();
        stateInitializer.Init(this, attackInput, playerCombat, out states, out currentState, out currentWorldState);
    }


    public void ChangeState(Type type)
    {
        currentState.Exit();
        states.TryGetValue(type, out currentState);
        currentState.Enter();
    }

    public void ChangeWorldState(Type type)
    {
        currentWorldState.Exit();
        states.TryGetValue(type, out currentWorldState);
        currentWorldState.Enter();
    }

    public void Update()
    {
        currentState.Update();
        currentWorldState.Update();
    }
}
