using UnityEngine;
using static UnityEditor.Progress;

public class exercicio4 : MonoBehaviour
{

    [SerializeField] bool po��o_de_vida;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (po��o_de_vida == true)
        {
            print("usando po��o de vida");
        }
        else
        {
            print("po��o indisponivel");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}


/* 
[SerializeFild] boll pocaoVida;
string resultado;
 
void start ()
{

print (pocaoVida == true ? ``usando pocao de vida`` : ``pocao indisponivel``)

}

 */




//(Verificar item de invent�rio) Um jogador possui itens limitados
//no invent�rio. Verifique se o jogador possui uma "Po��o de Vida".
//Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
//indispon�vel".