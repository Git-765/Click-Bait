using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int health;
    protected Vector3 direction;
    protected TMP_Text healthLable;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        direction = Vector3.zero - transform.position;
        healthLable = GetComponentInChildren<TMP_Text>();
        healthLable.text = "" + health;
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

    public virtual void ChangeHealth(int amount)
    {
        health += amount;
        healthLable.text = "" + health;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
