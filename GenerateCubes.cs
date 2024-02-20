using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
               GameObject cube0 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube0.AddComponent<Rigidbody>();
        cube0.transform.Translate(-5f,0f,0f);
        var cube0Renderer =  cube0.GetComponent<Renderer> ();
        cube0Renderer.material.SetColor("_Color",Color.red);



        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.AddComponent<Rigidbody>();
        cube1.transform.Translate(-2f,0f,0f);
        var cube1Renderer =  cube1.GetComponent<Renderer> ();
        cube1Renderer.material.SetColor("_Color",Color.blue);

        for (var i = 1; i < 10; i++) {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.AddComponent<Rigidbody>();
            
            var cubeRenderer =  cube.GetComponent<Renderer> ();
            cubeRenderer.material.SetColor("_Color",Color.green);

            cube.transform.Translate(0, i, 0);

            // int rndx  = rnd.Next(1, 13);
            //int rndz = rnd.Next(1,13);
            //cube.transform.Translate(rndx,0,0);
        }
            Debug.Log("5");
            print("5");
            print(gameObject.name);
            //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.SetActive(false);
    }
}
