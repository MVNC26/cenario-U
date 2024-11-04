using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class geral : MonoBehaviour
{
    /* 
     operadores relacionais 

        == (igual)
        != (diferente)
        > (maior)
        < (menor)
        <= (menor igual)
        > (Maior igual)

     */

    [SerializeField] int Vida_heroi = 100;
    [SerializeField] int Vida_vilao = 300;
    string resultado;
    
    void Start()
    {
        print ( Vida_vilao == Vida_heroi );//false 
        print (Vida_vilao <= Vida_heroi );//true 
        print (Vida_vilao != Vida_heroi ); // true

        //operador ternario 
        // condição valor a ser atribuido caso verdadeiro : caso falso 

        //resultado = Vida_heroi < Vida_vilao ? "Vida heroi Menor " : "Vida heroi Maior";
        //print (resultado);
        if(Vida_heroi < Vida_vilao)
        {
            resultado = "vida heroi menor";
            print("Vida heroi Menor");

        }else if(Vida_heroi == Vida_vilao)
        {
            resultado = "vida heroi igual vida vilao";
            print(resultado);
        }
        else 
        {
            resultado = "vida heroi Maior ";
            print("Vida heroi Maior");
        }
       
    }

    void Update()
    {

        
    }
}
