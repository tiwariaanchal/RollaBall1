using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField]
    float bouncePower = 100;
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        PlayerController pr = collision.gameObject.GetComponent<PlayerController>();
        Vector3 bounce = Vector3.Reflect(pr.lastVelocity, collision.contacts[0].normal);

        rb.AddForce(bounce.normalized * bouncePower);
    }
}
