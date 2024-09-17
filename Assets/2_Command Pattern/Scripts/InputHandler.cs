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
                ICommand moveForward = new MoveCommand(transform, Vector3.back);
                moveForward.Execute();
                commandHistory.Push(moveForward);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                ICommand moveForward = new MoveCommand(transform, Vector3.left);
                moveForward.Execute();
                commandHistory.Push(moveForward);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                ICommand moveForward = new MoveCommand(transform, Vector3.right);
                moveForward.Execute();
                commandHistory.Push(moveForward);
            }

            if (Input.GetKeyDown(KeyCode.Z) && commandHistory.Count > 0)
            {
                ICommand lastCommand = commandHistory.Pop();
                lastCommand.Undo();
            }
        }
    

   
}