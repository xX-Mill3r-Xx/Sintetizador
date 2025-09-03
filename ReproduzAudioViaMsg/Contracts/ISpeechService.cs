using System;
using System.Collections.Generic;
using System.Speech.Synthesis;

namespace ReproduzAudioViaMsg.Contracts
{
    public interface ISpeechService
    {
        event EventHandler<SpeakProgressEventArgs> SpeakProgress;
        event EventHandler<SpeakStartedEventArgs> SpeakStarted;
        event EventHandler<SpeakCompletedEventArgs> SpeakCompleted;

        IEnumerable<InstalledVoice> GetInstalledVoices();
        void SetVoice(string voiceName);
        void SetRate(int rate);
        void SetVolume(int volume);
        void SpeakAsync(string text);
        void CancelAll();
        void ExportToFile(string text, string filePath);
        void Dispose();
    }
}
