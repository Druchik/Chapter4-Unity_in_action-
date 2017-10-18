using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lidar : MonoBehaviour
{
    
    //public List<Vector3> points = new List<Vector3>();
   // private List _points;
    void Update()
    {
        //Луч находится в том же положении и нацеливается в том же направлении, что и объект
        //Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        float angle = Mathf.LerpUnclamped(0, 360, 1);
        for (int i = 0; i <= 360; i++)
        {
             Vector3 fwd = transform.TransformDirection(Quaternion.Euler(0, i, 0) * Vector3.forward);
            //Испущенный луч заполняет информацией переменную, на которую имеется ссылка
            if (Physics.Raycast(transform.position, fwd, out hit))
            {
                //Загружаем в сообщение координаты точки, в которую попал луч
                //points.Add(hit.point);
                Debug.DrawLine(transform.position, hit.point, Color.green);
                Debug.Log("Hit " + hit.point);
            }
        }
    }
}