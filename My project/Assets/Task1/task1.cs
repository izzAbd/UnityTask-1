using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject _gameObject;
        Destroy(gameObject.GetComponent<CapsuleCollider>());
        ChangeTag();
        ChangeName();
    }

    void ChangeTag()
    {
        gameObject.tag = "Changed";
    }
    void ChangeName()
    {
        if (gameObject.tag == "Changed")
        {
            gameObject.name = "Changed";
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
