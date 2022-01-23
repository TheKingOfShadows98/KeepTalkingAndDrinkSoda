using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Tk.Dimensions{

    public class CameraAddCullingMask : MonoBehaviour
    {
        public static CameraAddCullingMask instance;
        [SerializeField] Camera cam;
        [SerializeField] private List<Dim> Dims;
        public void AddCullingMask(string dim)
        {
            Dims.Find(x => x.Equals(dim)).value().SetActive(true);
        }

        public void RemoveCullingMask(string dim)
        {
            Dims.Find(x => x.Equals(dim)).value().SetActive(false);
        }

        private void Awake()
        {
            instance = this;
        }

        void Start()
        {

            cam = Camera.main;


        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    [System.Serializable]
    public class Dim
    {
        [SerializeField]string _name;
        [SerializeField] GameObject _obj;
        public Dim(string name, GameObject obj)
        {
            _name = name;
            _obj = obj;
        }

        public bool Equals(string name) => _name == name;

        public bool isActive() => _obj;

        public GameObject value() => _obj;
    }
}