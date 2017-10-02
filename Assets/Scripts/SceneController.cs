using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    //Создаем сериализованные переменные лидара и игрока
    [SerializeField] private GameObject _lidarPrefab;
    private GameObject _lidar;
    [SerializeField] private GameObject _playerPrefab;
    private GameObject _player;
    void Update()
    {
        //Если игрока нет на сцене, то создаем его
        if (_player == null)
        {
            _player = Instantiate(_playerPrefab) as GameObject;
            _player.transform.position = new Vector3(0, 1, -11);
            //Каждый раз поворачиваем игрока в новом направлении
            float angle = Random.Range(0, 360);
            _player.transform.Rotate(0, angle, 0);
            Camera.main.fieldOfView = Random.Range(10, 60);
        }

        //Если лидара нет, то содаем, каждый раз поворачивая его в новом направлении
        if (_lidar == null)
        {
            _lidar = Instantiate(_lidarPrefab) as GameObject;
            _lidar.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            _lidar.transform.Rotate(0, angle, 0);
        }
    }
} 

