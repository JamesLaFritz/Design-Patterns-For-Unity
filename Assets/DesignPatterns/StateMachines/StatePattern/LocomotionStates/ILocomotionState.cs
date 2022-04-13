// ILocomotionState.cs
// 04-13-2022
// James LaFritz

namespace DesignPatterns.StateMachines.StatePattern.LocomotionStates
{
    public interface ILocomotionState
    {
        public void EnterState(ILocomotionContext context);
        public void ExitState(ILocomotionContext context);
        public void UpdateState(ILocomotionContext context);
    }
}