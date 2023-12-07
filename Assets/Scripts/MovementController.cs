using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;
    private Camera _mainCamera;


    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        _navMeshAgent.SetDestination(_destination);
        
        if (!Input.GetMouseButtonDown(0)) return;
        var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hit))
        {
            _destination = hit.point;
        }
    }
}