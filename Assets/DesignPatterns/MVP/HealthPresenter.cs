// HealthPresenter.cs
// 05-01-2022
// James LaFritz

using Observer;
using UnityEngine;

namespace DesignPatterns.MVP
{
    public class HealthPresenter : MonoBehaviour
    {
        [SerializeField] private Health m_health;

        private void Awake()
        {
            if (m_health == null)
            {
                Debug.LogWarning(
                    "Health Presenter needs a Health to present please make sure one is set in The Inspector",
                    gameObject);
                enabled = false;
            }
        }
    }
}