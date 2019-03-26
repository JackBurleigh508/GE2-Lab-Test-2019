using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float tiberium = 0;

    public TextMeshPro text;

    public GameObject fighterPrefab;


    // Start is called before the first frame update
    void Start()
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
        }

        StartCoroutine(Count());
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + tiberium;
    }

    private IEnumerator Count()
    {
        yield return new WaitForSeconds(1);
        tiberium += 1;
        if(tiberium >= 10)
        {
            Instantiate(fighterPrefab, this.transform);
            tiberium = 0;
        }
        StartCoroutine(Count());
    }
}
