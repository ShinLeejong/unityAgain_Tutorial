using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class director : MonoBehaviour
{
    protected GameObject Car;
    protected GameObject Flag;
    protected GameObject Distance;

    public float gap;

    // Start is called before the first frame update
    void Start()
    {
        this.Car = GameObject.Find("car");
        this.Flag = GameObject.Find("flag");
        this.Distance = GameObject.Find("Distance");
        this.gap = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float x_pos__car = this.Car.transform.position.x;
        float x_pos__flag = this.Flag.transform.position.x;
        this.gap = x_pos__flag - x_pos__car;
        this.Distance.GetComponent<Text>().text = $"목적지 까지의 거리: {this.gap.ToString("F2")}m";
    }
}
