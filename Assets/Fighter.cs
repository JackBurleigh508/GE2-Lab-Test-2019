using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    public float tiberium = 0;

    public GameObject target;
    public int targetNum;
    public GameObject[] TargetBases;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        tiberium = 7;

        TargetBases = GameObject.FindGameObjectsWithTag("Base");

        targetNum = Random.Range(0, 3);
        target = TargetBases[targetNum];

        if(target == this.gameObject.transform.parent)
        {
            targetNum = Random.Range(0, 3);
            target = TargetBases[targetNum];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(tiberium == 0)
        {
            //this.gameObject.GetComponent<Attack>(false);
            //this.gameObject.GetComponent<Refuel>(true);
        }
        else if(tiberium > 0)
        {
            //this.gameObject.GetComponent<Attack>(true);
            //this.gameObject.GetComponent<Refuel>(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Base" /*&& other.gameObject /= this.gameObject.transform.parent*/)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(0.2f);
        Instantiate(bullet);
    }
}
