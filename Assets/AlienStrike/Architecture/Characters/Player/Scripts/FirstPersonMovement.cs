using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FirstPersonMovement : MonoBehaviour
{
    private const float GRAVITY = -9.81f;

    private CharacterController _controller;

    private void Awake() => _controller = GetComponent<CharacterController>();

    public void Move(Vector2 input, float speed)
    {
        _controller.Move(GetDirection(input).normalized * (speed * Time.deltaTime));
        _controller.Move(new Vector3(0, GRAVITY, 0) * Time.deltaTime);
    }

    private Vector3 GetDirection(Vector2 input)
    {
        return (transform.forward * input.y) + (transform.right * input.x);
    }
}
