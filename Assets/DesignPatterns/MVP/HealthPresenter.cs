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
    }
}