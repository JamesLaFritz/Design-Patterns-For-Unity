// ParallelAbility.cs
// 04-27-2022
// James LaFritz

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.StrategyPattern;

namespace DesignPatterns.CompositePattern
{
    public class ParallelAbility : IAbility
    {
        private IAbility[] m_abilities;

        private bool m_abilitiesRunning;

        public ParallelAbility(IAbility[] children)
        {
            m_abilities = children;
        }

        #region Implementation of IAbility

        /// <inheritdoc />
        public void Use()
        {
            #pragma warning disable CS4014
            ParallelUse();
            #pragma warning restore CS4014
        }

        #endregion

        private async Task ParallelUse()
        {
            if (m_abilitiesRunning) return;

            if (m_abilities == null || m_abilities.Length < 1) return;

            m_abilitiesRunning = true;

            List<Task> abilityTasks = m_abilities.Select(ability => Task.Run(ability.Use)).ToList();

            while (abilityTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(abilityTasks);
                abilityTasks.Remove(finishedTask);
            }

            m_abilitiesRunning = false;
        }
    }
}