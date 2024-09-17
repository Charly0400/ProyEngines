using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    void Execute();
    void Undo();
}

public class MoveCommand : ICommand
{
    private Transform player;
    private Vector3 direction;

    public MoveCommand(Transform player, Vector3 direction)
    {
        this.player = player;
        this.direction = direction;
    }

    public void Execute()
    {
        player.Translate(direction);
    }

    public void Undo()
    {
        player.Translate(-direction);
    }
}

