using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSignal : MonoBehaviour
{
    [Range(10f, 70f)]
    public float angle;

    [Range(0.6f, 0.8f)]
    public float heigh;
    public void Generated(int index)
    {
        transform.position += transform.parent.transform.position + transform.up * transform.localScale.y;
        transform.rotation *= Quaternion.Euler(Random.Range(15, angle) * ((index * 2) - 1), 90, 0);
        //transform.rotation *= Quaternion.Euler(30 * ((index * 2) - 1), 0, 0);
        transform.localScale *= Random.Range(heigh - 0.15f, heigh + 0.15f);
    }
}
