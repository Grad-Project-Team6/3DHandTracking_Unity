using UnityEngine;

public class HandZMovement : MonoBehaviour
{
    public UDPReceive udpReceive;
    public GameObject[] handPoints;
    public GameObject[] handLines;

    void Update()
    {
        string data = udpReceive.data;

        if (data.Length >= 2)
        {
            data = data.Remove(0, 1);
            data = data.Remove(data.Length - 1, 1);

            string[] points = data.Split(',');

            for (int i = 0; i < 21; i++)
            {
                float x = 5 - float.Parse(points[i * 3]) / 100;
                float y = float.Parse(points[i * 3 + 1]) / 100;
                float z = float.Parse(points[i * 3 + 2]) / 100;

                handPoints[i].transform.localPosition = new Vector3(x, y, z);

                if (i < 20)
                {
                    handLines[i].GetComponent<LineRenderer>().SetPosition(0, handPoints[i].transform.position);
                    handLines[i].GetComponent<LineRenderer>().SetPosition(1, handPoints[i + 1].transform.position);
                }
            }
        }
    }
}
