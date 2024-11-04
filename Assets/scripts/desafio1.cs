using UnityEngine;

public class desafio1 : MonoBehaviour
{
    [SerializeField] int power_up = 0;
    [SerializeField] int vidaheroiI = 100;
    [SerializeField] int vidaheroiA = 100;
    int valormorte = 0;

    string voltadosmortos = "Ainda não, vida atual = ";
    string fim = "Game over";
   

    // Start is called once before the first execution of Update after the MonoBehaviour is create

    void Start()
    {
        int vida2 = vidaheroiI / 2;

        if (power_up > 0 && vidaheroiA == valormorte) 
        {
            print(voltadosmortos + vida2);
        } 
        else if (power_up <= 0 && vidaheroiA == valormorte)
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
