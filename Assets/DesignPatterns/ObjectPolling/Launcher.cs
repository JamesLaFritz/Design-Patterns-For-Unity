// Launcher.cs
// 04-14-2022
// James LaFritz

using UnityEngine;
using UnityEngine.Pool;

namespace DesignPatterns.ObjectPolling
{
    public class Launcher : MonoBehaviour
    {
        [SerializeField] private Bullet m_bulletPrefab;

        private IObjectPool<Bullet> m_bulletPool;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(m_bulletPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}