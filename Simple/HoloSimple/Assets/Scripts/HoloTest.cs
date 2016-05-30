using UnityEngine;
using System.Collections;

public class HoloTest : MonoBehaviour
{

    void OnSelect()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f);
    }
}
