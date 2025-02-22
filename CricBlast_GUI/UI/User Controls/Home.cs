﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Policy;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using Ionic.Zip;
//using ZipFile = Ionic.Zip.ZipFile;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class Home : UserControl
    {
        public int SelectedMenu = 1;
        private bool _isAvailable = true;

        /* InterTok Vars: */
        /*                */
        public static string Game, Username, LocalLowAppdata, InterTokPath, GameFolderPath, GamePath;
        /*                */
        /* -------------- */

        public Home(string _Game, string _Username)
        {
            Game = _Game;
            Username = _Username;
            InitializeComponent();

            UpdateHomeLabels();
            ChangeButtonState(ConnectButton, false);
            ChangeButtonState(StartGameButton, false);
            ChangeButtonState(guna2Button4, false);
            GetFilePaths();

            string processName = "tiktokLiveApi.exe";
            string query = $"SELECT * FROM Win32_Process WHERE Name = '{processName}'";

            // Connect to WMI and execute the query
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    // Terminate the process
                    obj.InvokeMethod("Terminate", null);
                    Console.WriteLine($"Terminated process: {processName}");
                    Console.WriteLine("\n\nTerminated old API process.\n\n");
                }
            }
        }

        /* METHODS */
        private void UpdateHomeLabels()
        {
            Console.WriteLine("\n\n" + Username + "\n\n");
            this.usernameLabel.Text = Username;
        }

        private void ChangeButtonState(Guna2Button button, bool state)
        {
            button.Enabled = state; // Set the button as not clickable
        }
        private void ChangeButtonColor(Guna2Button button, int changeMenu)
        {
            button.FillColor = Color.FromArgb(246, 161, 47);
        }
        private void ChangeImageColor(Guna2CirclePictureBox picture, Color color)
        {
            picture.FillColor = color;
        }
        private void ChangeLabelText(Label label, string _Text)
        {
            label.Text = _Text;
        }
        private void ChangeButtonText(Guna2Button button, string _Text)
        {
            button.Text = _Text;
        }


        private void GetFilePaths()
        {
            LocalLowAppdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow");
            Console.Write("\n\n" + LocalLowAppdata + "\n\n");
            InterTokPath = Path.Combine(LocalLowAppdata, "InterTok\\");
            Console.Write("\n\n" + InterTokPath + "\n\n");
            GameFolderPath = InterTokPath + "TikTok." + Game + "\\";
            Console.Write("\n\n" + GameFolderPath + "\n\n");
            GamePath = GameFolderPath + "TikTok." + Game + ".exe";
            Console.Write("\n\n" + GamePath + "\n\n");

            if (!File.Exists(GamePath))
            {
                Directory.CreateDirectory(GameFolderPath);

                var threadParameters = new ThreadStart(() =>
                {
                    Invoke((Action)(() =>
                    {
                        new MessageBoxDownload("Game is not installed.", 0).ShowDialog();
                    }));
                });

                var thread = new Thread(threadParameters);
                thread.Start();
            }
        }



        /* BUTTON CLICKS */
        //private void Home_Load(object sender, EventArgs e)
        //{
        //    usernameLabel.Text = Selected.UserDetails[1];
        //    userPhoto.Image = Selected.UserImage;
        //}

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (StateLabel.Text == "Running")
            {
                BeginInvoke((Action)(() => {
                    new MessageBoxOk(Selected.ErrorMark, "Game is running, please stop it before updating", statusError: true).ShowDialog();
                }));
                return;
            }

            /* DELETE ALL GAME FILES */
            System.IO.DirectoryInfo di = new DirectoryInfo(GameFolderPath);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            /* REDOWNLOAD GAME FILES */
            Invoke((Action)(() =>
            {
                new MessageBoxDownload("Update game now?", 2).ShowDialog();
            }));
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new MessageBoxYesNo(1, "Are you sure you want to log out?").ShowDialog();
            if (!Selected.MessageBoxYesOrNo) return;

            //clearUserDetails();
            Controls.Clear();
            Controls.Add(new Welcome { welcomeLabel = { Text = "Welcome Back!" } });
        }


        private void userPhoto_Click(object sender, EventArgs e)
        {
            //usernameLabel.Text = Selected.UserDetails[1];
            //userPhoto.Image = Selected.UserImage;
        }

        private void GoLive_Click(object sender, EventArgs e)
        {
            ChangeButtonState(GoLiveButton, false);
            System.Threading.Thread.Sleep(1000);
            ChangeLabelText(StateLabel, "Live");
            ChangeImageColor(OnlineIcon, Color.Yellow);
            try
            {
                Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\TikTok LIVE Studio");
            }
            catch (Exception)
            {
                new MessageBoxOk(Selected.WarningMark, "Could not find TikTok Live Studio. Make sure to go live before connecting!", statusError: true).ShowDialog();
            }
            ChangeButtonState(ConnectButton, true);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            ChangeButtonState(ConnectButton, false);
            System.Threading.Thread.Sleep(1000);
            ChangeLabelText(StateLabel, "Connecting");
            Thread tiktokServerThread = new Thread(() => startTikTokApiLocalServer(Username, Welcome.key));
            tiktokServerThread.Start();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(300);
            ChangeLabelText(StateLabel, "Running");
            
            ChangeImageColor(OnlineIcon, Color.Green);
            ChangeButtonState(StartGameButton, false);


            Thread checkForGameQuit = new Thread(() =>
            {   
                if(!File.Exists(GamePath))
                {
                    new MessageBoxOk(Selected.WarningMark, "Game is not installed!").ShowDialog();
                    new ChooseTeam(Username, Welcome.GameList).ShowDialog();
                }
                else
                {
                    Process game = System.Diagnostics.Process.Start(GamePath);
                    game.WaitForExit();
                    BeginInvoke((Action)(() => {
                        ChangeImageColor(OnlineIcon, Color.Green);
                        ChangeButtonState(StartGameButton, true);
                    }));
                }
                
                

            });

            checkForGameQuit.Start();

        }


        private bool downloadComplete = true;
        private string installerPath;

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            if (StateLabel.Text == "Running")
            {
                BeginInvoke((Action)(() => {
                    new MessageBoxOk(Selected.ErrorMark, "Game is running, please stop it before updating", statusError: true).ShowDialog();
                }));
                return;
            }

            /* DELETE ALL GAME FILES */
            System.IO.DirectoryInfo di = new DirectoryInfo(GameFolderPath);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            /* REDOWNLOAD GAME FILES */
            Invoke((Action)(() =>
            {
                new MessageBoxDownload("Update game now?", 2).ShowDialog();
            }));
        }

        private void startTikTokApiLocalServer(string username, string key)
        {
            string apiPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tiktokLiveApi.exe");
            string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");
            installerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "installer.zip");


            Console.WriteLine("\n\n" + apiPath + "\n\n");
            Console.WriteLine(installerPath + "\n\n");

            if (!File.Exists(apiPath) || !File.Exists(ffmpegPath))
            {

                Console.WriteLine("Entered goofy ass if");

                if (File.Exists(apiPath))
                {
                    File.Delete(installerPath);
                }
                    
                else if (File.Exists(ffmpegPath))
                    File.Delete(ffmpegPath);

                string url;
                string pastebin = new WebClient().DownloadString("https://pastebin.com/raw/NsxaFHfZ");
                using (var reader = new StringReader(pastebin))
                {
                    url = reader.ReadLine();
                }

                Console.WriteLine("\n\n" + url + "\n\n");

                WebClient client = new WebClient();
                //client.DownloadProgressChanged += Client_DownloadProgressChanged;
                //client.DownloadFileCompleted += Client_DownloadFileCompleted;

                BeginInvoke((Action)(() =>
                {
                    new MessageBoxOk(Selected.WarningMark, "Downlading crucial assets. This could take some time, do not close the application!").ShowDialog();
                    ChangeLabelText(StateLabel, "Downloading assets");
                    downloadComplete = false;
                    Console.WriteLine("\n\nDOWNLOADING! \n\n");
                }));

                // Download tiktok api at "InterTokPath" 
                Thread thread = new Thread(() =>
                {
                    Uri uri = new Uri(url);
                    client.DownloadFile(uri, installerPath);
                });
                thread.Start();

                thread.Join();
                Download_Finished();
            }

            Console.WriteLine("DOWNLOAD COMPLETE: " + downloadComplete);

            
            Console.Write(AppDomain.CurrentDomain.BaseDirectory);

            Console.WriteLine("DOWNLOAD COMPLETE: " + downloadComplete);

            string successFile = Path.Combine(LocalLowAppdata, "InterTok", "TikTok." + Game, "success");
            if (File.Exists(successFile))
                File.Delete(successFile);

            

            foreach (var proc in Process.GetProcessesByName("tiktokLiveApi"))
            {
                proc.Kill();
            }


            Process process = new Process();
            process.StartInfo.FileName = $"{apiPath}"; // Replace with the path to your executable
            process.StartInfo.Arguments = $" {username} {key} {Game}"; // Replace with any command-line arguments

            process.Start();

            Thread.Sleep(500);

            bool firstConnectSuccess = false;
            Thread checkForSuccess = new Thread(() =>
            {
                Console.WriteLine("Success file: " + successFile);
                while (true)
                {
                    if (File.Exists(successFile))
                    {
                        try
                        {
                            string programStatus = File.ReadAllText(successFile);
                            Console.WriteLine("file content: " + programStatus);
                            if (programStatus == "positive")
                            {
                                firstConnectSuccess = true;
                                Console.WriteLine("POSITIVE:: "+  programStatus);
                                BeginInvoke((Action)(() => {
                                    Thread.Sleep(5000);
                                    ChangeLabelText(StateLabel, "Connected");
                                    ChangeButtonState(StartGameButton, true);
                                    ChangeButtonState(guna2Button4, true);
                                }));
                            }
                            else
                            {
                                BeginInvoke((Action)(() => {
                                    new MessageBoxOk(Selected.ErrorMark, programStatus, statusError: true).ShowDialog();
                                }));

                            }
                            File.Delete(successFile);
                            break;
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error.Message);
                            continue;
                        }
                    }
                }
            });


            checkForSuccess.Start();

            process.WaitForExit();
            Thread.Sleep(1000);
            int returnValue = process.ExitCode;
            Console.WriteLine($"Api exited with return value: {returnValue}");

            if (!firstConnectSuccess)
            {
                BeginInvoke((Action)(() => {
                    ChangeImageColor(OnlineIcon, Color.Yellow);
                    ChangeLabelText(StateLabel, "Live");
                    ChangeButtonState(ConnectButton, true);
                    ChangeButtonState(StartGameButton, false);
                }));
                return;
            }

            while (true)
            {
                if (!autoRestart)
                {
                    BeginInvoke((Action)(() => {
                        MainForm.Instance.mainPanel.Controls.Clear();
                        MainForm.Instance.mainPanel.Controls.Add(value: new Home(Game, Username));
                    }));
                } else
                {
                    Thread.Sleep(5000);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBoxYesNo msgbox = new MessageBoxYesNo(Selected.WarningMark, $"Are you sure you want to delete {Game}?");
            msgbox.ShowDialog();
            if(msgbox.result == true)
            {
                Directory.Delete(GameFolderPath, true);
                new ChooseTeam(Username, Welcome.GameList).ShowDialog();
            }
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string apiPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tiktokLiveApi.exe");
            MessageBoxYesNo msgbox = new MessageBoxYesNo(Selected.WarningMark, $"Are you sure you want to delete the Assets?");
            msgbox.ShowDialog();
            if (msgbox.result == true)
            {
                if (File.Exists(apiPath))
                {
                    foreach (var proc in Process.GetProcessesByName("tiktokLiveApi"))
                    {
                        proc.Kill();
                    }
                    File.Delete(apiPath);
                    BeginInvoke((Action)(() => {
                        ChangeImageColor(OnlineIcon, Color.Yellow);
                        ChangeLabelText(StateLabel, "Live");
                        ChangeButtonState(ConnectButton, true);
                        ChangeButtonState(StartGameButton, false);
                        ChangeButtonState(GoLiveButton, false);
                    }));
                }
            }
                
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private bool autoRestart = false;
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            autoRestart = !autoRestart;
            if (autoRestart)
            {
                this.guna2Button4.FillColor = Color.FromArgb(3, 119, 252);
                ChangeButtonText(guna2Button4, "Auto Restart   ON");
                try
                {
                    Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\TikTok LIVE Studio");
                }
                catch (Exception)
                {
                    new MessageBoxOk(Selected.WarningMark, "Could not find TikTok Live Studio. Make sure to go live before connecting!", statusError: true).ShowDialog();
                }

                string autoRestartPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "autorestart.exe");
                string apiPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tiktokLiveApi.exe");
                string apiArguments = $"{Username} {Welcome.key} {Game}";


                Process process = new Process();
                process.StartInfo.FileName = $"{autoRestartPath}"; // Replace with the path to your executable
                process.StartInfo.Arguments = $" {apiPath} {apiArguments} {Game}"; // Replace with any command-line arguments
                process.Start();

            } else
            {
                this.guna2Button4.FillColor = Color.FromArgb(53, 97, 148);
                ChangeButtonText(guna2Button4, "Auto Restart   OFF");

                string processName = "autorestart.exe";
                string query = $"SELECT * FROM Win32_Process WHERE Name = '{processName}'";

                // Connect to WMI and execute the query
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        // Terminate the process
                        obj.InvokeMethod("Terminate", null);
                        Console.WriteLine($"Terminated process: {processName}");
                        Console.WriteLine("\n\nTerminated old API process.\n\n");
                    }
                }
            }
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // If not, invoke this method on the UI thread
                this.Invoke(new Action(() => client_DownloadFileCompleted(sender, e)));
                return;
            }
            this.BeginInvoke((MethodInvoker)delegate
            {
                downloadComplete = true;
            });

            ZipFile.ExtractToDirectory(installerPath, Home.GameFolderPath);
            File.Delete(installerPath);
        }

        private void Client_DownloadFileCompleted(Object sender, AsyncCompletedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // If not, invoke this method on the UI thread
                this.Invoke(new Action(() => Client_DownloadFileCompleted(sender, e)));
                return;
            }


            // MessageBox.Show("Download complete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ZipFile.ExtractToDirectory(installerPath, AppDomain.CurrentDomain.BaseDirectory);
            File.Delete(installerPath);

            BeginInvoke((Action)(() => {
                ChangeLabelText(StateLabel, "Download complete");
            }));
        }
        private void Download_Finished()
        {
            ZipFile.ExtractToDirectory(installerPath, AppDomain.CurrentDomain.BaseDirectory);
            File.Delete(installerPath);

            BeginInvoke((Action)(() => {
                ChangeLabelText(StateLabel, "Download complete");
            }));
        }

        private void Client_DownloadProgressChanged(Object sender, DownloadProgressChangedEventArgs e)
        {
            return;
        }
    }
}
