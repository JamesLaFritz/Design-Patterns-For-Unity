// RageAbility.cs
// 04-22-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StrategyPattern
{
    public class RageAbility : IAbility
    {
        #region Implementation of IAbility

        /// <inheritdoc />
        public void Use()
        {
            Debug.Log("Rage Mode");
        }

        #endregion
    }
}