using System.Reflection.Metadata.Ecma335;

namespace nearbyCountries;

//Implementação da classe que represente um pais.
class Country
{
    //Declaração dos atributos.
    private string codeIso3166;
    private string countryName;
    private double population;
    private double dimensionKm2;
    private List<Country> neighboringCountries;

    //Métodos de acesso (getters/setter).
    public string CCodeIso3166
    {
        get {return this.codeIso3166;}
        set {this.codeIso3166 = value;}
    }
    public string CCountryName
    {
        get {return this.countryName;}
        set {this.countryName = value;}
    }
    public double CPopulation
    {
        get {return this.population;}
        set {this.population = value;}
    }
    public double CDimencionKm2
    {
        get {return this.dimensionKm2;}
        set {this.dimensionKm2 = value;}
    }
    public List<Country> CNeighboringCountries
    {
        get {return this.neighboringCountries;}
        set {this.neighboringCountries = value;}
    }

    //Construtor para inicializar o Código ISO, Nome do País e dimensão.
    public Country(string codeIso3166, string countryName, double dimensionKm2)
    {
        this.CCodeIso3166 = codeIso3166;
        this.CCountryName = countryName;
        this.CDimencionKm2 = dimensionKm2;
    }

    //Método para inserir países vizinhos
    public void neighbor(List<Country> neighbor)
    {
        this.CNeighboringCountries = neighbor;
    }

    //Método para verificar se o Código ISO é válido
    public bool sameCodeIso(Country countryInserted)
    {
        if(this.CCodeIso3166 == countryInserted.codeIso3166)
        {
            return true;
        }
        return false;
    }

    //Método para verificar se o País é vizinho do País que recebeu a mensagem.
    public bool neighborTrue(Country countryInserted)
    {
        if (CNeighboringCountries.Contains(countryInserted)){
            return true;
        }
        return false;
    }  

    //Método que retorna a densidade populacional do País
    public double demographicDensity()
    {
        double demographicDensity = (this.CPopulation * Math.Pow(10, 6))/this.CDimencionKm2;
        return demographicDensity;
    } 

    //Método que recebe um país como parâmetro e retorn a lista de vizinhos comuns aos dois países.
    public List<Country> commonNeighbors( Country countryIserted)
    {
        List<Country> commonNeighbors = null!;
        foreach (Country c in this.CNeighboringCountries){
            if (countryIserted.CNeighboringCountries.Contains(c))
            {
                commonNeighbors.Add(c);
            }
        }
        return commonNeighbors;
    }
}
