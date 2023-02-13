using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    public GameObject tick;
    public GameObject cross;
    public GridCreation grid;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if (grid.move == 1)
        {
            cross.SetActive(true);
            grid.move = 0;
            grid.crosscount++;
            grid.win();
            return;
        }
        if (grid.move == 0)
        {
            tick.SetActive(true);
            grid.move++;
            grid.tickcount++;
            grid.win();
        }
    }
}
