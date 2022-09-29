using UnityEngine;

public class DeathPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform startPos;
    private float invokeDelay = 2f;

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
        player.transform.position = startPos.transform.position;
        player.SetActive(true);
    }
}
