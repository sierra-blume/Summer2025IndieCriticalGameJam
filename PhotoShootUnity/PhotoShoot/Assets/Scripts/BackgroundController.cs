using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private float startPos;
    public GameObject cam;
    public float parallaxEffect; // The speed at which the background should move relative to the camera

    private void Start()
    {
        startPos = transform.position.x;
    }

    private void FixedUpdate()
    {
        // Calculate distance background move based on cam movement
        float dist = cam.transform.position.x * parallaxEffect; // 0 = move with cam || 1 = won't move || 0.5 = half

        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
    }
}