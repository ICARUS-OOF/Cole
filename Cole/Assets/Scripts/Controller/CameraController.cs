using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cole
{
    namespace Controllers
    {
        public class CameraController : MonoBehaviour
        {
            public static CameraController singleton;

            private void Awake()
            {
                if (singleton == null)
                {
                    singleton = this;
                }
            }
            private void LateUpdate()
            {
                Vector3 targetPos = PlayerController.singleton.transform.position;
                transform.position = Vector3.Lerp(transform.position, new Vector3(targetPos.x, targetPos.y, transform.position.z), Time.deltaTime * 10f);
            }
        }
    }
}
