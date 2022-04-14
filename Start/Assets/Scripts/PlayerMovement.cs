using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    RollingMovement m_rollingMovement;
    // Start is called before the first frame update
    void Start()
    {
        // Gather components
        m_rollingMovement = GetComponent<RollingMovement>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // Get the movement vector and apply it to the Rolling Movement component
        Vector2 movement = context.ReadValue<Vector2>();
        // y means vertical movement in x, y, z here
        m_rollingMovement.m_movementDirection = new Vector3(movement.x, 0f, movement.y);
    }
}
