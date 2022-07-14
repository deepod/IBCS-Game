using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowQuestion : MonoBehaviour
{

    public GameObject questionDisplay;
    public GameObject ansA;
    public GameObject ansB;
    public GameObject ansC;
    public GameObject ansD;
    

    // Start is called before the first frame update
    void Start()
    {
        questionDisplay.GetComponent<Text>().text = "State where the customer data is held during the process of modifying their data.";
        ansA.GetComponent<Text>().text = "Hard Disk";
        ansB.GetComponent<Text>().text = "RAM";
        ansC.GetComponent<Text>().text = "Bios";
        ansD.GetComponent<Text>().text = "Database";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
