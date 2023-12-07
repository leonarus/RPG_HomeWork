using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour
{
    [SerializeField] private GameObject _torch;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SetFireActive();
        }
    }
    
    private void SetFireActive()
    {
        _torch.SetActive(true);
    }
}
