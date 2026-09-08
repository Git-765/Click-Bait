using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Boss : Enemy
{
    public string message = "I'm evil";

    public override void Move()
    {
        direction = transform.position - Vector3.zero;
        Vector3 rotatedDirection = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward) * direction;
        transform.position = rotatedDirection;
    }
}
