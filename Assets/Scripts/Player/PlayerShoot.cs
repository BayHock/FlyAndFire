using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float fireRate = 15f;
    private float nextTimeToFire = 0f;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + (1f / fireRate);
            Instantiate(Bullet, transform.position, transform.rotation);

        }
    }
}