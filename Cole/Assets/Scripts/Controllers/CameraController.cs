using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cole
{
    namespace Controllers
    {
        public class CameraController : MonoBehaviour
        {
            public Transform target;

            #region Singleton
            public static CameraController singleton;
            private void Awake()
            {
                if (singleton == null)
                {
                    singleton = this;
                }
            }
            #endregion

            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {
                transform.position = new Vector3(target.position.x + 0.5f, target.position.y - 0.5f, transform.position.z);
            }
        }
    }
}
