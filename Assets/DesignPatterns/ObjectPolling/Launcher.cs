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

        private void Awake()
        {
            m_bulletPool = new ObjectPool<Bullet>(CreateBullet, OnGetBullet, OnReleaseBullet, OnDestroyBullet);
        }


        private Bullet CreateBullet()
        {
            Bullet bullet = Instantiate(m_bulletPrefab, transform.position, Quaternion.identity);
            return bullet;
        }

        private void OnGetBullet(Bullet bullet)
        {
            bullet.gameObject.SetActive(true);
            bullet.transform.position = transform.position;
        }

        private void OnReleaseBullet(Bullet obj) { }

        private void OnDestroyBullet(Bullet obj) { }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_bulletPool?.Get();
            }
        }
    }
}