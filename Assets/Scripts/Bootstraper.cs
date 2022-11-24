using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bootstraper : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private PlayerCombat playerCombat;
    [SerializeField] private Transform playerTransfom;
    [SerializeField] private float playerSpeed;
    [SerializeField] private KeyCode attackInput;
    [SerializeField] private TextMeshProUGUI stateText;

    private PlayerMovement playerMovement;
    private StateMachine stateMachine;
    private int stateCount;
    private Dictionary<int, Type> stateTypes;
    private Type type;

    void Start()
    {
        playerMovement = new PlayerMovement(playerSpeed);
        stateMachine = new StateMachine(attackInput, playerCombat);
        playerInput.Constructor(playerMovement, playerTransfom);
        stateCount = 0;

        stateTypes = new Dictionary<int, Type>()
        {
            {0, typeof(ShootState) },
            {1, typeof(ZoneState) },
            {2, typeof(InvisibleState) }
        };
    }

    private void Update()
    {
        stateMachine.Update();
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            stateCount++;
            if (stateCount >= 3)
                stateCount = 0;
            stateTypes.TryGetValue(stateCount, out type);
            stateMachine.ChangeState(type);
        }

        switch (stateCount)
        {
            case 0:
                stateText.text = "Shoot";
                break;
            case 1:
                stateText.text = "Zone";
                break;
            case 2:
                stateText.text = "Invisible";
                break;
        }
    }
}
