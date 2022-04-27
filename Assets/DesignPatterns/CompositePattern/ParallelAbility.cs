// ParallelAbility.cs
// 04-27-2022
// James LaFritz

using DesignPatterns.StrategyPattern;

namespace DesignPatterns.CompositePattern
{
    public class ParallelAbility : IAbility
    {
        private IAbility[] m_abilities;

        public ParallelAbility(IAbility[] children)
        {
            m_abilities = children;
        }

        #region Implementation of IAbility

        /// <inheritdoc />
        public void Use() { }

        #endregion
    }
}