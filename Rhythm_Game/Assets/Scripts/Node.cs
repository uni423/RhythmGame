using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Vector2 Point;

    public void GetPoint(Vector2 point)
    {
        Point = point;
        this.transform.localPosition = new Vector3(Point.x * 100, Point.y * -100, 0);
    }
}
