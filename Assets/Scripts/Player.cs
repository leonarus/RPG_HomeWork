using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Bridge _bridge;
    
    private Outline _outline;
    private bool _hasPotion = false;

    private void Start()
    {
        _outline = GetComponent<Outline>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Potion"))
        {
            PickUpPotion();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Bridge") && !_hasPotion)
        {
            _bridge.Break(); // Разрушаем мост только если игрок не подобрал зелье.
        }
        
    }

    private void PickUpPotion()
    {
        _outline.OutlineWidth = 2f;
        _hasPotion = true;
    }
}
