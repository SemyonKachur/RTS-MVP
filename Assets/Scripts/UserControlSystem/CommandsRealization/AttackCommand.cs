using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Utils;

namespace UserControlSystem.CommandsRealization
{
    public class AttackCommand : IAttackCommand
    {
        public Vector3 Position => position;
        public GameObject UnitPrefab => _unitPrefab;
        
        [InjectAsset("Chomper")] private GameObject _unitPrefab;
        [InjectAsset("Chomper")] private Vector3 position;

    }
}