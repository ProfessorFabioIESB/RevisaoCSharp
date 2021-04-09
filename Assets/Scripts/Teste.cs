using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public struct FichaDePersonagem{
    public string nome;
    public int hp;
    Teste.Naipes np;
    public void Mostrar(){
        Debug.Log("Meu nome é: "+nome+ "  e meu HP é: "+ hp);
    }
}

public class Teste : MonoBehaviour
{
    public GameObject cakePrefab;
    private float cakePosition = 1;
    public float timer = 0;
    public float timeToReload = 1;
    public int q;
    //public string[]nomes = new string[10];
    public string[] nomes;
    //LISTAS,PILHAS E FILAS
    public Stack<int> deck = new Stack<int>();
    public Queue<Color> bolhas = new Queue<Color>();
    public List<string> guns = new List<string>();
    public Dictionary<string,int> enemys = new Dictionary<string, int>();
    public enum Naipes{OUROS=10,COPAS=20,ESPADAS=30,PAUS=40}
    FichaDePersonagem f;

    public UnityEvent Disappear;

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
        while(true){
            Debug.Log(n);
            //n = n+2;
            //n+=2;
            //n++;
            //n=n-1;
            //n-=1;
            n--;

            if(n==null){
                break;
            }
        }
        */
        /*
        do{
            //AÇAO
        }while(n>=0);
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
        /*
        bolhas.Enqueue(Color.red);
        bolhas.Enqueue(Color.green);
        bolhas.Enqueue(Color.blue);

        //Debug.Log(bolhas.Peek());
        bolhas.Dequeue();
        //Debug.Log(bolhas.Peek());
        Debug.Log(bolhas.Dequeue());
        //Debug.Log(bolhas.Peek());
        Debug.Log(bolhas.Dequeue());
        */
        /*
        guns.Add("UMP45");
        guns.Add("GLOCK");
        guns.Add("AK47");
        guns.Add("AWP");

        guns.Sort();
        guns.Insert(1,"DESERTE");

        //guns.Reverse();

        //guns.Remove("AWP");
        //guns.RemoveAt(2);
        Debug.Log(guns.Contains("AWP"));

        int c = guns.Count;

        for(int i = 0; i < c;i++){
            Debug.Log(guns[i]);
        }
        guns.Clear();
        */
        /*
        enemys.Add("Orc", 100);
        enemys.Add("Troll", 200);
        enemys.Add("Beholder", 500);

        Debug.Log(enemys.Count);
        Debug.Log(enemys.ContainsKey("Beholder"));
        */
        /*
        f.nome = "Kleber";
        f.hp = 100;
        f.Mostrar();
        */
        /*
        //Car carro1 = new Car();
        Vehicle carro1 = new Car();
        carro1.MostraInfo();

        Car.Capotar();
        Car.cor = "BLUE";
        */

        //GameObject.FindObjectOfType<GameManager>().score++;
        //GameManager.Instance.score++;
        //GameManager.Instance.MostrarScore();

        ChangeColor cc;
        cc = GameObject.FindObjectOfType<ChangeColor>().GetComponent<ChangeColor>();


        cc.change();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        timer += Time.deltaTime;
        //Debug.Log(timer);
        if(timer >= timeToReload){
           //Debug.Log(q);
           q++;
           timer = 0;
        }
        */
        /*
        if(Input.GetAxis("Horizontal") > 0){
            Debug.Log("DIREITA!");
        }
        if(Input.GetAxis("Horizontal") < 0){
            Debug.Log("ESQUERDA!");
        }
        */

        if(Input.GetKeyDown(KeyCode.E)){
           Disappear.Invoke();
        }
    }

    public void BakeCake(){
        GameObject copia = Instantiate(cakePrefab, transform.position, Quaternion.identity); 
        copia.name = "Cake";
        //copia.GetComponent<Rigidbody>().useGravity = false;
        copia.transform.position = new Vector3(transform.position.x -2*cakePosition, 
        transform.position.y, transform.position.z);
        cakePosition++;
        Disappear.Invoke();
    }

    public void ResetCakePosition(){
        cakePosition = 1;
    }
}
