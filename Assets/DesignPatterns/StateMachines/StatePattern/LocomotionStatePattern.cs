// LocomotionStatePattern.cs
// 04-13-2022
// James LaFritz

using DesignPatterns.StateMachines.StatePattern.LocomotionStates;
using UnityEngine;

namespace DesignPatterns.StateMachines.StatePattern
{
    public interface ILocomotionContext
    {
        public void SetState(ILocomotionState newState);
    }

    public class LocomotionStatePattern : MonoBehaviour, ILocomotionContext
    {
        [SerializeField] private ILocomotionState m_currentState;

        #region Implementation of ILocomotionContext

        /// <inheritdoc />
        public void SetState(ILocomotionState newState)
        {
            m_currentState.ExitState(this);
            newState.EnterState(this);
            m_currentState = newState;
        }

        #endregion

        private void Update()
        {
            m_currentState.UpdateState(this);
        }
    }
}