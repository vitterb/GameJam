using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public Cinemachine.CinemachineDollyCart dolly;
    public Collider halt;

    private void OnTriggerEnter(Collider halt)
    {
        dolly.m_Speed = 0;
    }
}
