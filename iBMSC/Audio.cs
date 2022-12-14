using System.IO;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

internal static class Audio
{
    private static WasapiOut Output;
    private static IWaveSource Source;

    public static void Initialize()
    {
        Output = new WasapiOut();
        CodecFactory.Instance.Register("ogg",
            new CodecFactoryEntry(s => new NVorbisSource(s).ToWaveSource(), ".ogg"));
    }

    public static void Finalize()
    {
        Output.Stop();
        Output.Dispose();
        Output = null;
    }

    public static string CheckFilename(string filename)
    {
        if (File.Exists(filename))
        {
            return filename;
        }

        string extension = Path.GetExtension(filename);
        if (string.Compare(extension, ".ogg") == 0)
        {
            string text = Path.ChangeExtension(filename, ".wav");
            return Conversions.ToString(Interaction.IIf(File.Exists(text), text, filename));
        }

        if (string.Compare(extension, ".wav") == 0)
        {
            string text2 = Path.ChangeExtension(filename, ".ogg");
            return Conversions.ToString(Interaction.IIf(File.Exists(text2), text2, filename));
        }

        return filename;
    }

    public static void Play(string filename)
    {
        if (Source != null)
        {
            Output.Stop();
            Source.Dispose();
            Source = null;
        }

        if ((object)filename != "")
        {
            string text = CheckFilename(filename);
            if (File.Exists(text))
            {
                Source = CodecFactory.Instance.GetCodec(text);
                Output.Initialize(Source);
                Output.Play();
            }
        }
    }

    public static void StopPlaying()
    {
        Output.Stop();
    }
}