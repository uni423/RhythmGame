using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Define;

public class Node : MonoBehaviour
{
    public Vector2 Point;
    public nodeType Type;

    public Sprite normalSprite;
    public Sprite wallSprite;
    public Sprite trueSprite;

    public SpriteRenderer mySprite;

    public void SetPoint(Vector2 point, nodeType type)
    {
        Point = point;
        this.transform.localPosition = new Vector3(Point.x * 100, Point.y * -100, 0);

        if (type == nodeType.Normal)
        {
            Type = nodeType.Normal;
            mySprite.sprite = normalSprite;
        }
        else if (type == nodeType.Wall)
        {
            Type = nodeType.Wall;
            mySprite.sprite = wallSprite;
        }
    }

    public void Update()
    {
        if (Type == nodeType.Normal)
            mySprite.sprite = normalSprite;
        else if (Type == nodeType.True)
            mySprite.sprite = trueSprite;
    }
}
