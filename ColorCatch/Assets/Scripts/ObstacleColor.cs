using UnityEngine;



public class ObstacleColor : MonoBehaviour
{
    public GameObject Obstacle;
    public float obstacleColorChange = 10.0f;


    void Start()
    {
        InvokeRepeating("RepeteObstacle", 0f, obstacleColorChange);
    }


    Color[] colors = { Color.green, Color.red, Color.gray, Color.blue, Color.yellow, Color.black, Color.cyan, Color.magenta };



    void RepeteObstacle()
    {
        Obstacle.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
    }
}





    //  renderer.material.color = newColor;

    //GameObject thing = Instantiate(Obstacle) as GameObject;
    // Obstacle.GetComponent<Renderer>().material.color = Color.red;
    //working  Obstacle.GetComponent<Renderer>().material.color = newColor;


    /*
            if (Time.time > nextActionTime1)
            {
                nextActionTime1 += periodObstacle;

                //Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
                //Obstacle.GetComponent<MeshRenderer>().material.color = newColor;


                Obstacle.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            }


        */




/*

void ChangeMaterial(MeshRenderer platformRenderer)
{
    Color color = new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1), 1);
    platformRenderer.material.color = color;
}



    */




