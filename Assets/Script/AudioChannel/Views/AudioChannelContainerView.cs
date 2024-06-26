using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AudioChannel.Views
{
    public class AudioChannelContainerView : MonoBehaviour, IAudioChannelContainerView
    {
        [SerializeField] private GameObject _audioChannelSource;
        [SerializeField, Range(8, 24)] private int _audioChannelsSize;
        public int AudioChannelsSize => _audioChannelsSize;
        public GameObject AudioChannelSource => _audioChannelSource;
        public Transform Transform => transform;
    }

}
