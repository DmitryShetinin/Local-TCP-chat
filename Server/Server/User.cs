using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Drawing;
using AForge.Video;
using System.Drawing.Imaging;

namespace Server
{
    public class User
    {
        private Thread _userThread;
        private string _userName;
        private bool AuthSuccess = false;
        private bool _video;
        public string Username
        {
            get { return _userName; }
        }

        private bool status = false;
        private string currentName; 
        private Socket _userHandle;
        static private IPEndPoint consumerEndPoint;
        public User(Socket handle)
        {
            _userHandle = handle;
            _userThread = new Thread(listner);
            _userThread.IsBackground = true;
            _userThread.Start();
        }
        private void listner()
        {
            try
            {
                while (_userHandle.Connected)
                {
                    byte[] buffer = new byte[2048];
                    var bytesReceive = _userHandle.Receive(buffer);
                    handleCommand(Encoding.Unicode.GetString(buffer, 0, bytesReceive));
                }
            }
            catch { Server.EndUser(this); }
        }




        private bool setName(string Name)
        {
    
            _userName = Name;
            Server.NewUser(this);
            AuthSuccess = true;
            return true;
        }
        private void handleCommand(string cmd)
        {
            try
            {
                string[] commands = cmd.Split('#');
                int countCommands = commands.Length;           
                for (int i = 0; i < countCommands; i++)
                {
                    string currentCommand = commands[i];
                    if (string.IsNullOrEmpty(currentCommand))
                        continue;
                    if (!AuthSuccess)
                    {
                        if (currentCommand.Contains("setname"))
                        {
                            if (setName(currentCommand.Split('|')[1]))
                                Send("#setnamesuccess");
                        }
                        continue;
                    }
                    if(currentCommand.Contains("yy"))
                    {
                        string id = currentCommand.Split('|')[1];
                        Server.FileD file = Server.GetFileByID(int.Parse(id));
                        if (file.ID == 0)
                        {
                            SendMessage("Ошибка при передаче файла...");
                            continue;
                        }
                        Send(file.fileBuffer);
                        Server.Files.Remove(file);
                    }
                    if (currentCommand.Contains("message"))
                    {
                        string[] Arguments = currentCommand.Split('|');
                        Server.SendGlobalMessage($"[{_userName}]: {Arguments[1]}","Black");

                        continue;
                    }//sENDfile
                    //...
                    if(currentCommand.Contains("endsession"))
                    {
                        Server.EndUser(this);
                        return;
                    }
                    if(currentCommand.Contains("sendfileto"))
                    {
                        string[] Arguments = currentCommand.Split('|');
                        string TargetName = Arguments[1];
                        int FileSize = int.Parse(Arguments[2]);
                        string FileName = Arguments[3];
                        byte[] fileBuffer = new byte[FileSize];
                        _userHandle.Receive(fileBuffer);
                        User targetUser = Server.GetUser(TargetName);
                        if(targetUser == null)
                        {
                            SendMessage($"Пользователь {FileName} не найден!");
                            continue;
                        }
                        Server.FileD newFile = new Server.FileD()
                        {
                            ID = Server.Files.Count+1,
                            FileName = FileName,
                            From = Username,
                            fileBuffer = fileBuffer,
                            FileSize = fileBuffer.Length
                        };
                        Server.Files.Add(newFile);
                        targetUser.SendFile(newFile,targetUser);
                    }
                    if(currentCommand.Contains("private"))
                    {
                        string[] Arguments = currentCommand.Split('|');
                        string TargetName = Arguments[1];
                        string Content = Arguments[2];
                        User targetUser = Server.GetUser(TargetName);
                        if(targetUser == null)
                        {
                            SendMessage($"Пользователь {TargetName} не найден!");
                            continue;
                        }
                        SendMessage($"Отправлено личное сообщение пользователю[{TargetName}]: {Content}");
                        targetUser.SendMessage($"Получено личное сообщение от пользователя[{Username}]: {Content}");
                        continue;
                    }          
                }

            }
            catch (Exception exp) { Console.WriteLine("Error with handleCommand: " + exp.Message); }
        }

     
        public void SendFile(Server.FileD fd, User To)
        {
            byte[] answerBuffer = new byte[48];
            Console.WriteLine($"Sending {fd.FileName} from {fd.From} to {To.Username}");
            To.Send($"#gfile|{fd.FileName}|{fd.From}|{fd.fileBuffer.Length}|{fd.ID}");
        }
        public void SendMessage(string content)
        {
            Send($"#msg0|{content}|");
        }
        public void Send(byte[] buffer)
        {
            try
            {
                _userHandle.Send(buffer);
            }
            catch { }
        }
        public void Send(string Buffer)
        {
            try
            {
                _userHandle.Send(Encoding.Unicode.GetBytes(Buffer));
            }
            catch { }
        }
        public void End()
        {
            try
            {
                _userHandle.Close();
            }
            catch { }

        }
    }
}
