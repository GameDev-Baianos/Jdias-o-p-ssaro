using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    public float pipeSpeed = 5;
    public int deadZone = -35;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
