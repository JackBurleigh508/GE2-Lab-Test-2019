using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refuel : SteeringBehaviour
{
    public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetGameObject != null)
        {
            target = this.gameObject.transform.parent.position;
        }
        
        if(this.gameObject.transform.position == target)
        {
            this.GetComponent<Fighter>().tiberium = 7;
            this.GetComponentInParent<Base>().tiberium -= 7;
        }
        
    }

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }
}
