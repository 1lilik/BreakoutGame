using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BlockDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int hp = 3;

    public void takedamage()
    {
        hp -= 1;
        if (hp == 0)
        {
            Destroy(gameObject);
        }
    }
}
