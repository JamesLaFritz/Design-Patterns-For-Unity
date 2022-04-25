// AbilityRunner.cs
// 04-24-2022
// James LaFritz

using DesignPatterns.StrategyPattern;
using UnityEngine;

namespace DesignPatterns.DecoratorPattern
{
    public class AbilityCanvasRunner : MonoBehaviour, IAbility
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
                Use();
            }
        }

        public void Use()
        {
            m_currentAbility?.Use();
        }
    }
}