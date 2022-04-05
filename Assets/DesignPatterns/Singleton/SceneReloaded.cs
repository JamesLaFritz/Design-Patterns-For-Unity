// SceneReloaded.cs
// 04-04-2022
// James LaFritz

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Singleton
{
    public class SceneReloaded : MonoBehaviour
    {
        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.R))
            {
                return;
            }

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}