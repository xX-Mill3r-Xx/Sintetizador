using ReproduzAudioViaMsg.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ReproduzAudioViaMsg.Services
{
    public class SpeechService : ISpeechService, IDisposable
    {
        #region Properties

        private readonly SpeechSynthesizer _synthesizer;
        private bool _diposed = false;

        public event EventHandler<SpeakProgressEventArgs> SpeakProgress;
        public event EventHandler<SpeakStartedEventArgs> SpeakStarted;
        public event EventHandler<SpeakCompletedEventArgs> SpeakCompleted;

        #endregion

        #region Constructors

        public SpeechService()
        {
            _synthesizer = new SpeechSynthesizer();
            ConfigurarEvents();
        }

        #endregion

        private void ConfigurarEvents()
        {
            _synthesizer.SpeakProgress += (s, e) => SpeakProgress?.Invoke(s, e);
            _synthesizer.SpeakStarted += (s, e) => SpeakStarted?.Invoke(s, e);
            _synthesizer.SpeakCompleted += (s, e) => SpeakCompleted?.Invoke(s, e);
        }

        public IEnumerable<InstalledVoice> GetInstalledVoices()
        {
            return _synthesizer.GetInstalledVoices();
        }

        public void SetVoice(string nomeVoz)
        {
            if (!string.IsNullOrEmpty(nomeVoz))
            {
                _synthesizer.SelectVoice(nomeVoz);
            }
        }

        public void SetRate(int rate)
        {
            _synthesizer.Rate = rate;
        }

        public void SetVolume(int volume)
        {
            _synthesizer.Volume = volume;
        }

        public void SpeakAsync(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                _synthesizer.SetOutputToDefaultAudioDevice();
                _synthesizer.SpeakAsync(texto);
            }
        }

        public void CancelAll()
        {
            _synthesizer.SpeakAsyncCancelAll();
        }

        public void ExportToFile(string texto, string filePath)
        {
            if (string.IsNullOrEmpty(texto) || string.IsNullOrEmpty(filePath))
            {
                using (var synthetizer = new SpeechSynthesizer())
                {
                    synthetizer.SelectVoice(_synthesizer.Voice.Name);
                    synthetizer.Rate = _synthesizer.Rate;
                    synthetizer.Volume = _synthesizer.Volume;
                    synthetizer.SetOutputToWaveFile(filePath);
                    synthetizer.Speak(texto);
                    synthetizer.SetOutputToDefaultAudioDevice();
                }
            }
        }

        public void Dispose()
        {
            if (!_diposed)
            {
                _synthesizer?.Dispose();
                _diposed = true;
            }
        }
    }
}
