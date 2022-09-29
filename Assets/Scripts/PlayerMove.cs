using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float turnSpeedUpDown = 10f;
    [SerializeField] private float turnSpeedRightLeft = 10f;

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-Vector3.right, turnSpeedUpDown * Time.deltaTime);
            
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.right, turnSpeedUpDown * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up, turnSpeedRightLeft * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeedRightLeft * Time.deltaTime);
        }
    }
}
