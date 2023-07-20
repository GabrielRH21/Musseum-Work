using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultTV : MonoBehaviour
{
    public testTV notificar;

    // Start is called before the first frame update
    void Start()
    {
        notificar.change += changeResult;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void changeResult(int result) {
        transform.GetChild(0).gameObject.GetComponent<Text>().text += "Tu resultado es: ";
        transform.GetChild(0).gameObject.GetComponent<Text>().text += result.ToString() + "/8 \n";
        float nota = (float)result / 8f * 10f;
        transform.GetChild(0).gameObject.GetComponent<Text>().text += "La nota final es de: " + nota.ToString();
    }
}
