using UnityEngine;

public class exercicio11 : MonoBehaviour
{
    [SerializeField] int conversas = 1;
    [SerializeField] bool vidabaixa;
    [SerializeField] bool salvouTodos;
    [SerializeField] bool fome;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (conversas)
        {
            case 1:
                if (vidabaixa == true)
                {
                    print("voce esta morerndo, vou chamar um m�dico");
                }
                else
                {
                    print("tome cuidado para sua vida n�o baixar");
                }
                break;

            case 2:
                if (salvouTodos == true )
                {
                    print("obrigado voce salvou todo nosso povo");
                }
                else
                {
                    print("corra heroi ainda a muito oque fazer");
                }
                break;

            case 3:
                if (fome == true)
                {
                    print("voce quer comprar um p�o, voce parece estar com fome");
                }
                else
                {
                    print("aqui fazemos paes maravilhosos");
                }
                break;

            default:
                print("nenhum dialogo disponivel");
                break;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Implemente um sistema de di�logos onde o jogador
//pode interagir com um NPC (personagem n�o jog�vel), e o NPC
//responde com diferentes frases dependendo do estado do jogo.
//Use switch case para definir as respostas baseadas no estado do
//jogador.
