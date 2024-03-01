using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float maxSpeed;

    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rig.linearVelocity.magnitude > maxSpeed)
        {
            rig.linearVelocity = rig.linearVelocity.normalized * maxSpeed;
        }
    }
}
