using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    public interface IState
    {
        public void Enter();
        public void Update();
        public void FixedUpdate();
        public void Exit();
    }
    
    
  
}
