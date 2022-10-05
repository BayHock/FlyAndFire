using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject EnemyBullet;
    [SerializeField] private float fireRate = 15f;
    private float nextTimeToFire = 0f;

    public void FireByPlayer()
    {
        if (Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + (1f / fireRate);
            Instantiate(EnemyBullet, transform.position, transform.rotation);
        }
    }
}
