using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    //public string[]nomes = new string[10];
    public string[] nomes;
    //LISTAS,PILHAS E FILAS
    public Stack<int> deck = new Stack<int>();
    public Queue<Color> bolhas = new Queue<Color>();

    // Start is called before the first frame update
    void Start()
    {
        /* ==
           !=
           <
           >
           <=
           >=
           &&
           ||
           !
        */
        /*
        if(n>=18){
            Debug.Log("Adulto");
        }else if(n<18 && n>0){
            Debug.Log("Menor de idade");
        }else{
            Debug.Log("Não nasceu ainda");
        }
        */
        /*
        switch(n){
            case 1:
                Debug.Log("Bronze");break;
            case 2:
                Debug.Log("Prata");break;
            case 3:
                Debug.Log("Ouro");break;
            case 4:
                Debug.Log("Diamante");break;
            default:
                Debug.Log("Lixoso");break;
        }
        */
        /*
        while(n>=0){
            Debug.Log(n);
            //n = n+2;
            //n+=2;
            //n++;
            //n=n-1;
            //n-=1;
            n--;
        }
        */
        /*
        for(int i=50; i>=0; i-=2){
            Debug.Log(i);
        }*/
        /*
        nomes[0]="Kleber";
        nomes[1]="Carolzinha";
        nomes[2]="Joao";
        nomes[3]="xXLuc45Xx";
        nomes[15]="QWERTY";
        for(int i=0;i<nomes.Length;i++){
            Debug.Log(nomes[i]);
            if(nomes[i]=="Joao"){
            }
        }*/
        /*
        deck.Push(13);
        deck.Push(5);
        deck.Push(2);
        Debug.Log(deck.Peek());
        deck.Pop();
        Debug.Log(deck.Peek());
        deck.Pop();
        Debug.Log(deck.Peek());
        */

        bolhas.Enqueue(Color.red);
        bolhas.Enqueue(Color.green);
        bolhas.Enqueue(Color.blue);

        //Debug.Log(bolhas.Peek());
        bolhas.Dequeue();
        //Debug.Log(bolhas.Peek());
        Debug.Log(bolhas.Dequeue());
        //Debug.Log(bolhas.Peek());
         Debug.Log(bolhas.Dequeue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
