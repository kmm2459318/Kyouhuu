using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject paper;
    public GameObject cabbage;
    public GameObject dog;
    float paperspan = 1.0f;
    float cabbagespan = 3.0f;
    float dogspan = 5.0f;
    float paperdelta = 0;
    float cabbagedelta = 0;
    float dogdelta = 0;

    void Update()
    {
        this.paperdelta += Time.deltaTime;
        this.cabbagedelta += Time.deltaTime;
        this.dogdelta += Time.deltaTime;
        if (this.paperdelta > this.paperspan)
        {
            this.paperdelta = 0;
            GameObject go = Instantiate(paper);
            int px = Random.Range(-3, 7);
            go.transform.position = new Vector3(-10, px, 0);
        }
        if (this.cabbagedelta > this.cabbagespan)
        {
            this.cabbagedelta = 0;
            GameObject go = Instantiate(cabbage);
            int px = Random.Range(-3, 7);
            go.transform.position = new Vector3(-10, px, 0);
        }
        if (this.dogdelta > this.dogspan)
        {
            this.dogdelta = 0;
            GameObject go = Instantiate(dog);
            int px = Random.Range(-3, 7);
            go.transform.position = new Vector3(-10, px, 0);
        }
    }
}
