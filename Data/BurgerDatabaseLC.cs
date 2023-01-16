using HamburgerLC.Models;
using SQLite;

namespace HamburgerLC.Data
{
    public class BurgerDatabaseLC
    {
        string _dbPath;
        private SQLiteConnection conn;

        public BurgerDatabaseLC(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BurgerLC>();
        }

        public int AddNewBurger(BurgerLC burger)
        {
            if (burger.Id != 0)
                return conn.Update(burger);
            else
                return conn.Insert(burger);
        }

        public int DeleteBurger(BurgerLC burger)
        {
            Init();
            return conn.Delete(burger);
        }

        public List<BurgerLC> GetAllBurger()
        {
            Init();
            List<BurgerLC> burgers = conn.Table<BurgerLC>().ToList();
            return burgers;
        }
    }
}
