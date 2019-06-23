using OBM.Data;

namespace OBM.Service
{
    public class UnitOfWork
    {
        private static UnitOfWork _ins;

        public static UnitOfWork Ins
        {
            get { if (_ins == null) _ins = new UnitOfWork(); return _ins; }
            private set => _ins = value;
        }

        private UnitOfWork()
        {
        }

        public bool Commit()
        {
            return DataProvider.Ins.DB.SaveChanges() > 0;
        }
    }
}