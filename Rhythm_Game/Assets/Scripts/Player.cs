using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 Point;

    public void Start()
    {
        Point = new Vector2((GameManager.Instance.WH - 1) / 2, (GameManager.Instance.WH - 1) / 2);
    }

    public void Update()
    {
        if (!GameManager.Instance.IsGamePlay)
            return;

        //이동
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (Point.y > 0)
            {
                Point += new Vector2(0, -1);
                this.transform.position += new Vector3(0, 100);
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (Point.x > 0)
            {
                Point += new Vector2(-1, 0);
                this.transform.position += new Vector3(-100, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (Point.y < GameManager.Instance.WH - 1)
            {
                Point += new Vector2(0, 1);
                this.transform.position += new Vector3(0, -100);
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (Point.x < GameManager.Instance.WH - 1)
            {
                Point += new Vector2(1, 0);
                this.transform.position += new Vector3(100, 0);
            }
        }

    }
}
