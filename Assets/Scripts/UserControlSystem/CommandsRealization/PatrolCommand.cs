using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Utils;

namespace UserControlSystem.CommandsRealization
{
    public class PatrolCommand : IPatrolCommand
    {
        public Vector3 EndPosition => _endPosition;
        public Vector3 StartPosition => _startPosition;
        
        [InjectAsset("Chomper")] private Vector3 _endPosition;
        [InjectAsset("Chomper")] private Vector3 _startPosition;
    }
}