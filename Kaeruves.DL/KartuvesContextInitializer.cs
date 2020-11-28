using Kartuves.DL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartuves.DL
{
    public class KartuvesContextInitializer : CreateDatabaseIfNotExists<KartuvesContext>
    {
        protected override void Seed(KartuvesContext context)
        {
            const string temaVardai = "Vardai";
            const string temaMiestai = "Miestai";
            const string temaValstybes = "Valstybes";
            const string temaAuto = "Automobilio marke";

            List<Subject> temos = new List<Subject>
            {
                new Subject
                {Name = temaVardai,
                    Words = new List<Word>
                    {
                        new Word {Text = "Jonas"},
                        new Word {Text = "Petras"},
                        new Word {Text = "Agne"},
                        new Word {Text = "Lina"},
                        new Word {Text = "Karolis"},
                        new Word {Text = "Rokas"},
                        new Word {Text = "Indre"},
                        new Word {Text = "Ruta"},
                        new Word {Text = "Romas"},
                        new Word {Text = "Egle"},
                    } 
                },
                new Subject
                {Name = temaMiestai,
                    Words = new List<Word>
                  {
                        new Word {Text = "Vilnius"},
                        new Word {Text = "Kaunas"},
                        new Word {Text = "Klaipeda"},
                        new Word {Text = "Alytus"},
                        new Word {Text = "Ukmerge"},
                        new Word {Text = "Palanga"},
                        new Word {Text = "Siauliai"},
                        new Word {Text = "Elektrenai"},
                        new Word {Text = "Skuodas"},
                        new Word {Text = "Silute"},
                    },
                    },
                new Subject
                {Name = temaValstybes,
                    Words = new List<Word>
                    { 
                        new Word {Text = "Lietuva"},
                        new Word {Text = "Latvija"},
                        new Word {Text = "Estija"},
                        new Word {Text = "Austrija"},
                        new Word {Text = "Danija"},
                        new Word {Text = "Norvegija"},
                        new Word {Text = "Ispanija"},
                        new Word {Text = "Portugalija"},
                        new Word {Text = "Kanada"},
                        new Word {Text = "Australija"},
                    },
                    },
                new Subject 
                {Name = temaAuto,
                  Words = new List<Word>
                    {
                        new Word {Text = "Opel"},
                        new Word {Text = "Audi"},
                        new Word {Text = "Hyundai"},
                        new Word {Text = "Honda"},
                        new Word {Text = "Mitsubishi"},
                        new Word {Text = "BMW"},
                        new Word {Text = "Volvo"},
                        new Word {Text = "Skoda"},
                        new Word {Text = "Suzuki"},
                        new Word {Text = "Renault"},
                    },
                },
            };
            context.Subjects.AddRange(temos);
        }
    }
}
