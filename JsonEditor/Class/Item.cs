using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonEditor
{
    public class Camera
    {
        public string _IP;
        public int _Port;
        public string _User;
        public string _Name;
        public string _Password;
        public string _Company;
        public int _ChannelNo;
        public bool _Entrance;
        public bool _ORC;
        public bool _SubStream;

        public string IP { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Company { get; set; }
        public int ChannelNo { get; set; }
        public bool Entrance { get; set; }
        public bool ORC { get; set; }
        public bool SubStream { get; set; }

        public Camera(string ip, int port, string user, string name, string password, string company, int chanelno, bool entrance, bool orc, bool substream)
        {
            this.IP = ip;
            this.Port = port;
            this.User = user;
            this.Name = name;
            this.Password = password;
            this.Company = company;
            this.ChannelNo = chanelno;
            this.Entrance = entrance;
            this.ORC = orc;
            this.SubStream = substream;
        }
    }

    public class Reader
    {
        public string _Type;
        public int _Port;
        public int _Lane;

        public string Type { get; set; }
        public int Port { get; set; }
        public int Lane { get; set; }

        public Reader(string type, int port, int lane)
        {
            this.Type = type;
            this.Port = port;
            this.Lane = lane;
        }
    }

    public class TXTDB
    {
        public int _id;
        public string _STT1;

        public int id { set; get; }
        public string STT1 { set; get; }

        public TXTDB(int id, string STT1)
        {
            this.id = id;
            this.STT1 = STT1;
        }
    }
}
