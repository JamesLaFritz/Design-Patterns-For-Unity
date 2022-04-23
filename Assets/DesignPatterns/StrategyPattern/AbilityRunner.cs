// AbilityRunner.cs
// 04-22-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StrategyPattern
{
    public class AbilityRunner : MonoBehaviour
    {
        private IAbility m_currentAbility;

        public IAbility CurrentAbility
        {
            get => m_currentAbility;
            set => m_currentAbility = value;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_currentAbility?.Use();
            }
        }
    }
}