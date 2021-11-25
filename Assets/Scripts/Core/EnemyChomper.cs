using Abstractions;
using UnityEngine;

public sealed class EnemyChomper : MonoBehaviour, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    public Outline Outline => _outline;

    [field: SerializeField] private float _maxHealth = 100;
    [field: SerializeField] private Sprite _icon;
    [field: SerializeField] private Outline _outline;
    private float _health = 100;
}
