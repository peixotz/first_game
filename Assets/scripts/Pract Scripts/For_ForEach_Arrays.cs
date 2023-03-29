using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_ForEach_Arrays : MonoBehaviour
{

    //For é um laço/loop de repetição

   /*  Laço de repetição é uma estrutura que executa 
       um conjunto de instruções enquanto uma determinada 
       condição é verdadeira */
    // Start is called before the first frame update

    public int[] arrayInt = {1, 2, 3, 4, 5};
    void Start()
    {
        // For (valorInicial; condiçãoFinal; valorIncremento)
        for(int i = 0; i < 10; i++) 
        {
            Debug.Log(i);

        }

        foreach(int valor in arrayInt) 
        {
            Debug.Log(valor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
