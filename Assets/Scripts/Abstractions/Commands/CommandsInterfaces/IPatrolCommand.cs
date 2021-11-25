using UnityEngine;

namespace Abstractions.Commands.CommandsInterfaces
{
    public interface IPatrolCommand : ICommand
    {
        Vector3 EndPosition { get; }
        Vector3 StartPosition { get; }
    }
}