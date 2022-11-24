using System;
using UnityEngine;

namespace Player
{
    public class PlayerInput : MonoBehaviour
    {
        private PlayerMovement playerMovement;
        private Transform playerTransform;
        private int stateCount;

        public static Action<int> onStateChange;

        void Update()
        {
            playerMovement.Move(playerTransform);
        }

        public void ChangeState()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                stateCount++;
                if (stateCount >= 3)
                    stateCount = 0;
                onStateChange?.Invoke(stateCount);
            }
        }

        public void Constructor(PlayerMovement playerMovement, Transform playerTransform)
        {
            this.playerMovement = playerMovement;
            this.playerTransform = playerTransform;
        }
    }
}