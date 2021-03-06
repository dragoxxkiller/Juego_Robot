using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta_1 : MonoBehaviour
{

    Animator animator;
    [SerializeField] Transform player;

    [SerializeField] Transform cannon;
   
    [SerializeField] GameObject bala;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

       

        player = GameObject.Find("Robot").transform;

    }

    // Update is called once per frame
    void Update()
    {


        Vector3 dir = player.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);



    }

   
  public void ActivarTorreta()
    {
        animator.SetBool("EnZona", true);
    }

    public void DesactivarTorreta()
    {
        animator.SetBool("EnZona", false);
    }
    void Disparar()
    {
        Instantiate(bala, cannon);
    }

}
