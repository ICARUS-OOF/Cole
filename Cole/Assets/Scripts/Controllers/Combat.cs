using Cole.Managers;
using System.Collections;
using UnityEngine;
namespace Cole
{
    namespace Controllers
    {
        public class Combat : MonoBehaviour
        {
            //References
            [SerializeField] GameObject gfx;
            [SerializeField] Transform swordPoint;
            [SerializeField] Vector3 colliderBox;

            Rigidbody2D rb;
            Vector2 mousePos;

            public bool canAttack = true;

            private void Start()
            {
                rb = GetComponent<Rigidbody2D>();
            }
            private void Update()
            {
                if (GameManager.singleton.playerUI.isPaused)
                {
                    return;
                }

                Transform target = GameManager.singleton.movement.transform;
                transform.position = new Vector3(target.position.x + 0.477f, target.position.y + -0.497f, target.position.z - -0.0112f);
                if (canAttack)
                {
                    //Attack();
                    mousePos = GameManager.singleton.cameraController.cam.ScreenToWorldPoint(Input.mousePosition);
                    Vector2 lookDir = mousePos - GameManager.singleton.movement.rb.position;
                    float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
                    rb.rotation = angle;
                }
            }
            private void FixedUpdate()
            {
                
            }
            void Attack()
            {
                Collider2D[] EnemyColls = Physics2D.OverlapBoxAll(swordPoint.position, colliderBox, LayerMask.NameToLayer("Enemy"));
                foreach (Collider2D enemy in EnemyColls)
                {

                }
            }
            private void OnDrawGizmos()
            {
                Gizmos.DrawWireCube(swordPoint.position, colliderBox);
            }
        }
    }
}