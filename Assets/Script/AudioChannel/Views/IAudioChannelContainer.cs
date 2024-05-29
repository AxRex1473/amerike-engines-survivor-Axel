using System.Collections.Generic;
using UnityEngine;

namespace AudioChannel.Views
{
    public interface IAudioChannelContainerView
    {
        int AudioChannelsSize { get; }
        GameObject AudioChannelSource { get; }
        Transform Transform { get; }
    }
}
