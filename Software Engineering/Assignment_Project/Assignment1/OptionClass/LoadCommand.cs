using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment1.OptionClass
{
    /// <summary>
    /// This class loads commands from a file into a multiline textbox.
    /// </summary>
    public class LoadCommand
    {
        /// <summary>
        /// Opens the file explorer to load commands into a textbox.
        /// </summary>
        /// <param name="textBox">Textbox to load the commands.</param>
        public void loadAllCommands(TextBox textBox)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "C:\\";
                    openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                       
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            textBox.Text = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
