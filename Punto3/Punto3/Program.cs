using UnityEngine;
using System.IO.Ports;
using TMPro;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Diagnostics;

enum TaskState
{
    INIT,
    WAIT_COMMANDS
}

public class Codigo : MonoBehaviour
{
    private static TaskState taskState = TaskState.INIT;
    private SerialPort _serialPort;
    public TextMeshProUGUI myText;
    private float lastSendTime = 0f;
    private float intervalo = 3f;
    void Start()
    {
        _serialPort = new SerialPort();
        _serialPort.PortName = "COM5";
        _serialPort.BaudRate = 115200;
        _serialPort.DtrEnable = true;
        _serialPort.NewLine = "\n";
        _serialPort.Open();
        Debug.Log("Open Serial Port");
    }

    void Update()
    {
        switch (taskState)
        {
            case TaskState.INIT:
                taskState = TaskState.WAIT_COMMANDS;
                Debug.Log("WAIT COMMANDS");
                break;
            case TaskState.WAIT_COMMANDS:



                if (Input.GetKeyDown(KeyCode.A) && Time.time - lastSendTime >= intervalo)
                {
                    byte[] data = { 0x41 };
                    _serialPort.Write(data, 0, 1);
                    lastSendTime = Time.time;
                    Debug.Log("Se presionó A");
                }
                if (Input.GetKeyDown(KeyCode.S) && Time.time - lastSendTime >= intervalo)
                {
                    byte[] data = { 0x53 };
                    _serialPort.Write(data, 0, 1);
                    lastSendTime = Time.time;
                    Debug.Log("Se presionó S");
                }
                if (_serialPort.BytesToRead > 0)
                {
                    string response = _serialPort.ReadLine();
                    myText.text = response;
                }
                break;
            default:
                Debug.Log("State Error");
                break;
        }
    }
}