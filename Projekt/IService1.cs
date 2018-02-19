using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projekt
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        void ZmianaMiejscaZamieszkania(string PESEL, string MiejsceZamieszkania);

        [OperationContract]
        void NowyKlient(string NrPESEL, string Nazwisko, string Imie, string MiejsceZamieszkania);

        [OperationContract]
        void NowyPojazd(string PeselWlasciciela, string NrRejestracji, string Marka, string Model, int Rocznik, string Przebieg);

        [OperationContract]
        void Przeglad(string NrRejestracji, string Przebieg, int Waznosc);
        
        [OperationContract]
        string Informacje(string PESEL);

        [OperationContract]
        string Waznosc(string PESEL);



    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}