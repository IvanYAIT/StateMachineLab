using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet
{
    public class Bullet : MonoBehaviour
    {
        void Update()
        {
            transform.position += new Vector3(10 * Time.deltaTime, 0);
        }
    }
}