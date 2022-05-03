using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rouletteController : MonoBehaviour
{
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            this.rotateSpeed = 10f;


        this.rotateSpeed -= 0.3f;
        transform.Rotate(0, 0, this.rotateSpeed);
    }
}
