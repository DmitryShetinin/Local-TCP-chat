using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public static class Server
    {
        public static List<FileD> Files = new List<FileD>();
        public struct FileD
        {
            public int ID;
            public string FileName;
            public string From;
            public int FileSize;
            public byte[] fileBuffer;
        }
        public static int CountUsers = 0;
        public delegate void UserEvent(string Name);
        public static event UserEvent UserConnected = (Username) =>
        {
            Console.WriteLine($"User {Username} connected.");
            CountUsers++;
            SendGlobalMessage($"Пользователь {Username} подключился к чату.", "Black");
            SendUserList();
        };
        public static event UserEvent UserDisconnected = (Username) =>
        {
            Console.WriteLine($"User {Username} disconnected.");
            CountUsers--;
            SendGlobalMessage($"Пользователь {Username} отключился от чата.","Black");
            SendUserList();
        };
        public static List<User> UserList = new List<User>();
        public static Socket ServerSocket;
        public const string Host = "127.0.0.1";
        public const int Port = 2222;
        public static bool Work = true;

        public static FileD GetFileByID(int ID)
        {
            int countFiles = Files.Count;
            for(int i = 0;i < countFiles;i++)
            {
                if (Files[i].ID == ID)
                    return Files[i];
            }
            return new FileD() { ID = 0};
        }
        public static void NewUser(User usr)
        {
            if (UserList.Contains(usr))
                return;
            UserList.Add(usr);
            UserConnected(usr.Username);
        }
        public static void EndUser(User usr)
        {
            if (!UserList.Contains(usr))
                return;
            UserList.Remove(usr);
            usr.End();
            UserDisconnected(usr.Username);

        }

        public static User GetUser(string Name)
        {
            for(int i = 0;i < CountUsers;i++)
            {
                if (UserList[i].Username == Name)
                    return UserList[i];
            }
            return null;
        }
        public static void SendUserList()
        {
            string userList = "#userlist|";

            for(int i = 0;i < CountUsers;i++)
            {
                userList += UserList[i].Username + ",";
            }

            SendAllUsers(userList);
        }
        public static void SendGlobalMessage(string content,string clr)
        {
            for(int i = 0;i < CountUsers;i++)
            {
                UserList[i].SendMessage(content);
            }
        }
        public static void SendAllUsers(byte[] data)
        {
            for(int i = 0;i < CountUsers;i++)
            {
                UserList[i].Send(data);
            }
        }



        public static void SendAllUsers(string data)
        {
            for (int i = 0; i < CountUsers; i++)
            {
                UserList[i].Send(data);
            }
        }


    }
}
