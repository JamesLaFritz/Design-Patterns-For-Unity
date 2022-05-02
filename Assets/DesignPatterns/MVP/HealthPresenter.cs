// HealthPresenter.cs
// 05-01-2022
// James LaFritz

using Observer;
using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.MVP
{
    public class HealthPresenter : MonoBehaviour
    {
        [SerializeField] private Health m_health;

        [SerializeField] private Slider m_healthSlider;

        private void Awake()
        {
            if (m_health == null)
            {
                Debug.LogWarning(
                    "Health Presenter needs a Health to present please make sure one is set in The Inspector",
                    gameObject);
                enabled = false;
            }

            if (m_healthSlider == null)
            {
                Debug.LogWarning(
                    "Health Presenter needs a Slider to Update please make sure one is set in The Inspector",
                    gameObject);
                enabled = false;
            }
        }

        private void OnEnable()
        {
            m_health.onHealthChanged += OnHealthChanged;
        }

        private void OnDisable()
        {
            m_health.onHealthChanged -= OnHealthChanged;
        }

        private void OnHealthChanged(float currentHealth, float maxHealth) { }
    }
}