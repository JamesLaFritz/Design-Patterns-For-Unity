// Bullet.cs
// 04-14-2022
// James LaFritz

using UnityEngine;
using UnityEngine.Pool;

namespace DesignPatterns.ObjectPolling
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Vector3 m_speed;
        private IObjectPool<Bullet> m_pool;

        public void SetPool(IObjectPool<Bullet> pool)
        {
            m_pool = pool;
        }

        private void Update()
        {
            transform.position += m_speed * Time.deltaTime;
        }

        private void OnBecameInvisible()
        {
            m_pool?.Release(this);
        }
    }
}