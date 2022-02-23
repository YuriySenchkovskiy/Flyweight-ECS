using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMoveComponent : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    public float MoveSpeed => moveSpeed;
}
