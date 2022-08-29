using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class manager : MonoBehaviour
{

    public int Remoteport = 8080;

    public UDPSending sender = new UDPSending();

    public string datafromnode;

    void Start()
    {
        sender.init("172.18.27.62", Remoteport, 8080);
        sender.sendString("Hello from Start. " + Time.realtimeSinceStartup);

        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
            sender.sendString("This should be delivered");

        if (sender.newdatahereboys)
        {
            datafromnode = sender.getLatestUDPPacket();
        }
    }

    public void OnDisable()
    {
        sender.ClosePorts();
    }

    public void OnApplicationQuit()
    {
        sender.ClosePorts();
    }

}
