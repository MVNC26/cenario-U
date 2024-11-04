using UnityEngine;

public class desafio1 : MonoBehaviour
{
    [SerializeField] int power_up = 0;
    [SerializeField] int vidaheroi = 100;
    int valormorte = 0;

    string voltadosmortos = "Ainda não, vida atual = ";
    string fim = "Game over";
    int vida2 = 100 / 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     if (power_up > 0 && vidaheroi == valormorte) 
        {
            print(voltadosmortos + vida2);
        } 
        else if (power_up <= 0 && vidaheroi == valormorte)
        {
            print(fim);
        }
        else
        {
            print("ainda vivo");
        }

    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
