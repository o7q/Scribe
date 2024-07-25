<img src="assets/images/banner.png" width="50%">

![Total Downloads](https://img.shields.io/github/downloads/o7q/Scribe/total?logo=github&label=Total%20Downloads&color=%232fd653)
![Code Size](https://img.shields.io/github/languages/code-size/o7q/Scribe?logo=github&label=Code%20Size&color=%23b65cff)


# [<b>>> Download Latest</b>](https://github.com/o7q/Scribe/releases/latest/download/Scribe.exe)
### Welcome! Scribe is a simple, compact, offline, GUI based media transcriber that enables you to search for local media content based on its spoken words.

---

<img src="assets/images/program.png">

---

# Overview
Scribe uses OpenAI's whisper model to process audio files.\
FFmpeg is used beforehand to handle a wide variety of media formats.

### **Powered by**
stable-ts: https://github.com/jianfch/stable-ts \
FFmpeg: https://ffmpeg.org

---

# Installation

1. Ensure you have Python 3.9 or 3.10 installed (not tested on newer versions) \
You can check your version by typing this command:
```powershell
python --version
```
2. Download the bootstrapper from https://github.com/o7q/Scribe/releases
3. Select your preferred device type (CPU or CUDA) \
You can check your CUDA version by typing this command:
```
nvidia-smi
```
4. Click install and wait for it to complete

<br>

# Side Note
By default, Scribe configures FFmpeg in the `PATH` environment variable. If you are having issues with Scribe not working correctly, check if FFmpeg was added to the `PATH` environment variable correctly.

---

## **Interface**

<details>
<summary><b>Selection</b></summary>

- **Add Folder** Adds a watch folder to scan from
- **Remove Folder** Removes the selected watch folder
- **Filetypes** Filetypes formats to scan for (separate with a comma)
- **Scan Subdirectories** Enable the scanning of subdirectories

</details>

<details>
<summary><b>Processing</b></summary>

- **Start With Windows** Makes the program start with your computer
- **Auto Update** Enable the automatic processing of watch folders
- **Use GPU (CUDA)** Enable the usage of supported NVIDIA CUDA GPUs
- **Model** The model for the whisper speech-to-text algorithm (default is: **small**)
- **Language** The language for the whisper speech-to-text algorithm (default is: **English**)
- **Media Buffer** The amount of media files Scribe will buffer before finalizing, the higher the number the faster the processing, but **I wouldn't recommend going above 30** because of limitations relating the the Windows Command Prompt. (this because the max command length is 8191)
- **Debug** Enable debug/verbose mode, this will display all intermediate steps during processing
- **Update** Manually process media
- **Abort** Cancels the process
- **Clean** Cleans storage files that no longer have the corresponding media file tied to it, it also cleans temporary files

</details>

<details>
<summary><b>Searching</b></summary>

- **Phrase Search** The phrase to search for
- **File Search** The specific file to search for (leave blank to show all files that contain the phrase)
- **Search** Searches with the specified settings
- **Auto Update** Automatically updates the search without having to click the **Search Button**
- **Case Sensitive** Enable case sensitivity
- **Open File** Opens the selected file
- **Browse File** Browses to the selected file in Windows Explorer

</details>

<details>
<summary><b>Viewing</b></summary>

- **View Panel** This will display all of the written text as well as their timestamps of the selection media, it will highlight every occurrence of the searched phrase

</details>

---

**Scribe** \
Written in C# using .NET 8.0