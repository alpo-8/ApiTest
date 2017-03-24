using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest
{
    public class Data : INotifyPropertyChanged
    {
        private DateTime lastUpdate;
        public string methodName { get; set; }
        public string endpoint { get; set; }
        public Dictionary<string, string> adacoHeaders { get; set; }
        public Dictionary<string, string> parameters { get; set; }
        public string request { get; set; }
        public string response { get; set; }


        public DateTime LastUpdate
        {
            get { return lastUpdate; }
            set
            {
                lastUpdate = value;
                OnPropertyChanged("LastUpdate");
            }
        }

        public string MethodName
        {
            get { return methodName; }
            set
            {
                methodName = value;
                OnPropertyChanged("MethodName");
            }
        }

        public string Endpoint
        {
            get { return endpoint; }
            set
            {
                endpoint = value;
                OnPropertyChanged("Endpoint");
            }
        }

        public string Request
        {
            get { return request; }
            set
            {
                request = value;
                OnPropertyChanged("Request");
            }
        }

        public string Response
        {
            get { return response; }
            set
            {
                response = value;
                OnPropertyChanged("Response");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public Data() { }
        
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }        
    }
}
