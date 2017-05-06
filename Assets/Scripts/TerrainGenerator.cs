using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour {


    public Terrain terrain;

	// Use this for initialization
	void Start () {
        TerrainData terrainData = new TerrainData();
        float[,] heightData = new float[30,30];
        for(int i = 1; i < heightData.GetLength(0); i++)
        {
            for(int j = 0; j < heightData.GetLength(1); j++)
            {
                heightData[i, j] = 1f/(float)i;
                print(string.Format("Height data[{0}, {1}] = {2}", i, j, heightData[i, j]));
            }
        }

        terrainData.SetHeights(0, 0, heightData);
        terrain.GetComponent<TerrainCollider>().terrainData = terrainData;
        terrain.terrainData = terrainData;
        terrain.Flush();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
