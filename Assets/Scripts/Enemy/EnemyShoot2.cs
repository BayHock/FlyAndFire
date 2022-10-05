using UnityEngine;
public class EnemyShoot2 : MonoBehaviour
{
    [SerializeField] private GameObject EnemyBullet;
    [SerializeField] private float fireRate = 15f;
    private float nextTimeToFire = 0f;

    public void FireByPlayer2()
    {
        if (Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + (1f / fireRate);
            Instantiate(EnemyBullet, transform.position, transform.rotation);
        }
    }
}
