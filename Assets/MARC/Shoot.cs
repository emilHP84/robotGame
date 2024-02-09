using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject cubedeRose;
    public int speeeeed;
    public Rigidbody rigid;
    private float m_Thrust = 02000f;
    // Start is called before the first frame update
    void Start()
    {
        //rigid.AddForce(transform.forward*m_Thrust);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(transform.forward * m_Thrust);
        }
        //cubedeRose.transform.Translate(new Vector3(speeeeed, 0, 0) * Time.deltaTime);
    }
}
