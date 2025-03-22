using UnityEngine;

namespace Game.Object
{
    public class TestObject : BaseObject
    {
        private float _time = 0f;

        public void Update()
        {
            _time += Time.deltaTime;
            this.transform.position = Vector3.up * Mathf.Sin(_time);
        }
    }
}