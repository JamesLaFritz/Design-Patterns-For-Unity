// LocomotionFSM.cs
// 04-05-2022
// James LaFritz

using System;
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

        private void Jump()
        {
            switch (m_currentState)
            {
                case State.Grounded:
                    m_currentState = State.InAir;
                    break;
                case State.InAir:
                    break;
                case State.Crouching:
                    m_currentState = State.Grounded;
                    break;
            }
        }

        private void Fall()
        {
            switch (m_currentState)
            {
                case State.Grounded:
                    m_currentState = State.InAir;
                    break;
                case State.InAir:
                    break;
                case State.Crouching:
                    m_currentState = State.InAir;
                    break;
            }
        }
    }
}