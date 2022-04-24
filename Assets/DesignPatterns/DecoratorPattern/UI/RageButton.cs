// FireballButton.cs
// 04-24-2022
// James LaFritz

using DesignPatterns.StrategyPattern;

namespace DesignPatterns.DecoratorPattern.UI
{
    public class RageButton : AbilityButton<RageAbility>
    {
        #region Overrides of AbilityButton<RageAbility>

        /// <inheritdoc />
        public override void Use()
        {
            m_ability.Use();
        }

        #endregion
    }
}