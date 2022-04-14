// CrouchingState.cs
// 04-13-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StateMachines.StatePattern.LocomotionStates
{
    public class CrouchingState : ILocomotionState
    {
        #region Implementation of ILocomotionState

        public void EnterState(ILocomotionContext context) { }

        public void ExitState(ILocomotionContext context) { }

        public void UpdateState(ILocomotionContext context)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                context.SetState(new GroundedState());
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                context.SetState(new GroundedState());
            }
        }

        #endregion
    }
}