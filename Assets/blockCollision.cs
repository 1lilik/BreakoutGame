using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballColision : MonoBehaviour
{
    int hp = 1;

    // Start is called before the first frame update
    void Start()
    {
       
    }
        
    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherGameObject = collision.gameObject;
        BlockDestruction hitEnemy = otherGameObject.GetComponent<BlockDestruction>();
        
        if (hp != 0)
        {
            Destroy(gameObject);
        }
    }
}
