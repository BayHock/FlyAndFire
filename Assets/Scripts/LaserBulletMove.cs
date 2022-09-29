using UnityEngine;
public class LaserBulletMove : MonoBehaviour
{
    public Rigidbody rb;    

    [SerializeField] private float timeToDestruct = 1f;
    [SerializeField] private float damage = 1f;
    [SerializeField] private float startSpeed = 1f;

    Vector3 PreviousStep;

    private void Awake()
    {
        Destroy(gameObject, timeToDestruct);
        rb.velocity = transform.TransformDirection(Vector3.forward * startSpeed);
        PreviousStep = gameObject.transform.position;
    }

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }


   private void FixedUpdate()
    {
        Quaternion CurrentStep = gameObject.transform.rotation;

        transform.LookAt(PreviousStep, transform.up);

        RaycastHit hit = new RaycastHit();
        float Distance = Vector3.Distance(PreviousStep, transform.position);
        if (Distance == 0f)
        {
            Distance = 1e-05f;
        }
        
        if (Physics.Raycast(PreviousStep,transform.TransformDirection(Vector3.back), out hit, Distance * 0.9999f) && (hit.transform.gameObject != gameObject))
        {
            SendMessage(hit.transform.gameObject);
            Debug.Log("Получен урон");
        }

        gameObject.transform.rotation = CurrentStep;

        PreviousStep = gameObject.transform.position;
    }

    private void SendMessage(GameObject Hit)
    {
        Hit.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
    }
}
