using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    public bool isMoving;
    public float speed;
    public AudioSource audio;
    public Vector2 mouseDownPos;
    public Vector2 mouseUpPos;

    // Start is called before the first frame update
    void Start()
    {
        this.speed = 0f;
        this.audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.mouseDownPos = Input.mousePosition;
        } else if (Input.GetMouseButtonUp(0))
        {
            if (this.audio.isPlaying) return;

            this.mouseUpPos = Input.mousePosition;
            try
            {
                float gap = this.mouseUpPos.x - this.mouseDownPos.x;
                this.speed = gap / 500 * 0.7f;
            } catch (System.Exception e)
            {
                Debug.Log(e);
            } finally
            {
                if(!this.audio.isPlaying) 
                    this.audio.Play();
            }
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= .88f;
    }
}
