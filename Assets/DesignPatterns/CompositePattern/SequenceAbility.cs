// SequenceAbility.cs
// 04-27-2022
// James LaFritz

using DesignPatterns.StrategyPattern;

namespace DesignPatterns.CompositePattern
{
    public class SequenceAbility : IAbility
    {
        private IAbility[] m_abilities;

        public SequenceAbility(IAbility[] children)
        {
            m_abilities = children;
        }

        #region Implementation of IAbility

        /// <inheritdoc />
        public void Use()
        {
            
        }

        #endregion
    }
}