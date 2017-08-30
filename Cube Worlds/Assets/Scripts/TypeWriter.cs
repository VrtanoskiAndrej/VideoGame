using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{

    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";
    public int number = 0;
    public GameObject Text01;

    

    // Use this for initialization
    void Start()
    {
        StartCoroutine(ShowText());
        TotalDelays();
    }

    void TotalDelays()
    {
        float TotalDelay = delay * fullText.Length;
        Invoke("NextLine", TotalDelay);
    }

    void NextLine()
    {
        Text01.SetActive(true);
    }

    IEnumerator ShowText()
    {
        for (int number = 0; number < fullText.Length; number++)
        {
            currentText = fullText.Substring(0, number);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

}
