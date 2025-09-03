using ReproduzAudioViaMsg.Contracts;
using ReproduzAudioViaMsg.Helpers;
using ReproduzAudioViaMsg.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;
namespace ReproduzAudioViaMsg
{
    public partial class FrmPrincipal : Form
    {
        #region Properties

        private readonly ISpeechService _speechService;
        private readonly TextHighlighter _textHighlighter;
        private InstalledVoice _selectedVoice;

        #endregion

        #region Constructors

        public FrmPrincipal()
        {
            InitializeComponent();

            _speechService = new SpeechService();
            _textHighlighter = new TextHighlighter(txt_Texto);
            ConfigureSpeechEvents();

        }

        #endregion

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadVoices();
            if (cbVoices.Items.Count > 0)
            {
                cbVoices.SelectedIndex = 0;
            }
        }

        private void ConfigureSpeechEvents()
        {
            _speechService.SpeakProgress += OnSpeakProgress;
            _speechService.SpeakStarted += OnSpeakStarted;
            _speechService.SpeakCompleted += OnSpeakCompleted;
        }

        private void _speechService_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadVoices()
        {
            var voices = _speechService.GetInstalledVoices();
            cbVoices.Items.Clear();
            foreach (var voice in voices)
            {
                cbVoices.Items.Add(voice.VoiceInfo.Name);
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GenerateSpeech();
        }

        private void GenerateSpeech()
        {
            string text = txt_Texto.Text;
            if (string.IsNullOrEmpty(text) || _selectedVoice == null)
            {
                string titulo = "Aviso!";
                string msg = "Digite um texto e selecione uma voz!";
                MessageSpeak.ShowMessageAndSpeakWarning(msg, titulo, _speechService);

                return;
            }

            _speechService.CancelAll();
            _textHighlighter.RemoveHighlight();

            _speechService.SetVoice(_selectedVoice.VoiceInfo.Name);
            _speechService.SetRate(tracVelocidade.Value);
            _speechService.SetVolume(trackVolume.Value);
            _speechService.SpeakAsync(text);
        }

        private void cbVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVoices.SelectedItem != null)
            {
                string voiceName = cbVoices.SelectedItem.ToString();
                var voices = _speechService.GetInstalledVoices();
                _selectedVoice = voices.FirstOrDefault(v => v.VoiceInfo.Name == voiceName);
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            trackVolume.Value = 70;
        }

        private void btnVelocidade_Click(object sender, EventArgs e)
        {
            tracVelocidade.Value = 6;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _speechService.CancelAll();
            _textHighlighter.RemoveHighlight();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarAudio();
        }

        private void ExportarAudio()
        {
            string text = txt_Texto.Text; ;
            if (string.IsNullOrEmpty(text))
            {
                string title = "Atenção!";
                string msg = "Digite um texto para exportar!";
                MessageSpeak.ShowMessageAndSpeakInformation(msg, title, _speechService);

                return;
            }

            if (_selectedVoice == null)
            {
                string title = "Atenção!";
                string msg = "Selecione uma voz antes de exportar";
                MessageSpeak.ShowMessageAndSpeakInformation(msg, title, _speechService);

                return;
            }

            string filePath = FileExporter.ShowSaveDialog();
            if (string.IsNullOrEmpty(filePath))
                return;

            if (!FileExporter.ValidateAndCreateDirectory(filePath))
                return;

            try
            {
                pbProgresso.Style = ProgressBarStyle.Marquee;
                pbProgresso.Visible = true;

                _speechService.SetVoice(_selectedVoice.VoiceInfo.Name);
                _speechService.SetRate(tracVelocidade.Value);
                _speechService.SetVolume(trackVolume.Value);
                _speechService.ExportToFile(text, filePath);

                FileExporter.ShowSucessMessage(filePath);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExportException(ex);
            }
            finally
            {
                pbProgresso.Style = ProgressBarStyle.Blocks;
                pbProgresso.Visible = false;
            }
        }

        private void OnSpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => OnSpeakProgress(sender, e)));
                return;
            }

            try
            {
                _textHighlighter.RemoveHighlight();
                _textHighlighter.ApplyHighlight(e.CharacterPosition, e.Text.Length);
                _textHighlighter.ScrollToPosition(e.CharacterPosition);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OnSpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => OnSpeakStarted(sender, e)));
                return;
            }
        }

        private void OnSpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => OnSpeakCompleted(sender, e)));
                return;
            }

            _textHighlighter.RemoveHighlight();
        }

        
    }
}
