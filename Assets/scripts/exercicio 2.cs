using UnityEngine;

public class exercicio2 : MonoBehaviour
{
    [SerializeField] int itenspersonagem = 0;
    int powerup = 1;

    string Pcoletado = "power-up coletado";
    string semitens = "nenhum power-up encontrado";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (itenspersonagem == powerup) 
        {
            print(Pcoletado);
        }
        else
        {
            print(semitens);    
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/* metodo alternativo mais facil, sendo melhor para a memoria ocupando menos espa�o
 * 
 
[serialFild] bool powerup;

void Start ()

if ( power up == true )
{
 print ("power up coletado");
}

else
{
print ("nenhum power up encontrado")
}

MOdo boleano 

print (power up ? "power uo Coletado" : "nenhum power up encontrado") ; 


 
 
 
 
 
 
 
 
 */
