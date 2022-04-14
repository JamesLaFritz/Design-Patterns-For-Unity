// Bullet.cs
// 04-14-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.ObjectPolling
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Vector3 m_speed;

        private void Update()
        {
            transform.position += m_speed * Time.deltaTime;
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}