using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class smallColliderController : MonoBehaviour
{
    //public GameObject CamaraCuadro;
    //public delegate bool mensaje(string name);
    //public event mensaje check;
    public testTV notificar;
    public GameObject TextoCuadro;
    public GameObject indicadorEspacio;
    public GameObject NestedParent_Unpack;
    public GameObject Video;
    public VideoPlayer videoplayer;

    private bool flagIndicadorEspacio = false;
    private bool flagInfoCuadro = false;
    private bool flagVideo = false;
    private bool flagTest = false;

    void Start()
    {
        notificar.check += checkAnswer;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "smallCollider" && !flagIndicadorEspacio) {
            //CamaraCuadro.SetActive(true);
            indicadorEspacio.SetActive(true);
            flagIndicadorEspacio = true;
            flagTest = true;
            //NestedParent_Unpack.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.tag == "smallCollider") {
            indicadorEspacio.SetActive(false);
            TextoCuadro.SetActive(false);
            flagIndicadorEspacio = false;
            flagTest = false;
        }
    }

    void Awake() {

    }

    void Update() {

        // equis
        if (Input.GetKeyDown(KeyCode.JoystickButton1) && flagIndicadorEspacio) {
            //NestedParent_Unpack.SetActive(true);
            //CamaraCuadro.SetActive(false);
            indicadorEspacio.SetActive(false);
            TextoCuadro.SetActive(true);
            flagIndicadorEspacio = false;
            flagInfoCuadro = true;
        }

        // cuadrado
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && flagInfoCuadro) {
            //NestedParent_Unpack.SetActive(true);
            //CamaraCuadro.SetActive(false);
            indicadorEspacio.SetActive(true);
            TextoCuadro.SetActive(false);
            flagInfoCuadro = false;
            flagIndicadorEspacio = true;
        }

        // triangulo
        if (Input.GetKeyDown(KeyCode.JoystickButton3) && flagInfoCuadro) {
            Video.SetActive(true);
            NestedParent_Unpack.SetActive(false);
            TextoCuadro.SetActive(false);
            videoplayer.Play();
            flagInfoCuadro = false;
            flagVideo= true;
        }

        // cuadrado
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && flagVideo) {
            videoplayer.Stop();
            Video.SetActive(false);
            NestedParent_Unpack.SetActive(true);
            flagIndicadorEspacio = true;
            flagVideo= false;

        }
    }

    void checkAnswer(string name, ref int aux) {
        if (flagTest) {
            if (name == gameObject.name) {
                transform.GetChild(1).gameObject.SetActive(true);
                aux  =  2;
            } else {
                transform.GetChild(2).gameObject.SetActive(true);
                aux = 1;
            }
        }
    }
}
