using UnityEngine;

public class exercicio7 : MonoBehaviour
{
    [SerializeField] int facesDado;
    int probalidade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        probalidade = Random.Range(0, facesDado);
        print (probalidade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Para fazer um jogo de RPG, vamos precisar
//calcular probabilidades e simular a rolagem de dados. Crie um
//script em que o usu�rio defina o n�mero de faces de um dado
//(int) e calcule a rolagem de um dado com esse n�mero de faces.
//Use a fun��o abaixo para o c�lculo: Random.Range(valor_min,
//valor_max); (Coloque o c�digo dentro da fun��o-evento Start).