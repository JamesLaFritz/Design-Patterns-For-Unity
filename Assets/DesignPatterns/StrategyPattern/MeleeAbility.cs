// MeleeAbility.cs
// 04-22-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StrategyPattern
{
    public class MeleeAbility : IAbility
    {
        #region Implementation of IAbility

        /// <inheritdoc />
        public void Use()
        {
            Debug.Log("Laying down the smack down!");
        }

        #endregion
    }
}