// FireballButton.cs
// 04-24-2022
// James LaFritz

using DesignPatterns.StrategyPattern;

namespace DesignPatterns.DecoratorPattern.UI
{
    public class MeleeButton : AbilityButton<MeleeAbility>
    {
        #region Overrides of AbilityButton<MeleeAbility>

        /// <inheritdoc />
        public override void Use()
        {
            m_ability.Use();
        }

        #endregion
    }
}