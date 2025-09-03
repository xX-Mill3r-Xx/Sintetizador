using ReproduzAudioViaMsg.Contracts;
using System.Windows.Forms;

namespace ReproduzAudioViaMsg.Helpers
{
    public class MessageSpeak
    {
        private static void MessageParamiters(string msg, string title, MessageBoxIcon icon, ISpeechService _speechService)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
            _speechService.SetRate(7);
            _speechService.SetVolume(100);
            _speechService.SpeakAsync(title);
            _speechService.SpeakAsync(msg);
        }

        public static void ShowMessageAndSpeakWarning(string msg, string title, ISpeechService _speechService, MessageBoxIcon icon = MessageBoxIcon.Warning)
        {
            MessageParamiters(msg, title, icon, _speechService);
        }

        public static void ShowMessageAndSpeakInformation(string msg, string title, ISpeechService _speechService, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            MessageParamiters(msg, title, icon, _speechService);
        }
    }
}
