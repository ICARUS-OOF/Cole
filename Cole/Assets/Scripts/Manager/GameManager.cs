using UnityEngine;
using Cole.Controllers;
namespace Cole
{
	namespace Managers
	{
		public class GameManager : MonoBehaviour
		{
			#region Singleton
			public static GameManager singleton;
			private void Awake()
			{
				if (singleton == null)
				{
					singleton = this;
				}
			}
			#endregion
			#region References
			public PlayerMovement movement;
			public CameraController cameraController;
			#endregion
			#region Methods
			private void Start()
			{

			}
			private void Update()
			{
				movement = PlayerMovement.singleton;
				cameraController = CameraController.singleton;
			}
			#endregion
		}
	}
	namespace Enums
	{
		public enum Direction
		{
			Down,
			Up,
			Left,
			Right
		}
	}
}