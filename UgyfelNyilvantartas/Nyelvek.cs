using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgyfelNyilvantartas
{
    class Nyelvek
    {
        int nyelv_ID;
        string megnevezes;

        public int Nyelv_ID { get => nyelv_ID; set => nyelv_ID = value; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }

        public Nyelvek(int nyelv_ID, string nyelv)
        {
            Nyelv_ID = nyelv_ID;
            Megnevezes = nyelv;
        }
        public Nyelvek()
        {

        }
        public override string ToString()
        {
            return megnevezes;
        }
    }
}
