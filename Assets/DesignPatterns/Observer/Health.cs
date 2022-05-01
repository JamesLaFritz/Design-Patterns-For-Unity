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
        private float m_currentHealth;

        public float CurrentHealth
        {
            get => m_currentHealth;
            set
            {
                m_currentHealth = m_currentHealth <= m_fullHealth
                    ? Mathf.Clamp(value, 0, m_fullHealth)
                    : Mathf.Max(0, value);
                OnHealthChanged();
            }
        }

        public float MaxHealth
        {
            get => m_fullHealth;
            set
            {
                float max = Mathf.Max(1, value);
                m_currentHealth = Mathf.Max(Mathf.Clamp(m_currentHealth + max - m_fullHealth, 1, value),
                                            m_currentHealth);
                m_fullHealth = max;
                OnHealthChanged();
            }
        }

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

        private void OnHealthChanged() => onHealthChanged?.Invoke(m_currentHealth, m_fullHealth);
    }
}