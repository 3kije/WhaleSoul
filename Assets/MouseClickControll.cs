using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickControll : MonoBehaviour
{
    [SerializeField]
    private GameObject particles;

    private Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        particles.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            particles.SetActive(true);
            particles.transform.position = new Vector3(mousePos.x, 6f, 0f);
        }


        if (Input.GetMouseButtonUp(0))
        {
            StartCoroutine(DisableParticle());
        }

        IEnumerator DisableParticle()
        {
            yield return new WaitForSeconds(1);
            particles.SetActive(false);
        }
    }
}
