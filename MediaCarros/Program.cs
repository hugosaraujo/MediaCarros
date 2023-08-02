Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

double mediaVendasBugatti = vendasCarros["Bugatti Veyron"].Average();
double mediaVendasKoenigsegg = vendasCarros["Koenigsegg Agera RS"].Average();
double mediaVendasLamborghini = vendasCarros["Lamborghini Aventador"].Average();
double mediaVendasPagani = vendasCarros["Pagani Huayra"].Average();
double mediaVendasFerrari = vendasCarros["Ferrari LaFerrari"].Average();

Console.WriteLine($"A media de Bugatti Veyron vendidas é: {mediaVendasBugatti} veículos");
Console.WriteLine($"A media Koenigsegg Agera RS vendidas é: {mediaVendasKoenigsegg} veículos");
Console.WriteLine($"A media de Lamborghini Aventador vendidas é: {mediaVendasLamborghini} veículos");
Console.WriteLine($"A media de Pagani Huayra vendidas é: {mediaVendasPagani} veículos");
Console.WriteLine($"A media de Ferrari LaFerrari vendidas é: {mediaVendasFerrari} veículos");