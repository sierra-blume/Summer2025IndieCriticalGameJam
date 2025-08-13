using UnityEngine;
using UnityEngine.InputSystem;

public class CameraTargetMove : MonoBehaviour
{
    [SerializeField] int sensitivity = 100;
    //Rigidbody2D rb;

    public Vector2 xClamp;
    public Vector2 yClamp;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraMov = transform.position + new Vector3(Input.GetAxis("Mouse X")*Time.deltaTime*sensitivity, Input.GetAxis("Mouse Y")*Time.deltaTime*sensitivity);
        cameraMov.x = Mathf.Clamp(cameraMov.x, xClamp.x, xClamp.y);
        cameraMov.y = Mathf.Clamp(cameraMov.y, yClamp.x, yClamp.y);
        transform.position = cameraMov;
    }
}
