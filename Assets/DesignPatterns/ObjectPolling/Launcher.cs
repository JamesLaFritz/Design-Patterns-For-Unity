// Launcher.cs
// 04-14-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.ObjectPolling
{
    public class Launcher : MonoBehaviour
    {
        [SerializeField] private Bullet m_bulletPrefab;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(m_bulletPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}