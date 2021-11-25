using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Utils;

namespace UserControlSystem.CommandsRealization
{
    public class StopCommand : IStopCommand
    {
        public Vector3 StopPosition => _stopPosition;
       
       [InjectAsset("Chomper")] private Vector3 _stopPosition;

    }
}