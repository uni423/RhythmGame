using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeManager : MonoBehaviour
{
    public GameObject Nodes;
    public GameObject node;

    void Start()
    {
        int wh = GameManager.Instance.WH;
        GameObject obj;

        for(int i = 0; i < wh; i++)
        {
            for (int j = 0; j < wh; j++)
            {
                obj = Instantiate(node, Nodes.transform);
                obj.GetComponent<Node>().GetPoint(new Vector2(j, i));
            }
        }

        Nodes.transform.position = new Vector3((wh * -100) / 2 + 50, (wh * 100) / 2 - 50);
    }
}
