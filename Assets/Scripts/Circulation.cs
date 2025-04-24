using UnityEngine;

public class Circulation : MonoBehaviour
{
    [SerializeField] private Vector3 _circulationDirection;
    [SerializeField] private float _interval;

    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _interval)
        {
            _circulationDirection = _circulationDirection * -1f;
            _timer = 0f;
        }

        transform.Translate(_circulationDirection * Time.deltaTime);
    }
}
