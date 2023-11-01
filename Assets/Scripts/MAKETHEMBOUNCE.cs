using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAKETHEMBOUNCE : MonoBehaviour
{
    public float flingForce = 100;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        Invoke("Fling", 1);
    }

    void Fling()
    {
        float randomTime = Random.Range(1, 3);
        rb.AddForce(Vector3.up * flingForce, ForceMode.Impulse);
        Invoke("Fling", randomTime);
    }
}
