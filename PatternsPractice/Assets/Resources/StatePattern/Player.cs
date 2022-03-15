using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class Player : MonoBehaviour
    {
        private StateManager stateManager;  
        private StatePattern runnig,
                             jumping,
                             sliding;
        void Start()
        {
            runnig = new Running(transform);
            jumping = new Jumping(transform);
            sliding = new Sliding(transform);

            stateManager = new StateManager(runnig);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) stateManager.SetState(runnig);
            else if (Input.GetKeyDown(KeyCode.Space)) stateManager.SetState(jumping);
            else if (Input.GetKeyDown(KeyCode.LeftControl)) stateManager.SetState(sliding);
        }
    }
}
