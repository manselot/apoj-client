using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Json;
using System.Net.Http;
using System.Xml.Linq;
using System.IO;
using System.Net.Http.Headers;
using SharpCompress;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Threading;
using NAudio.Wave;
using WaveFileManipulator;
using System.Media;




namespace apoj
{
    public partial class Form1 : Form
    {
        static int sec = 60;
        static int sec1 = 60;
        static int member1score = 0;
        static int member2score = 0;
        static int member3score = 0;
        static int member4score = 0;
        public int idd;
        public bool host;
        static public string name = "";
        public static string[] id;
        public string roomId;
        public string songDir;
        public string[] songList;
        static public int currentIndex = 0;
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimer1 = new System.Windows.Forms.Timer();
        static bool exitFlag = false;
        static public int countSong = 1;


        public Form1()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            
            


        }
        class Person
        {
            public string name { get; set; } = "";
            public string username { get; set; } = "";
        }
        private void ff()
        {
            string s = "notStarted";
            string str = roomId;
            while (s == "notStarted")
            {
                System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"http://localhost:8080/LobbyInfo/" + str);
                System.Net.WebResponse resp = reqGET.GetResponse();
                System.IO.Stream stream = resp.GetResponseStream();
                System.IO.StreamReader sr = new System.IO.StreamReader(stream);
                s = sr.ReadToEnd();
                if (listBox2.InvokeRequired)
                {
                    listBox2.Invoke((MethodInvoker)delegate {
                        listBox2.Items.Clear();
                        listBox2.Items.AddRange(s.Split(','));
                        listBox2.Items.RemoveAt(listBox2.Items.Count - 1);

                    });
                }



                reqGET = System.Net.WebRequest.Create(@"http://localhost:8080/LobbyStart/" + str);
                resp = reqGET.GetResponse();
                stream = resp.GetResponseStream();
                sr = new System.IO.StreamReader(stream);
                s = sr.ReadToEnd();
               
               
                Thread.Sleep(5000);

            }
            if (panel5.InvokeRequired)
            {
                textBox2.Invoke((MethodInvoker)delegate {
                    panel5.Visible = true;

                });
            }
            if (host == false)
            {
                panel5.Visible = true;
                if (button8.InvokeRequired)
                {
                    button8.Invoke((MethodInvoker)delegate
                    {
                        button8.PerformClick();

                    });
                }
            }
        }
        private  void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
      

            label5.Text = sec.ToString();    
            sec--;
            if (sec == 0)
            {

                myTimer.Stop();

                if (countSong != currentIndex)
                {

                    HttpClient httpClient = new HttpClient();
                    Dictionary<string, string> data = new Dictionary<string, string>
                    {
                        ["id"] = roomId,
                        ["username"] = name,
                        ["answer"] = textBox4.Text
                    };
                    // создаем объект HttpContent
                    HttpContent contentForm = new FormUrlEncodedContent(data);
                    // отправляем запрос
                    var response = httpClient.PostAsync("http://localhost:8080/Answer", contentForm);                   
                    sec = 60;
                    myTimer.Enabled = true;
                    button8.PerformClick();
                    
                   


                }
                else
                {
                    // Stops the timer.
                    exitFlag = true;
                    sec = 60;
                    var files = Directory.GetFiles("C:\\Users\\as\\Desktop\\Новая папка (3)\\Новая папка\\reverse");
                    foreach (var file in files)
                    {
                        File.Delete(file);
                    }
                    var files1 = Directory.GetFiles("C:\\Users\\as\\Desktop\\Новая папка (3)\\Новая папка", "*.*", SearchOption.AllDirectories).Where(q => q.EndsWith(".mp3") || q.EndsWith(".wav"));
                    foreach (var file in files1)
                    {
                        File.Delete(file);
                    }
                    System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"http://localhost:8080/GetResult/" + roomId);
                    System.Net.WebResponse resp = reqGET.GetResponse();
                    System.IO.Stream stream = resp.GetResponseStream();
                    System.IO.StreamReader sr = new System.IO.StreamReader(stream);
                    string[] s = sr.ReadToEnd().Split(',');
                    panel6.Visible = true;
                    if (listBox2.Items.Count == 1)
                    {
                        label7.Text = s[0];
                    }
                    if (listBox2.Items.Count == 2)
                    {
                        label8.Text = s[1];
                    }
                    if (listBox2.Items.Count == 3)
                    {
                        label9.Text = s[2];
                    }
                    if (listBox2.Items.Count == 4)
                    {
                        label10.Text = s[3];
                    }
                }
            }
        }

        private void TimerEventProcessor1(Object myObject,
                                           EventArgs myEventArgs)
        {
            

            label6.Text = sec1.ToString();
            sec1--;
            if (sec1 == 0)
            {
                if (countSong != currentIndex + 1)
                {
                    sec1 = 60;
                    label4.Text = Path.GetFileName(songList[currentIndex]);
                    System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"http://localhost:8080/GetAnswer/" + roomId);
                    System.Net.WebResponse resp = reqGET.GetResponse();
                    System.IO.Stream stream = resp.GetResponseStream();
                    System.IO.StreamReader sr = new System.IO.StreamReader(stream);
                    string[] s = sr.ReadToEnd().Split(',');

                    if (listBox2.Items.Count == 1)
                    {
                        checkBox1.Text = s[0];
                    }
                    if (listBox2.Items.Count == 2)
                    {
                        checkBox2.Text = s[1];
                    }
                    if (listBox2.Items.Count == 3)
                    {
                        checkBox3.Text = s[2];
                    }
                    if (listBox2.Items.Count == 4)
                    {
                        checkBox4.Text = s[3];
                    }
                    currentIndex++;



                }
                else
                {
                    HttpClient httpClient = new HttpClient();
                    Dictionary<string, string> data = new Dictionary<string, string>
                    {
                        ["id"] = roomId,
                        ["score1"] = member1score.ToString(),
                        ["score2"] = member2score.ToString(),
                        ["score3"] = member3score.ToString(),
                        ["score4"] = member4score.ToString()
                    };
                    // создаем объект HttpContent
                    HttpContent contentForm = new FormUrlEncodedContent(data);
                    // отправляем запрос
                    var response = httpClient.PostAsync("http://localhost:8080/Result", contentForm);
                    Thread.Sleep(2000);
                    // Stops the timer
                    System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"http://localhost:8080/GetResult/" + roomId);
                    System.Net.WebResponse resp = reqGET.GetResponse();
                    System.IO.Stream stream = resp.GetResponseStream();
                    System.IO.StreamReader sr = new System.IO.StreamReader(stream);
                    string[] s = sr.ReadToEnd().Split(',');
                    panel6.Visible = true;
                    if (listBox2.Items.Count == 1)
                    {
                        label7.Text = s[0];
                    }
                    if (listBox2.Items.Count == 2)
                    {
                        label8.Text = s[1];
                    }
                    if (listBox2.Items.Count == 3)
                    {
                        label9.Text = s[2];
                    }
                    if (listBox2.Items.Count == 4)
                    {
                        label10.Text = s[3];
                    }
                    exitFlag = true;
                    myTimer1.Stop();
                    sec1 = 60;
                    httpClient = new HttpClient();
                    data = new Dictionary<string, string>
                    {            
                        ["id"] = roomId,
                    };
                    // создаем объект HttpContent
                    contentForm = new FormUrlEncodedContent(data);
                    // отправляем запрос
                    response = httpClient.PostAsync("http://localhost:8080/DeleteLobby", contentForm);

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
     
        }

        private void CreateHost_Click(object sender, EventArgs e)
        {
           panel7.Visible = true;
           CreateHost.Visible = false;
           JoinLobby.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                ["name"] = textBoxLobbyName.Text,
                ["username"] = name,
            };
            // создаем объект HttpContent
            HttpContent contentForm = new FormUrlEncodedContent(data);
            // отправляем запрос
            var response = httpClient.PostAsync("http://localhost:8080/CreateHost", contentForm);
            string responseText = response.Result.Content.ReadAsStringAsync().Result;
            roomId = responseText;
            panelCreateHost.Visible = true;
            panel7.Visible = false;


        }

        private void JoinLobby_Click(object sender, EventArgs e)
        {
            host = false;
            listBox1.Items.Clear();
            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"http://localhost:8080/JoinLobby");
            System.Net.WebResponse resp = reqGET.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string s = sr.ReadToEnd();
            string[] ss = lobbysorter(s);
            for (int i = 0; i < ss.Length-1; i++)
            {
                listBox1.Items.Add(ss[i]);
            }
            panel1.Visible = true;
            CreateHost.Visible = false;
            JoinLobby.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                songDir = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            host = false;
            listBox2.Items.Clear();
            idd = (int)listBox1.SelectedIndex;
            string str = id[idd];
            roomId = id[idd];
            HttpClient httpClient = new HttpClient();
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                ["id"] = str,
                ["username"] = name,
            };
            // создаем объект HttpContent
            HttpContent contentForm = new FormUrlEncodedContent(data);
            // отправляем запрос
            var response = httpClient.PostAsync("http://localhost:8080/Join", contentForm);
            System.IO.Stream stream = response.Result.Content.ReadAsStreamAsync().Result;
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            var fs = new FileStream("..\\song.zip", FileMode.Create);
            byte[] buffer = new byte[4096];
            int byteread = 1;
            while (byteread != 0)
            {
                byteread = stream.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, byteread); 
            }
            fs.Close();
            string zipFile = Path.Combine("..\\", "song.zip"); // сжатый файл
            string targetFolder = AppDomain.CurrentDomain.BaseDirectory; // папка, куда распаковывается файл
            string[] files = Directory.GetFiles(targetFolder, "*.mp3");
            foreach (var file in files)
            {
                File.Delete(file); 
            }
            ZipFile.ExtractToDirectory(zipFile, targetFolder);
            files = Directory.GetFiles(targetFolder, "*.mp3");
            foreach (var file in files)
            {
                Reverser.Start(file);
            }

            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"http://localhost:8080/LobbyInfo/" + str );
            System.Net.WebResponse resp = reqGET.GetResponse();
            stream = resp.GetResponseStream();
            sr = new System.IO.StreamReader(stream);
            string s = sr.ReadToEnd();
            listBox2.Items.AddRange(s.Split(','));
            listBox2.Items.RemoveAt(listBox2.Items.Count-1);
            button7.Visible = true;
            panel2.Visible = true;

            System.Threading.Thread thr = new System.Threading.Thread(ff);
            thr.Start();          
        }
        private string[] lobbysorter(string s) {
            string[] str = s.Split(':', ',');
            string idd = "";
            string name = "";
            for (int i = 0; i < str.Length-1; i++)
            {
                if (i % 2 == 0) {
                    name += name + str[i] + ',';
                }
                else {
                    idd += idd + str[i] + ",";
                }
            }
           
            id = idd.Split(',');
            string[] ss = name.Split(',');
            return ss;
        }

        private void button4_Click(object sender, EventArgs e)
        {
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            name = textBox3.Text;
            Play_button.Visible = false;
            CreateHost.Visible = true;
            JoinLobby.Visible = true;
            panel3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            host = true;
            HttpClient httpClient = new HttpClient();
            var serverAddress = "http://localhost:8080/upload/"+roomId;
            // пути к файлам
            var files = songDir;
            string[] songList = Directory.GetFiles(files);
            countSong = songList.Length;

            var multipartFormContent = new MultipartFormDataContent();
            // в цикле добавляем все файлы в MultipartFormDataContent
            foreach (var file in songList)
            {
                // получаем краткое имя файла
                var fileName = Path.GetFileName(file);
                var fileStreamContent = new StreamContent(File.OpenRead(file));
                fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("music/mp3");
                multipartFormContent.Add(fileStreamContent, name: "files", fileName: fileName);
                
            }

            // Отправляем файлы
            var response = httpClient.PostAsync(serverAddress, multipartFormContent);
            panel2.Visible = true;
            button7.Visible = true;
            panelCreateHost.Visible = false;
            System.Threading.Thread thr = new System.Threading.Thread(ff);
            thr.Start();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str = roomId;
            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"http://localhost:8080/Start/" + str);
            System.Net.WebResponse resp = reqGET.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);

            panel4.Visible = true;
            Thread.Sleep(8000);

            myTimer1.Tick += new EventHandler(TimerEventProcessor1);
            myTimer1.Interval = 1000;
            myTimer1.Start();
            string[] files = Directory.GetFiles("..\\", "*.mp3");
            label4.Text = Path.GetFileName(files[0]);
            songList = files;
            panel4.Visible = true;

            while (exitFlag == false)
            {
                // Processes all the events in the queue.
                Application.DoEvents();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (myTimer.Enabled==false)
            {
                myTimer.Tick += new EventHandler(TimerEventProcessor);
                myTimer.Interval = 1000;
                myTimer.Start();
            }
            
            

            string[] files = Directory.GetFiles("..\\reverse");
            countSong = files.Length;

            if (countSong == currentIndex)
            {

            }
            else
            {
                WMP.URL = files[currentIndex];
                currentIndex++;
            }
            
            while (exitFlag == false)
            {
                // Processes all the events in the queue.
                Application.DoEvents();
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                member1score++;
            }
            if (checkBox2.Checked)
            {
                member2score++;
            }
            if (checkBox3.Checked)
            {
                member3score++;
            }
            if (checkBox4.Checked)
            {
                member4score++;
            }
            checkBox1.Text = "ждем ответа";
            checkBox2.Text = "ждем ответа";
            checkBox3.Text = "ждем ответа";
            checkBox4.Text = "ждем ответа";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = false;
            Play_button.Visible = true;
        }
    }
}
