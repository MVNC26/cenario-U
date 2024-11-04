using UnityEngine;

public class exercicio1 : MonoBehaviour
{
    [SerializeField] int vidaheroi = 100;
    int valormorte = 0;

    string condicao_vida = "o persoangem está vivo";
    string condicao_morte = "o personagem está morto";


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(vidaheroi > valormorte)
        {
            print (condicao_vida + " vida = " + vidaheroi );

        } else if(vidaheroi <= valormorte)
        {
            print( condicao_morte + " vida = " +  valormorte );
        }
        else
        {
            print(condicao_vida);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

