using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float health = 50f;

    private void Update()
    {
        Vector3 direction = player.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);
        direction.Normalize();        
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }

    public void TakeDamage( float amount)
    {
        if ((health -= amount) <= 0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
            Debug.Log("Противник разбился");
        }
    }
}
