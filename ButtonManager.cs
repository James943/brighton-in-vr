using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourUpButton, m_YourRightButton, m_YourLeftButton, m_YourDownButton, m_YourForwardButton, m_YourBackwardButton;
    // Start is called before the first frame update
    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourUpButton.onClick.AddListener(TaskOnClickUp);
        m_YourRightButton.onClick.AddListener(TaskOnClickRight);
        m_YourLeftButton.onClick.AddListener(TaskOnClickLeft);
        m_YourDownButton.onClick.AddListener(TaskOnClickDown);
        m_YourForwardButton.onClick.AddListener(TaskOnClickForward);
        m_YourBackwardButton.onClick.AddListener(TaskOnClickBackward);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void TaskOnClickUp()
    {
        Debug.Log("You have clicked the up button!");
        Camera.main.gameObject.transform.Translate(0, 5, 0);
    }

            void TaskOnClickRight()
    {
        Debug.Log("You have clicked the right button!");
        Camera.main.gameObject.transform.Translate(5, 0, 0);
    }

            void TaskOnClickLeft()
    {
        Debug.Log("You have clicked the left button!");
        Camera.main.gameObject.transform.Translate(-5, 0, 0);
    }

            void TaskOnClickDown()
    {
        Debug.Log("You have clicked the down button!");
        Camera.main.gameObject.transform.Translate(0, -5, 0);
    }

            void TaskOnClickForward()
    {
        Debug.Log("You have clicked the down button!");
        Camera.main.gameObject.transform.Translate(0, 0, 5);
    }

            void TaskOnClickBackward()
    {
        Debug.Log("You have clicked the down button!");
        Camera.main.gameObject.transform.Translate(0, 0, -5);
        }
        
}
