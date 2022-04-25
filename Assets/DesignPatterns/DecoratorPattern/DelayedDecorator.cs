// DelayedDecorator.cs
// 04-24-2022
// James LaFritz

using System.Threading.Tasks;
using DesignPatterns.StrategyPattern;
using UnityEngine;

namespace DesignPatterns.DecoratorPattern
{
    public class DelayedDecorator : IAbility
    {
        private readonly IAbility m_ability;

        public IAbility Ability => m_ability;

        private int m_delayTime;

        private bool m_inUse;

        public DelayedDecorator(IAbility ability, int delayTime = 1000)
        {
            m_ability = ability;
            m_delayTime = delayTime;
        }

        #region Implementation of IAbility

        /// <inheritdoc />
        public void Use()
        {
            if (!m_inUse)
                DelayUse();
        }

        #endregion

        private async Task DelayUse()
        {
            m_inUse = true;
            Debug.Log("Delaying Ability");

            await Task.Delay(m_delayTime);

            m_ability.Use();

            m_inUse = false;
        }
    }
}