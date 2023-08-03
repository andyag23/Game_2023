using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //移動速度設定
    [SerializeField]
    private float WalkSpeed;

    protected Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }

    public void Move()
    {
        //deltaTime - 針數之間的時間差
        transform.Translate(direction * WalkSpeed * Time.deltaTime);
    }


}
