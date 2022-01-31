using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swerve : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 FirstPos;
    private Vector3 LastPos;
    public float swerveSensitivity;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Swerving();
    }

    void Swerving()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FirstPos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            transform.position = new Vector3(LastPos.x + (FirstPos - Input.mousePosition).x / -swerveSensitivity, transform.position.y, transform.position.z); // Swerwe
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.5f, 4.5f), transform.position.y, transform.position.z);  // Limited Position
        }
    }
}
