// DelayedDecorator.cs
// 04-24-2022
// James LaFritz

using DesignPatterns.StrategyPattern;

namespace DesignPatterns.DecoratorPattern
{
    public class DelayedDecorator : IAbility
    {
        private readonly IAbility m_ability;

        public IAbility Ability => m_ability;

        public DelayedDecorator(IAbility ability)
        {
            m_ability = ability;
        }

        #region Implementation of IAbility

        /// <inheritdoc />
        public void Use()
        {
            // Do Delaying magic

            m_ability.Use();
        }

        #endregion
    }
}