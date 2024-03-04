using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    public GameObject lanterna;
    private bool ativo = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && ativo == false)
        {
            lanterna.SetActive(true);
            ativo = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && ativo == true )
        {
            lanterna.SetActive(false);
            ativo = false;
        }
    }
}
