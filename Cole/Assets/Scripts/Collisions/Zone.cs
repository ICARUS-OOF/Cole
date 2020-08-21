using UnityEngine;
using Cole.Interfaces;
using Cole.Managers;
using UnityEngine.Events;

namespace Cole
{
    namespace Collisions
    {
        public class Zone : MonoBehaviour, ITrigger
        {
            void OnTriggerEnter2D(Collider2D col)
            {
                if (col.transform.tag == GameHandler.PLAYER_TAG)
                {
                    Trigger();
                }
            }
            public void Trigger()
            {
                Debug.Log("Triggered");
            }
        }
    }
}