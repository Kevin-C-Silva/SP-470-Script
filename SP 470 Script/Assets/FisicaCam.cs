using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class FisicaCam : MonoBehaviour
{
    Vector3 M;
    Vector3 C;
    double P;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CReset();
        Pular();
        Movi();
        Girar();
        C.y = 0f;
        C.x = 0;
        C.z = 0;
    }

    private void Movi()
    {
        if (Input.GetKey(KeyCode.W))
        {
            C.x = 0f;
            C.y = 0f;
            C.z += 0.0025f;
            transform.Translate(C);
        }
        if (Input.GetKey(KeyCode.S))
        {
            C.x = 0f;
            C.y = 0f;
            C.z += -0.0025f;
            transform.Translate(C);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            C.x = 0f;
            C.y = 0f;
            C.z += 0.0050f;
            transform.Translate(C);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            C.x = 0f;
            C.y = 0f;
            C.z += -0.0050f;
            transform.Translate(C);
        }
    }
    private void Girar()
    {
        if (Input.GetKey(KeyCode.A))
        {
            C.x = 0f;
            C.y = -0.15f;
            C.z += 0f;
            transform.Rotate(C);
        }
        if (Input.GetKey(KeyCode.D))
        {
            C.x = 0f;
            C.y = 0.15f;
            C.z += 0f;
            transform.Rotate(C);
        }
    }
    private void Pular()
    {
        P = 0;
        if (P == 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                C.x = 0f;
                C.y = 0.25f;
                C.z += 0f;
                transform.Translate(C);
                P = 1;
            }
        }
        else if (P == 1)
        {
            while (P > 0)
            {
                P -= 0.0000000000000000000000025;
            }
        }
    }
    private void CReset()
    {
        if (Input.GetKey(KeyCode.R))
        {
            C.y = 0f;
            transform.Rotate(C);

        }
    }
}