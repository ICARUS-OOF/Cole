using System.Collections;
using UnityEngine;
namespace Cole
{
    namespace Controllers
    {
        public class Combat : MonoBehaviour
        {
            Animator anim;
            [SerializeField] GameObject gfx;
            [SerializeField] Transform swordPoint;
            [SerializeField] Vector3 colliderBox;
            bool canAttack = true;

            private void Start()
            {
                anim = GetComponent<Animator>();      
            }
            private void Update()
            {
                if (Input.GetKeyDown(KeyCode.Mouse0) && canAttack)
                {
                    StartCoroutine(AttackPointer());
                }
            }
            IEnumerator AttackPointer()
            {
                Attack();
                yield return new WaitForSeconds(0.5f);
                canAttack = true;
                anim.SetBool("Swing", false);
                gfx.SetActive(false);
            }
            void Attack()
            {
                canAttack = false;
                anim.SetBool("Swing", true);
                gfx.SetActive(true);

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