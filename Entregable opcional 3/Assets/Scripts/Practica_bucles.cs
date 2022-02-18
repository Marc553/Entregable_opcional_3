using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica_bucles : MonoBehaviour
{
    public int divisor = 3;
    public int[] intArray;
    public int numEnemies = 1;

    public Vector3 posicion;
    
    public GameObject objeto;
    

    void Start()
    {
        //Ejercicio1_for();
        //Ejercicio1_while();
        //Ejercicio2_for();
        //Ejercicio2_while();
        //Ejercicio3_for();
        //Ejercicio3_while();
        //Ejercicio4_for();
        //Ejercicio4_while();
        //Ejercicio5_for();
        //Ejercicio5_while();
        //Ejercicio6_for();
        //Ejercicio6_while();
    }

    
    void Update()
    {
        
    }
    ///////////////////////////
   //FOR
   ////////////////////////////
   public void Ejercicio1_for()
   {
     for(int i = 0; i <= 100; i += 2)
     {
       Debug.Log(i);

     }
   }

    public void Ejercicio2_for()
    {
        for(int i = 0; i <= 20; i++)
        {
            Debug.Log("Hola, holita, vecinito");
        }
    }

    public void Ejercicio3_for()
    {
        for(int i = 0; i <= 500; i += divisor)
        {
            Debug.Log(i);
        }
    }

    public void Ejercicio4_for()
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i]);
        }
    }

    public void Ejercicio5_for()
    {
        
        for(int i = 1; i <= numEnemies; i++)
        {
            Instantiate(objeto, position(),
                objeto.transform.rotation);
        }
    }

    public void Ejercicio6_for()
    {
        for (int i = 0; i <= numEnemies; i++)
        {
            posicion = new Vector3(i, i, 0);
            Instantiate(objeto, posicion,
                objeto.transform.rotation);
        }
    }





    //////////////////////////////
    //WHILE
    /////////////////////////////
    public void Ejercicio1_while()
    { 
        int i = 0;
        while(i <= 100)
        {
            Debug.Log(i);
            i += 2;

        }
    }
    public void Ejercicio2_while()
    { 
        int i = 0;
        while(i <= 20)
        {
            Debug.Log("Hola, holita, vecinito");
            i ++;

        }
    }
    public void Ejercicio3_while()
    { 
        int i = 0;
        while(i <= 500)
        {
            Debug.Log("Hola, holita, vecinito");
            i += divisor;

        }
    }
    public void Ejercicio4_while()
    {
        int i = 0;
        while(i < intArray.Length)
        {
            Debug.Log(intArray[i]);
            i++;
        }
    }

    public void Ejercicio5_while()
    {
        int i = 0;
         while(i <= numEnemies)
        {
            Instantiate(objeto, position(),
                objeto.transform.rotation);
        }
    }
    
    public void Ejercicio6_while()
    {
       
        int i = 0;
         while(i <= numEnemies)
        {
            posicion = new Vector3(i, i, 0);
            Instantiate(objeto, posicion,
                objeto.transform.rotation);
        }
    }

    //////////////////////
    //Demás
    //////////////////////

    public Vector3 position()
    {
        float randomR = 2;

        float randomX = Random.Range(-randomR, randomR);
        float randomY = Random.Range(-randomR, randomR);
        float randomZ = Random.Range(-randomR, randomR);

        return new Vector3 (randomX, randomY, randomZ);
    }


    



}
