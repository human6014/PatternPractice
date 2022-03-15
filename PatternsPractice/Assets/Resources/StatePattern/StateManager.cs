using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class StateManager
    {
        StatePattern statePattern;
        public StateManager(StatePattern _statePattern)
        {
            statePattern = _statePattern;
        }
        public void SetState(StatePattern _statePattern)
        {
            if (statePattern == _statePattern) return; //�ߺ� �Է� �ȹ���
            statePattern = _statePattern;

            //statePattern.EnterAction();
            statePattern.Action();
            //statePattern.ExitAction();
        }
    }
}
