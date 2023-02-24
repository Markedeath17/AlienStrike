using UnityEngine;

public interface IControllable
{
    void Move(Vector2 input);
    void Look(Vector2 input);
}
