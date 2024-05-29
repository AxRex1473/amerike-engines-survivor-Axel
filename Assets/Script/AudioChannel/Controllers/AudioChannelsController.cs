using AudioChannel.Views;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace AudioChannel.Controllers
{
    public class AudioChannelsController : IAudioChannelsController
    {
        private IAudioChannelContainerView _audioChannelContainerView;
        private List<AudioSource> _audioChannels;

        private NativeArray<int> instaceIds;
        private NativeArray<int> TransformIds;

        public AudioChannelsController(IAudioChannelContainerView audioChannelContainerView) 
        {
            _audioChannelContainerView = audioChannelContainerView;
            _audioChannels = new List<AudioSource>();
            InitializeChannels();
        }

        private void InitializeChannels()
        {
            var audioChannelSize = _audioChannelContainerView.AudioChannelsSize;

            instaceIds = new NativeArray<int>(audioChannelSize, Allocator.Persistent);
            TransformIds = new NativeArray<int>(audioChannelSize, Allocator.Persistent);

            GameObject.InstantiateGameObjects(_audioChannelContainerView.AudioChannelSource.GetInstanceID(), audioChannelSize, instaceIds, TransformIds);
            //_audioChannels.Add(new AudioSource());

            for (int i = 0; i < _audioChannelContainerView.AudioChannelsSize; i++)
            {
            }
        }
    }
}