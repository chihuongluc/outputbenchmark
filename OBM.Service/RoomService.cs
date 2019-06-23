using OBM.Data;
using OBM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBM.Service
{
    public class RoomService
    {
        private static RoomService _ins;

        public static RoomService Ins
        {
            get { if (_ins == null) _ins = new RoomService(); return _ins; }
            private set => _ins = value;
        }

        private RoomService()
        {
        }

        public List<Room> GetAll()
        {
            return DataProvider.Ins.DB.Rooms.ToList();
        }
    }
}
