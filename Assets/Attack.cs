using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : SteeringBehaviour
{
    public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;
    public float shootDistance = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        targetGameObject = this.GetComponent<Fighter>().target;
    }

    // Update is called once per frame
    void Update()
    {
        if (targetGameObject != null)
        {
            target = targetGameObject.transform.position;
        }
    }

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }
}
