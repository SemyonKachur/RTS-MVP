using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Utils;

namespace UserControlSystem.CommandsRealization
{
    public class MoveCommand : IMoveCommand
    {
        public Vector3 Position => position;

        [InjectAsset("Chomper")] private Vector3 position;

    }
}