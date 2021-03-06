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
            m_bulletPool = new ObjectPool<Bullet>(CreateBullet, OnGetBullet, OnReleaseBullet, OnDestroyBullet,
                                                  maxSize: 5);
        }


        private Bullet CreateBullet()
        {
            Bullet bullet = Instantiate(m_bulletPrefab, transform.position, Quaternion.identity);
            bullet.SetPool(m_bulletPool);
            return bullet;
        }

        private void OnGetBullet(Bullet bullet)
        {
            bullet.gameObject.SetActive(true);
            bullet.transform.position = transform.position;
        }

        private void OnReleaseBullet(Bullet bullet)
        {
            bullet.gameObject.SetActive(false);
        }

        private void OnDestroyBullet(Bullet bullet)
        {
            Destroy(bullet.gameObject);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_bulletPool?.Get();
            }
        }
    }
}