using UnityEngine;

public class exercicio8 : MonoBehaviour
{
    [SerializeField] int hora;
    [SerializeField] int dia;
    [SerializeField] float segundos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundos = Time.deltaTime;

        if (segundos >= 10f)
        {
            hora++;
            segundos = 0;
            if (hora == 24 )
            {
                dia++;
                hora = 0;
                print(dia);
            }

        }
        
          

        
    }
}


//Crie um script que em que uma
//vari�vel inteira hora seja incrementada de uma unidade a cada 10
//segundos e volte a ser 0 quando alcan�ar o valor 24. Quando
//completar um ciclo, incremente uma vari�vel dias e escreva o
//n�mero de dias que se passaram no console. (Coloque o c�digo
//dentro da fun��o-evento Update).

//void Update()
//{
//    segundos++;

//    if (segundos % 1000 == 0)
//    {
//        hora++;
//        print(hora);
//    }
//    if (hora == 24)
//    {
//        dias++;
//        hora = 0;
//        print(dias);
//    }




//}
//}