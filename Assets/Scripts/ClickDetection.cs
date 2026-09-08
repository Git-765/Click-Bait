using UnityEngine;
using UnityEngine.InputSystem;

public class ClickDetection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 mousePostion = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            print("The Mouse is at: " +  mousePostion);
            RaycastHit2D hit = Physics2D.Raycast(mousePostion, Vector3.forward);

            if (hit.collider != null)
            {
                if (hit.collider.TryGetComponent<Enemy>(out Enemy enemyComponent))
                {
                    enemyComponent.ChangeHealth(-1);
                }
            }
        }
    }
}
