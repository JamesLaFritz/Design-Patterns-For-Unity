// CoolDownDecorator.cs
// 04-24-2022
// James LaFritz

using System.Threading.Tasks;
using DesignPatterns.StrategyPattern;
using UnityEngine;

namespace DesignPatterns.DecoratorPattern
{
    public class CoolDownDecorator : IAbility
    {
        private readonly IAbility m_ability;

        public IAbility Ability => m_ability;

        private int m_coolDownTime;

        private bool m_inUse;

        public CoolDownDecorator(IAbility ability, int delayTime = 1000)
        {
            m_ability = ability;
            m_coolDownTime = delayTime;
        }

        #region Implementation of IAbility

        /// <inheritdoc />
        public void Use()
        {
            if (m_inUse) return;
            m_ability.Use();
            #pragma warning disable CS4014
            CoolDown();
            #pragma warning restore CS4014
        }

        #endregion

        private async Task CoolDown()
        {
            m_inUse = true;
            Debug.Log("Cooling Down Ability");

            await Task.Delay(m_coolDownTime);

            Debug.Log($"{m_ability.GetType().Name} can now be used.");

            m_inUse = false;
        }
    }
}