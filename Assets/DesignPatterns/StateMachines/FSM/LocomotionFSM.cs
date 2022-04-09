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

        public void Jump()
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

        public void Fall()
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

        public void Land()
        {
            switch (m_currentState)
            {
                case State.Grounded:
                    break;
                case State.InAir:
                    m_currentState = State.Grounded;
                    break;
                case State.Crouching:
                    break;
            }
        }

        public void Crouch()
        {
            switch (m_currentState)
            {
                case State.Grounded:
                    m_currentState = State.Crouching;
                    break;
                case State.InAir:
                    break;
                case State.Crouching:
                    m_currentState = State.Grounded;
                    break;
            }
        }
    }
}