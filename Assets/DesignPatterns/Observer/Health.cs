// Health.cs
// 03-01-2022
// James LaFritz

using System.Collections;
using UnityEngine;

namespace Observer
{
    [RequireComponent(typeof(Level))]
    public class Health : MonoBehaviour
    {
        [SerializeField] private int m_fullHealth = 100;
        [SerializeField] private int m_drainPerSecond = 2;
        public float CurrentHealth { get; private set; } = 0;

        private void Awake()
        {
            ResetHealth();
            StartCoroutine(HealthDrain());
        }

        private void OnEnable()
        {
            GetComponent<Level>().levelUp += LevelUpHealth;
        }

        private void OnDisable()
        {
            GetComponent<Level>().levelUp -= LevelUpHealth;
        }

        private void ResetHealth()
        {
            CurrentHealth = m_fullHealth;
        }

        private void LevelUpHealth(int currentLevel)
        {
            ResetHealth();
        }

        private IEnumerator HealthDrain()
        {
            while (CurrentHealth > 0)
            {
                CurrentHealth -= m_drainPerSecond;
                yield return new WaitForSeconds(1);
            }
        }
    }
}