using UnityEngine;

public class exercicio8 : MonoBehaviour
{
    [SerializeField] int hora = 0;
    int segundos;
    int dias = 0;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundos++;

        if (segundos % 1000 == 0)
        {
            hora++;
            print(hora);
        }
        if (hora ==24)
        {
            dias++;
            hora = 0;
            print(dias);
        }
        
          

        
    }
}


//Crie um script que em que uma
//variável inteira hora seja incrementada de uma unidade a cada 10
//segundos e volte a ser 0 quando alcançar o valor 24. Quando
//completar um ciclo, incremente uma variável dias e escreva o
//número de dias que se passaram no console. (Coloque o código
//dentro da função-evento Update).