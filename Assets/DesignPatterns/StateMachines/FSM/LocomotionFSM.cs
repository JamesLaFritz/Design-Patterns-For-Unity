// LocomotionFSM.cs
// 04-05-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StateMachines.FSM
{
    public class LocomotionFSM : MonoBehaviour
    {
        enum State
        {
            Grounded,
            InAir,
            Crouching
        }

        private State m_currentState = State.Grounded;
    }
}