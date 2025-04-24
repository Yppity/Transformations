using UnityEngine;

public class Increase : MonoBehaviour
{
    [SerializeField] private float _rateIncrease;

    void Update()
    {
        transform.localScale += new Vector3(_rateIncrease, _rateIncrease, _rateIncrease) * Time.deltaTime;
    }
}
