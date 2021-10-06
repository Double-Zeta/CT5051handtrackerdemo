using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    Rigidbody m_rigidbody;
    float m_Speed;
    Vector3 originalPos;

    void Start()
    {
        originalPos = gameObject.transform.position;
        m_rigidbody = GetComponent<Rigidbody>();
        //set speed of the gameobject
        m_Speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        m_rigidbody.velocity = -transform.forward * m_Speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.transform.position = originalPos;
        }
    }
}
