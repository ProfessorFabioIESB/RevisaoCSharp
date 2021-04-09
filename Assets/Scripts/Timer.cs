using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float timer = 0;
    private bool timerOn = false;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("TimerCoroutine");
        //StartCoroutine(TimerCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        timerText.text = timer.ToString("0");
    }

    IEnumerator TimerCoroutine(){
        yield return new WaitUntil(() => timerOn == true);
        yield return new WaitForSeconds(1);
        timer++;
        StartCoroutine(TimerCoroutine());
    }

    public void StartStopTimer(bool on){
        if(timerOn){
            StopAllCoroutines();
            StartCoroutine(TimerCoroutine());
        }
        timerOn = on;  
    }
}
