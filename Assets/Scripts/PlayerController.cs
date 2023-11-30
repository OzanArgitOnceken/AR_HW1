using UnityEngine;
using EasyJoystick;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Joystick joystick;
    private void Update()
    {
        float xMovement = joystick.Horizontal();
        float yMovement = joystick.Vertical();
        transform.position += new Vector3(xMovement, yMovement, 0f) * speed * Time.deltaTime;
    }
}