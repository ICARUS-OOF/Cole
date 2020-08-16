using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cole
{
    namespace Managers
    {
        public class PlayerUI : MonoBehaviour
        {
            #region Singleton
            public static PlayerUI singleton;
            private void Awake()
            {
                if (singleton == null)
                {
                    singleton = this;
                }
            }
            #endregion
            public bool isPaused = false;
            [Header("References")]
            public GameObject menu;
            private void Update()
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Pause();
                }
                menu.SetActive(isPaused);
                if (isPaused)
                {
                    FreeCursor();
                } else
                {
                    LockCursor();
                }
            }
            public void Pause()
            {
                isPaused = true;
                Time.timeScale = 1f;
            }
            public void Resume()
            {
                isPaused = false;
                Time.timeScale = 1f;
            }
            public void LockCursor()
            {
                Cursor.visible = false;
            }
            public void FreeCursor()
            {
                Cursor.visible = true;
            }
            public void Exit()
            {
                Application.Quit();
                Debug.Log("Exiting game...");
            }
        }
    }
}
