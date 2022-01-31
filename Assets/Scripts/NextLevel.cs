using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Time.timeScale = 1;
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
       Application.LoadLevel(Application.loadedLevel + 1);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="finish")
        {
            Time.timeScale = 0;
            yourButton.gameObject.SetActive(true);
            Debug.Log("TMEAS VAR");
            
        }
   
    }
}
