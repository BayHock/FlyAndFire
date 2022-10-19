using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private GameObject obs;
    [SerializeField] private float speedRotate = 0.0f;


    void Update()
    {
        obs.transform.Rotate(new Vector3(180, 0, 0), speedRotate * Time.deltaTime);
    }
}
