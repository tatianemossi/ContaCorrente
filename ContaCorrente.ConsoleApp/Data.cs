using System;

namespace ContaCorrente.ConsoleApp
{
    public static class Data
    {
        //8)Como garantir que datas como 31/2/2005 não sejam aceitas pela sua classe Data?
        public static bool DataEhValida(string data)
        {
            DateTime dataConvertida;
            if (DateTime.TryParse(data, out dataConvertida))
            {
                return true;
            }            

            return false;
        }
    }
}
