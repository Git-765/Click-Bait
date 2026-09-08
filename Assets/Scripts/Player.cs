using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int health;
    private TMP_Text healthLabel;
    public UnityEvent onGameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthLabel = GetComponentInChildren<TMP_Text>();
        healthLabel.text = "" + health;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            health -= collision.transform.GetComponent<Enemy>().health;
            if (health <= 0) onGameOver.Invoke();
            healthLabel.text = "" + health;
            Destroy(collision.gameObject);
        }
    }
}
