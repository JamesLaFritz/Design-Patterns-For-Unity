// Health.cs
// 03-01-2022
// James LaFritz

using System;
using System.Collections;
using UnityEngine;

namespace Observer
{
    [RequireComponent(typeof(Level))]
    public class Health : MonoBehaviour
    {
        [SerializeField] private float m_fullHealth = 100;
        [SerializeField] private int m_drainPerSecond = 2;
        public float CurrentHealth { get; private set; }

        /// <summary>
        /// Every Time the Health Changes let observers know what the Current Health is and what the Max Health is.
        /// </summary>
        public Action<float, float> onHealthChanged;

        private void Awake()
        {
            ResetHealth();
            StartCoroutine(HealthDrain());
        }

        private void OnEnable()
        {
            GetComponent<Level>().OnLevelUp += LevelUpHealth;
        }

        private void OnDisable()
        {
            GetComponent<Level>().OnLevelUp -= LevelUpHealth;
        }

        private void ResetHealth()
        {
            CurrentHealth = m_fullHealth;
        }

        private void LevelUpHealth(int currentLevel)
        {
            m_fullHealth += m_fullHealth / currentLevel * m_fullHealth;
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

        private void OnHealthChanged() => onHealthChanged?.Invoke(CurrentHealth, m_fullHealth);
    }
}