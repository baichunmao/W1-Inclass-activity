using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    [SerializeField] private Transform _playerTransform;
    private bool _isChasing;
    private void Update()
    {
        if (_isChasing && _playerTransform != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, _speed * Time.deltaTime);
        }
    }
    public void StartChasing(Transform target)
    {
        _isChasing = true;
        _playerTransform = target;

    }
    public void StopChasing()
    {
        _isChasing = false;
    }
}
