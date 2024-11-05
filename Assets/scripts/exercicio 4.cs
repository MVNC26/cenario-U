using UnityEngine;
using static UnityEditor.Progress;

public class exercicio4 : MonoBehaviour
{

    [SerializeField] bool poção_de_vida;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (poção_de_vida == true)
        {
            print("usando poção de vida");
        }
        else
        {
            print("poção indisponivel");
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




//(Verificar item de inventário) Um jogador possui itens limitados
//no inventário. Verifique se o jogador possui uma "Poção de Vida".
//Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
//indisponível".