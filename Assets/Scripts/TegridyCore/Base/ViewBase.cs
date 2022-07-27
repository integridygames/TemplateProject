using System;
using UnityEngine;

namespace TegridyCore.Base
{
    public abstract class ViewBase : MonoBehaviour
    {
        [SerializeField] private bool _asTransient;

        public bool AsTransient => _asTransient;
        
        public event Action OnShow;
        
        public event Action OnHide;
        
        protected virtual void OnEnable()
        {
            OnShow?.Invoke();
        }
        
        protected virtual void OnDisable()
        {
            OnHide?.Invoke();
        }
    }
}