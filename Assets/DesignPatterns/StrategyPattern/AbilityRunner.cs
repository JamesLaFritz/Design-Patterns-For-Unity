// AbilityRunner.cs
// 04-22-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StrategyPattern
{
    public class AbilityRunner : MonoBehaviour
    {
        [SerializeField] private IAbility m_currentAbility;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_currentAbility?.Use();
            }
        }
    }
}