using Kartuves.DL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartuves.DL
{
    public class KartuvesContext : DbContext
    {
        public KartuvesContext(): base("Kartuves")
        {
            Database.SetInitializer(new KartuvesContextInitializer());
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<ScoreBoard> ScoreBoards { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Word> Words { get; set; }




    }
}
