using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lidar : MonoBehaviour
{
    void Update()
    {
        //Луч находится в том же положении и нацеливается в том же направлении, что и объект
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        //Испущенный луч заполняет информацией переменную, на которую имеется ссылка
        if (Physics.Raycast(ray, out hit))
        {
            //Загружаем в сообщение координаты точки, в которую попал луч
            Debug.Log("Hit " + hit.point);
        }
    }
}