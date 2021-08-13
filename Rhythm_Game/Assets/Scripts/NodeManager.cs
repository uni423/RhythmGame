using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Define;

public class NodeManager : MonoBehaviour
{
    public GameObject Nodes;
    public GameObject node;

    int bpm = 0;
    double curTime = 0d;

    public Image White;

    public void Init()
    {
        bpm = GameManager.Instance.Bpm;

        int wh = GameManager.Instance.WH;
        GameObject obj;

        for(int i = 0; i < wh + 2; i++)
        {
            for (int j = 0; j < wh + 2; j++)
            {
                obj = Instantiate(node, Nodes.transform);
                if (i == 0 || j == 0 || i == wh + 1 || j == wh + 1)
                    obj.GetComponent<Node>().SetPoint(new Vector2(j, i), nodeType.Wall);
                else
                    obj.GetComponent<Node>().SetPoint(new Vector2(j, i), nodeType.Normal);
            }
        }

        Nodes.transform.position = new Vector3(((wh + 2) * -100) / 2 + 50, ((wh + 2) * 100) / 2 - 50);
    }

    public void Update()
    {
        curTime += Time.deltaTime;

        if (curTime >= 60d / bpm)
        {
            White.DOFade(255 / 255, 0.2f).From();

            curTime -= 60d / bpm;
        }
    }
}
