using System;
using System.IO;
using System.Windows.Forms;

namespace ReproduzAudioViaMsg.Helpers
{
    public class ExceptionHandler
    {
        public static void HandleExportException(Exception ex)
        {
            string message;
            string title;

            switch (ex)
            {
                case UnauthorizedAccessException _:
                    message = "Erro: Não há permissão para escrever neste local.\n\nTente escolher outro diretório";
                    title = "Erro de permissão";
                    break;

                case DirectoryNotFoundException _:
                    message = "Erro: Diretório expecificado não foi encontrado";
                    title = "Erro de diretório";
                    break;

                case IOException _:
                    message = $"Erro de E/S: {ex.Message}\n\nVerifique se o arquivo não está sendo usado por outro programa.";
                    title = "Erro de E/S";
                    break;

                default:
                    message = $"Erro inesperado: {ex.Message}";
                    title = "Erro";
                    break;
            }

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
