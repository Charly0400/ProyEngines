using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
        private Stack<ICommand> commandHistory = new Stack<ICommand>();

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                ICommand moveForward = new MoveCommand(transform, Vector3.forward);
                moveForward.Execute();
                commandHistory.Push(moveForward);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                ICommand moveBackward = new MoveCommand(transform, Vector3.back);
                moveBackward.Execute();
                commandHistory.Push(moveBackward);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                ICommand toTheLeft = new MoveCommand(transform, Vector3.left);
            toTheLeft.Execute();
                commandHistory.Push(toTheLeft);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                ICommand toTheRight= new MoveCommand(transform, Vector3.right);
                toTheRight.Execute();
                commandHistory.Push(toTheRight);
            }

            if (Input.GetKeyDown(KeyCode.Z) && commandHistory.Count > 0)
            {
                ICommand lastCommand = commandHistory.Pop();
                lastCommand.Undo();
            }
        }
    

   
}