using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaAggregation
{
    class Buku
    {
        public Stack<Penerbit> pbt;
        private string pengarang;

        //ethod
        public string Pengarang
        {
            get
            {
                return pengarang;
            }

            set
            {
                pengarang = value;
            }
        }
        
        public void setPenerbit(Penerbit terbit)
        {
            this.pbt = new Stack<Penerbit>();
            this.pbt.Push(terbit);
        }



    }
}
