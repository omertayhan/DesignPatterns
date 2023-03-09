using DesignPatterns.SignletonPattern;

//bir objeye bir defa ihtiyacımız olduğunda bu objeden(prop) sadece tek bir örnek(instance) oluşturulabilmesi için singleton patterni kullanırız (fetch data from db)

Console.WriteLine(DateTime.Now.ToLongTimeString());

var countries =
    await CountryProvider.Instance.GetCountries();

foreach (var country in countries)
{
    Console.WriteLine(country.Name);
}

// Another Service

var countries1 = await CountryProvider.Instance.GetCountries();

//Console.WriteLine(CountryProvider.Instance.CountryCount);

Console.WriteLine(DateTime.Now.ToLongTimeString());