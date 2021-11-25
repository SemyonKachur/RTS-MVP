using UnityEngine;

namespace Abstractions.Commands.CommandsInterfaces
{
    public interface IStopCommand : ICommand
    {
        Vector3 StopPosition { get; }
    }
}