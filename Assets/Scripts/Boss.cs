using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;

public class Boss : Enemy
{
    public string message = "I'm evil";
    public UnityEvent onWin;

    protected override void Start()
    {
        base.Start();
        healthLable.text = message;
    }

    public override void Move()
    {
        direction = transform.position - Vector3.zero;
        Vector3 rotatedDirection = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward) * direction;
        transform.position = rotatedDirection;
    }

    public override void ChangeHealth(int amount)
    {
        health += amount;
        healthLable.text = "" + health;
        if (health <= 0) onWin.Invoke();
    }
}
