using UnityEngine;

public class EnemyPointerLaser : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private EnemyShoot enemyShoot;
    private EnemyShoot2 enemyShoot2;
    private void Start()
    {
        enemyShoot = FindObjectOfType<EnemyShoot>();
        enemyShoot2 = FindObjectOfType<EnemyShoot2>();
    }

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 150, Color.red);
        if (Physics.Raycast(ray, out RaycastHit hit, 150) && hit.transform.position == target.transform.position)
        {
            enemyShoot.FireByPlayer();
            enemyShoot2.FireByPlayer2();
        }
    }
}
