// FireballButton.cs
// 04-24-2022
// James LaFritz

using DesignPatterns.StrategyPattern;

namespace DesignPatterns.DecoratorPattern.UI
{
    public class HealButton : AbilityButton<HealAbility>
    {
        #region Overrides of AbilityButton<HealAbility>

        /// <inheritdoc />
        public override void Use()
        {
            m_ability.Use();
        }

        #endregion
    }
}