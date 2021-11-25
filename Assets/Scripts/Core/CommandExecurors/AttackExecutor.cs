﻿using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Core.CommandExecutors
{
    public class AttackExecutor : CommandExecutorBase<IAttackCommand>
    {
        public override void ExecuteSpecificCommand(IAttackCommand command)
        {
            Debug.Log($"Attack unit {command.UnitPrefab.name} in position {command.Position}");
        }
    }
}