using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissloveTest : MonoBehaviour
{

    public Material material;            //메테리얼을 받아온다.
    public float amount = 1f;            //설정한 값을 받아온다.
    public bool bDisslove;               //시작 플레그

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
