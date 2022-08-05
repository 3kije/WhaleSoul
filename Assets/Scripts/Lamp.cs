using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject LampCanvas;

    private void OnMouseDown()
    {
        LampCanvas.SetActive(true);

    }
}
