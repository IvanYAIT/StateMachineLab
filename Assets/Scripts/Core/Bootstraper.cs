using UnityEngine;
using TMPro;
using State;
using Player;


namespace Core
{
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
        private WorldStateMachine worldStateMachine;
        private PlayerStateView stateView;
        private int stateCount;

        void Start()
        {
            playerMovement = new PlayerMovement(playerSpeed);
            stateMachine = new StateMachine(attackInput, playerCombat);
            worldStateMachine = new WorldStateMachine(stateMachine);
            stateView = new PlayerStateView(stateText);
            playerInput.Constructor(playerMovement, playerTransfom);
        }

        private void Update()
        {
            stateMachine.Update();
            worldStateMachine.Update();
        }
    }
}