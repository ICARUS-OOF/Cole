using UnityEngine;
using UnityEngine.SceneManagement;
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
			public PlayerUI playerUI;
			#endregion
			#region Methods
			private void Start()
			{
				SceneManager.sceneLoaded += OnSceneLoaded;
				movement = PlayerMovement.singleton;
				cameraController = CameraController.singleton;
				playerUI = PlayerUI.singleton;
			}
			private void Update()
			{
				movement = PlayerMovement.singleton;
				cameraController = CameraController.singleton;
				playerUI = PlayerUI.singleton;
			}
			void OnSceneLoaded(Scene _scene, LoadSceneMode mode)
			{
				movement = PlayerMovement.singleton;
				cameraController = CameraController.singleton;
				playerUI = PlayerUI.singleton;
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