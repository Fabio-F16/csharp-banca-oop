namespace csharp_banca_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Banca banca = new Banca("Intesa SanPaolo");

            //  popoliamo liste

            banca.AggiungiNuovoCliente(new Cliente("Ettore", "Rodrigo", "FF5845125420854", 20000));
            banca.AggiungiNuovoCliente(new Cliente("Rodrigo", "Ettore", "FF5845125420854", 35000));
            banca.AggiungiNuovoCliente(new Cliente("Claudio ", "Bisio", "FF5845125420854", 10000));
            banca.AggiungiNuovoCliente(new Cliente("Fabio", "De Luigi", "FF5845125420854", 50000));

            banca.prestiti.Add(new Prestito(banca.clienti[0], 18000, 200, "23/10/2010", "23/10/2020"));
            banca.prestiti.Add(new Prestito(banca.clienti[1], 36000, 200, "23/10/2011", "23/10/2021"));
            banca.prestiti.Add(new Prestito(banca.clienti[2], 150000, 200, "23/10/2012", "23/10/2022"));
            banca.prestiti.Add(new Prestito(banca.clienti[0], 28000, 200, "23/10/2013", "23/10/2023"));

            //end popoliamo list

            Menu menu = new Menu("Banca Intesa", banca.clienti, banca.prestiti, banca);
            menu.SelezionaMenu();
        }
    }
}