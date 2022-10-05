using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlayer : MonoBehaviour
{
    [SerializeField] private RectTransform fade;
    [SerializeField] private GameObject player;
    [SerializeField] private float health = 0f;
    private readonly float invokeDelay = 0.5f;

    private void TakeDamage(float amount)
    {
        if ((health -= amount) <= 0f)
        {
            player.SetActive(false);
            Invoke(nameof(Revival), invokeDelay);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacles"))
        {
            player.SetActive(false);
            Invoke(nameof(Revival), invokeDelay);
        }
    }

    private void Revival()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
