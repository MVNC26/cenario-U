using UnityEngine;

public class exercicio9 : MonoBehaviour
{
    [SerializeField] int PtimeA = 0;
    [SerializeField] int PtimeB = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(PtimeA > PtimeB)
        {
            print("vit�ria time A");

        }else if(PtimeB > PtimeA)
        {
            print("vit�tia time B");

        }
        else if (PtimeA > 3 &&  PtimeB > 3 && PtimeA == PtimeB )
        {
            print("um empate emocionante");
        }
        else if (PtimeA == PtimeB)
        {
            print("empate");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Crie um script que l� o placar de uma partida entre
//time A e time B. Depois, escreva no console qual dos tr�s
//resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B
//ou empate. Se o empate teve mais de 3 pontos para cada lado,
//escreva que foi �um empate emocionante�.
