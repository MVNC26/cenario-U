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

/* metodo alternativo para realizar desafio 
 
[SereialFild]boll playervivo;
[SerialFild]boll powerUp;
double vidaplayer = 100
 
 
void start()

if(playerVivo == false && powerUp == true)
{
vidaPlayer = vidaplayer * 0.5;
print(``Ainda nao, vida atual `` + vidaPlayer);
}
else
{
print(``Gameover!``);
}

 */