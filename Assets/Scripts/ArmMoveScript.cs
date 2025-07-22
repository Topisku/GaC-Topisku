using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class ArmMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < -10)
        {
            Debug.Log("Arm Deleted");
            Destroy(gameObject);
        }
    }
}
