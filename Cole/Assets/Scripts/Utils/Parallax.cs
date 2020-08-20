using Cole.Controllers;
using UnityEngine;
namespace Cole
{
    namespace Utils {
        public class Parallax : MonoBehaviour
        {
            private float length, startPos;
            public float parallaxEffect;

            private void Start()
            {
                startPos = transform.position.x;
                length = GetComponent<SpriteRenderer>().bounds.size.x;
            }

            private void FixedUpdate()
            {
                Vector3 camPos = CameraController.singleton.transform.position;
                float dist = (camPos.x * parallaxEffect);
                float temp = (camPos.x * (1 - parallaxEffect));

                transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

                if (temp > startPos + length) startPos += length;
                else if (temp < startPos - length) startPos -= length;
            }
        } 
    } 
}
