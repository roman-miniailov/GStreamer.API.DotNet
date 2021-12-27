// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp.GstreamerSharp
{
    using System;

    using Gst;

    public class ObjectManager
    {
        static bool initialized = false;

        // Call this method from the appropriate module init function.
        public static void Initialize()
        {
            if (initialized)
            {
                return;
            }

            initialized = true;

            try
            {
                GLib.GType.Register(Gst.App.AppSink.GType, typeof(Gst.App.AppSink));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Audio.AudioBaseSink.GType, typeof(Gst.Audio.AudioBaseSink));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Audio.AudioBaseSrc.GType, typeof(Gst.Audio.AudioBaseSrc));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Audio.AudioCdSrc.GType, typeof(Gst.Audio.AudioCdSrc));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Audio.AudioClock.GType, typeof(Gst.Audio.AudioClock));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Audio.AudioDecoder.GType, typeof(Gst.Audio.AudioDecoder));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Audio.AudioEncoder.GType, typeof(Gst.Audio.AudioEncoder));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Audio.AudioFilter.GType, typeof(Gst.Audio.AudioFilter));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            
            try
            {
                GLib.GType.Register(Gst.Audio.AudioRingBuffer.GType, typeof(Gst.Audio.AudioRingBuffer));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Audio.AudioSink.GType, typeof(Gst.Audio.AudioSink));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Audio.AudioSrc.GType, typeof(Gst.Audio.AudioSrc));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Base.Adapter.GType, typeof(Gst.Base.Adapter));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Base.Aggregator.GType, typeof(Gst.Base.Aggregator));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Base.AggregatorPad.GType, typeof(Gst.Base.AggregatorPad));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Base.BaseParse.GType, typeof(Gst.Base.BaseParse));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Base.BaseSink.GType, typeof(Gst.Base.BaseSink));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Base.BaseSrc.GType, typeof(Gst.Base.BaseSrc));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Base.BaseTransform.GType, typeof(Gst.Base.BaseTransform));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Base.CollectPads.GType, typeof(Gst.Base.CollectPads));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Base.DataQueue.GType, typeof(Gst.Base.DataQueue));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Base.PushSrc.GType, typeof(Gst.Base.PushSrc));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Controller.ARGBControlBinding.GType, typeof(Gst.Controller.ARGBControlBinding));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Controller.DirectControlBinding.GType, typeof(Gst.Controller.DirectControlBinding));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Controller.InterpolationControlSource.GType, typeof(Gst.Controller.InterpolationControlSource));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Controller.LFOControlSource.GType, typeof(Gst.Controller.LFOControlSource));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Controller.ProxyControlBinding.GType, typeof(Gst.Controller.ProxyControlBinding));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Controller.TimedValueControlSource.GType, typeof(Gst.Controller.TimedValueControlSource));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Controller.TriggerControlSource.GType, typeof(Gst.Controller.TriggerControlSource));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Net.NetClientClock.GType, typeof(Gst.Net.NetClientClock));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Net.NetTimeProvider.GType, typeof(Gst.Net.NetTimeProvider));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Net.PtpClock.GType, typeof(Gst.Net.PtpClock));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.AudioVisualizer.GType, typeof(Gst.PbUtils.AudioVisualizer));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.Discoverer.GType, typeof(Gst.PbUtils.Discoverer));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.DiscovererAudioInfo.GType, typeof(Gst.PbUtils.DiscovererAudioInfo));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.DiscovererContainerInfo.GType, typeof(Gst.PbUtils.DiscovererContainerInfo));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.DiscovererInfo.GType, typeof(Gst.PbUtils.DiscovererInfo));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.DiscovererStreamInfo.GType, typeof(Gst.PbUtils.DiscovererStreamInfo));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.DiscovererSubtitleInfo.GType, typeof(Gst.PbUtils.DiscovererSubtitleInfo));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.DiscovererVideoInfo.GType, typeof(Gst.PbUtils.DiscovererVideoInfo));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.EncodingAudioProfile.GType, typeof(Gst.PbUtils.EncodingAudioProfile));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.EncodingContainerProfile.GType, typeof(Gst.PbUtils.EncodingContainerProfile));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.EncodingProfile.GType, typeof(Gst.PbUtils.EncodingProfile));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.EncodingTarget.GType, typeof(Gst.PbUtils.EncodingTarget));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.PbUtils.EncodingVideoProfile.GType, typeof(Gst.PbUtils.EncodingVideoProfile));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Rtp.RTPBaseAudioPayload.GType, typeof(Gst.Rtp.RTPBaseAudioPayload));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Rtp.RTPBaseDepayload.GType, typeof(Gst.Rtp.RTPBaseDepayload));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Rtp.RTPBasePayload.GType, typeof(Gst.Rtp.RTPBasePayload));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Tags.TagDemux.GType, typeof(Gst.Tags.TagDemux));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Tags.TagMux.GType, typeof(Gst.Tags.TagMux));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Video.ColorBalanceChannel.GType, typeof(Gst.Video.ColorBalanceChannel));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Video.VideoAggregator.GType, typeof(Gst.Video.VideoAggregator));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Video.VideoAggregatorConvertPad.GType, typeof(Gst.Video.VideoAggregatorConvertPad));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Video.VideoAggregatorPad.GType, typeof(Gst.Video.VideoAggregatorPad));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Video.VideoBufferPool.GType, typeof(Gst.Video.VideoBufferPool));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Video.VideoDecoder.GType, typeof(Gst.Video.VideoDecoder));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Video.VideoEncoder.GType, typeof(Gst.Video.VideoEncoder));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Video.VideoFilter.GType, typeof(Gst.Video.VideoFilter));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.Video.VideoSink.GType, typeof(Gst.Video.VideoSink));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.WebRTC.WebRTCDTLSTransport.GType, typeof(Gst.WebRTC.WebRTCDTLSTransport));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.WebRTC.WebRTCDataChannel.GType, typeof(Gst.WebRTC.WebRTCDataChannel));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.WebRTC.WebRTCICETransport.GType, typeof(Gst.WebRTC.WebRTCICETransport));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.WebRTC.WebRTCRTPReceiver.GType, typeof(Gst.WebRTC.WebRTCRTPReceiver));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.WebRTC.WebRTCRTPSender.GType, typeof(Gst.WebRTC.WebRTCRTPSender));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            try
            {
                GLib.GType.Register(Gst.WebRTC.WebRTCRTPTransceiver.GType, typeof(Gst.WebRTC.WebRTCRTPTransceiver));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }
    }
}