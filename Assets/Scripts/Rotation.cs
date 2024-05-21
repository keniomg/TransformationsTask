using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private Vector3 _rotationAxis = Vector3.up;

    private void Update()
    {
        Rotate(_rotationSpeed, _rotationAxis);
    }

    private void Rotate(float rotationSpeed, Vector3 rotationAxis)
    {
        transform.Rotate(rotationAxis * Time.deltaTime * rotationSpeed);
    }
}