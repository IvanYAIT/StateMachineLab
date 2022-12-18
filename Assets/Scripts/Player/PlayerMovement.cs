using UnityEngine;

namespace Player
{
    public class PlayerMovement
    {
        private float speed;

        public PlayerMovement(float speed)
        {
            this.speed = speed;
        }

        public void Move(Transform transform)
        {
            float axisX = Input.GetAxis("Horizontal");
            float axisY = Input.GetAxis("Vertical");

            transform.position += new Vector3(speed * axisX * Time.deltaTime, speed * axisY * Time.deltaTime);
        }
    }
}