using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}