using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInStart : MonoBehaviour
{

    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        image.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
