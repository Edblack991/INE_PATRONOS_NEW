using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class INE_PatronosDbInitializer : DropCreateDatabaseIfModelChanges<INE_PatronosDbContext>
    {
        protected override void Seed(INE_PatronosDbContext context)
        {
            context.Database.Log = Console.Write;

            using (DbContextTransaction dbTran = context.Database.BeginTransaction())
            {
                try
                {

                    List<CountryRegion> defaultCountriesRegion = new List<CountryRegion>();
                    List<StateProvince> defaultStatesProvince = new List<StateProvince>();
                    List<City> defaultCities = new List<City>();
                    List<Citizen> defaultCitizens = new List<Citizen>();
                    List<PoliticalParty> politicalParties = new List<PoliticalParty>();
                    List<President> presidents = new List<President>();
                    List<Governor> governors = new List<Governor>();
                    List<Mayor> mayors = new List<Mayor>();

                    #region PAIS
                    defaultCountriesRegion.Add(new CountryRegion()
                    {
                        Description = "MEXICO",
                        FIPS104 = "MX",
                        ISO2 = "MX",
                        ISO3 = "MEX",
                        ISON = "484",
                        Internet = "MX",
                        Capital = "MEXICO",
                        MapReference = "NORTH AMERICA",
                        NationalitySingular = "MEXICAN",
                        NationalityPlural = "MEXICANS",
                        Currency = "MEXICAN PESO",
                        CurrencyCode = "MXN",
                        Population = 101879171,
                        Title = "MEXICO",
                        Comment = ""
                    });
                    #endregion

                    #region ESTADOS
                    defaultStatesProvince.Add(new StateProvince()
                    {
                        CountryRegionId = 1,
                        CveEnt = "19",
                        Description = "NUEVO LEON",
                        Abrev = "NL",
                        CveCab = "390001",
                        NameCab = "CIUDAD MONTERREY",
                        PTOT = "4653458",
                        PMAS = "2320185",
                        PFEM = "2333273",
                        VTOT = "1210893"
                    });


                    defaultStatesProvince.Add(new StateProvince()
                    {
                        CountryRegionId = 1,
                        CveEnt = "14",
                        Description = "JALISCO",
                        Abrev = "JAL",
                        CveCab = "390001",
                        NameCab = "GUADALAJARA",
                        PTOT = "7350682",
                        PMAS = "3600641",
                        PFEM = "3750041",
                        VTOT = "1831205"
                    });
                    #endregion

                    #region MUNICIPIOS
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "1", Description = "ABASOLO", CveCab = "1", NameCab = "ABASOLO", PTOT = "2791", PMAS = "1406", PFEM = "1385", VTOT = "741" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "2", Description = "AGUALEGUAS", CveCab = "1", NameCab = "AGUALEGUAS", PTOT = "3443", PMAS = "1777", PFEM = "1666", VTOT = "1175" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "3", Description = "LOS ALDAMAS", CveCab = "1", NameCab = "LOS ALDAMAS", PTOT = "1374", PMAS = "708", PFEM = "666", VTOT = "475" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "4", Description = "ALLENDE", CveCab = "1", NameCab = "CIUDAD DE ALLENDE", PTOT = "32593", PMAS = "16440", PFEM = "16153", VTOT = "9360" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "5", Description = "ANÁHUAC", CveCab = "1", NameCab = "ANÁHUAC", PTOT = "18480", PMAS = "9219", PFEM = "9261", VTOT = "5139" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "6", Description = "APODACA", CveCab = "1", NameCab = "CIUDAD APODACA", PTOT = "523370", PMAS = "263374", PFEM = "259996", VTOT = "133180" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "7", Description = "ARAMBERRI", CveCab = "1", NameCab = "ARAMBERRI", PTOT = "15470", PMAS = "7869", PFEM = "7601", VTOT = "4045" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "8", Description = "BUSTAMANTE", CveCab = "1", NameCab = "BUSTAMANTE", PTOT = "3773", PMAS = "1890", PFEM = "1883", VTOT = "1116" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "9", Description = "CADEREYTA JIMÉNEZ", CveCab = "1", NameCab = "CADEREYTA JIMÉNEZ", PTOT = "86445", PMAS = "43939", PFEM = "42506", VTOT = "24088" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "10", Description = "EL CARMEN", CveCab = "1", NameCab = "CARMEN", PTOT = "16092", PMAS = "8175", PFEM = "7917", VTOT = "4378" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "11", Description = "CERRALVO", CveCab = "1", NameCab = "CIUDAD CERRALVO", PTOT = "7855", PMAS = "4049", PFEM = "3806", VTOT = "2419" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "12", Description = "CIÉNEGA DE FLORES", CveCab = "1", NameCab = "CIÉNEGA DE FLORES", PTOT = "24526", PMAS = "12476", PFEM = "12050", VTOT = "6486" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "13", Description = "CHINA", CveCab = "1", NameCab = "CHINA", PTOT = "10864", PMAS = "5585", PFEM = "5279", VTOT = "3188" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "14", Description = "DOCTOR ARROYO", CveCab = "1", NameCab = "DOCTOR ARROYO", PTOT = "35445", PMAS = "17849", PFEM = "17596", VTOT = "8488" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "15", Description = "DOCTOR COSS", CveCab = "1", NameCab = "DOCTOR COSS", PTOT = "1716", PMAS = "889", PFEM = "827", VTOT = "539" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "16", Description = "DOCTOR NZÁLEZ", CveCab = "1", NameCab = "DOCTOR NZÁLEZ", PTOT = "3345", PMAS = "1713", PFEM = "1632", VTOT = "974" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "17", Description = "GALEANA", CveCab = "1", NameCab = "GALEANA", PTOT = "39991", PMAS = "20237", PFEM = "19754", VTOT = "10201" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "18", Description = "GARCÍA", CveCab = "1", NameCab = "GARCÍA", PTOT = "143668", PMAS = "72640", PFEM = "71028", VTOT = "38791" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "19", Description = "SAN PEDRO GARZA GARCÍA", CveCab = "1", NameCab = "SAN PEDRO GARZA GARCÍA", PTOT = "122659", PMAS = "57622", PFEM = "65037", VTOT = "31936" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "20", Description = "GENERAL BRAVO", CveCab = "1", NameCab = "GENERAL BRAVO", PTOT = "5527", PMAS = "2876", PFEM = "2651", VTOT = "1643" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "21", Description = "GENERAL ESCOBEDO", CveCab = "1", NameCab = "CIUDAD GENERAL ESCOBEDO", PTOT = "357937", PMAS = "180332", PFEM = "177605", VTOT = "89379" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "22", Description = "GENERAL TERÁN", CveCab = "1", NameCab = "CIUDAD GENERAL TERÁN", PTOT = "14437", PMAS = "7234", PFEM = "7203", VTOT = "4360" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "23", Description = "GENERAL TREVIÑO", CveCab = "1", NameCab = "GENERAL TREVIÑO", PTOT = "1277", PMAS = "626", PFEM = "651", VTOT = "437" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "25", Description = "GENERAL ZUAZUA", CveCab = "1", NameCab = "GENERAL ZUAZUA", PTOT = "55213", PMAS = "27787", PFEM = "27426", VTOT = "14744" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "26", Description = "GUADALUPE", CveCab = "1", NameCab = "GUADALUPE", PTOT = "678006", PMAS = "336731", PFEM = "341275", VTOT = "172341" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "27", Description = "LOS HERRERAS", CveCab = "1", NameCab = "LOS HERRERAS", PTOT = "2030", PMAS = "1001", PFEM = "1029", VTOT = "728" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "28", Description = "HIGUERAS", CveCab = "1", NameCab = "HIGUERAS", PTOT = "1594", PMAS = "829", PFEM = "765", VTOT = "451" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "29", Description = "HUALAHUISES", CveCab = "1", NameCab = "HUALAHUISES", PTOT = "6914", PMAS = "3424", PFEM = "3490", VTOT = "1978" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "30", Description = "ITURBIDE", CveCab = "1", NameCab = "ITURBIDE", PTOT = "3558", PMAS = "1844", PFEM = "1714", VTOT = "948" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "31", Description = "JUÁREZ", CveCab = "1", NameCab = "CIUDAD BENITO JUÁREZ", PTOT = "256970", PMAS = "129324", PFEM = "127646", VTOT = "65980" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "32", Description = "LAMPAZOS DE NARANJO", CveCab = "1", NameCab = "LAMPAZOS DE NARANJO", PTOT = "5349", PMAS = "2700", PFEM = "2649", VTOT = "1542" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "33", Description = "LINARES", CveCab = "1", NameCab = "LINARES", PTOT = "78669", PMAS = "39104", PFEM = "39565", VTOT = "20939" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "34", Description = "MARÍN", CveCab = "1", NameCab = "MARÍN", PTOT = "5488", PMAS = "2808", PFEM = "2680", VTOT = "1426" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "35", Description = "MELCHOR OCAMPO", CveCab = "1", NameCab = "MELCHOR OCAMPO", PTOT = "862", PMAS = "433", PFEM = "429", VTOT = "285" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "36", Description = "MIER Y NORIEGA", CveCab = "1", NameCab = "MIER Y NORIEGA", PTOT = "7095", PMAS = "3555", PFEM = "3540", VTOT = "1574" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "37", Description = "MINA", CveCab = "1", NameCab = "MINA", PTOT = "5447", PMAS = "2774", PFEM = "2673", VTOT = "1458" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "38", Description = "MONTEMORELOS", CveCab = "1", NameCab = "MONTEMORELOS", PTOT = "59113", PMAS = "29370", PFEM = "29743", VTOT = "17056" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "39", Description = "MONTERREY", CveCab = "1", NameCab = "MONTERREY", PTOT = "1135550", PMAS = "561656", PFEM = "573894", VTOT = "297825" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "40", Description = "PARRÁS", CveCab = "1", NameCab = "PARÁS", PTOT = "1034", PMAS = "512", PFEM = "522", VTOT = "319" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "41", Description = "PESQUERÍA", CveCab = "1", NameCab = "PESQUERÍA", PTOT = "20843", PMAS = "10737", PFEM = "10106", VTOT = "5768" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "42", Description = "LOS RAMONES", CveCab = "1", NameCab = "LOS RAMONES", PTOT = "5359", PMAS = "2720", PFEM = "2639", VTOT = "1715" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "43", Description = "RAYONES", CveCab = "1", NameCab = "RAYONES", PTOT = "2628", PMAS = "1363", PFEM = "1265", VTOT = "767" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "44", Description = "SABINAS HIDAL", CveCab = "1", NameCab = "CIUDAD SABINAS HIDAL", PTOT = "34671", PMAS = "17214", PFEM = "17457", VTOT = "10027" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "45", Description = "SALINAS VICTORIA", CveCab = "1", NameCab = "SALINAS VICTORIA", PTOT = "32660", PMAS = "16800", PFEM = "15860", VTOT = "8544" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "46", Description = "SAN NICOLÁS DE LOS GARZA", CveCab = "1", NameCab = "SAN NICOLÁS DE LOS GARZA", PTOT = "443273", PMAS = "219337", PFEM = "223936", VTOT = "115413" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "47", Description = "HIDALGO", CveCab = "1", NameCab = "HIDAL", PTOT = "16604", PMAS = "8318", PFEM = "8286", VTOT = "4398" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "48", Description = "SANTA CATARINA", CveCab = "1", NameCab = "CIUDAD SANTA CATARINA", PTOT = "268955", PMAS = "134388", PFEM = "134567", VTOT = "67067" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "49", Description = "SANTIA", CveCab = "1", NameCab = "SANTIA", PTOT = "40469", PMAS = "20341", PFEM = "20128", VTOT = "11675" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "50", Description = "VALLECILLO", CveCab = "1", NameCab = "VALLECILLO", PTOT = "1971", PMAS = "1065", PFEM = "906", VTOT = "641" });
                    defaultCities.Add(new City() { StateProvinceId = 1, CountryRegionId = 1, CveEnt = "19", CveCity = "51", Description = "VILLALDAMA", CveCab = "1", NameCab = "CIUDAD DE VILLALDAMA", PTOT = "4113", PMAS = "2073", PFEM = "2040", VTOT = "1318" });

                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "1", Description = "ACATIC", CveCab = "1", NameCab = "ACATIC", PTOT = "21206", PMAS = "10348", PFEM = "10858", VTOT = "5256" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "2", Description = "ACATLÁN DE JUÁREZ", CveCab = "1", NameCab = "ACATLÁN DE JUÁREZ", PTOT = "23241", PMAS = "12220", PFEM = "11021", VTOT = "5363" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "3", Description = "AHUALULCO DE MERCADO", CveCab = "1", NameCab = "AHUALULCO DE MERCADO", PTOT = "21714", PMAS = "10677", PFEM = "11037", VTOT = "5657" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "4", Description = "AMACUECA", CveCab = "1", NameCab = "AMACUECA", PTOT = "5545", PMAS = "2674", PFEM = "2871", VTOT = "1411" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "5", Description = "AMATITÁN", CveCab = "1", NameCab = "AMATITÁN", PTOT = "14648", PMAS = "7273", PFEM = "7375", VTOT = "3455" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "6", Description = "AMECA", CveCab = "1", NameCab = "AMECA", PTOT = "57340", PMAS = "28013", PFEM = "29327", VTOT = "15559" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "7", Description = "SAN JUANITO DE ESCOBEDO", CveCab = "1", NameCab = "SAN JUANITO DE ESCOBEDO", PTOT = "8896", PMAS = "4461", PFEM = "4435", VTOT = "2333" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "8", Description = "ARANDAS", CveCab = "1", NameCab = "ARANDAS", PTOT = "72812", PMAS = "35135", PFEM = "37677", VTOT = "18033" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "9", Description = "EL ARENAL", CveCab = "1", NameCab = "EL ARENAL", PTOT = "17545", PMAS = "8631", PFEM = "8914", VTOT = "4229" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "10", Description = "ATEMAJAC DE BRIZUELA", CveCab = "1", NameCab = "ATEMAJAC DE BRIZUELA", PTOT = "6655", PMAS = "3303", PFEM = "3352", VTOT = "1437" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "11", Description = "ATEN", CveCab = "1", NameCab = "ATEN", PTOT = "5400", PMAS = "2797", PFEM = "2603", VTOT = "1388" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "12", Description = "ATENGUILLO", CveCab = "1", NameCab = "ATENGUILLO", PTOT = "4115", PMAS = "2014", PFEM = "2101", VTOT = "1182" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "13", Description = "ATOTONILCO EL ALTO", CveCab = "1", NameCab = "ATOTONILCO EL ALTO", PTOT = "57717", PMAS = "28217", PFEM = "29500", VTOT = "14182" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "14", Description = "ATOYAC", CveCab = "1", NameCab = "ATOYAC", PTOT = "8276", PMAS = "3962", PFEM = "4314", VTOT = "2255" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "15", Description = "AUTLÁN DE NAVARRO", CveCab = "1", NameCab = "AUTLÁN DE NAVARRO", PTOT = "57559", PMAS = "28210", PFEM = "29349", VTOT = "15077" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "16", Description = "AYOTLÁN", CveCab = "1", NameCab = "AYOTLÁN", PTOT = "38291", PMAS = "18603", PFEM = "19688", VTOT = "9095" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "17", Description = "AYUTLA", CveCab = "1", NameCab = "AYUTLA", PTOT = "12664", PMAS = "6308", PFEM = "6356", VTOT = "3245" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "18", Description = "LA BARCA", CveCab = "1", NameCab = "LA BARCA", PTOT = "64269", PMAS = "30920", PFEM = "33349", VTOT = "15557" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "19", Description = "BOLAÑOS", CveCab = "1", NameCab = "BOLAÑOS", PTOT = "6820", PMAS = "3384", PFEM = "3436", VTOT = "1441" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "20", Description = "CABO CORRIENTES", CveCab = "1", NameCab = "EL TUITO", PTOT = "10029", PMAS = "5176", PFEM = "4853", VTOT = "2615" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "21", Description = "CASIMIRO CASTILLO", CveCab = "1", NameCab = "LA RESOLANA", PTOT = "21475", PMAS = "10667", PFEM = "10808", VTOT = "5772" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "22", Description = "CIHUATLÁN", CveCab = "1", NameCab = "CIHUATLÁN", PTOT = "39020", PMAS = "19694", PFEM = "19326", VTOT = "10306" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "23", Description = "ZAPOTLÁN EL GRANDE", CveCab = "1", NameCab = "CIUDAD GUZMÁN", PTOT = "100534", PMAS = "48661", PFEM = "51873", VTOT = "25107" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "24", Description = "COCULA", CveCab = "1", NameCab = "COCULA", PTOT = "26174", PMAS = "12721", PFEM = "13453", VTOT = "6819" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "25", Description = "COLOTLÁN", CveCab = "1", NameCab = "COLOTLÁN", PTOT = "18091", PMAS = "8711", PFEM = "9380", VTOT = "4708" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "26", Description = "CONCEPCIÓN DE BUENOS AIRES", CveCab = "1", NameCab = "CONCEPCIÓN DE BUENOS AIRES", PTOT = "5933", PMAS = "3011", PFEM = "2922", VTOT = "1619" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "27", Description = "CUAUTITLÁN DE GARCÍA BARRAGÁN", CveCab = "1", NameCab = "CUAUTITLÁN DE GARCÍA BARRAGÁN", PTOT = "17322", PMAS = "8763", PFEM = "8559", VTOT = "4242" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "28", Description = "CUAUTLA", CveCab = "1", NameCab = "CUAUTLA", PTOT = "2171", PMAS = "1045", PFEM = "1126", VTOT = "584" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "29", Description = "CUQUÍO", CveCab = "1", NameCab = "CUQUÍO", PTOT = "17795", PMAS = "8488", PFEM = "9307", VTOT = "4488" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "30", Description = "CHAPALA", CveCab = "1", NameCab = "CHAPALA", PTOT = "48839", PMAS = "23902", PFEM = "24937", VTOT = "12681" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "31", Description = "CHIMALTITÁN", CveCab = "1", NameCab = "CHIMALTITÁN", PTOT = "3771", PMAS = "1869", PFEM = "1902", VTOT = "913" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "32", Description = "CHIQUILISTLÁN", CveCab = "1", NameCab = "CHIQUILISTLÁN", PTOT = "5814", PMAS = "2896", PFEM = "2918", VTOT = "1341" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "33", Description = "DELLADO", CveCab = "1", NameCab = "DELLADO", PTOT = "21132", PMAS = "10119", PFEM = "11013", VTOT = "5262" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "34", Description = "EJUTLA", CveCab = "1", NameCab = "EJUTLA", PTOT = "2082", PMAS = "1072", PFEM = "1010", VTOT = "611" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "35", Description = "ENCARNACIÓN DE DÍAZ", CveCab = "1", NameCab = "ENCARNACIÓN DE DÍAZ", PTOT = "51396", PMAS = "24692", PFEM = "26704", VTOT = "12508" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "36", Description = "ETZATLÁN", CveCab = "1", NameCab = "ETZATLÁN", PTOT = "18632", PMAS = "9157", PFEM = "9475", VTOT = "4698" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "37", Description = "EL GRULLO", CveCab = "1", NameCab = "EL GRULLO", PTOT = "23845", PMAS = "11622", PFEM = "12223", VTOT = "6321" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "38", Description = "GUACHINAN", CveCab = "1", NameCab = "GUACHINAN", PTOT = "4323", PMAS = "2178", PFEM = "2145", VTOT = "1218" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "39", Description = "GUADALAJARA", CveCab = "1", NameCab = "GUADALAJARA", PTOT = "1495189", PMAS = "717404", PFEM = "777785", VTOT = "379624" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "40", Description = "HOSTOTIPAQUILLO", CveCab = "1", NameCab = "HOSTOTIPAQUILLO", PTOT = "10284", PMAS = "5501", PFEM = "4783", VTOT = "2261" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "41", Description = "HUEJÚCAR", CveCab = "1", NameCab = "HUEJÚCAR", PTOT = "6084", PMAS = "2905", PFEM = "3179", VTOT = "1746" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "42", Description = "HUEJUQUILLA EL ALTO", CveCab = "1", NameCab = "HUEJUQUILLA EL ALTO", PTOT = "8781", PMAS = "4237", PFEM = "4544", VTOT = "2143" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "43", Description = "LA HUERTA", CveCab = "1", NameCab = "LA HUERTA", PTOT = "23428", PMAS = "11845", PFEM = "11583", VTOT = "6360" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "44", Description = "IXTLAHUACÁN DE LOS MEMBRILLOS", CveCab = "1", NameCab = "IXTLAHUACÁN DE LOS MEMBRILLOS", PTOT = "41060", PMAS = "20419", PFEM = "20641", VTOT = "10493" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "45", Description = "IXTLAHUACÁN DEL RÍO", CveCab = "1", NameCab = "IXTLAHUACÁN DEL RÍO", PTOT = "19005", PMAS = "9175", PFEM = "9830", VTOT = "4786" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "46", Description = "JALOSTOTITLÁN", CveCab = "1", NameCab = "JALOSTOTITLÁN", PTOT = "31948", PMAS = "15598", PFEM = "16350", VTOT = "7594" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "47", Description = "JAMAY", CveCab = "1", NameCab = "JAMAY", PTOT = "22881", PMAS = "11337", PFEM = "11544", VTOT = "5515" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "48", Description = "JESÚS MARÍA", CveCab = "1", NameCab = "JESÚS MARÍA", PTOT = "18634", PMAS = "8571", PFEM = "10063", VTOT = "4634" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "49", Description = "JILOTLÁN DE LOS DOLORES", CveCab = "1", NameCab = "JILOTLÁN DE LOS DOLORES", PTOT = "9545", PMAS = "4905", PFEM = "4640", VTOT = "2456" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "50", Description = "JOCOTEPEC", CveCab = "1", NameCab = "JOCOTEPEC", PTOT = "42164", PMAS = "20839", PFEM = "21325", VTOT = "9375" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "51", Description = "JUANACATLÁN", CveCab = "1", NameCab = "JUANACATLÁN", PTOT = "13218", PMAS = "6675", PFEM = "6543", VTOT = "3232" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "52", Description = "JUCHITLÁN", CveCab = "1", NameCab = "JUCHITLÁN", PTOT = "5515", PMAS = "2637", PFEM = "2878", VTOT = "1495" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "53", Description = "LAS DE MORENO", CveCab = "1", NameCab = "LAS DE MORENO", PTOT = "153817", PMAS = "74472", PFEM = "79345", VTOT = "36001" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "54", Description = "EL LIMÓN", CveCab = "1", NameCab = "EL LIMÓN", PTOT = "5499", PMAS = "2752", PFEM = "2747", VTOT = "1740" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "55", Description = "MAGDALENA", CveCab = "1", NameCab = "MAGDALENA", PTOT = "21321", PMAS = "10583", PFEM = "10738", VTOT = "5055" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "56", Description = "SANTA MARÍA DEL ORO", CveCab = "1", NameCab = "SANTA MARÍA DEL ORO", PTOT = "2517", PMAS = "1273", PFEM = "1244", VTOT = "672" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "57", Description = "LA MANZANILLA DE LA PAZ", CveCab = "1", NameCab = "LA MANZANILLA DE LA PAZ", PTOT = "3755", PMAS = "1790", PFEM = "1965", VTOT = "1059" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "58", Description = "MASCOTA", CveCab = "1", NameCab = "MASCOTA", PTOT = "14245", PMAS = "7010", PFEM = "7235", VTOT = "3855" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "59", Description = "MAZAMITLA", CveCab = "1", NameCab = "MAZAMITLA", PTOT = "13225", PMAS = "6288", PFEM = "6937", VTOT = "3284" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "60", Description = "MEXTICACÁN", CveCab = "1", NameCab = "MEXTICACÁN", PTOT = "6034", PMAS = "2777", PFEM = "3257", VTOT = "1722" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "61", Description = "MEZQUITIC", CveCab = "1", NameCab = "MEZQUITIC", PTOT = "18084", PMAS = "8745", PFEM = "9339", VTOT = "3754" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "62", Description = "MIXTLÁN", CveCab = "1", NameCab = "MIXTLÁN", PTOT = "3574", PMAS = "1800", PFEM = "1774", VTOT = "946" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "63", Description = "OCOTLÁN", CveCab = "1", NameCab = "OCOTLÁN", PTOT = "92967", PMAS = "45453", PFEM = "47514", VTOT = "23118" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "64", Description = "OJUELOS DE JALISCO", CveCab = "1", NameCab = "OJUELOS DE JALISCO", PTOT = "30097", PMAS = "14636", PFEM = "15461", VTOT = "6718" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "65", Description = "PIHUAMO", CveCab = "1", NameCab = "PIHUAMO", PTOT = "12119", PMAS = "6045", PFEM = "6074", VTOT = "3464" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "66", Description = "PONCITLÁN", CveCab = "1", NameCab = "PONCITLÁN", PTOT = "48408", PMAS = "23721", PFEM = "24687", VTOT = "10714" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "67", Description = "PUERTO VALLARTA", CveCab = "1", NameCab = "PUERTO VALLARTA", PTOT = "255681", PMAS = "128577", PFEM = "127104", VTOT = "68710" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "68", Description = "VILLA PURIFICACIÓN", CveCab = "1", NameCab = "VILLA PURIFICACIÓN", PTOT = "11623", PMAS = "5933", PFEM = "5690", VTOT = "3108" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "69", Description = "QUITUPAN", CveCab = "1", NameCab = "QUITUPAN", PTOT = "8691", PMAS = "4066", PFEM = "4625", VTOT = "2396" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "70", Description = "EL SALTO", CveCab = "1", NameCab = "EL SALTO", PTOT = "138226", PMAS = "69006", PFEM = "69220", VTOT = "32233" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "71", Description = "SAN CRISTÓBAL DE LA BARRANCA", CveCab = "1", NameCab = "SAN CRISTÓBAL DE LA BARRANCA", PTOT = "3176", PMAS = "1583", PFEM = "1593", VTOT = "770" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "72", Description = "SAN DIE DE ALEJANDRÍA", CveCab = "1", NameCab = "SAN DIE DE ALEJANDRÍA", PTOT = "6647", PMAS = "3172", PFEM = "3475", VTOT = "1534" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "73", Description = "SAN JUAN DE LOS LAS", CveCab = "1", NameCab = "SAN JUAN DE LOS LAS", PTOT = "65219", PMAS = "32066", PFEM = "33153", VTOT = "15134" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "74", Description = "SAN JULIÁN", CveCab = "1", NameCab = "SAN JULIÁN", PTOT = "15454", PMAS = "7296", PFEM = "8158", VTOT = "3916" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "75", Description = "SAN MARCOS", CveCab = "1", NameCab = "SAN MARCOS", PTOT = "3762", PMAS = "1918", PFEM = "1844", VTOT = "949" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "76", Description = "SAN MARTÍN DE BOLAÑOS", CveCab = "1", NameCab = "SAN MARTÍN DE BOLAÑOS", PTOT = "3405", PMAS = "1704", PFEM = "1701", VTOT = "837" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "77", Description = "SAN MARTÍN HIDAL", CveCab = "1", NameCab = "SAN MARTÍN HIDAL", PTOT = "26306", PMAS = "12785", PFEM = "13521", VTOT = "7263" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "78", Description = "SAN MIGUEL EL ALTO", CveCab = "1", NameCab = "SAN MIGUEL EL ALTO", PTOT = "31166", PMAS = "14999", PFEM = "16167", VTOT = "7541" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "79", Description = "GÓMEZ FARÍAS", CveCab = "1", NameCab = "SAN SEBASTIÁN DEL SUR", PTOT = "14011", PMAS = "6778", PFEM = "7233", VTOT = "3250" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "80", Description = "SAN SEBASTIÁN DEL OESTE", CveCab = "1", NameCab = "SAN SEBASTIÁN DEL OESTE", PTOT = "5755", PMAS = "3008", PFEM = "2747", VTOT = "1574" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "81", Description = "SANTA MARÍA DE LOS ÁNGELES", CveCab = "1", NameCab = "SANTA MARÍA DE LOS ÁNGELES", PTOT = "3726", PMAS = "1758", PFEM = "1968", VTOT = "1030" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "82", Description = "SAYULA", CveCab = "1", NameCab = "SAYULA", PTOT = "34829", PMAS = "16733", PFEM = "18096", VTOT = "8308" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "83", Description = "TALA", CveCab = "1", NameCab = "TALA", PTOT = "69031", PMAS = "34313", PFEM = "34718", VTOT = "17495" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "84", Description = "TALPA DE ALLENDE", CveCab = "1", NameCab = "TALPA DE ALLENDE", PTOT = "14410", PMAS = "7215", PFEM = "7195", VTOT = "3669" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "85", Description = "TAMAZULA DE RDIANO", CveCab = "1", NameCab = "TAMAZULA DE RDIANO", PTOT = "37986", PMAS = "18512", PFEM = "19474", VTOT = "10522" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "86", Description = "TAPALPA", CveCab = "1", NameCab = "TAPALPA", PTOT = "18096", PMAS = "8848", PFEM = "9248", VTOT = "3942" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "87", Description = "TECALITLÁN", CveCab = "1", NameCab = "TECALITLÁN", PTOT = "16847", PMAS = "8220", PFEM = "8627", VTOT = "4481" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "88", Description = "TECOLOTLÁN", CveCab = "1", NameCab = "TECOLOTLÁN", PTOT = "16573", PMAS = "8292", PFEM = "8281", VTOT = "4555" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "89", Description = "TECHALUTA DE MONTENEGRO", CveCab = "1", NameCab = "TECHALUTA DE MONTENEGRO", PTOT = "3511", PMAS = "1722", PFEM = "1789", VTOT = "938" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "90", Description = "TENAMAXTLÁN", CveCab = "1", NameCab = "TENAMAXTLÁN", PTOT = "7051", PMAS = "3495", PFEM = "3556", VTOT = "2009" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "91", Description = "TEOCALTICHE", CveCab = "1", NameCab = "TEOCALTICHE", PTOT = "40105", PMAS = "18973", PFEM = "21132", VTOT = "10106" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "92", Description = "TEOCUITATLÁN DE CORONA", CveCab = "1", NameCab = "TEOCUITATLÁN DE CORONA", PTOT = "10837", PMAS = "5307", PFEM = "5530", VTOT = "3069" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "93", Description = "TEPATITLÁN DE MORELOS", CveCab = "1", NameCab = "TEPATITLÁN DE MORELOS", PTOT = "136123", PMAS = "66244", PFEM = "69879", VTOT = "33088" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "94", Description = "TEQUILA", CveCab = "1", NameCab = "TEQUILA", PTOT = "40697", PMAS = "20148", PFEM = "20549", VTOT = "9225" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "95", Description = "TEUCHITLÁN", CveCab = "1", NameCab = "TEUCHITLÁN", PTOT = "9088", PMAS = "4425", PFEM = "4663", VTOT = "2429" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "96", Description = "TIZAPÁN EL ALTO", CveCab = "1", NameCab = "TIZAPÁN EL ALTO", PTOT = "20857", PMAS = "10163", PFEM = "10694", VTOT = "5460" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "97", Description = "TLAJOMULCO DE ZÚÑIGA", CveCab = "1", NameCab = "TLAJOMULCO DE ZÚÑIGA", PTOT = "416626", PMAS = "206958", PFEM = "209668", VTOT = "105973" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "98", Description = "SAN PEDRO TLAQUEPAQUE", CveCab = "1", NameCab = "TLAQUEPAQUE", PTOT = "608114", PMAS = "299904", PFEM = "308210", VTOT = "143359" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "99", Description = "TOLIMÁN", CveCab = "1", NameCab = "TOLIMÁN", PTOT = "9591", PMAS = "4724", PFEM = "4867", VTOT = "2353" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "100", Description = "TOMATLÁN", CveCab = "1", NameCab = "TOMATLÁN", PTOT = "35050", PMAS = "17822", PFEM = "17228", VTOT = "8908" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "101", Description = "TONALÁ", CveCab = "1", NameCab = "TONALÁ", PTOT = "478689", PMAS = "243241", PFEM = "235448", VTOT = "107305" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "102", Description = "TONAYA", CveCab = "1", NameCab = "TONAYA", PTOT = "5930", PMAS = "2874", PFEM = "3056", VTOT = "1647" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "103", Description = "TONILA", CveCab = "1", NameCab = "TONILA", PTOT = "7256", PMAS = "3573", PFEM = "3683", VTOT = "1976" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "104", Description = "TOTATICHE", CveCab = "1", NameCab = "TOTATICHE", PTOT = "4435", PMAS = "2209", PFEM = "2226", VTOT = "1334" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "105", Description = "TOTOTLÁN", CveCab = "1", NameCab = "TOTOTLÁN", PTOT = "21871", PMAS = "10668", PFEM = "11203", VTOT = "5530" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "106", Description = "TUXCACUESCO", CveCab = "1", NameCab = "TUXCACUESCO", PTOT = "4234", PMAS = "2168", PFEM = "2066", VTOT = "1104" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "107", Description = "TUXCUECA", CveCab = "1", NameCab = "TUXCUECA", PTOT = "6316", PMAS = "3054", PFEM = "3262", VTOT = "1571" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "108", Description = "TUXPAN", CveCab = "1", NameCab = "TUXPAN", PTOT = "34182", PMAS = "16442", PFEM = "17740", VTOT = "8165" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "109", Description = "UNIÓN DE SAN ANTONIO", CveCab = "1", NameCab = "UNIÓN DE SAN ANTONIO", PTOT = "17325", PMAS = "8306", PFEM = "9019", VTOT = "4122" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "110", Description = "UNIÓN DE TULA", CveCab = "1", NameCab = "UNIÓN DE TULA", PTOT = "13737", PMAS = "6620", PFEM = "7117", VTOT = "3687" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "111", Description = "VALLE DE GUADALUPE", CveCab = "1", NameCab = "VALLE DE GUADALUPE", PTOT = "6705", PMAS = "3333", PFEM = "3372", VTOT = "1693" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "112", Description = "VALLE DE JUÁREZ", CveCab = "1", NameCab = "VALLE DE JUÁREZ", PTOT = "5798", PMAS = "2806", PFEM = "2992", VTOT = "1613" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "113", Description = "SAN GABRIEL", CveCab = "1", NameCab = "SAN GABRIEL", PTOT = "15310", PMAS = "7507", PFEM = "7803", VTOT = "3931" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "114", Description = "VILLA CORONA", CveCab = "1", NameCab = "VILLA CORONA", PTOT = "16969", PMAS = "8357", PFEM = "8612", VTOT = "4431" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "115", Description = "VILLA GUERRERO", CveCab = "1", NameCab = "VILLA GUERRERO", PTOT = "5638", PMAS = "2785", PFEM = "2853", VTOT = "1542" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "116", Description = "VILLA HIDAL", CveCab = "1", NameCab = "VILLA HIDAL", PTOT = "18711", PMAS = "9043", PFEM = "9668", VTOT = "4604" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "117", Description = "CAÑADAS DE OBREGÓN", CveCab = "1", NameCab = "CAÑADAS DE OBREGÓN", PTOT = "4152", PMAS = "2015", PFEM = "2137", VTOT = "1216" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "118", Description = "YAHUALICA DE NZÁLEZ GALLO", CveCab = "1", NameCab = "YAHUALICA DE NZÁLEZ GALLO", PTOT = "22284", PMAS = "10586", PFEM = "11698", VTOT = "6293" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "119", Description = "ZACOALCO DE TORRES", CveCab = "1", NameCab = "ZACOALCO DE TORRES", PTOT = "27901", PMAS = "13698", PFEM = "14203", VTOT = "6779" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "120", Description = "ZAPOPAN", CveCab = "1", NameCab = "ZAPOPAN", PTOT = "1243756", PMAS = "607907", PFEM = "635849", VTOT = "317419" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "121", Description = "ZAPOTILTIC", CveCab = "1", NameCab = "ZAPOTILTIC", PTOT = "29192", PMAS = "14181", PFEM = "15011", VTOT = "7527" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "122", Description = "ZAPOTITLÁN DE VADILLO", CveCab = "1", NameCab = "ZAPOTITLÁN DE VADILLO", PTOT = "6685", PMAS = "3328", PFEM = "3357", VTOT = "1642" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "123", Description = "ZAPOTLÁN DEL REY", CveCab = "1", NameCab = "ZAPOTLÁN DEL REY", PTOT = "17585", PMAS = "8671", PFEM = "8914", VTOT = "4343" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "124", Description = "ZAPOTLANEJO", CveCab = "1", NameCab = "ZAPOTLANEJO", PTOT = "63636", PMAS = "31114", PFEM = "32522", VTOT = "15642" });
                    defaultCities.Add(new City() { StateProvinceId = 2, CountryRegionId = 1, CveEnt = "14", CveCity = "125", Description = "SAN IGNACIO CERRO RDO", CveCab = "1", NameCab = "SAN IGNACIO CERRO RDO", PTOT = "17626", PMAS = "8501", PFEM = "9125", VTOT = "4171" });
                    #endregion

                    #region Credenciales

                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "JUAN GERARDO",
                        LastNameFather = "GUERRA",
                        LastNameMother = "RODRIGUEZ",
                        Address = "AV. GALAXIA 144 COL. METROPLEX 1ER. SEC 66612 APODACA, N.L.",
                        ElectroKey = "GRRDJN9901919H7000",
                        CURP = "GURJ990109HNLRDN03",
                        BirthDate = "09-01-1999",
                        YearRegistration = "2017",
                        StateProvinceId = 1,
                        CityId = 6,
                        Section = "0069",
                        Localization = "1",
                        Issue = "2017",
                        Validity = "2027",
                        Gender = "H",
                        CIC = "IDMEX1558771189"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "VICENTE",
                        LastNameFather = "GARCIA",
                        LastNameMother = "MENDOZA",
                        Address = "C NOCHE BUENA 334 FRACC NUEVO LAS PUENTES 3ER SECTOR 66612 APODACA, N.L.",
                        ElectroKey = "GRMNVC00042019H900",
                        CURP = "GAMV000420HNLRNCA5",
                        BirthDate = "20-04-2000",
                        YearRegistration = "2018",
                        StateProvinceId = 1,
                        CityId = 6,
                        Section = "2429",
                        Localization = "1",
                        Issue = "2018",
                        Validity = "2028",
                        Gender = "H",
                        CIC = "IDMEX1780284813"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "ARTURO ASAEL",
                        LastNameFather = "HERNANDEZ",
                        LastNameMother = "TORRES",
                        Address = "AV LOS AMARANTOS 411 FRACC LOS AMARANTOS 66613 APODACA, N.L.",
                        ElectroKey = "HRTRAR98060219H000",
                        CURP = "HETA980602HNLRRR03",
                        BirthDate = "02-06-1999",
                        YearRegistration = "2016",
                        StateProvinceId = 1,
                        CityId = 6,
                        Section = "2501",
                        Localization = "1",
                        Issue = "2016",
                        Validity = "2026",
                        Gender = "H",
                        CIC = "IDMEX1510744914"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "PEDRO ARMANDO",
                        LastNameFather = "LOPEZ",
                        LastNameMother = "RIVERA",
                        Address = "C VIVERO DEL ROCIO 105 FRACC PORTAL DE LAS SALINAS 65550 CIENEGA DE FLORES, N.L.",
                        ElectroKey = "LPRVPD99080619H400",
                        CURP = "LORP990806HNLPVD04",
                        BirthDate = "06-08-1999",
                        YearRegistration = "2017",
                        StateProvinceId = 1,
                        CityId = 6,
                        Section = "0232",
                        Localization = "1",
                        Issue = "2017",
                        Validity = "2027",
                        Gender = "H",
                        CIC = "IDMEX1671728400"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "ALAN JESUS",
                        LastNameFather = "SAPIENS",
                        LastNameMother = "IRIBE",
                        Address = "C MADRID 4906 COL BALCONES DEL VALLE 80184 CULIACAN, SIN",
                        ElectroKey = "SPIRAL97122425H300",
                        CURP = "SAIA971224HSLPRL03",
                        BirthDate = "24-12-1997",
                        YearRegistration = "2016",
                        StateProvinceId = 1,
                        CityId = 6,
                        Section = "1201",
                        Localization = "1",
                        Issue = "2016",
                        Validity = "2026",
                        Gender = "H",
                        CIC = "IDMEX1472959902",
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "HILDA JOSELINE",
                        LastNameFather = "ORTEGA",
                        LastNameMother = "MORENO",
                        Address = "C HABANA 210 COL PARAJE DE SANTA ROSA SEC NORTE 66610 APODACA, N.L.",
                        ElectroKey = "ORMRHL00072519M000",
                        CURP = "OEMH000725MNLRRLA5",
                        BirthDate = "25-07-2000",
                        YearRegistration = "2018",
                        StateProvinceId = 1,
                        CityId = 6,
                        Section = "2469",
                        Localization = "1",
                        Issue = "2018",
                        Validity = "2028",
                        Gender = "M",
                        CIC = "IDMEX1756816884"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "LUIS DAVID",
                        LastNameFather = "HARO",
                        LastNameMother = "AGUILAR",
                        Address = "C AZAFRAN 104 FRACC LOS AMARANTOS 66613 APODACA, N.L.",
                        ElectroKey = "HRAGLS98092324H200",
                        CURP = "HAAL980923HSPRGS07",
                        BirthDate = "23-09-1998",
                        YearRegistration = "2016",
                        StateProvinceId = 1,
                        CityId = 6,
                        Section = "2501",
                        Localization = "1",
                        Issue = "2016",
                        Validity = "2026",
                        Gender = "H",
                        CIC = "IDMEX1533146968"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "JUAN GUSTAVO",
                        LastNameFather = "SALAS",
                        LastNameMother = "FLORES",
                        Address = "Jarrilla #630 EBANOS SEGUNDO SECTOR. APODACA, N.L.",
                        ElectroKey = "SFJG97561348H94300",
                        CURP = "SAFJ970612HNLLLN01",
                        BirthDate = "12-06-1997",
                        YearRegistration = "2018",
                        StateProvinceId = 1,
                        CityId = 6,
                        Section = "0620",
                        Localization = "1",
                        Issue = "2018",
                        Validity = "2028",
                        Gender = "H",
                        CIC = "IDMEX1836577717"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "JONATHAN",
                        LastNameFather = "GONZALEZ",
                        LastNameMother = "FERNANDEZ",
                        Address = "GRAL PABLO DE LA GARZA 247 COL JARDINES DE ESCOBEDO 1ER. SEC 66050 GRAL. ESCOBEDO, N.L.",
                        ElectroKey = "GNFRJN97102019H800",
                        CURP = "GOFJ971020HNLNR04",
                        BirthDate = "20-10-1997",
                        YearRegistration = "2015",
                        StateProvinceId = 1,
                        CityId = 21,
                        Section = "0451",
                        Localization = "1",
                        Issue = "2015",
                        Validity = "2025",
                        Gender = "H",
                        CIC = "IDMEX1369817135"
                    });

                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "EDGAR ALFREDO",
                        LastNameFather = "GONZALEZ",
                        LastNameMother = "SALAZAR",
                        Address = "C DIEGO DE MONTEMAYOR 600 B AMPL LAZARO CARDENAS 66058 GRAL ESCOBEDO, N.L.",
                        ElectroKey = "GNSLED99031119H000",
                        CURP = "GOSE990311HNLNLD07",
                        BirthDate = "11-03-1999",
                        YearRegistration = "2017",
                        StateProvinceId = 1,
                        CityId = 21,
                        Section = ".0454",
                        Localization = "1",
                        Issue = "2017",
                        Validity = "2027",
                        Gender = "H",
                        CIC = "IDMEX1605645443"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "OMAR ANDRES",
                        LastNameFather = "GARCIA",
                        LastNameMother = "HERNANDEZ",
                        Address = "PROL AGUILA REAL 129 A COL VILLAS DE SAN FRANCISCO 66062 GRAL ESCOBEDO, N.L.",
                        ElectroKey = "GRHROM98022028H200",
                        CURP = "GAHO980220HTSRRM05",
                        BirthDate = "20-02-1998",
                        YearRegistration = "2016",
                        StateProvinceId = 1,
                        CityId = 21,
                        Section = ".0441",
                        Localization = "1",
                        Issue = "2017",
                        Validity = "2027",
                        Gender = "H",
                        CIC = "IDMEX157554"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "JESUS DAVID",
                        LastNameFather = "TORRES",
                        LastNameMother = "GARCIA",
                        Address = "C FRESNO 340 FRACC LOS GIRASOLES 3ER SEC 66050 GRAL. ESCOBEDO, N.L.",
                        ElectroKey = "TRGRJS99082719H700",
                        CURP = "TOGJ990820HNLRRS08",
                        BirthDate = "31-05-1999",
                        YearRegistration = "2018",
                        StateProvinceId = 1,
                        CityId = 21,
                        Section = ".0480",
                        Localization = "1",
                        Issue = "2018",
                        Validity = "2028",
                        Gender = "H",
                        CIC = "IDMEX1747130270"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "RUBEN",
                        LastNameFather = "ESCOBAR",
                        LastNameMother = "LOZANO",
                        Address = "C ITURBIDE 602 ZONA CENTRO 65500 SALINAS VICTORIA, N.L.",
                        ElectroKey = "ESLZRB97090119H400",
                        CURP = "EOLR970901HNLSZB07",
                        BirthDate = "01-09-1997",
                        YearRegistration = "2015",
                        StateProvinceId = 1,
                        CityId = 44,
                        Section = "1755",
                        Localization = "1",
                        Issue = "2015",
                        Validity = "2025",
                        Gender = "H",
                        CIC = "IDMEX1367474518"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "FABIAN",
                        LastNameFather = "REBOLORIO",
                        LastNameMother = "MENDEZ",
                        Address = "C CIUDADELA 116 B FRACC BOSQUES DE CASTILLA 65503 SALINAS VICTORIA, N.L.",
                        ElectroKey = "RBMNFB99053107H300",
                        CURP = "REMF990531HCSBNB000",
                        BirthDate = "31-05-1999",
                        YearRegistration = "2017",
                        StateProvinceId = 1,
                        CityId = 44,
                        Section = "1760",
                        Localization = "1",
                        Issue = "2017",
                        Validity = "2027",
                        Gender = "H",
                        CIC = "IDMEX1618329551"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "JESSIKA NOHEMI",
                        LastNameFather = "DE LA CRUZ",
                        LastNameMother = "GONZALEZ",
                        Address = "C 2A AVENIDA 424 COL SATELITE DEL NORTE 65500 SALINAS VICTORIA, N.L.",
                        ElectroKey = "CRGNJS98071519M700",
                        CURP = "CUGJ980715MNLRNS02",
                        BirthDate = "15-07-1998",
                        YearRegistration = "2016",
                        StateProvinceId = 1,
                        CityId = 44,
                        Section = "1760",
                        Localization = "1",
                        Issue = "2016",
                        Validity = "2026",
                        Gender = "M",
                        CIC = "IDMEX1509869514",
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "ADRIAN ALFONSO",
                        LastNameFather = "GONZALEZ",
                        LastNameMother = "GONZALEZ",
                        Address = "C ZARAGOZA 104 NTE CENTRO DE CARMEN 66550 CARMEN, N.L.",
                        ElectroKey = "GNGNAD98123019H600",
                        CURP = "GOGA981230HNLNND08",
                        BirthDate = "30-12-1998",
                        YearRegistration = "2017",
                        StateProvinceId = 1,
                        CityId = 44,
                        Section = "0218",
                        Localization = "1",
                        Issue = "2017",
                        Validity = "2027",
                        Gender = "H",
                        CIC = "IDMEX1568040260"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "JORGE DE JESUS",
                        LastNameFather = "PEREZ",
                        LastNameMother = "SANCHEZ",
                        Address = "C AZUCENA 234 COL PASEO DEL NOGALAR 66480 SAN NICOLAS DE LOS GARZA, N.L.",
                        ElectroKey = "PRSNJR99120519H700",
                        CURP = "PESJ991205HNLRNR04",
                        BirthDate = "05-12-1999",
                        YearRegistration = "2018",
                        StateProvinceId = 1,
                        CityId = 45,
                        Section = "1908",
                        Localization = "1",
                        Issue = "2018",
                        Validity = "2028",
                        Gender = "H",
                        CIC = "IDMEX1777943730"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "RONALDO",
                        LastNameFather = "GUIZAR",
                        LastNameMother = "PONCE",
                        Address = "C SABIDURIA 463 COL PASEO SAN NICOLAS 66446 SAN NINCOLAS DE LOS GARZA, N.L.",
                        ElectroKey = "GZPNRN00060116H500",
                        CURP = "GUPR000601HMNZNNA5",
                        BirthDate = "01-06-2000",
                        YearRegistration = "2018",
                        StateProvinceId = 1,
                        CityId = 45,
                        Section = "1897",
                        Localization = "1",
                        Issue = "2018",
                        Validity = "2028",
                        Gender = "H",
                        CIC = "IDMEX1797426068"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "FABIOLA BERENIC",
                        LastNameFather = "JIMENEZ",
                        LastNameMother = "ROCHA",
                        Address = "C ZONA PONIENTE 452 COL CENTRO DE SAN NICOLAS 666400 SAN NICOLAS DE LOS GARZA, N.L.",
                        ElectroKey = "JMRCFB98093019M100",
                        CURP = "JIRF980930MNLMCB00",
                        BirthDate = "30-09-1998",
                        YearRegistration = "2017",
                        StateProvinceId = 1,
                        CityId = 45,
                        Section = "0047",
                        Localization = "1",
                        Issue = "2017",
                        Validity = "2027",
                        Gender = "M",
                        CIC = "IDMEX1646791927"
                    });
                    defaultCitizens.Add(new Citizen()
                    {
                        Name = "ALBA JATSIRI",
                        LastNameFather = "GONZALEZ",
                        LastNameMother = "ARIAS",
                        Address = "CALLE 18 649 RDCIAL LAS PUENTES 2SEC 66460 SAN NICOLAS DE LOS GARZA, N.L.",
                        ElectroKey = "GNARAL97032719M700",
                        CURP = "GOAA970327MNLNRL01",
                        BirthDate = "20-03-1997",
                        YearRegistration = "2014",
                        StateProvinceId = 1,
                        CityId = 45,
                        Section = "1875",
                        Localization = "1",
                        Issue = "2014",
                        Validity = "2024",
                        Gender = "M",
                        CIC = "IDMEX1244951288"
                    });
                    #endregion

                    #region Partidos Politicos
                    politicalParties.Add(new PoliticalParty()
                    {
                        Name = "Partido Revolucionario Institucional",
                        Description = "PRI",
                        Foundation = "4 de marzo de 1929",
                    });
                    politicalParties.Add(new PoliticalParty()
                    {
                        Name = "Partido Accion Nacional",
                        Description = "PAN",
                        Foundation = "16 de septiembre de 1939",
                    });
                    politicalParties.Add(new PoliticalParty()
                    {
                        Name = "Movimiento Ciudadano",
                        Description = "MC",
                        Foundation = "1 de agosto de 1998",
                    });
                    politicalParties.Add(new PoliticalParty()
                    {
                        Name = "Nueva Alianza",
                        Description = "NA",
                        Foundation = "30 de enero de 2005",
                    });
                    politicalParties.Add(new PoliticalParty()
                    {
                        Name = "Partido Revolución Democrática",
                        Description = "PRD",
                        Foundation = "5 de mayo de 1989",
                    });
                    politicalParties.Add(new PoliticalParty()
                    {
                        Name = "Partido del trabajo",
                        Description = "PT",
                        Foundation = "8 de diciembre de 1990",
                    });
                    politicalParties.Add(new PoliticalParty()
                    {
                        Name = "Partido Verde Ecologista",
                        Description = "Partido Verde",
                        Foundation = "1986",
                    });
                    politicalParties.Add(new PoliticalParty()
                    {
                        Name = "Morena",
                        Description = "La esperanza de México",
                        Foundation = "2014 fundada por Andrés Manuel López Obrador",
                    });
                    #endregion

                    #region Candidatos
                    //PRESIDENTES//
                    presidents.Add(new President()
                    {
                        PoliticalPartyId = 1,
                        CountryRegionId = 1,
                        Name = "JOSE ANTONIO",
                        LastName = "MEADE KURIBEÑA",
                        Age = "49 AÑOS"
                    });
                    presidents.Add(new President()
                    {
                        PoliticalPartyId = 2,
                        CountryRegionId = 1,
                        Name = "RICARDO",
                        LastName = "ANAYA CORTES",
                        Age = "39 AÑOS"
                    });
                    presidents.Add(new President()
                    {
                        PoliticalPartyId = 8,
                        CountryRegionId = 1,
                        Name = "ANDRES MANUEL",
                        LastName = "LOPEZ OBRADOR",
                        Age = "64 AÑOS"
                    });

                    //GOBERNADORES DE NUEVO LEON//
                    governors.Add(new Governor()
                    {
                        PoliticalPartyId = 1,
                        StateProvinceId = 1,
                        Name = "IVONNE",
                        LastName = "ALVAREZ GARCIA",
                        Age = "47 AÑOS"
                    });
                    governors.Add(new Governor()
                    {
                        PoliticalPartyId = 2,
                        StateProvinceId = 1,
                        Name = "FELIPE DE JESUS",
                        LastName = "CANTU RODRIGUEZ",
                        Age = "45 AÑOS"
                    });
                    governors.Add(new Governor()
                    {
                        PoliticalPartyId = 5,
                        StateProvinceId = 1,
                        Name = "HUMBERTO",
                        LastName = "GONZALEZ SESMA",
                        Age = "52 AÑOS"
                    });

                    //GOBERNADORES DE JALISCO//
                    governors.Add(new Governor()
                    {
                        PoliticalPartyId = 1,
                        StateProvinceId = 2,
                        Name = "JORGE ARISTOTELES",
                        LastName = "SANDOVAL DIAZ",
                        Age = "54 AÑOS"
                    });
                    governors.Add(new Governor()
                    {
                        PoliticalPartyId = 2,
                        StateProvinceId = 2,
                        Name = "FERNANDO GUZMAN",
                        LastName = "PEREZ PELAEZ",
                        Age = "43 AÑOS"
                    });

                    //ALCALDES DE NUEVO LEON//

                    //ALCALDES DE APODACA//
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 1,
                        CityId = 6,
                        Name = "CESAR",
                        LastName = "GARZA VILLAREAL",
                        Age = "46 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 2,
                        CityId = 6,
                        Name = "ADRIAN MARIO",
                        LastName = "GONZALEZ CABALLERO",
                        Age = "43 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 5,
                        CityId = 6,
                        Name = "ROSA MARIA",
                        LastName = "URDIALES NAVARRO",
                        Age = "35 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 7,
                        CityId = 6,
                        Name = "MANUEL",
                        LastName = "RODRIGUEZ URESTI",
                        Age = "58 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 3,
                        CityId = 6,
                        Name = "JESUS RODRIGO",
                        LastName = "GARCIA VILLAREAL",
                        Age = "38 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 4,
                        CityId = 6,
                        Name = "MANUEL BRAULIO",
                        LastName = "MARTINEZ RAMIREZ",
                        Age = "51 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 8,
                        CityId = 6,
                        Name = "VICTOR HUGO",
                        LastName = "GARZA JIMENEZ",
                        Age = "32 AÑOS"
                    });

                    //ALCALDES DE ESCOBEDO//
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 1,
                        CityId = 21,
                        Name = "CLARA LUZ",
                        LastName = "FLORES CARRALES",
                        Age = "35 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 2,
                        CityId = 21,
                        Name = "GABRIEL EDUARDO",
                        LastName = "ALMAGUER SEGURA",
                        Age = "45 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 5,
                        CityId = 21,
                        Name = "DULCE VALERIA CRISTAL",
                        LastName = "MORALES ASTORGA",
                        Age = "40 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 7,
                        CityId = 21,
                        Name = "MARIA MAGDALENA",
                        LastName = "ALAFFA GUTIERREZ",
                        Age = "46 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 4,
                        CityId = 21,
                        Name = "JESUS LAURO",
                        LastName = "BRISEÑO TREVIÑO",
                        Age = "57 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 6,
                        CityId = 21,
                        Name = "KARLA IVONNE",
                        LastName = "GALICIA GUTIERREZ",
                        Age = "42 AÑOS"
                    });

                    //ALCALDES DE SAN NICOLAS//
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 1,
                        CityId = 45,
                        Name = "VERONICA PATRICIA",
                        LastName = "CANTU GONZALEZ",
                        Age = "48 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 2,
                        CityId = 45,
                        Name = "ZEFERINO",
                        LastName = "SALGADO ALMAGUER",
                        Age = "43 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 5,
                        CityId = 45,
                        Name = "RUBI",
                        LastName = "GARZA LOZANO",
                        Age = "34 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 7,
                        CityId = 45,
                        Name = "ROSALINDA LIZETH",
                        LastName = "CHAPA CHAVEZ",
                        Age = "40  AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 3,
                        CityId = 45,
                        Name = "BEATRIZ",
                        LastName = "ACOSTA ARMENDARIZ",
                        Age = "35 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 4,
                        CityId = 45,
                        Name = "RICARDO IVAN",
                        LastName = "YAÑEZ GONZALEZ",
                        Age = "52 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 8,
                        CityId = 45,
                        Name = "MARIO ALBERTO",
                        LastName = "CANTU GUTIERREZ",
                        Age = "46 AÑOS"
                    });

                    //ALCALDES DE SALINAS VICTORIA//
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 1,
                        CityId = 44,
                        Name = "ABEL",
                        LastName = "FLORES REYES",
                        Age = "37 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 2,
                        CityId = 44,
                        Name = "GONZALO",
                        LastName = "ELIZONDO LIRA",
                        Age = "50 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 5,
                        CityId = 44,
                        Name = "DINA ELIZABETH",
                        LastName = "GUAJARDO FLORES",
                        Age = "43 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 3,
                        CityId = 44,
                        Name = "SANDRA PATRICIA",
                        LastName = "GUAJARDO FLORES",
                        Age = "46 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 4,
                        CityId = 44,
                        Name = "MIGUEL ANGEL",
                        LastName = "RODRIGUEZ LOZANO",
                        Age = "53 AÑOS"
                    });

                    //ALCALDES DE JALISCO//

                    //ALCALDES DE GUADALAJARA//
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 1,
                        CityId = 89,
                        Name = "JESUS EDUARDO",
                        LastName = "ALMAGUER RAMIREZ",
                        Age = "34 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 2,
                        CityId = 89,
                        Name = "MIGUEL",
                        LastName = "ZARATE HERNANDEZ",
                        Age = "46 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 5,
                        CityId = 89,
                        Name = "VALERIA GUADALUPE",
                        LastName = "AVILA GUTIERREZ",
                        Age = "42 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 6,
                        CityId = 89,
                        Name = "CLAUDIA",
                        LastName = "DELGADILLO GONZALEZ",
                        Age = "47 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 7,
                        CityId = 89,
                        Name = "AURELIO",
                        LastName = "MARTINEZ FLORES",
                        Age = "39 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 3,
                        CityId = 89,
                        Name = "ISMAEL",
                        LastName = "DEL TORO CASTRO",
                        Age = "45 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 4,
                        CityId = 89,
                        Name = "RODOLFO ARMANDO",
                        LastName = "CASANOVA VALLE",
                        Age = "42 AÑOS"
                    });

                    //ALCALDES DE BOLAÑOS//
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 1,
                        CityId = 69,
                        Name = "MODESTO",
                        LastName = "CHINO DE LA CRUZ",
                        Age = "49 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 2,
                        CityId = 69,
                        Name = "MANUEL",
                        LastName = "VILLALOBOS ALVAREZ",
                        Age = "41 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 6,
                        CityId = 69,
                        Name = "JOSE GUADALUPE",
                        LastName = "MEDINA VALDIVIA",
                        Age = "36 AÑOS"
                    });

                    //ALCALDES DE ZAPOPAN//
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 1,
                        CityId = 170,
                        Name = "ABEL OCTAVIO",
                        LastName = "SALGADO PEÑA",
                        Age = "53 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 2,
                        CityId = 170,
                        Name = "JOSE ANTONIO",
                        LastName = "DE LA TORRE BRAVO",
                        Age = "46 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 5,
                        CityId = 170,
                        Name = "JAIME",
                        LastName = "PRIETO PEREZ",
                        Age = "42 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 6,
                        CityId = 170,
                        Name = "JOSE HIRAM",
                        LastName = "TORRES SALCEDO",
                        Age = "34 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 5,
                        CityId = 170,
                        Name = "MARIO ALEJANDRO",
                        LastName = "CARDENAS OCHOA",
                        Age = "47 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 3,
                        CityId = 170,
                        Name = "JESUS PABLO",
                        LastName = "LEMUS NAVARRO",
                        Age = "43 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 4,
                        CityId = 170,
                        Name = "JORGE",
                        LastName = "LEAL RAMIREZ",
                        Age = "41 AÑOS"
                    });

                    //ALCALDES DE TONALA//
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 1,
                        CityId = 151,
                        Name = "EDGAR OSWALDO",
                        LastName = "BAÑALES OROZCO",
                        Age = "45 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 2,
                        CityId = 151,
                        Name = "JUAN ANTONIO",
                        LastName = "GONZALEZ MORA",
                        Age = "37 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 6,
                        CityId = 151,
                        Name = "CATARINO",
                        LastName = "OLEA VELAZQUEZ",
                        Age = "54 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 7,
                        CityId = 151,
                        Name = "CELIA GUADALUPE",
                        LastName = "SERRANO VILLAGOMEZ",
                        Age = "47 AÑOS"
                    });
                    mayors.Add(new Mayor()
                    {
                        PoliticalPartyId = 4,
                        CityId = 151,
                        Name = "JUAN MANUEL",
                        LastName = "PEREZ SUAREZ",
                        Age = "45 AÑOS"
                    });
                    #endregion

                    #region Voto Presidente

                    #endregion

                    #region Voto Gobernador

                    #endregion

                    #region Voto Alcalde

                    #endregion

                    context.CountryRegions.AddRange(defaultCountriesRegion);
                    context.SaveChanges();

                    context.StateProvinces.AddRange(defaultStatesProvince);
                    context.SaveChanges();

                    context.Citys.AddRange(defaultCities);
                    context.SaveChanges();

                    context.Citizens.AddRange(defaultCitizens);
                    context.SaveChanges();

                    context.PoliticalPartys.AddRange(politicalParties);
                    context.SaveChanges();

                    context.Presidents.AddRange(presidents);
                    context.SaveChanges();

                    context.Governors.AddRange(governors);
                    context.SaveChanges();

                    context.Mayors.AddRange(mayors);
                    context.SaveChanges();

                    dbTran.Commit();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors: ",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\" ",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    dbTran.Rollback();
                    throw;
                }
            }

            base.Seed(context);
        }
    }
}