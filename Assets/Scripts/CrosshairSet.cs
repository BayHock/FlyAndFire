using UnityEngine;

public class CrosshairSet : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float velocity = 0f;
    private float xPos = 100f, yPos = 50f;    
    private RectTransform rect;
    Vector2 posCrosshair;

    private void Start()
    {
        rect = this.GetComponent<RectTransform>();
    }

    private void Update()
    {
        posCrosshair = player.transform.position;
        posCrosshair.Normalize();
        MoveCrosshair();
    }

    private void MoveCrosshair()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rect.anchoredPosition = Vector2.MoveTowards(rect.anchoredPosition, new Vector2(xPos, 0), velocity*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rect.anchoredPosition = Vector2.MoveTowards(rect.anchoredPosition, new Vector2(-xPos, 0), velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rect.anchoredPosition = Vector2.MoveTowards(rect.anchoredPosition, new Vector2(0, yPos), velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rect.anchoredPosition = Vector2.MoveTowards(rect.anchoredPosition, new Vector2(0, -yPos), velocity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            rect.anchoredPosition = Vector2.MoveTowards(rect.anchoredPosition, new Vector2(xPos, yPos), velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            rect.anchoredPosition = Vector2.MoveTowards(rect.anchoredPosition, new Vector2(-xPos, yPos), velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            rect.anchoredPosition = Vector2.MoveTowards(rect.anchoredPosition, new Vector2(-xPos, -yPos), velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            rect.anchoredPosition = Vector2.MoveTowards(rect.anchoredPosition, new Vector2(xPos, -yPos), velocity * Time.deltaTime);
        }

        if (!Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A))
        {
            rect.anchoredPosition = Vector2.MoveTowards(rect.anchoredPosition, new Vector2(0, 0), velocity * Time.deltaTime);
        }
    }

}
