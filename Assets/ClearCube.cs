using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCube : MonoBehaviour
{
    private Renderer cubeRenderer;
    public GameObject cube;
    private Transform cubeTransform;
    private Vector3 translationDirection = Vector3.back;
    private bool buttonAPressed = false;
    private bool buttonBPressed = false;
    private float rotationSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        cubeTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ClearAction()
    {
        transform.rotation = Quaternion.Euler(Vector3.zero);
        transform.position = new Vector3(-11.58f, 1.96f, 39.67f);

    }
}
