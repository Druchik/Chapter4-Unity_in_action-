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
        }
        //Debug.Log(_player.transform.position);
        //Если лидара нет, то содаем, каждый раз поворачивая его в новом направлении
        /*if (_lidar == null)
        {
            _lidar = Instantiate(_lidarPrefab) as GameObject;
            _lidar.transform.position = new Vector3(0, 1, 0);
        }*/
    }
} 

