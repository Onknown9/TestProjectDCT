using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDCT
{
    public class AppViewModel : INotifyPropertyChanged
    {
        private Data selectedCrypto;

        public ObservableCollection<Data> Cryptos { get; set; }
        public Data SelectedCrypto
        {
            get { return selectedCrypto; }
            set
            {
                selectedCrypto = value;
                OnPropertyChanged();
             }
        }
        public ObservableCollection<Data> TopCryptos { get; set; }


        public AppViewModel()
        {

            string url = "https://api.coincap.io/v2/assets";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string jsonresponse;
            Data dat = new Data();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                jsonresponse = reader.ReadToEnd();
            }
            Root r = JsonConvert.DeserializeObject<Root>(jsonresponse);
            Cryptos = new ObservableCollection<Data>() { };
            TopCryptos = new ObservableCollection<Data>() { };
            foreach (var a in r.Data)
            {
                Cryptos.Add(new Data() { Name = a.Name, Id = a.Id, PriceUsd = a.PriceUsd.Substring(0, a.PriceUsd.IndexOf('.')+4)+" $", Rank = a.Rank, Supply = a.Supply.Substring(0, a.Supply.IndexOf('.')), MaxSupply = a.MaxSupply, MarketCapUsd = a.MarketCapUsd.Substring(0,a.MarketCapUsd.IndexOf('.')+3)+" $", VolumeUsd24Hr = a.VolumeUsd24Hr.Substring(0, a.VolumeUsd24Hr.IndexOf('.')+3)+" $", ChangePercent24Hr = a.ChangePercent24Hr.Substring(0, a.ChangePercent24Hr.IndexOf('.')+3) + " %", Vwap24Hr = a.Vwap24Hr , Explorer=a.Explorer , Symbol = a.Symbol });
                if (Int32.Parse(a.Rank) <= 10)
                {
                    TopCryptos.Add(new Data() { Name = a.Name, Id = a.Id, PriceUsd = a.PriceUsd, Rank = a.Rank, Supply = a.Supply, MaxSupply = a.MaxSupply, MarketCapUsd = a.MarketCapUsd, VolumeUsd24Hr = a.VolumeUsd24Hr, ChangePercent24Hr = a.ChangePercent24Hr, Vwap24Hr = a.Vwap24Hr , Explorer=a.Explorer });
                }
            }
            foreach (var a in Cryptos)
            {
                if (a.MaxSupply != null)
                {
                    a.MaxSupply = a.MaxSupply.Substring(0, a.MaxSupply.IndexOf('.'));
                }
                if (a.Vwap24Hr != null)
                {
                    a.Vwap24Hr = a.Vwap24Hr.Substring(0, a.Vwap24Hr.IndexOf('.')+4) + " %";
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
