using UnityEngine;

public class exercicio6 : MonoBehaviour
{
    [SerializeField] bool guerreiro;
    [SerializeField] bool mago;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       if (guerreiro == true)
        {
            print("guerreiro escolhido");

        } else if (mago == true)
        {
            print("mago escolhido"); 
        }else
        {
            print("nenhum persoangem escolhido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//O jogador pode escolher entre o
//personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
//jogador selecionar Guerreiro e "Mago escolhido" se selecionar
//Mago.
