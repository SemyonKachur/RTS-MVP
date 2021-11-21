using System;
using System.Linq;
using Abstractions;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
    public class SelectableValue : ScriptableObject
    {
        public ISelectable CurrentValue { get; private set; }
        public Action<ISelectable> OnSelected;

        public void SetValue(ISelectable value)
        {
            CurrentValue = value;
            OnSelected?.Invoke(value);
            if (value == null)
            {
                ISelectable[] select = FindObjectsOfType<MonoBehaviour>().OfType<ISelectable>().ToArray();
                for (int i = 0; i < select.Length; i++)
                {
                    select[i].Outline.enabled = false;
                }
            }
        }
    }
}