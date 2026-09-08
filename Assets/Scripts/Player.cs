using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    private TMP_Text healthLabel;

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
            healthLabel.text = "" + health;
            Destroy(collision.gameObject);
        }
    }
}
