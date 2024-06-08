using Assignment1.HelperClass;
using Assignment1.POJO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Assignment1.OptionClass
{
    /// <summary>
    /// This class saves commands to a text file.
    /// </summary>
    public class SaveCommand
    {
        /// <summary>
        /// Saves the commands to a text file.
        /// </summary>
        /// <param name="commands">The commands to be saved.</param>
        public void saveCommands(string commands)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.InitialDirectory = "C:\\";
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                       
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.Write(commands);
                        }

                        MessageBox.Show("File Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Logic for saving image in file
        /// </summary>
        /// <param name="panel">The panel to draw on</param>
        ///<param name="commands">The commands to draw</param> 

        public void saveImage(Panel panel, List<string> commands)
        {
            Bitmap bitmap = new Bitmap(panel.Width, panel.Height);

            using (Graphics g=Graphics.FromImage(bitmap))
            {
                Carrier carrier=new Carrier();
                carrier.Panel=panel;
                carrier.Graphics = g;
                carrier.Variables = new Dictionary<string, float>();
                carrier.MethodName = new Dictionary<string, (int, int)>();
                CommandParser parser = new CommandParser(carrier);
                string command = string.Join(" ", commands);
                MessageBox.Show(command);
                parser.runMultiCommand(command);
                
            }
            string filePath = "E:\\output.png";
            bitmap.Save(filePath);
            MessageBox.Show("Image Saved");
        }



    }

}

