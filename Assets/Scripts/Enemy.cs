using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int health;
    protected Vector3 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = Vector3.zero - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        transform.position += direction.normalized * speed * Time.deltaTime;

    }

    public void ChangeHealth(int amount)
    {
        health += amount;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
