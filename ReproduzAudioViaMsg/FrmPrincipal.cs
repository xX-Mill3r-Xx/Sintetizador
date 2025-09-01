using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ReproduzAudioViaMsg
{
    public partial class FrmPrincipal : Form
    {
        #region Properties

        private InstalledVoice selecionarVoz;
        SpeechSynthesizer _synthesizer;

        private int posicaoAtualPalavra = 0;
        private int tamanhoPalavraAtual = 0;
        private Color corOriginalFundo;
        private Color corOriginalTexto;
        private bool destacoAtivo = false;

        #endregion

        #region Constructors

        public FrmPrincipal()
        {
            InitializeComponent();
            _synthesizer = new SpeechSynthesizer();
            ConfigurarEventoSpeech();
            ConfigurarTextBox();
            
        }

        #endregion

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CarregarVozes();
            if (cbVoices.Items.Count > 0)
            {
                cbVoices.SelectedIndex = 0;
            }
        }

        private void ConfigurarEventoSpeech()
        {
            _synthesizer.SpeakProgress += OnSpeakProgress;
            _synthesizer.SpeakStarted += OnSpeakStarted;
            _synthesizer.SpeakCompleted += OnSpeakCompleted;
        }

        private void ConfigurarTextBox()
        {
            corOriginalFundo = txt_Texto.BackColor;
            corOriginalTexto = txt_Texto.ForeColor;

            if (txt_Texto is RichTextBox)
            {
                ((RichTextBox)txt_Texto).DetectUrls = false;
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Gerar();

        }

        private void Gerar()
        {
            string texto = txt_Texto.Text;
            if (!string.IsNullOrEmpty(texto) && selecionarVoz != null)
            {

                _synthesizer.SpeakAsyncCancelAll();
                RemoverDestaque();

                _synthesizer.SetOutputToDefaultAudioDevice();
                _synthesizer.SelectVoice(selecionarVoz.VoiceInfo.Name);
                _synthesizer.Rate = tracVelocidade.Value;
                _synthesizer.Volume = trackVolume.Value;
                _synthesizer.SpeakAsync(texto);
            }
            else
            {
                MessageBox.Show("Digite um texto e selecione uma voz!",
                    "Aviso!",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }

        private void CarregarVozes()
        {
            var vozes = _synthesizer.GetInstalledVoices();
            cbVoices.Items.Clear();
            foreach (var voz in vozes)
            {
                cbVoices.Items.Add(voz.VoiceInfo.Name);
            }
        }

        private void cbVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVoices.SelectedItem != null)
            {
                string nomeVoz = cbVoices.SelectedItem.ToString();
                var vozes = _synthesizer.GetInstalledVoices();
                selecionarVoz = vozes.FirstOrDefault(v => v.VoiceInfo.Name == nomeVoz);
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

            _synthesizer.SpeakAsyncCancelAll();
            RemoverDestaque();
            destacoAtivo = false;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            pbProgresso.Style = ProgressBarStyle.Marquee;
            pbProgresso.Visible = true;

            ExportarAudio();

            pbProgresso.Style = ProgressBarStyle.Blocks;
            pbProgresso.Visible = false;
        }

        private void ExportarAudio()
        {
            string texto = txt_Texto.Text; ;
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Digite um texto para exportar!");
                return;
            }

            if (selecionarVoz == null)
            {
                MessageBox.Show("Selecione uma voz antes de exportar");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivos de Áudio WAV (*.wav) | *.wav";
            saveDialog.Title = "Salvar áudio como ...";
            saveDialog.FileName = "audio_sintetizado.wav";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string caminhoArquivo = saveDialog.FileName;
                    string diretorio = Path.GetDirectoryName(caminhoArquivo);

                    if (!Directory.Exists(diretorio))
                    {
                        DialogResult resultado = MessageBox.Show($"O diretório '{diretorio}' não existe.\n\nDeseja criá-lo?",
                            "Diretório não encontrado.",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            Directory.CreateDirectory(diretorio);
                        }
                        else
                        {
                            return;
                        }
                    }

                    using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                    {
                        synthesizer.SelectVoice(selecionarVoz.VoiceInfo.Name);
                        synthesizer.Rate = tracVelocidade.Value;
                        synthesizer.Volume = trackVolume.Value;
                        synthesizer.SetOutputToWaveFile(caminhoArquivo);
                        synthesizer.Speak(texto);
                        synthesizer.SetOutputToDefaultAudioDevice();
                    }

                    MessageBox.Show($"Arquivo exportado com sucesso!\n\nLocal: {caminhoArquivo}",
                        "Exportação concluída.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult abrirPasta = MessageBox.Show("Deseja abrir a pasta onde o arquivo foi salvo?",
                        "Abrir pasta.",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (abrirPasta == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{caminhoArquivo}\"");
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Erro: Não há permissão para escrever neste local.\n\nTente escolher outro diretório",
                        "Erro de permissão",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Erro: Diretório expecificado não foi encontrado",
                        "Erro de diretório",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Erro de E/S: {ex.Message}\n\nVerifique se o arquivo não está sendo usado por outro programa.",
                        "Erro de E/S",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro inesperado: {ex.Message}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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
                RemoverDestaque();

                posicaoAtualPalavra = e.CharacterPosition;
                tamanhoPalavraAtual = e.Text.Length;

                AplicarDestaque(posicaoAtualPalavra, tamanhoPalavraAtual);
                destacoAtivo = true;

                ScrollParaPalavra(posicaoAtualPalavra);
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

            destacoAtivo = true;
        }

        private void OnSpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => OnSpeakCompleted(sender, e)));
                return;
            }

            RemoverDestaque();
            destacoAtivo = false;
        }

        private void AplicarDestaque(int posicao, int tamanho)
        {
            if (txt_Texto is RichTextBox richTextBox)
            {
                richTextBox.Select(posicao, tamanho);
                richTextBox.SelectionBackColor = Color.LightBlue;
                richTextBox.SelectionColor = Color.DarkBlue;

                richTextBox.Select(richTextBox.Text.Length, 0);
            }
            else
            {
                txt_Texto.Select(posicao, tamanho);
                txt_Texto.BackColor = Color.LightBlue;
            }
        }

        private void RemoverDestaque()
        {
            if (!destacoAtivo)
            {
                return;
            }

            if (txt_Texto is RichTextBox richTextBox)
            {
                richTextBox.SelectAll();
                richTextBox.SelectionBackColor = corOriginalFundo;
                richTextBox.SelectionColor = corOriginalTexto;

                richTextBox.Select(richTextBox.Text.Length, 0);
            }
            else
            {
                txt_Texto.BackColor= corOriginalFundo;
                txt_Texto.ForeColor= corOriginalTexto;
            }
        }

        private void ScrollParaPalavra(int posicao)
        {
            if (txt_Texto is RichTextBox richTextBox)
            {
                richTextBox.Select(posicao, 0);
                richTextBox.ScrollToCaret();
            }
            else if(txt_Texto.Multiline)
            {
                txt_Texto.Select(posicao, 0);
                txt_Texto.ScrollToCaret();
            }
        }
    }
}
