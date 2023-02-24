using UnityEngine;

[RequireComponent(typeof(FirstPersonMovement))]
public class Player : MonoBehaviour, IControllable
{
    private FirstPersonMovement _movement;

    [SerializeField] private float _speed;

    private void Awake()
    {
        _movement = GetComponent<FirstPersonMovement>();
    }

    public void Move(Vector2 input)
    {
        _movement.Move(input, _speed);
    }
    
    public void Look(Vector2 input)
    {
        throw new System.NotImplementedException();
    }
}
