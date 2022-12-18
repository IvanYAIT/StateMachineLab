using UnityEngine;

namespace Player
{
    public class PlayerCombat : MonoBehaviour
    {
        [SerializeField] private Transform firePoint;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private GameObject redZone;
        [SerializeField] private SpriteRenderer playerSprite;

        public Transform GetFirePoint => firePoint;
        public GameObject GetBulletPrefab => bulletPrefab;
        public GameObject GetRedZone => redZone;
        public SpriteRenderer GetPlayerSprite => playerSprite;

        public void SetPlayerSpriteColor(Color playerSpritecolor) => playerSprite.color = playerSpritecolor;
    }
}