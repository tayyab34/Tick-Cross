using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCreation : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject cell;
    public int move;
    public int tickcount;
    public int crosscount;
    // Start is called before the first frame update
    void Start()
    {
        Grid();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Grid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Instantiate(cell, new Vector2(x,y), Quaternion.identity);
            }
        }
    }
    public void win()
    {
        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                if (x==y && tickcount == width || crosscount == width)
                {
                    Debug.Log("Win");
                    tickcount = 0;
                    crosscount = 0;
                }
            }
        }
    }
}
