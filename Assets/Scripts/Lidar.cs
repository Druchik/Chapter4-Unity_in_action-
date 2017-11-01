using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Lidar : MonoBehaviour
{
    //public Texture2D lastImage = null;
    public HashSet<Vector3> points = new HashSet<Vector3>();
    //public List<Vector3> lidarpoints = new List<Vector3>();
    //public int x = 5;
    void Update()
    {
        transform.Rotate(0,1,0);
        //Луч находится в том же положении и нацеливается в том же направлении, что и объект
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        //Испущенный луч заполняет информацией переменную, на которую имеется ссылка
        if (Physics.Raycast(ray, out hit))
        {
            //Загружаем в сообщение координаты точки, в которую попал луч
            points.Add(hit.point);
            //lidarpoints = points;
            Debug.DrawLine(transform.position, hit.point, Color.green);
            //Debug.Log("Hit " + points);
        }
        //lastImage.SetPixel(0, 2, new Color(0, 2, 0));
    }

    public int Check(int x)
    {
        var z = x;
        return z;
    }
}