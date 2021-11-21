using Abstractions;
using UnityEngine;

public class FlowerBuilding : MonoBehaviour, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    public Outline Outline => _outline;

    [SerializeField] private float _maxHealth = 500;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Outline _outline;

    private float _health = 500;
}
