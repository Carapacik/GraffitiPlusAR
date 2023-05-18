using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PenManager : MonoBehaviour
{
    public static bool drawingOnSpace = false;
    GameObject button;
    GameObject button2;
    public GameObject spacePenPoint;

    public void DrawOnSpace()
    {
        drawingOnSpace = true;

        button = GameObject.Find("ButtonDraw");
        button.SetActive(false);
    }

    public void DrawOffSpace()
    {
        drawingOnSpace = false;

        button2 = GameObject.Find("ButtonDraw2");
        button2.SetActive(false);

        button.SetActive(true);
        button2.SetActive(true);
    }
}
