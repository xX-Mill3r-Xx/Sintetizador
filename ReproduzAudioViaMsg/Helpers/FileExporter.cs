using System.IO;
using System.Windows.Forms;

namespace ReproduzAudioViaMsg.Helpers
{
    public class FileExporter
    {
        public static string ShowSaveDialog(string defaultFileName = "audio_sintetizado.wav")
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Arquivos de Áudio WAV (.wav) | *.wav";
                saveDialog.Title = "Salvar áudio como...";
                saveDialog.FileName = defaultFileName;

                return saveDialog.ShowDialog() == DialogResult.OK ? saveDialog.FileName : null;
            }
        }

        public static bool ValidateAndCreateDirectory(string filePath)
        {
            string directory = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(directory))
            {
                DialogResult result = MessageBox.Show($"O diretório '{directory}' não existe.\n\nDeseja criá-lo?",
                            "Diretório não encontrado.",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Directory.CreateDirectory(directory);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                return false;
            }
            return true;
        }

        public static void ShowSucessMessage(string filePath)
        {
            MessageBox.Show($"Arquivo exportado com sucesso!\n\nLocal: {filePath}",
                        "Exportação concluída.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

            DialogResult openFolder = MessageBox.Show(
                        "Deseja abrir a pasta onde o arquivo foi salvo?",
                        "Abrir pasta.",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (openFolder == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{filePath}\"");
            }
        }
    }
}
