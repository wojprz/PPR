using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projekt
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public void ZmianaMiejscaZamieszkania(string PESEL, string MiejsceZamieszkania)
        {

            Model1 model = new Model1();
            Owners owners = model.Owners.Find(PESEL);


            owners.ZmianaZamieszkania(MiejsceZamieszkania);

            model.Entry(owners).State = System.Data.Entity.EntityState.Modified;
            model.SaveChanges();

        }

        public void NowyKlient(string NrPESEL, string Nazwisko, string Imie, string MiejsceZamieszkania)
        {
            Owners Nowy = new Owners() { PESEL = NrPESEL, Nazwisko = Nazwisko, Imie = Imie, Miejsce_zamieszkania = MiejsceZamieszkania };
            Model1 model = new Model1();
            Owners owners = model.Owners.Add(Nowy);

            model.SaveChanges();
        }

        public void NowyPojazd(string PeselWlasciciela, string NrRejestracji, string Marka, string Model, int Rocznik, string Przebieg)
        {
            Samochody Nowy = new Samochody() { PESEL_Własciciela = PeselWlasciciela, Rejestracja = NrRejestracji, Marka = Marka, Model = Model, Rocznik = Rocznik, Przebieg = Przebieg };
            Model1 model = new Model1();
            Samochody samochody = model.Samochody.Add(Nowy);

            DateTime data = DateTime.Now;
            DateTime dataWaz = data.AddYears(3);

            Rejestracje NowyRe = new Rejestracje() { Rejestracja = NrRejestracji, Pierwsza_Rejestracja = data, Ostatnia_Rejestracja = data, Waznosc_Rejestracji = dataWaz };
            Rejestracje rejestracje = model.Rejestracje.Add(NowyRe);


            model.SaveChanges();
        }
        public void Przeglad(string NrRejestracji, string Przebieg, int Waznosc)
        {
            Model1 model = new Model1();
            DateTime data = DateTime.Now;
            //DateTime data2 = data.AddYears(Waznosc);

            Rejestracje rejestracje = model.Rejestracje.Find(NrRejestracji);
            rejestracje.Ostatnia_Rejestracja = data;
            // rejestracje.Waznosc_Rejestracji = data2;
            rejestracje.Waznosc_Rejestracji = rejestracje.Przedluzenie(data, Waznosc);

            Samochody samochody = model.Samochody.Find(NrRejestracji);
            samochody.Przebieg = Przebieg;

            model.SaveChanges();
        }

        public string Informacje(string PESEL)
        {

            string PESEL_Własciciela = PESEL;
            Model1 model = new Model1();
            Samochody samochody = model.Samochody.FirstOrDefault(_c => _c.PESEL_Własciciela == PESEL);
            string tem = samochody.Rejestracja;
            Rejestracje rejestracje = model.Rejestracje.FirstOrDefault(_c => _c.Rejestracja == tem);
            return string.Format("Osoba o PESELU " + samochody.PESEL_Własciciela + " posiada: " + samochody.Marka + " " + samochody.Model + " o przebiegu: " + samochody.Przebieg + " o waznosci rejestracji do: " + rejestracje.Waznosc_Rejestracji +  ".");


        }
        public string Waznosc(string PESEL)
        {
            Model1 model = new Model1();
            Samochody samochody = model.Samochody.FirstOrDefault(_c => _c.PESEL_Własciciela == PESEL);
            return samochody.Rej();
        }
        
    }
}
