using System.Linq;
using Abstractions;
using UnityEngine;
using UserControlSystem;


public class OutlinePresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectedValue;

    private void Start()
    {
        _selectedValue.OnSelected += ONSelected;
    }
        
    private void ONSelected(ISelectable selected)
    {
        if (selected == null)
        {
            ISelectable[] select = FindObjectsOfType<MonoBehaviour>().OfType<ISelectable>().ToArray();
            for (int i = 0; i < select.Length; i++)
            {
                select[i].Outline.enabled = false;
            }
        }
        else selected.Outline.enabled = true;
    }
}

