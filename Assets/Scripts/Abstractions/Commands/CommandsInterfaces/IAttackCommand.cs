using UnityEngine;

namespace Abstractions.Commands.CommandsInterfaces
{
    public interface IAttackCommand : ICommand
    {
        Vector3 Position { get; }
        GameObject UnitPrefab { get; }
    }
}