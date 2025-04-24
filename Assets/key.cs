using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialougetetx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Keyunlocked");
            dialougetetx.text = "Keyunlocked";
            this.gameObject.SetActive(false);
        }
    }
}
