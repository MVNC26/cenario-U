using UnityEngine;

public class exercicio7 : MonoBehaviour
{
    [SerializeField] int facesDado;
    int probalidade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       if (facesDado == 0)
        {
            print("o numero de faces do dado nçao pode ser " + facesDado );
        }else
        {
            probalidade = Random.Range(1, facesDado );
            print(probalidade);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Para fazer um jogo de RPG, vamos precisar
//calcular probabilidades e simular a rolagem de dados. Crie um
//script em que o usuário defina o número de faces de um dado
//(int) e calcule a rolagem de um dado com esse número de faces.
//Use a função abaixo para o cálculo: Random.Range(valor_min,
//valor_max); (Coloque o código dentro da função-evento Start).
