using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissloveTest : MonoBehaviour
{

    public Material material;            //���׸����� �޾ƿ´�.
    public float amount = 1f;            //������ ���� �޾ƿ´�.
    public bool bDisslove;               //���� �÷���

    private void Start()
    {
        amount = -1;
        material.SetFloat("_Amount", amount);
    }

    // Update is called once per frame
    void Update()
    {
        amount += Time.deltaTime;
        material.SetFloat("_Amount", amount);
    }
}
