using System.Diagnostics;

namespace Plex_PreRoll_Path_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string txt_File_Path;
        private List<string> file_Paths = new List<string>();

        private void Folder_Select_Button_Click(object sender, EventArgs e)
        {
            File_Viewer_Button.Visible = false; // Hides the file viewer button initially.
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select a folder"; // Sets the dialog's description.

                DialogResult result = dialog.ShowDialog(); // Displays the dialog and waits for user action.

                if (result == DialogResult.OK) // Checks if the user clicked the OK button.
                {
                    string selected_Path = dialog.SelectedPath; // Retrieves the path of the selected folder.
                    Selected_Folder_TextBox.Text = selected_Path; // Displays the selected path in the TextBox.
                }
            }
            Create_File_Button.Visible = true; // Makes the create file button visible after a folder is selected.
        }
        private void Create_File_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the files from the selected folder
                string[] files = Directory.GetFiles(Selected_Folder_TextBox.Text);
                txt_File_Path = Selected_Folder_TextBox.Text;
                txt_File_Path = Path.GetFullPath(Path.Combine(txt_File_Path, @"..\PreRoll Path.txt"));  // Combine with parent directory to create the file path
                // Create the file (this step creates an empty file)
                using (FileStream fs = File.Create(txt_File_Path))                  
                {
                    // Just creating the file;
                }
                foreach (string file_Path in files)                 // Populate the list with file paths
                {
                    file_Paths.Add(file_Path);
                }
                // Write the paths to the file
                using (StreamWriter sw = new StreamWriter(txt_File_Path)) // Create a StreamWriter to write to the file
                {
                    foreach (string path in file_Paths)
                    {
                        sw.Write(path + ";"); // Write each path followed by a semicolon
                    }
                }
                MessageBox.Show("File paths written successfully to: " + txt_File_Path);
                File_Viewer_Button.Visible = true;
                Create_File_Button.Visible = false;
            }
            catch (Exception ex)
            {
                // Optionally handle the exception (e.g., log it or show a message)
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void File_Viewer_Button_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(txt_File_Path) { UseShellExecute = true }); //Opens the 'PreRoll.txt' file that has just been generated or modified
        }
    }
}
