using UnityEngine;
public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject EnemyBullet;
    [SerializeField] private float fireRate = 15f;
    [SerializeField] private GameObject target; 
    private float nextTimeToFire = 0f;
    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 150, Color.red);
        if (Physics.Raycast(ray,out RaycastHit hit, 150) && hit.transform.position == target.transform.position)
        {
            if (Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + (1f / fireRate);
                Instantiate(EnemyBullet, transform.position, transform.rotation);
            }
        }
    }
}
