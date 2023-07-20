using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System.Linq;
using System.Threading;


public class testTV : MonoBehaviour
{
  public delegate void mensaje(string name, ref int aux);
  public delegate void resultados(int result);
  public event mensaje check;
  public event resultados change;
  public int[] quests = new int[8];
  private int number = 0;
  private int result = 0;
  private string questName = "";
  private int aux = 2;
  private bool spaceFlag = false;
  private bool lastQuestflag = false;
  private bool lastAnswerflag = false;
  private bool startedFlag = false;
  //public PaintingController notificar;

  // Start is called before the first frame update
  void Start()
  {
    for (int i = 0; i < quests.Length; i++) {
      quests[i] = i+1;
    }
  }

private void OnTriggerEnter(Collider other)
{
  if (other.tag == "Player" && !spaceFlag) {
    spaceFlag = true;
    Debug.Log("hola");
  }
}
private void OnTriggerExit(Collider other) {
  if (other.tag == "Player") {
    spaceFlag = false;
    Debug.Log("adios");
  }
}

  // Update is called once per frame
  void Update()
  {
    // equis
    if (Input.GetKeyDown(KeyCode.JoystickButton0) && spaceFlag && !lastQuestflag) {
        if (!startedFlag) {
          GameObject button = transform.GetChild(quests.Length + 1).gameObject;
          button.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Siguiente X";
          startedFlag = true;
        }
        transform.GetChild(number).gameObject.SetActive(false);
      if (quests.Length != 1) {
        number = Random.Range(0, quests.Length);
        number = quests[number];
        quests = quests.Where(val => val != number).ToArray();
      } else {
        lastQuestflag = true;
        number = quests[0];
      }
      questName = transform.GetChild(number).gameObject.name;
      transform.GetChild(number).gameObject.SetActive(true);
      aux = 0;
    }

  // circulo en pc -> cuadrado en movil (button1)
    if (Input.GetKeyDown(KeyCode.JoystickButton1) && aux == 0) {
      check(questName, ref aux);
      if (aux > 0) {
        result += aux - 1;
        if (lastQuestflag) {
          transform.GetChild(9).gameObject.SetActive(false);
          lastAnswerflag = true;
        }
      }
    }

    if (lastAnswerflag) {
      transform.GetChild(number).gameObject.SetActive(false);
      change(result);
      lastAnswerflag = false;
    }
  }
}
