
namespace Plex_PreRoll_Path_Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Folder_Select_Button = new Button();
            Selected_Folder_TextBox = new TextBox();
            File_Viewer_Button = new Button();
            Create_File_Button = new Button();
            SuspendLayout();
            // 
            // Folder_Select_Button
            // 
            Folder_Select_Button.Location = new Point(12, 12);
            Folder_Select_Button.Name = "Folder_Select_Button";
            Folder_Select_Button.Size = new Size(138, 51);
            Folder_Select_Button.TabIndex = 1;
            Folder_Select_Button.Text = "Choose Folder";
            Folder_Select_Button.UseVisualStyleBackColor = true;
            Folder_Select_Button.Click += button1_Click;
            // 
            // Selected_Folder_TextBox
            // 
            Selected_Folder_TextBox.Location = new Point(156, 19);
            Selected_Folder_TextBox.Multiline = true;
            Selected_Folder_TextBox.Name = "Selected_Folder_TextBox";
            Selected_Folder_TextBox.ReadOnly = true;
            Selected_Folder_TextBox.Size = new Size(303, 44);
            Selected_Folder_TextBox.TabIndex = 2;
            // 
            // File_Viewer_Button
            // 
            File_Viewer_Button.Location = new Point(156, 90);
            File_Viewer_Button.Name = "File_Viewer_Button";
            File_Viewer_Button.Size = new Size(138, 51);
            File_Viewer_Button.TabIndex = 4;
            File_Viewer_Button.Text = "View File";
            File_Viewer_Button.UseVisualStyleBackColor = true;
            File_Viewer_Button.Visible = false;
            File_Viewer_Button.Click += File_Viewer_Button_Click;
            // 
            // Create_File_Button
            // 
            Create_File_Button.Location = new Point(156, 90);
            Create_File_Button.Name = "Create_File_Button";
            Create_File_Button.Size = new Size(138, 51);
            Create_File_Button.TabIndex = 5;
            Create_File_Button.Text = "Create File";
            Create_File_Button.UseVisualStyleBackColor = true;
            Create_File_Button.Visible = false;
            Create_File_Button.Click += Create_File_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 153);
            Controls.Add(Create_File_Button);
            Controls.Add(File_Viewer_Button);
            Controls.Add(Selected_Folder_TextBox);
            Controls.Add(Folder_Select_Button);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PreRoll Path Generator";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Button Folder_Select_Button;
        private TextBox Selected_Folder_TextBox;
        private Button File_Viewer_Button;
        private Button Create_File_Button;
    }
}
