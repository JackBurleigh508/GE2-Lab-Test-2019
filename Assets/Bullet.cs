using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("KillMe", 10);
        target = GetComponentInParent<Fighter>().target;
    }

    public void KillMe()
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        if(this.gameObject.transform.position == target.gameObject.transform.position)
        {
            target.GetComponent<Base>().tiberium -= 0.5f;
            Invoke("Kill Me", 1);
        }
    }

    
}
