using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> images;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < images.Count; i++)
        {
            GameObject temp = new GameObject();
            int rnd = Random.Range(0, images.Count - 1);
            temp.transform.position = images[rnd].transform.position;
            images[rnd].transform.position = images[i].transform.position;
            images[i].transform.position = temp.transform.position;
            //Image image = images[i];
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
