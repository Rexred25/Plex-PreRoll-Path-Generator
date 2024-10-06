# PreRoll Path Generator

## Description
This program generates a text file named **"PreRoll Path.txt"** after the user selects a folder containing files to use as prerolls within Plex.

## Requirements
- .NET 8.0 Desktop Runtime
  - The program will prompt the user to install the .NET runtime if it is not already present on the PC.

## Usage
1. Launch the program.
2. Click the "Choose Folder" button to select a folder containing the desired video files.
3. Click the "Create File" button to create a file named **"PreRoll Path.txt"** in the parent directory of the selected folder.
4. Optionally, click the "View File" button to open **"PreRoll Path.txt."**

## Output Format
The text within the **"PreRoll Path.txt"** file will be formatted as a single line, with each file path separated by a semicolon (`;`). An example of the file contents is shown below:

C:/Users/username/Videos/preroll_1.mp4;C:/Users/username/Videos/preroll_2.mp4;C:/Users/username/Videos/preroll_3.mp4;C:/Users/username/Videos/preroll_4.mp4;

## Notes
- Ensure that the selected folder contains the files you want to include as prerolls.
- The generated text file will contain absolute paths to the video files, making it easy to reference them in Plex.
- **Every time the program is run, it generates a fresh 'PreRoll Path.txt' file, removing any previous version.**

