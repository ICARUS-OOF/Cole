using UnityEngine;
namespace Cole
{
    namespace Managers
    {
        public class GameHandler : MonoBehaviour
        {
            #region Singleton
            public static GameHandler singleton;
            private void Awake()
            {
                if (singleton == null)
                {
                    singleton = this;
                }
            }
            #endregion
            public static string PLAYER_TAG = "Player";
        }
    }
}