using Player;
using UnityEngine;

namespace State
{
    class ShootState : AState
    {
        public static string Name = "Shoot";

        private PlayerCombat playerCombat;
        private KeyCode attackInput;

        public ShootState(StateMachine owner, KeyCode attackInput, PlayerCombat playerCombat) : base(owner)
        {
            this.playerCombat = playerCombat;
            this.attackInput = attackInput;
        }

        public override void Enter() { }

        public override void Exit() { }

        public override void Update()
        {
            if (Input.GetKeyDown(attackInput))
                Instantiate(playerCombat.GetBulletPrefab, new Vector3(playerCombat.GetFirePoint.position.x, playerCombat.GetFirePoint.position.y), new Quaternion());
        }
    }
}