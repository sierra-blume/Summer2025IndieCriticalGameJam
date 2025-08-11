using UnityEngine;
using UnityEngine.InputSystem;

public class CameraTargetMove : MonoBehaviour
{
    [SerializeField] int sensitivity = 100;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraMov = transform.position + new Vector3(Input.GetAxis("Mouse X")*Time.deltaTime*sensitivity, Input.GetAxis("Mouse Y")*Time.deltaTime*sensitivity);
        transform.position = cameraMov;
    }
}
