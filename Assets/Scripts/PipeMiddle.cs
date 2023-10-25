using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public LogicManager logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
            logic.addScore(1);
    }
}
