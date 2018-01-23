using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour {

    public GameObject TilePrefab;

    public int X = 2;
    public int Y = 3;



    private void Start() {
        CreateGrid();
    }

    void CreateGrid() {

        float size = TilePrefab.transform.localScale.x + 0.1f;

        for (int x = 0; x < X; x++) {
            for (int y = 0; y < Y; y++) {
                
                Instantiate(TilePrefab, new Vector3(x * size, transform.position.y, y * size), transform.rotation, transform);
            }
        }
    }

}
