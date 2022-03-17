// AmbientAudioPlayer.cs
// 03-17-2022
// James LaFritz

using UnityEngine;

namespace Singleton
{
    public class AmbientAudioPlayer : MonoBehaviour
    {
        private static AmbientAudioPlayer _instance;

        public static AmbientAudioPlayer GetInstance()
        {
            if (_instance == null)
            {
                throw new System.NullReferenceException(
                    "You are trying to acess a non existing Ambient Audio Player Please make sure one exist in the scene");
            }

            return _instance;
        }

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Debug.LogWarning("There is already an AmbientAudioPlayer in the Scene there should only ever be one!", this);
                Destroy(this);
            }
            else
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
    }
}