using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour 
{
    public GameObject PointA, PointB;
    public Vector2 Direction, Normalized;
    public float PointAX, PointAY, PointBX, PointBY;
    public float Length;
    [SerializeField] private float value, SquareRoot;

    // Update is called once per frame
    void Update()
    {
        Direction = PointB.transform.position - PointA.transform.position;

        PointAX = PointA.transform.position.x;
        PointAY = PointB.transform.position.y;
        PointBX = PointB.transform.position.x;
        PointBY = PointB.transform.position.y;

        Length = Mathf.Sqrt((Direction.x * Direction.x) + (Direction.y * Direction.y));
        Normalized = Direction/Length;
        SquareRoot = Mathf.Sqrt(value);
    }
}
