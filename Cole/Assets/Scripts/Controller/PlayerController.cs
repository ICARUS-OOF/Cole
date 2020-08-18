using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cole
{
    namespace Controllers
    {
        public class PlayerController : MonoBehaviour
        {
            public static PlayerController singleton;

            public float runSpeed = 40f;

            float horizontalMove = 0f;
            bool jump = false;

            private void Awake()
            {
                if (singleton == null)
                {
                    singleton = this;
                }
            }

            private void Update()
            {
                horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

                if (Input.GetButtonDown("Jump"))
                {
                    jump = true;
                }
            }
            private void FixedUpdate()
            {
                PlayerPhysics.singleton.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
                jump = false;
            }
        }
    }
}
