using UnityEngine;

public class Upscaling : MonoBehaviour
{
    [SerializeField] private float _upscalingSpeed;

    private Vector3 _upscalingDirection = new Vector3(1, 1, 1);

    private void Update()
    {
        Upscale(_upscalingDirection, _upscalingSpeed);
    }

    private void Upscale(Vector3 upscalingDirection, float upscalingSpeed)
    {
        transform.localScale += upscalingDirection * upscalingSpeed * Time.deltaTime;
    }
}