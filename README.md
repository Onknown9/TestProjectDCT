TestProject DCT is my self-written multi-page program with navigation that is written in WPF technology and with MVVM pattern.
For API i was using:
- CoinCap API 2.0 (https://docs.coincap.io/)

For Models I was using:
- Data.cs (has all data needed for a single currency)
- Root.cs (has list with all cryptos that were returned by API)

For ViewModel I was using:
- AppViewModel.cs (all program logic)

For Views I was using:
- HomePage.xaml (page for showing top 10 cryptocurrencies)
- ListView.xaml (for showing all returned cryptocurrencies)
- MainWindow.xaml (for navigation buttons)
- SettingsView.xaml (page for switching color modes)
- CryptoDetails.xaml (page for detailed information about cryptocurrency)

It allows user:
- to see top 10 cryptocurrencies that were returned by API. (in homepage)
- to see full list of cryptocurrencies that were returned by API (in crypto list)
- to see detaield information about currency over last 24 hours (crypto details)
- to change color modes (from dark to light) in settings page
- to search for specific crypto by name (if it was returned by API) in crypto details page
- to go to the currency page of selected currency (in crypto details page)
