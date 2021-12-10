using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Instanciador : MonoBehaviour
{


    [SerializeField] GameObject Plataforma;
    [SerializeField] GameObject Final;


    // Start is called before the first frame update
    void Start()
    {

        Instantiate(Plataforma);
        Instantiate(Final);


    }

    // Update is called once per frame
    void Update()
    {
        





    }





}
