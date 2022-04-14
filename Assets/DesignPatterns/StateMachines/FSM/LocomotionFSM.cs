// LocomotionFSM.cs
// 04-05-2022
// James LaFritz

using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace DesignPatterns.StateMachines.FSM
{
    [SuppressMessage("ReSharper", "IteratorNeverReturns")]
    public class LocomotionFSM : MonoBehaviour
    {
        private enum State
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

        private void Update()
        {
            if (m_currentState == State.InAir)
            {
                // Simulate Physics of the character being in the air gravity is being applied
                if (Random.Range(0, 100) > 20)
                {
                    Land();
                }

                return;
            }

            // Simulate physics and the character falling of a ledge
            if (Random.Range(0, 100) > 90)
            {
                Fall();
                return;
            }

            if (Input.GetKeyDown(KeyCode.Space))
                Jump();
            else if (Input.GetKeyDown(KeyCode.C))
                Crouch();
        }
    }
}