using UnityEngine;
using System.Collections;

public class EnemyBulletMoveForward : MonoBehaviour
{

    private float acceleration = 50f;

    private float initialVelocity = 5f;

    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.velocity = Vector2.down * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        ourRigidbody.AddForce(ForceToAdd);
    }
}
