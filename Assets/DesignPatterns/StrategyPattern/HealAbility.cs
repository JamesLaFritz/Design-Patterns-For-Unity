// HealAbility.cs
// 04-22-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StrategyPattern
{
    public class HealAbility : IAbility
    {
        #region Implementation of IAbility

        /// <inheritdoc />
        public void Use()
        {
            Debug.Log("This should cure your wounds");
        }

        #endregion
    }
}