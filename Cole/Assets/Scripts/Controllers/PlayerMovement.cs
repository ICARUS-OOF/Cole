using Cole.Managers;
using UnityEngine;
namespace Cole
{
    namespace Controllers
    {
        public class PlayerMovement : MonoBehaviour
        {
            public float speed = 5f;
            [HideInInspector]
            public Rigidbody2D rb;
            private Animator anim;

            Vector2 movement;

            #region Singleton
            public static PlayerMovement singleton;
            private void Awake()
            {
                if (singleton == null)
                {
                    singleton = this;
                }
            }
            #endregion

            private void Start()
            {
                rb = GetComponent<Rigidbody2D>();
                anim = GetComponent<Animator>();
            }

            private void Update()
            {
                movement.x = Input.GetAxisRaw("Horizontal");
                movement.y = Input.GetAxisRaw("Vertical");
            }

            private void FixedUpdate()
            {
                if (GameManager.singleton.playerUI.isPaused)
                {
                    return;
                }

                anim.SetFloat("Horizontal", movement.x);
                anim.SetFloat("Vertical", movement.y);
                anim.SetFloat("Speed", movement.sqrMagnitude);

                if (movement.y == -1f)
                {
                    anim.SetInteger("LastDirID", 0);
                }
                else if (movement.y == 1f)
                {
                    anim.SetInteger("LastDirID", 1);
                }
                else if (movement.x == -1f)
                {
                    anim.SetInteger("LastDirID", 2);
                }
                else if (movement.x == 1f)
                {
                    anim.SetInteger("LastDirID", 3);
                }

                rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
            }
        }
    }
}