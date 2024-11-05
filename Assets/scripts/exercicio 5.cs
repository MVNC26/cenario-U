using UnityEngine;

public class exercicio5 : MonoBehaviour
{
    [SerializeField] bool missao;
    [SerializeField] int pontuação = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if ( missao = true && pontuação > 50 )
        {
            print("Missão bem-sucedida");
        } 
        else
        {
            print("Missão incompleta");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



//Após completar uma missão, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Missão bem-sucedida"; caso contrário, "Missão
//incompleta".
