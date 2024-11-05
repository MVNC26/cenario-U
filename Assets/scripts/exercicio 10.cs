using UnityEngine;

public class exercicio10 : MonoBehaviour
{
    [SerializeField] int ItensColetados = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (ItensColetados)
        {
            case 1:
                print("Use a poção para aumentar a vida");
                
                break;

            case 2:
                print("powerUo utilizado, sua força Aumentou 50%");
                break;


            case 3:
                print("100 moedas coletadas");
                break;

            default:
                print("nenhum item coletado");
                break;
        

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}




//Crie um script onde o jogador pode coletar
//diferentes tipos de itens (como moedas, poções, ou power-ups)
//que têm efeitos diferentes dependendo do tipo coletado. Use um
//switch case para determinar o efeito de cada tipo de item.