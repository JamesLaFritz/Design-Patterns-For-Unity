// LocomotionStatePattern.cs
// 04-13-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StateMachines.StatePattern
{
    public interface ILocomotionContext
    {
        
    }

    public interface ILocomotionState
    {
        
    }

    public class LocomotionStatePattern : MonoBehaviour, ILocomotionContext
    {
        
    }

    public class GroundedState : ILocomotionState
    {
        
    }

    public class InAirtate : ILocomotionState { }

    public class CrouchingState : ILocomotionState { }
}