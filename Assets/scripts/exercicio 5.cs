using UnityEngine;

public class exercicio5 : MonoBehaviour
{
    [SerializeField] bool missao;
    [SerializeField] int pontua��o = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if ( missao = true && pontua��o > 50 )
        {
            print("Miss�o bem-sucedida");
        } 
        else
        {
            print("Miss�o incompleta");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



//Ap�s completar uma miss�o, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
//incompleta".
