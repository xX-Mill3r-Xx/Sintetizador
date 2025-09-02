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
        void SetVoice(string nomeVoz);
        void SetRate(int rate);
        void SetVolume(int volume);
        void SpeakAsync(string texto);
        void CancelAll();
        void ExportToFile(string texto, string filePath);
        void Dispose();
    }
}
