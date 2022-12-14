using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Repository.Seeds
{
    public class CitySeed : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
            new City { Id = 1, Title = "ADANA", Latitude = 37.00000000, Longitude = 35.32133330, NortheastLat = 37.07200400, NortheastLng = 35.46199500, SouthwestLat = 36.93552300, SouthwestLng = 35.17470600,CountryId= 218 },
            new City { Id = 2, Title = "ADIYAMAN", Latitude = 37.76416670, Longitude = 38.27616670, NortheastLat = 37.82566700, NortheastLng = 38.33546500, SouthwestLat = 37.71708600, SouthwestLng = 38.18818800, CountryId = 218 },
            new City { Id = 3, Title = "AFYONKARAHİSAR", Latitude = 38.76376000, Longitude = 30.54034000, NortheastLat = 38.80210500, NortheastLng = 30.61116700, SouthwestLat = 38.71428900, SouthwestLng = 30.44232000, CountryId = 218 },
            new City { Id = 4, Title = "AĞRI", Latitude = 39.72166670, Longitude = 43.05666670, NortheastLat = 39.74860500, NortheastLng = 43.08524100, SouthwestLat = 39.68814400, SouthwestLng = 43.00177800, CountryId = 218 },
            new City { Id = 5, Title = "AMASYA", Latitude = 40.65000000, Longitude = 35.83333330, NortheastLat = 40.67283400, NortheastLng = 35.85632100, SouthwestLat = 40.63691100, SouthwestLng = 35.78909100, CountryId = 218 },
            new City { Id = 6, Title = "ANKARA", Latitude = 39.92077000, Longitude = 32.85411000, NortheastLat = 40.10098100, NortheastLng = 33.02486600, SouthwestLat = 39.72282100, SouthwestLng = 32.49909700, CountryId = 218 },
            new City { Id = 7, Title = "ANTALYA", Latitude = 36.88414000, Longitude = 30.70563000, NortheastLat = 36.97517800, NortheastLng = 30.84095300, SouthwestLat = 36.78586600, SouthwestLng = 30.51609500, CountryId = 218 },
            new City { Id = 8, Title = "ARTVİN", Latitude = 41.18333330, Longitude = 41.81666670, NortheastLat = 41.20707800, NortheastLng = 41.85479900, SouthwestLat = 41.15541500, SouthwestLng = 41.77736100, CountryId = 218 },
            new City { Id = 9, Title = "AYDIN", Latitude = 37.84440000, Longitude = 27.84580000, NortheastLat = 37.87099700, NortheastLng = 27.88535500, SouthwestLat = 37.81957300, SouthwestLng = 27.79052200, CountryId = 218 },
            new City { Id = 10, Title = "BALIKESİR", Latitude = 39.64836900, Longitude = 27.88261000, NortheastLat = 39.69366600, NortheastLng = 27.95241000, SouthwestLat = 39.61241100, SouthwestLng = 27.83831300, CountryId = 218 },
            new City { Id = 11, Title = "BİLECİK", Latitude = 40.15013100, Longitude = 29.98306100, NortheastLat = 40.19761700, NortheastLng = 30.01359200, SouthwestLat = 40.10624300, SouthwestLng = 29.95665700, CountryId = 218 },
            new City { Id = 12, Title = "BİNGÖL", Latitude = 38.88534900, Longitude = 40.49829100, NortheastLat = 38.89796300, NortheastLng = 40.52592900, SouthwestLat = 38.87298700, SouthwestLng = 40.47725800, CountryId = 218 },
            new City { Id = 13, Title = "BİTLİS", Latitude = 38.40000000, Longitude = 42.11666670, NortheastLat = 38.45363800, NortheastLng = 42.14887900, SouthwestLat = 38.38531200, SouthwestLng = 42.09384000, CountryId = 218 },
            new City { Id = 14, Title = "BOLU", Latitude = 40.73947900, Longitude = 31.61156100, NortheastLat = 40.75800400, NortheastLng = 31.65841800, SouthwestLat = 40.71680200, SouthwestLng = 31.57332400, CountryId = 218 },
            new City { Id = 15, Title = "BURDUR", Latitude = 37.72690900, Longitude = 30.28887600, NortheastLat = 37.76375000, NortheastLng = 30.33666200, SouthwestLat = 37.69143300, SouthwestLng = 30.19175700, CountryId = 218 },
            new City { Id = 16, Title = "BURSA", Latitude = 40.18257000, Longitude = 29.06687000, NortheastLat = 40.29719400, NortheastLng = 29.21123700, SouthwestLat = 40.16299700, SouthwestLng = 28.85963000, CountryId = 218 },
            new City { Id = 17, Title = "ÇANAKKALE", Latitude = 40.15531200, Longitude = 26.41416000, NortheastLat = 40.19946200, NortheastLng = 26.45710600, SouthwestLat = 40.08808600, SouthwestLng = 26.37802600, CountryId = 218 },
            new City { Id = 18, Title = "ÇANKIRI", Latitude = 40.60000000, Longitude = 33.61666670, NortheastLat = 40.65515900, NortheastLng = 33.68485300, SouthwestLat = 40.55770900, SouthwestLng = 33.59657100, CountryId = 218 },
            new City { Id = 19, Title = "ÇORUM", Latitude = 40.55055560, Longitude = 34.95555560, NortheastLat = 40.60931700, NortheastLng = 35.00643800, SouthwestLat = 40.49521400, SouthwestLng = 34.88763400, CountryId = 218 },
            new City { Id = 20, Title = "DENİZLİ", Latitude = 37.77652000, Longitude = 29.08639000, NortheastLat = 37.84736600, NortheastLng = 29.18891500, SouthwestLat = 37.71617100, SouthwestLng = 28.98137300, CountryId = 218 },
            new City { Id = 21, Title = "DİYARBAKIR", Latitude = 37.91441000, Longitude = 40.23062900, NortheastLat = 37.97617400, NortheastLng = 40.24580300, SouthwestLat = 37.87962400, SouthwestLng = 40.10615900, CountryId = 218 },
            new City { Id = 22, Title = "EDİRNE", Latitude = 41.66666670, Longitude = 26.56666670, NortheastLat = 41.69793900, NortheastLng = 26.60309300, SouthwestLat = 41.64993500, SouthwestLng = 26.51405900, CountryId = 218 },
            new City { Id = 23, Title = "ELAZIĞ", Latitude = 38.68096900, Longitude = 39.22639800, NortheastLat = 38.71356800, NortheastLng = 39.27731400, SouthwestLat = 38.63056400, SouthwestLng = 39.13340500, CountryId = 218 },
            new City { Id = 24, Title = "ERZİNCAN", Latitude = 39.75000000, Longitude = 39.50000000, NortheastLat = 39.76916400, NortheastLng = 39.53174300, SouthwestLat = 39.72988400, SouthwestLng = 39.46025300, CountryId = 218 },
            new City { Id = 25, Title = "ERZURUM", Latitude = 39.90431890, Longitude = 41.26788530, NortheastLat = 39.95453300, NortheastLng = 41.30359400, SouthwestLat = 39.86671500, SouthwestLng = 41.17709300, CountryId = 218 },
            new City { Id = 26, Title = "ESKİŞEHİR", Latitude = 39.78430200, Longitude = 30.51922000, NortheastLat = 39.81679300, NortheastLng = 30.66769000, SouthwestLat = 39.72475200, SouthwestLng = 30.41408400, CountryId = 218 },
            new City { Id = 27, Title = "GAZİANTEP", Latitude = 37.06622000, Longitude = 37.38332000, NortheastLat = 37.11372200, NortheastLng = 37.46695800, SouthwestLat = 37.00594700, SouthwestLng = 37.30370900, CountryId = 218 },
            new City { Id = 28, Title = "GİRESUN", Latitude = 40.91281100, Longitude = 38.38953000, NortheastLat = 40.92799500, NortheastLng = 38.45004400, SouthwestLat = 40.87787600, SouthwestLng = 38.30901800, CountryId = 218 },
            new City { Id = 29, Title = "GÜMÜŞHANE", Latitude = 40.46027780, Longitude = 39.48138890, NortheastLat = 40.47135900, NortheastLng = 39.52064100, SouthwestLat = 40.43020100, SouthwestLng = 39.44691400, CountryId = 218 },
            new City { Id = 30, Title = "HAKKARİ", Latitude = 37.58333330, Longitude = 43.73333330, NortheastLat = 37.60165600, NortheastLng = 43.76225700, SouthwestLat = 37.55154900, SouthwestLng = 43.69809000, CountryId = 218 },
            new City { Id = 31, Title = "HATAY", Latitude = 36.40184880, Longitude = 36.34980970, NortheastLat = 37.01492100, NortheastLng = 36.69753500, SouthwestLat = 35.81269200, SouthwestLng = 35.77937500, CountryId = 218 },
            new City { Id = 32, Title = "ISPARTA", Latitude = 37.76666670, Longitude = 30.55000000, NortheastLat = 37.83071900, NortheastLng = 30.60919700, SouthwestLat = 37.73988000, SouthwestLng = 30.50367300, CountryId = 218 },
            new City { Id = 33, Title = "MERSİN{İÇEL}", Latitude = 36.80000000, Longitude = 34.63333330, NortheastLat = 36.87827200, NortheastLng = 34.71670200, SouthwestLat = 36.69950300, SouthwestLng = 34.45765500, CountryId = 218 },
            new City { Id = 34, Title = "İSTANBUL", Latitude = 41.00527000, Longitude = 28.97696000, NortheastLat = 41.32078600, NortheastLng = 29.45645600, SouthwestLat = 40.80275000, SouthwestLng = 27.97130700, CountryId = 218 },
            new City { Id = 35, Title = "İZMİR", Latitude = 38.41885000, Longitude = 27.12872000, NortheastLat = 38.50677300, NortheastLng = 27.30441500, SouthwestLat = 38.34315700, SouthwestLng = 27.01719200, CountryId = 218 },
            new City { Id = 36, Title = "KARS", Latitude = 40.59267000, Longitude = 43.07783100, NortheastLat = 40.62484300, NortheastLng = 43.13390000, SouthwestLat = 40.57748400, SouthwestLng = 43.05643200, CountryId = 218 },
            new City { Id = 37, Title = "KASTAMONU", Latitude = 41.38871000, Longitude = 33.78273000, NortheastLat = 41.43605900, NortheastLng = 33.81498900, SouthwestLat = 41.35066800, SouthwestLng = 33.75290100, CountryId = 218 },
            new City { Id = 38, Title = "KAYSERİ", Latitude = 38.73333330, Longitude = 35.48333330, NortheastLat = 38.81879700, NortheastLng = 35.62767500, SouthwestLat = 38.62200200, SouthwestLng = 35.30432400, CountryId = 218 },
            new City { Id = 39, Title = "KIRKLARELİ", Latitude = 41.73333330, Longitude = 27.21666670, NortheastLat = 41.76005400, NortheastLng = 27.24222000, SouthwestLat = 41.71061500, SouthwestLng = 27.18284300, CountryId = 218 },
            new City { Id = 40, Title = "KIRŞEHİR", Latitude = 39.15000000, Longitude = 34.16666670, NortheastLat = 39.20393900, NortheastLng = 34.21774300, SouthwestLat = 39.08129300, SouthwestLng = 34.12553200, CountryId = 218 },
            new City { Id = 41, Title = "KOCAELİ", Latitude = 40.85327040, Longitude = 29.88152030, NortheastLat = 41.20976000, NortheastLng = 30.35968400, SouthwestLat = 40.53278200, SouthwestLng = 29.33346200, CountryId = 218 },
            new City { Id = 42, Title = "KONYA", Latitude = 37.86666670, Longitude = 32.48333330, NortheastLat = 38.05063000, NortheastLng = 32.68011600, SouthwestLat = 37.71903100, SouthwestLng = 32.33873700, CountryId = 218 },
            new City { Id = 43, Title = "KÜTAHYA", Latitude = 39.41666670, Longitude = 29.98333330, NortheastLat = 39.44271800, NortheastLng = 30.06650300, SouthwestLat = 39.37947300, SouthwestLng = 29.91919900, CountryId = 218 },
            new City { Id = 44, Title = "MALATYA", Latitude = 38.35519000, Longitude = 38.30946000, NortheastLat = 38.39755900, NortheastLng = 38.45324400, SouthwestLat = 38.30512300, SouthwestLng = 38.23262200, CountryId = 218 },
            new City { Id = 45, Title = "MANİSA", Latitude = 38.61909900, Longitude = 27.42892100, NortheastLat = 38.64228900, NortheastLng = 27.48797600, SouthwestLat = 38.60237600, SouthwestLng = 27.32608600, CountryId = 218 },
            new City { Id = 46, Title = "KAHRAMANMARAŞ", Latitude = 37.58333330, Longitude = 36.93333330, NortheastLat = 37.60526100, NortheastLng = 36.99767800, SouthwestLat = 37.53030900, SouthwestLng = 36.82970300, CountryId = 218 },
            new City { Id = 47, Title = "MARDİN", Latitude = 37.31223610, Longitude = 40.73511200, NortheastLat = 37.33055400, NortheastLng = 40.76448600, SouthwestLat = 37.30510900, SouthwestLng = 40.71697100, CountryId = 218 },
            new City { Id = 48, Title = "MUĞLA", Latitude = 37.21527780, Longitude = 28.36361110, NortheastLat = 37.22581000, NortheastLng = 28.41449800, SouthwestLat = 37.19465100, SouthwestLng = 28.34127900, CountryId = 218 },
            new City { Id = 49, Title = "MUŞ", Latitude = 38.74329260, Longitude = 41.50648230, NortheastLat = 38.78350300, NortheastLng = 41.54062500, SouthwestLat = 38.71822400, SouthwestLng = 41.47230600, CountryId = 218 },
            new City { Id = 50, Title = "NEVŞEHİR", Latitude = 38.62442000, Longitude = 34.72396900, NortheastLat = 38.68410700, NortheastLng = 34.76475900, SouthwestLat = 38.58904700, SouthwestLng = 34.66975200, CountryId = 218 },
            new City { Id = 51, Title = "NİĞDE", Latitude = 37.96666670, Longitude = 34.68333330, NortheastLat = 37.97991300, NortheastLng = 34.69158500, SouthwestLat = 37.95699200, SouthwestLng = 34.66190600, CountryId = 218 },
            new City { Id = 52, Title = "ORDU", Latitude = 40.98333330, Longitude = 37.88333330, NortheastLat = 41.02034000, NortheastLng = 37.97897600, SouthwestLat = 40.93163100, SouthwestLng = 37.82599200, CountryId = 218 },
            new City { Id = 53, Title = "RİZE", Latitude = 41.02005000, Longitude = 40.52344900, NortheastLat = 41.04649200, NortheastLng = 40.58680200, SouthwestLat = 41.01078200, SouthwestLng = 40.47857800, CountryId = 218 },
            new City { Id = 54, Title = "SAKARYA", Latitude = 40.75687930, Longitude = 30.37813800, NortheastLat = 40.82551800, NortheastLng = 30.43983200, SouthwestLat = 40.68619900, SouthwestLng = 30.32213800, CountryId = 218 },
            new City { Id = 55, Title = "SAMSUN", Latitude = 41.29278200, Longitude = 36.33128000, NortheastLat = 41.34413400, NortheastLng = 36.38120500, SouthwestLat = 41.23500200, SouthwestLng = 36.24951900, CountryId = 218 },
            new City { Id = 56, Title = "SİİRT", Latitude = 37.94429000, Longitude = 41.93288000, NortheastLat = 37.95594000, NortheastLng = 41.96365800, SouthwestLat = 37.90967100, SouthwestLng = 41.87254700, CountryId = 218 },
            new City { Id = 57, Title = "SİNOP", Latitude = 42.02642220, Longitude = 35.15507450, NortheastLat = 42.03213500, NortheastLng = 35.19494700, SouthwestLat = 42.01267500, SouthwestLng = 35.11595700, CountryId = 218 },
            new City { Id = 58, Title = "SİVAS", Latitude = 39.74766200, Longitude = 37.01787900, NortheastLat = 39.78366900, NortheastLng = 37.06167300, SouthwestLat = 39.69902400, SouthwestLng = 36.91985800, CountryId = 218 },
            new City { Id = 59, Title = "TEKİRDAĞ", Latitude = 40.98333330, Longitude = 27.51666670, NortheastLat = 40.99672300, NortheastLng = 27.60025200, SouthwestLat = 40.93770400, SouthwestLng = 27.46899300, CountryId = 218 },
            new City { Id = 60, Title = "TOKAT", Latitude = 40.31666670, Longitude = 36.55000000, NortheastLat = 40.35893200, NortheastLng = 36.59321900, SouthwestLat = 40.26786800, SouthwestLng = 36.46966200, CountryId = 218 },
            new City { Id = 61, Title = "TRABZON", Latitude = 41.00000000, Longitude = 39.73333330, NortheastLat = 41.01237000, NortheastLng = 39.82051000, SouthwestLat = 40.95573600, SouthwestLng = 39.65240700, CountryId = 218 },
            new City { Id = 62, Title = "TUNCELİ", Latitude = 39.10798680, Longitude = 39.54016720, NortheastLat = 39.11347700, NortheastLng = 39.55185000, SouthwestLat = 39.09453400, SouthwestLng = 39.53001500, CountryId = 218 },
            new City { Id = 63, Title = "ŞANLIURFA", Latitude = 37.15000000, Longitude = 38.80000000, NortheastLat = 37.18963900, NortheastLng = 38.84087600, SouthwestLat = 37.09827400, SouthwestLng = 38.76786800, CountryId = 218 },
            new City { Id = 64, Title = "UŞAK", Latitude = 38.68230100, Longitude = 29.40819000, NortheastLat = 38.71588000, NortheastLng = 29.46983800, SouthwestLat = 38.63067900, SouthwestLng = 29.35593600, CountryId = 218 },
            new City { Id = 65, Title = "VAN", Latitude = 38.49416670, Longitude = 43.38000000, NortheastLat = 38.58031400, NortheastLng = 43.45535600, SouthwestLat = 38.42188000, SouthwestLng = 43.26952400, CountryId = 218 },
            new City { Id = 66, Title = "YOZGAT", Latitude = 39.82000000, Longitude = 34.80444440, NortheastLat = 39.83842300, NortheastLng = 34.85823600, SouthwestLat = 39.79896800, SouthwestLng = 34.77109400, CountryId = 218 },
            new City { Id = 67, Title = "ZONGULDAK", Latitude = 41.45640900, Longitude = 31.79873100, NortheastLat = 41.48078400, NortheastLng = 31.87442500, SouthwestLat = 41.42529600, SouthwestLng = 31.75705200, CountryId = 218 },
            new City { Id = 68, Title = "AKSARAY", Latitude = 38.36869000, Longitude = 34.03698000, NortheastLat = 38.44672400, NortheastLng = 34.08869800, SouthwestLat = 38.29701200, SouthwestLng = 33.93251500, CountryId = 218 },
            new City { Id = 69, Title = "BAYBURT", Latitude = 40.25516900, Longitude = 40.22488000, NortheastLat = 40.27263600, NortheastLng = 40.23826100, SouthwestLat = 40.24288100, SouthwestLng = 40.20876200, CountryId = 218 },
            new City { Id = 70, Title = "KARAMAN", Latitude = 37.17593000, Longitude = 33.22874800, NortheastLat = 37.22937300, NortheastLng = 33.33424400, SouthwestLat = 37.14825700, SouthwestLng = 33.16600300, CountryId = 218 },
            new City { Id = 71, Title = "KIRIKKALE", Latitude = 39.84682100, Longitude = 33.51525100, NortheastLat = 39.87284300, NortheastLng = 33.59796800, SouthwestLat = 39.81380200, SouthwestLng = 33.46828900, CountryId = 218 },
            new City { Id = 72, Title = "BATMAN", Latitude = 37.88116800, Longitude = 41.13509000, NortheastLat = 37.94727400, NortheastLng = 41.17603000, SouthwestLat = 37.85657000, SouthwestLng = 41.08059100, CountryId = 218 },
            new City { Id = 73, Title = "ŞIRNAK", Latitude = 37.51638890, Longitude = 42.46111110, NortheastLat = 37.53357200, NortheastLng = 42.47112700, SouthwestLat = 37.50009300, SouthwestLng = 42.44463100, CountryId = 218 },
            new City { Id = 74, Title = "BARTIN", Latitude = 41.63444440, Longitude = 32.33750000, NortheastLat = 41.65654200, NortheastLng = 32.37105000, SouthwestLat = 41.61351300, SouthwestLng = 32.29745700, CountryId = 218 },
            new City { Id = 75, Title = "ARDAHAN", Latitude = 41.11048100, Longitude = 42.70217100, NortheastLat = 41.12146700, NortheastLng = 42.71712900, SouthwestLat = 41.09891000, SouthwestLng = 42.68641800, CountryId = 218 },
            new City { Id = 76, Title = "IĞDIR", Latitude = 39.91666670, Longitude = 44.03333330, NortheastLat = 39.95016300, NortheastLng = 44.09282500, SouthwestLat = 39.88410900, SouthwestLng = 43.98072900, CountryId = 218 },
            new City { Id = 77, Title = "YALOVA", Latitude = 40.65000000, Longitude = 29.26666670, NortheastLat = 40.66806000, NortheastLng = 29.31653600, SouthwestLat = 40.63413800, SouthwestLng = 29.21023300, CountryId = 218 },
            new City { Id = 78, Title = "KARABÜK", Latitude = 41.20000000, Longitude = 32.63333330, NortheastLat = 41.23812900, NortheastLng = 32.67551800, SouthwestLat = 41.16301400, SouthwestLng = 32.59258200, CountryId = 218 },
            new City { Id = 79, Title = "KİLİS", Latitude = 36.71839900, Longitude = 37.12122000, NortheastLat = 36.74781900, NortheastLng = 37.15954100, SouthwestLat = 36.70267300, SouthwestLng = 37.08518300, CountryId = 218 },
            new City { Id = 80, Title = "OSMANİYE", Latitude = 37.06805000, Longitude = 36.26158900, NortheastLat = 37.10406100, NortheastLng = 36.28794100, SouthwestLat = 37.04694000, SouthwestLng = 36.20803400, CountryId = 218 },
            new City { Id = 81, Title = "DÜZCE", Latitude = 40.84384900, Longitude = 31.15654000, NortheastLat = 40.89176200, NortheastLng = 31.19580700, SouthwestLat = 40.82471700, SouthwestLng = 31.10666200, CountryId = 218 }
            );
        }
    }
}
