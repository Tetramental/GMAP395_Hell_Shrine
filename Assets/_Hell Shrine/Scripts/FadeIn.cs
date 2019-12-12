using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    Renderer rend;
    public Color alpha;

    // Start is called before the first frame update
    void Start()
    {
        rend = this.GetComponent<Renderer>();
        alpha = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (alpha.a > 0f)
        {
            alpha.a -= 0.1f * Time.deltaTime;
            rend.material.SetColor("_BaseColor", alpha);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}