using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform bullet;
    public int bulletForce = 5000;
    public int magazine = 30;
    public AudioClip fireSound;
    public AudioClip reloadSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && magazine > 0)
        {
            Transform bulletInstance = Instantiate(bullet, transform.position, transform.rotation);
            bulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce);
            magazine--;
            audioSource.PlayOneShot(fireSound);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            magazine = 30; // assuming you want to reload to full magazine
            audioSource.PlayOneShot(reloadSound);
        }
    }
}

