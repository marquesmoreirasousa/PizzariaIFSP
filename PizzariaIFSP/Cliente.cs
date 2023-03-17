using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaIFSP
{
    internal class Cliente
    {
        private int id;
        private string nome;
        private string telefone;
        private string email;
        private DateTime datNasc;

        public Cliente(int id, string nome, string tel)
        {
            Id = id;
            Nome = nome;
            Telefone = tel;
        }
        public Cliente(int id, string nome, string tel, string email, DateTime datNasc)
        {
            Id = id;
            Nome = nome;
            Telefone = tel;
            Email = email;
            DatNasc = datNasc;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Telefone
        {
            get { return telefone; }
            set { 
                if(value != String.Empty)
                    telefone = value; 
            }
        }
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DatNasc
        {
            get { return datNasc; }
            set { datNasc = value; }
        }
        public override string ToString()
        {
            string saida = "\nID: " + Id +
                           "\nNOME: " + Nome +
                           "\nTELEFONE:" + Telefone;
            if (!String.IsNullOrEmpty(Email))
                saida = saida + "\nEMAIL:" + Email;
            if(!(DatNasc.CompareTo(Convert.ToDateTime("01/01/0001") ) == 0))
            //if(DatNasc.ToShortDateString() == Convert.ToDateTime("01/01/0001").ToString())
                saida = saida + "\nNASCIMENTO: " + DatNasc.ToShortDateString();

            return saida;
        }
    }
}
