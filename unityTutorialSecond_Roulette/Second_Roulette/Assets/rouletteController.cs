using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rouletteController : MonoBehaviour
{
    public bool IsRotating;
    public float RotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // initialize fields
        this.RotateSpeed = 0;
        this.IsRotating = false;
    }

    // Update is called once per frame
    void Update()
    {
        // on mouse clicked - left click button up
        if (Input.GetMouseButtonUp(0))
        {
            // if roulette is rotating
            if (this.IsRotating)
            {
                this.RotateSpeed = 0;
                this.IsRotating = false;
                return; // no need to flow to the last logics
            } else // if roulette is not rotating(stopped position)
            {
                this.RotateSpeed = 20f;
                this.IsRotating = true;
            }
        }

        // Is Roulette ACTUALLY rotating?
        if (this.RotateSpeed >= 0) 
        {
            // keep rotating, but just let it gradually slow down
            this.RotateSpeed -= 0.15f;
            // rotate method here
            transform.Rotate(0, 0, this.RotateSpeed);
        } else
        {
            // NOT ACTUALLY rotating, so store the state as false
            this.IsRotating = false;
        }
    }
}
