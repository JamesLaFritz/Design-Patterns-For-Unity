// FireballButton.cs
// 04-24-2022
// James LaFritz

using DesignPatterns.StrategyPattern;

namespace DesignPatterns.DecoratorPattern.UI
{
    public class FireballButton : AbilityButton<FireBallAbility>
    {
        #region Overrides of AbilityButton<FireBallAbility>

        /// <inheritdoc />
        public override void Use()
        {
            m_ability.Use();
        }

        #endregion
    }
}