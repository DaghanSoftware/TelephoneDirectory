using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TelephoneDirectory.Repository.Migrations
{
    /// <inheritdoc />
    public partial class tablolarolusturuluyor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Iso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iso3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumCode = table.Column<int>(type: "int", nullable: false),
                    PhoneCode = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber1 = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber2 = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber3 = table.Column<int>(type: "int", nullable: false),
                    FaxNumber1 = table.Column<int>(type: "int", nullable: false),
                    FaxNumber2 = table.Column<int>(type: "int", nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainInstitutionId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CountyId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainInstitutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainInstitutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    NortheastLat = table.Column<double>(type: "float", nullable: false),
                    NortheastLng = table.Column<double>(type: "float", nullable: false),
                    SouthwestLat = table.Column<double>(type: "float", nullable: false),
                    SouthwestLng = table.Column<double>(type: "float", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NortheastLat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NortheastLng = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SouthwestLat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SouthwestLng = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counties_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Active", "CreateDate", "Iso", "Iso3", "Name", "NiceName", "NumCode", "PhoneCode", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AF", "AFG", "AFGHANISTAN", "Afghanistan", 4, 93, null },
                    { 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AL", "ALB", "ALBANIA", "Albania", 8, 355, null },
                    { 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DZ", "DZA", "ALGERIA", "Algeria", 12, 213, null },
                    { 4, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AS", "ASM", "AMERICAN SAMOA", "American Samoa", 16, 1684, null },
                    { 5, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD", "AND", "ANDORRA", "Andorra", 20, 376, null },
                    { 6, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AO", "AGO", "ANGOLA", "Angola", 24, 244, null },
                    { 7, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AI", "AIA", "ANGUILLA", "Anguilla", 660, 1264, null },
                    { 8, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQ", null, "ANTARCTICA", "Antarctica", 0, 0, null },
                    { 9, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AG", "ATG", "ANTIGUA AND BARBUDA", "Antigua and Barbuda", 28, 1268, null },
                    { 10, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AR", "ARG", "ARGENTINA", "Argentina", 32, 54, null },
                    { 11, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AM", "ARM", "ARMENIA", "Armenia", 51, 374, null },
                    { 12, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AW", "ABW", "ARUBA", "Aruba", 533, 297, null },
                    { 13, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AU", "AUS", "AUSTRALIA", "Australia", 36, 61, null },
                    { 14, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AT", "AUT", "AUSTRIA", "Austria", 40, 43, null },
                    { 15, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AZ", "AZE", "AZERBAIJAN", "Azerbaijan", 31, 994, null },
                    { 16, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BS", "BHS", "BAHAMAS", "Bahamas", 44, 1242, null },
                    { 17, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BH", "BHR", "BAHRAIN", "Bahrain", 48, 973, null },
                    { 18, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BD", "BGD", "BANGLADESH", "Bangladesh", 50, 880, null },
                    { 19, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BB", "BRB", "BARBADOS", "Barbados", 52, 1246, null },
                    { 20, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BY", "BLR", "BELARUS", "Belarus", 112, 375, null },
                    { 21, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE", "BEL", "BELGIUM", "Belgium", 56, 32, null },
                    { 22, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BZ", "BLZ", "BELIZE", "Belize", 84, 501, null },
                    { 23, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BJ", "BEN", "BENIN", "Benin", 204, 229, null },
                    { 24, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BM", "BMU", "BERMUDA", "Bermuda", 60, 1441, null },
                    { 25, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BT", "BTN", "BHUTAN", "Bhutan", 64, 975, null },
                    { 26, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BO", "BOL", "BOLIVIA", "Bolivia", 68, 591, null },
                    { 27, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BA", "BIH", "BOSNIA AND HERZEGOVINA", "Bosnia and Herzegovina", 70, 387, null },
                    { 28, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BW", "BWA", "BOTSWANA", "Botswana", 72, 267, null },
                    { 29, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BV", null, "BOUVET ISLAND", "Bouvet Island", 0, 0, null },
                    { 30, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BR", "BRA", "BRAZIL", "Brazil", 76, 55, null },
                    { 31, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IO", null, "BRITISH INDIAN OCEAN TERRITORY", "British Indian Ocean Territory", 0, 246, null },
                    { 32, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BN", "BRN", "BRUNEI DARUSSALAM", "Brunei Darussalam", 96, 673, null },
                    { 33, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BG", "BGR", "BULGARIA", "Bulgaria", 100, 359, null },
                    { 34, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BF", "BFA", "BURKINA FASO", "Burkina Faso", 854, 226, null },
                    { 35, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BI", "BDI", "BURUNDI", "Burundi", 108, 257, null },
                    { 36, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KH", "KHM", "CAMBODIA", "Cambodia", 116, 855, null },
                    { 37, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CM", "CMR", "CAMEROON", "Cameroon", 120, 237, null },
                    { 38, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CA", "CAN", "CANADA", "Canada", 124, 1, null },
                    { 39, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CV", "CPV", "CAPE VERDE", "Cape Verde", 132, 238, null },
                    { 40, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KY", "CYM", "CAYMAN ISLANDS", "Cayman Islands", 136, 1345, null },
                    { 41, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CF", "CAF", "CENTRAL AFRICAN REPUBLIC", "Central African Republic", 140, 236, null },
                    { 42, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TD", "TCD", "CHAD", "Chad", 148, 235, null },
                    { 43, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CL", "CHL", "CHILE", "Chile", 152, 56, null },
                    { 44, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CN", "CHN", "CHINA", "China", 156, 86, null },
                    { 45, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CX", null, "CHRISTMAS ISLAND", "Christmas Island", 0, 61, null },
                    { 46, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CC", null, "COCOS {KEELING} ISLANDS", "Cocos {Keeling} Islands", 0, 672, null },
                    { 47, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CO", "COL", "COLOMBIA", "Colombia", 170, 57, null },
                    { 48, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KM", "COM", "COMOROS", "Comoros", 174, 269, null },
                    { 49, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CG", "COG", "CONGO", "Congo", 178, 242, null },
                    { 50, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CD", "COD", "CONGO, THE DEMOCRATIC REPUBLIC OF THE", "Congo, the Democratic Republic of the", 180, 242, null },
                    { 51, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CK", "COK", "COOK ISLANDS", "Cook Islands", 184, 682, null },
                    { 52, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CR", "CRI", "COSTA RICA", "Costa Rica", 188, 506, null },
                    { 53, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CI", "CIV", "COTE DIVOIRE", "Cote DIvoire", 384, 225, null },
                    { 54, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "HRV", "CROATIA", "Croatia", 191, 385, null },
                    { 55, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CU", "CUB", "CUBA", "Cuba", 192, 53, null },
                    { 56, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CY", "CYP", "CYPRUS", "Cyprus", 196, 357, null },
                    { 57, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CZ", "CZE", "CZECH REPUBLIC", "Czech Republic", 203, 420, null },
                    { 58, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DK", "DNK", "DENMARK", "Denmark", 208, 45, null },
                    { 59, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DJ", "DJI", "DJIBOUTI", "Djibouti", 262, 253, null },
                    { 60, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DM", "DMA", "DOMINICA", "Dominica", 212, 1767, null },
                    { 61, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DO", "DOM", "DOMINICAN REPUBLIC", "Dominican Republic", 214, 1809, null },
                    { 62, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EC", "ECU", "ECUADOR", "Ecuador", 218, 593, null },
                    { 63, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EG", "EGY", "EGYPT", "Egypt", 818, 20, null },
                    { 64, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SV", "SLV", "EL SALVADOR", "El Salvador", 222, 503, null },
                    { 65, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GQ", "GNQ", "EQUATORIAL GUINEA", "Equatorial Guinea", 226, 240, null },
                    { 66, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ER", "ERI", "ERITREA", "Eritrea", 232, 291, null },
                    { 67, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EE", "EST", "ESTONIA", "Estonia", 233, 372, null },
                    { 68, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ET", "ETH", "ETHIOPIA", "Ethiopia", 231, 251, null },
                    { 69, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FK", "FLK", "FALKLAND ISLANDS {MALVINAS}", "Falkland Islands {Malvinas}", 238, 500, null },
                    { 70, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FO", "FRO", "FAROE ISLANDS", "Faroe Islands", 234, 298, null },
                    { 71, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FJ", "FJI", "FIJI", "Fiji", 242, 679, null },
                    { 72, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FI", "FIN", "FINLAND", "Finland", 246, 358, null },
                    { 73, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FR", "FRA", "FRANCE", "France", 250, 33, null },
                    { 74, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GF", "GUF", "FRENCH GUIANA", "French Guiana", 254, 594, null },
                    { 75, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PF", "PYF", "FRENCH POLYNESIA", "French Polynesia", 258, 689, null },
                    { 76, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TF", null, "FRENCH SOUTHERN TERRITORIES", "French Southern Territories", 0, 0, null },
                    { 77, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GA", "GAB", "GABON", "Gabon", 266, 241, null },
                    { 78, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GM", "GMB", "GAMBIA", "Gambia", 270, 220, null },
                    { 79, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GE", "GEO", "GEORGIA", "Georgia", 268, 995, null },
                    { 80, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE", "DEU", "GERMANY", "Germany", 276, 49, null },
                    { 81, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GH", "GHA", "GHANA", "Ghana", 288, 233, null },
                    { 82, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GI", "GIB", "GIBRALTAR", "Gibraltar", 292, 350, null },
                    { 83, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GR", "GRC", "GREECE", "Greece", 300, 30, null },
                    { 84, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GL", "GRL", "GREENLAND", "Greenland", 304, 299, null },
                    { 85, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GD", "GRD", "GRENADA", "Grenada", 308, 1473, null },
                    { 86, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GP", "GLP", "GUADELOUPE", "Guadeloupe", 312, 590, null },
                    { 87, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GU", "GUM", "GUAM", "Guam", 316, 1671, null },
                    { 88, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GT", "GTM", "GUATEMALA", "Guatemala", 320, 502, null },
                    { 89, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GN", "GIN", "GUINEA", "Guinea", 324, 224, null },
                    { 90, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GW", "GNB", "GUINEA-BISSAU", "Guinea-Bissau", 624, 245, null },
                    { 91, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GY", "GUY", "GUYANA", "Guyana", 328, 592, null },
                    { 92, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HT", "HTI", "HAITI", "Haiti", 332, 509, null },
                    { 93, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HM", null, "HEARD ISLAND AND MCDONALD ISLANDS", "Heard Island and Mcdonald Islands", 0, 0, null },
                    { 94, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VA", "VAT", "HOLY SEE {VATICAN CITY STATE}", "Holy See {Vatican City State}", 336, 39, null },
                    { 95, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HN", "HND", "HONDURAS", "Honduras", 340, 504, null },
                    { 96, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HK", "HKG", "HONG KONG", "Hong Kong", 344, 852, null },
                    { 97, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HU", "HUN", "HUNGARY", "Hungary", 348, 36, null },
                    { 98, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IS", "ISL", "ICELAND", "Iceland", 352, 354, null },
                    { 99, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IN", "IND", "INDIA", "India", 356, 91, null },
                    { 100, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ID", "IDN", "INDONESIA", "Indonesia", 360, 62, null },
                    { 101, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IR", "IRN", "IRAN, ISLAMIC REPUBLIC OF", "Iran, Islamic Republic of", 364, 98, null },
                    { 102, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IQ", "IRQ", "IRAQ", "Iraq", 368, 964, null },
                    { 103, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IE", "IRL", "IRELAND", "Ireland", 372, 353, null },
                    { 104, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IL", "ISR", "ISRAEL", "Israel", 376, 972, null },
                    { 105, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "ITA", "ITALY", "Italy", 380, 39, null },
                    { 106, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JM", "JAM", "JAMAICA", "Jamaica", 388, 1876, null },
                    { 107, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JP", "JPN", "JAPAN", "Japan", 392, 81, null },
                    { 108, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JO", "JOR", "JORDAN", "Jordan", 400, 962, null },
                    { 109, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KZ", "KAZ", "KAZAKHSTAN", "Kazakhstan", 398, 7, null },
                    { 110, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KE", "KEN", "KENYA", "Kenya", 404, 254, null },
                    { 111, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KI", "KIR", "KIRIBATI", "Kiribati", 296, 686, null },
                    { 112, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KP", "PRK", "KOREA, DEMOCRATIC PEOPLES REPUBLIC OF", "Korea, Democratic Peoples Republic of", 408, 850, null },
                    { 113, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KR", "KOR", "KOREA, REPUBLIC OF", "Korea, Republic of", 410, 82, null },
                    { 114, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KW", "KWT", "KUWAIT", "Kuwait", 414, 965, null },
                    { 115, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KG", "KGZ", "KYRGYZSTAN", "Kyrgyzstan", 417, 996, null },
                    { 116, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LA", "LAO", "LAO PEOPLE'S DEMOCRATIC REPUBLIC", "Lao Peoples Democratic Republic", 418, 856, null },
                    { 117, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LV", "LVA", "LATVIA", "Latvia", 428, 371, null },
                    { 118, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LB", "LBN", "LEBANON", "Lebanon", 422, 961, null },
                    { 119, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LS", "LSO", "LESOTHO", "Lesotho", 426, 266, null },
                    { 120, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LR", "LBR", "LIBERIA", "Liberia", 430, 231, null },
                    { 121, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LY", "LBY", "LIBYAN ARAB JAMAHIRIYA", "Libyan Arab Jamahiriya", 434, 218, null },
                    { 122, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LI", "LIE", "LIECHTENSTEIN", "Liechtenstein", 438, 423, null },
                    { 123, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LT", "LTU", "LITHUANIA", "Lithuania", 440, 370, null },
                    { 124, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LU", "LUX", "LUXEMBOURG", "Luxembourg", 442, 352, null },
                    { 125, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MO", "MAC", "MACAO", "Macao", 446, 853, null },
                    { 126, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MK", "MKD", "MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF", "Macedonia, the Former Yugoslav Republic of", 807, 389, null },
                    { 127, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MG", "MDG", "MADAGASCAR", "Madagascar", 450, 261, null },
                    { 128, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MW", "MWI", "MALAWI", "Malawi", 454, 265, null },
                    { 129, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MY", "MYS", "MALAYSIA", "Malaysia", 458, 60, null },
                    { 130, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MV", "MDV", "MALDIVES", "Maldives", 462, 960, null },
                    { 131, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ML", "MLI", "MALI", "Mali", 466, 223, null },
                    { 132, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MT", "MLT", "MALTA", "Malta", 470, 356, null },
                    { 133, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MH", "MHL", "MARSHALL ISLANDS", "Marshall Islands", 584, 692, null },
                    { 134, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MQ", "MTQ", "MARTINIQUE", "Martinique", 474, 596, null },
                    { 135, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MR", "MRT", "MAURITANIA", "Mauritania", 478, 222, null },
                    { 136, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MU", "MUS", "MAURITIUS", "Mauritius", 480, 230, null },
                    { 137, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "YT", null, "MAYOTTE", "Mayotte", 0, 269, null },
                    { 138, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MX", "MEX", "MEXICO", "Mexico", 484, 52, null },
                    { 139, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FM", "FSM", "MICRONESIA, FEDERATED STATES OF", "Micronesia, Federated States of", 583, 691, null },
                    { 140, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MD", "MDA", "MOLDOVA, REPUBLIC OF", "Moldova, Republic of", 498, 373, null },
                    { 141, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MC", "MCO", "MONACO", "Monaco", 492, 377, null },
                    { 142, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MN", "MNG", "MONGOLIA", "Mongolia", 496, 976, null },
                    { 143, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MS", "MSR", "MONTSERRAT", "Montserrat", 500, 1664, null },
                    { 144, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MA", "MAR", "MOROCCO", "Morocco", 504, 212, null },
                    { 145, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MZ", "MOZ", "MOZAMBIQUE", "Mozambique", 508, 258, null },
                    { 146, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM", "MMR", "MYANMAR", "Myanmar", 104, 95, null },
                    { 147, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NA", "NAM", "NAMIBIA", "Namibia", 516, 264, null },
                    { 148, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NR", "NRU", "NAURU", "Nauru", 520, 674, null },
                    { 149, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NP", "NPL", "NEPAL", "Nepal", 524, 977, null },
                    { 150, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NL", "NLD", "NETHERLANDS", "Netherlands", 528, 31, null },
                    { 151, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AN", "ANT", "NETHERLANDS ANTILLES", "Netherlands Antilles", 530, 599, null },
                    { 152, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NC", "NCL", "NEW CALEDONIA", "New Caledonia", 540, 687, null },
                    { 153, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NZ", "NZL", "NEW ZEALAND", "New Zealand", 554, 64, null },
                    { 154, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NI", "NIC", "NICARAGUA", "Nicaragua", 558, 505, null },
                    { 155, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NE", "NER", "NIGER", "Niger", 562, 227, null },
                    { 156, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NG", "NGA", "NIGERIA", "Nigeria", 566, 234, null },
                    { 157, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NU", "NIU", "NIUE", "Niue", 570, 683, null },
                    { 158, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NF", "NFK", "NORFOLK ISLAND", "Norfolk Island", 574, 672, null },
                    { 159, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MP", "MNP", "NORTHERN MARIANA ISLANDS", "Northern Mariana Islands", 580, 1670, null },
                    { 160, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NO", "NOR", "NORWAY", "Norway", 578, 47, null },
                    { 161, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OM", "OMN", "OMAN", "Oman", 512, 968, null },
                    { 162, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PK", "PAK", "PAKISTAN", "Pakistan", 586, 92, null },
                    { 163, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PW", "PLW", "PALAU", "Palau", 585, 680, null },
                    { 164, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PS", null, "PALESTINIAN TERRITORY, OCCUPIED", "Palestinian Territory, Occupied", 0, 970, null },
                    { 165, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PA", "PAN", "PANAMA", "Panama", 591, 507, null },
                    { 166, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PG", "PNG", "PAPUA NEW GUINEA", "Papua New Guinea", 598, 675, null },
                    { 167, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PY", "PRY", "PARAGUAY", "Paraguay", 600, 595, null },
                    { 168, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PE", "PER", "PERU", "Peru", 604, 51, null },
                    { 169, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PH", "PHL", "PHILIPPINES", "Philippines", 608, 63, null },
                    { 170, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PN", "PCN", "PITCAIRN", "Pitcairn", 612, 0, null },
                    { 171, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PL", "POL", "POLAND", "Poland", 616, 48, null },
                    { 172, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PT", "PRT", "PORTUGAL", "Portugal", 620, 351, null },
                    { 173, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PR", "PRI", "PUERTO RICO", "Puerto Rico", 630, 1787, null },
                    { 174, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QA", "QAT", "QATAR", "Qatar", 634, 974, null },
                    { 175, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RE", "REU", "REUNION", "Reunion", 638, 262, null },
                    { 176, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RO", "ROM", "ROMANIA", "Romania", 642, 40, null },
                    { 177, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RU", "RUS", "RUSSIAN FEDERATION", "Russian Federation", 643, 70, null },
                    { 178, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RW", "RWA", "RWANDA", "Rwanda", 646, 250, null },
                    { 179, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SH", "SHN", "SAINT HELENA", "Saint Helena", 654, 290, null },
                    { 180, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KN", "KNA", "SAINT KITTS AND NEVIS", "Saint Kitts and Nevis", 659, 1869, null },
                    { 181, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LC", "LCA", "SAINT LUCIA", "Saint Lucia", 662, 1758, null },
                    { 182, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PM", "SPM", "SAINT PIERRE AND MIQUELON", "Saint Pierre and Miquelon", 666, 508, null },
                    { 183, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VC", "VCT", "SAINT VINCENT AND THE GRENADINES", "Saint Vincent and the Grenadines", 670, 1784, null },
                    { 184, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WS", "WSM", "SAMOA", "Samoa", 882, 684, null },
                    { 185, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SM", "SMR", "SAN MARINO", "San Marino", 674, 378, null },
                    { 186, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ST", "STP", "SAO TOME AND PRINCIPE", "Sao Tome and Principe", 678, 239, null },
                    { 187, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SA", "SAU", "SAUDI ARABIA", "Saudi Arabia", 682, 966, null },
                    { 188, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SN", "SEN", "SENEGAL", "Senegal", 686, 221, null },
                    { 189, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CS", null, "SERBIA AND MONTENEGRO", "Serbia and Montenegro", 0, 381, null },
                    { 190, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SC", "SYC", "SEYCHELLES", "Seychelles", 690, 248, null },
                    { 191, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SL", "SLE", "SIERRA LEONE", "Sierra Leone", 694, 232, null },
                    { 192, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SG", "SGP", "SINGAPORE", "Singapore", 702, 65, null },
                    { 193, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SK", "SVK", "SLOVAKIA", "Slovakia", 703, 421, null },
                    { 194, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SI", "SVN", "SLOVENIA", "Slovenia", 705, 386, null },
                    { 195, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SB", "SLB", "SOLOMON ISLANDS", "Solomon Islands", 90, 677, null },
                    { 196, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SO", "SOM", "SOMALIA", "Somalia", 706, 252, null },
                    { 197, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZA", "ZAF", "SOUTH AFRICA", "South Africa", 710, 27, null },
                    { 198, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GS", null, "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", "South Georgia and the South Sandwich Islands", 0, 0, null },
                    { 199, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ES", "ESP", "SPAIN", "Spain", 724, 34, null },
                    { 200, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LK", "LKA", "SRI LANKA", "Sri Lanka", 144, 94, null },
                    { 201, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SD", "SDN", "SUDAN", "Sudan", 736, 249, null },
                    { 202, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SR", "SUR", "SURINAME", "Suriname", 740, 597, null },
                    { 203, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SJ", "SJM", "SVALBARD AND JAN MAYEN", "Svalbard and Jan Mayen", 744, 47, null },
                    { 204, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SZ", "SWZ", "SWAZILAND", "Swaziland", 748, 268, null },
                    { 205, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SE", "SWE", "SWEDEN", "Sweden", 752, 46, null },
                    { 206, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CH", "CHE", "SWITZERLAND", "Switzerland", 756, 41, null },
                    { 207, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SY", "SYR", "SYRIAN ARAB REPUBLIC", "Syrian Arab Republic", 760, 963, null },
                    { 208, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TW", "TWN", "TAIWAN, PROVINCE OF CHINA", "Taiwan, Province of China", 158, 886, null },
                    { 209, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TJ", "TJK", "TAJIKISTAN", "Tajikistan", 762, 992, null },
                    { 210, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TZ", "TZA", "TANZANIA, UNITED REPUBLIC OF", "Tanzania, United Republic of", 834, 255, null },
                    { 211, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TH", "THA", "THAILAND", "Thailand", 764, 66, null },
                    { 212, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TL", null, "TIMOR-LESTE", "Timor-Leste", 0, 670, null },
                    { 213, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TG", "TGO", "TOGO", "Togo", 768, 228, null },
                    { 214, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TK", "TKL", "TOKELAU", "Tokelau", 772, 690, null },
                    { 215, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TO", "TON", "TONGA", "Tonga", 776, 676, null },
                    { 216, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TT", "TTO", "TRINIDAD AND TOBAGO", "Trinidad and Tobago", 780, 1868, null },
                    { 217, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TN", "TUN", "TUNISIA", "Tunisia", 788, 216, null },
                    { 218, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TR", "TUR", "TURKEY", "Turkey", 792, 90, null },
                    { 219, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TM", "TKM", "TURKMENISTAN", "Turkmenistan", 795, 7370, null },
                    { 220, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TC", "TCA", "TURKS AND CAICOS ISLANDS", "Turks and Caicos Islands", 796, 1649, null },
                    { 221, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TV", "TUV", "TUVALU", "Tuvalu", 798, 688, null },
                    { 222, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UG", "UGA", "UGANDA", "Uganda", 800, 256, null },
                    { 223, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UA", "UKR", "UKRAINE", "Ukraine", 804, 380, null },
                    { 224, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AE", "ARE", "UNITED ARAB EMIRATES", "United Arab Emirates", 784, 971, null },
                    { 225, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GB", "GBR", "UNITED KINGDOM", "United Kingdom", 826, 44, null },
                    { 226, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US", "USA", "UNITED STATES", "United States", 840, 1, null },
                    { 227, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UM", null, "UNITED STATES MINOR OUTLYING ISLANDS", "United States Minor Outlying Islands", 0, 1, null },
                    { 228, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UY", "URY", "URUGUAY", "Uruguay", 858, 598, null },
                    { 229, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UZ", "UZB", "UZBEKISTAN", "Uzbekistan", 860, 998, null },
                    { 230, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VU", "VUT", "VANUATU", "Vanuatu", 548, 678, null },
                    { 231, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VE", "VEN", "VENEZUELA", "Venezuela", 862, 58, null },
                    { 232, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VN", "VNM", "VIET NAM", "Viet Nam", 704, 84, null },
                    { 233, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VG", "VGB", "VIRGIN ISLANDS, BRITISH", "Virgin Islands, British", 92, 1284, null },
                    { 234, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VI", "VIR", "VIRGIN ISLANDS, U.S.", "Virgin Islands, U.s.", 850, 1340, null },
                    { 235, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WF", "WLF", "WALLIS AND FUTUNA", "Wallis and Futuna", 876, 681, null },
                    { 236, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EH", "ESH", "WESTERN SAHARA", "Western Sahara", 732, 212, null },
                    { 237, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "YE", "YEM", "YEMEN", "Yemen", 887, 967, null },
                    { 238, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZM", "ZMB", "ZAMBIA", "Zambia", 894, 260, null },
                    { 239, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZW", "ZWE", "ZIMBABWE", "Zimbabwe", 716, 263, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 24, 21, 7, 41, 194, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 24, 21, 7, 41, 194, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 24, 21, 7, 41, 194, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 24, 21, 7, 41, 194, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 24, 21, 7, 41, 194, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreateDate", "Latitude", "Longitude", "NortheastLat", "NortheastLng", "SouthwestLat", "SouthwestLng", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 35.321333299999999, 37.072004, 35.461995000000002, 36.935523000000003, 35.174706, "ADANA", null },
                    { 2, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.764166699999997, 38.276166699999997, 37.825667000000003, 38.335464999999999, 37.717086000000002, 38.188187999999997, "ADIYAMAN", null },
                    { 3, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.763759999999998, 30.54034, 38.802104999999997, 30.611166999999998, 38.714289000000001, 30.442319999999999, "AFYONKARAHİSAR", null },
                    { 4, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.7216667, 43.056666700000001, 39.748604999999998, 43.085241000000003, 39.688144000000001, 43.001778000000002, "AĞRI", null },
                    { 5, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.649999999999999, 35.8333333, 40.672834000000002, 35.856321000000001, 40.636910999999998, 35.789090999999999, "AMASYA", null },
                    { 6, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.920769999999997, 32.854109999999999, 40.100980999999997, 33.024866000000003, 39.722821000000003, 32.499096999999999, "ANKARA", null },
                    { 7, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.884140000000002, 30.705629999999999, 36.975178, 30.840952999999999, 36.785865999999999, 30.516095, "ANTALYA", null },
                    { 8, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.183333300000001, 41.816666699999999, 41.207078000000003, 41.854799, 41.155414999999998, 41.777360999999999, "ARTVİN", null },
                    { 9, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.8444, 27.845800000000001, 37.870997000000003, 27.885355000000001, 37.819572999999998, 27.790521999999999, "AYDIN", null },
                    { 10, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.648369000000002, 27.88261, 39.693666, 27.95241, 39.612411000000002, 27.838312999999999, "BALIKESİR", null },
                    { 11, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.150131000000002, 29.983060999999999, 40.197617000000001, 30.013591999999999, 40.106242999999999, 29.956657, "BİLECİK", null },
                    { 12, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.885348999999998, 40.498291000000002, 38.897962999999997, 40.525928999999998, 38.872987000000002, 40.477257999999999, "BİNGÖL", null },
                    { 13, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.399999999999999, 42.116666700000003, 38.453637999999998, 42.148879000000001, 38.385311999999999, 42.09384, "BİTLİS", null },
                    { 14, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.739479000000003, 31.611560999999998, 40.758004, 31.658418000000001, 40.716802000000001, 31.573324, "BOLU", null },
                    { 15, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.726908999999999, 30.288875999999998, 37.763750000000002, 30.336662, 37.691433000000004, 30.191756999999999, "BURDUR", null },
                    { 16, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.182569999999998, 29.066870000000002, 40.297193999999998, 29.211237000000001, 40.162996999999997, 28.859629999999999, "BURSA", null },
                    { 17, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.155312000000002, 26.414159999999999, 40.199461999999997, 26.457106, 40.088085999999997, 26.378025999999998, "ÇANAKKALE", null },
                    { 18, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.600000000000001, 33.616666700000003, 40.655158999999998, 33.684852999999997, 40.557709000000003, 33.596570999999997, "ÇANKIRI", null },
                    { 19, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.550555600000003, 34.955555599999997, 40.609316999999997, 35.006438000000003, 40.495213999999997, 34.887633999999998, "ÇORUM", null },
                    { 20, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.776519999999998, 29.086390000000002, 37.847366000000001, 29.188915000000001, 37.716171000000003, 28.981373000000001, "DENİZLİ", null },
                    { 21, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.914409999999997, 40.230629, 37.976174, 40.245803000000002, 37.879624, 40.106158999999998, "DİYARBAKIR", null },
                    { 22, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.6666667, 26.566666699999999, 41.697938999999998, 26.603093000000001, 41.649934999999999, 26.514059, "EDİRNE", null },
                    { 23, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.680968999999997, 39.226398000000003, 38.713568000000002, 39.277313999999997, 38.630564, 39.133405000000003, "ELAZIĞ", null },
                    { 24, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.75, 39.5, 39.769164000000004, 39.531742999999999, 39.729883999999998, 39.460253000000002, "ERZİNCAN", null },
                    { 25, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.9043189, 41.267885300000003, 39.954532999999998, 41.303593999999997, 39.866714999999999, 41.177092999999999, "ERZURUM", null },
                    { 26, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.784301999999997, 30.519220000000001, 39.816792999999997, 30.66769, 39.724752000000002, 30.414083999999999, "ESKİŞEHİR", null },
                    { 27, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.066220000000001, 37.383319999999998, 37.113722000000003, 37.466957999999998, 37.005946999999999, 37.303708999999998, "GAZİANTEP", null },
                    { 28, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.912810999999998, 38.389530000000001, 40.927995000000003, 38.450043999999998, 40.877876000000001, 38.309018000000002, "GİRESUN", null },
                    { 29, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.4602778, 39.481388899999999, 40.471359, 39.520640999999998, 40.430200999999997, 39.446914, "GÜMÜŞHANE", null },
                    { 30, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.5833333, 43.733333299999998, 37.601655999999998, 43.762256999999998, 37.551549000000001, 43.698090000000001, "HAKKARİ", null },
                    { 31, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.401848800000003, 36.349809700000002, 37.014921000000001, 36.697535000000002, 35.812691999999998, 35.779375000000002, "HATAY", null },
                    { 32, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.766666700000002, 30.550000000000001, 37.830719000000002, 30.609197000000002, 37.739879999999999, 30.503672999999999, "ISPARTA", null },
                    { 33, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.799999999999997, 34.633333299999997, 36.878272000000003, 34.716701999999998, 36.699503, 34.457655000000003, "MERSİN{İÇEL}", null },
                    { 34, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.005270000000003, 28.976959999999998, 41.320785999999998, 29.456455999999999, 40.802750000000003, 27.971306999999999, "İSTANBUL", null },
                    { 35, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.418849999999999, 27.128720000000001, 38.506773000000003, 27.304414999999999, 38.343156999999998, 27.017192000000001, "İZMİR", null },
                    { 36, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.592669999999998, 43.077831000000003, 40.624842999999998, 43.133899999999997, 40.577483999999998, 43.056432000000001, "KARS", null },
                    { 37, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.388710000000003, 33.782730000000001, 41.436059, 33.814988999999997, 41.350667999999999, 33.752901000000001, "KASTAMONU", null },
                    { 38, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.733333299999998, 35.483333299999998, 38.818797000000004, 35.627675000000004, 38.622002000000002, 35.304324000000001, "KAYSERİ", null },
                    { 39, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.733333299999998, 27.216666700000001, 41.760053999999997, 27.24222, 41.710614999999997, 27.182842999999998, "KIRKLARELİ", null },
                    { 40, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.149999999999999, 34.1666667, 39.203938999999998, 34.217742999999999, 39.081293000000002, 34.125532, "KIRŞEHİR", null },
                    { 41, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.8532704, 29.881520299999998, 41.209760000000003, 30.359684000000001, 40.532781999999997, 29.333462000000001, "KOCAELİ", null },
                    { 42, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.866666700000003, 32.483333299999998, 38.050629999999998, 32.680115999999998, 37.719031000000001, 32.338737000000002, "KONYA", null },
                    { 43, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.4166667, 29.983333300000002, 39.442717999999999, 30.066503000000001, 39.379472999999997, 29.919198999999999, "KÜTAHYA", null },
                    { 44, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.35519, 38.309460000000001, 38.397559000000001, 38.453243999999998, 38.305123000000002, 38.232621999999999, "MALATYA", null },
                    { 45, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.619098999999999, 27.428920999999999, 38.642288999999998, 27.487976, 38.602376, 27.326086, "MANİSA", null },
                    { 46, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.5833333, 36.933333300000001, 37.605260999999999, 36.997678000000001, 37.530309000000003, 36.829703000000002, "KAHRAMANMARAŞ", null },
                    { 47, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.3122361, 40.735112000000001, 37.330553999999999, 40.764485999999998, 37.305109000000002, 40.716971000000001, "MARDİN", null },
                    { 48, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.215277800000003, 28.3636111, 37.225810000000003, 28.414497999999998, 37.194651, 28.341279, "MUĞLA", null },
                    { 49, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.743292599999997, 41.506482300000002, 38.783503000000003, 41.540624999999999, 38.718223999999999, 41.472306000000003, "MUŞ", null },
                    { 50, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.624420000000001, 34.723968999999997, 38.684106999999997, 34.764758999999998, 38.589047000000001, 34.669752000000003, "NEVŞEHİR", null },
                    { 51, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.966666699999998, 34.683333300000001, 37.979913000000003, 34.691585000000003, 37.956992, 34.661906000000002, "NİĞDE", null },
                    { 52, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.983333299999998, 37.883333299999997, 41.020339999999997, 37.978976000000003, 40.931631000000003, 37.825991999999999, "ORDU", null },
                    { 53, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.020049999999998, 40.523448999999999, 41.046492000000001, 40.586801999999999, 41.010781999999999, 40.478577999999999, "RİZE", null },
                    { 54, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.756879300000001, 30.378138, 40.825518000000002, 30.439831999999999, 40.686199000000002, 30.322137999999999, "SAKARYA", null },
                    { 55, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.292782000000003, 36.33128, 41.344133999999997, 36.381205000000001, 41.235002000000001, 36.249518999999999, "SAMSUN", null },
                    { 56, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.944290000000002, 41.932879999999997, 37.955939999999998, 41.963658000000002, 37.909671000000003, 41.872546999999997, "SİİRT", null },
                    { 57, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.026422199999999, 35.155074499999998, 42.032134999999997, 35.194946999999999, 42.012675000000002, 35.115957000000002, "SİNOP", null },
                    { 58, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.747661999999998, 37.017879000000001, 39.783669000000003, 37.061672999999999, 39.699024000000001, 36.919857999999998, "SİVAS", null },
                    { 59, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.983333299999998, 27.516666699999998, 40.996723000000003, 27.600252000000001, 40.937703999999997, 27.468993000000001, "TEKİRDAĞ", null },
                    { 60, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.316666699999999, 36.549999999999997, 40.358932000000003, 36.593218999999998, 40.267868, 36.469662, "TOKAT", null },
                    { 61, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 39.733333299999998, 41.012369999999997, 39.820509999999999, 40.955736000000002, 39.652406999999997, "TRABZON", null },
                    { 62, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.107986799999999, 39.540167199999999, 39.113477000000003, 39.551850000000002, 39.094534000000003, 39.530014999999999, "TUNCELİ", null },
                    { 63, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.149999999999999, 38.799999999999997, 37.189639, 38.840876000000002, 37.098274000000004, 38.767868, "ŞANLIURFA", null },
                    { 64, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.682301000000002, 29.408190000000001, 38.715879999999999, 29.469837999999999, 38.630679000000001, 29.355936, "UŞAK", null },
                    { 65, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.494166700000001, 43.380000000000003, 38.580314000000001, 43.455356000000002, 38.421880000000002, 43.269523999999997, "VAN", null },
                    { 66, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.82, 34.804444400000001, 39.838422999999999, 34.858235999999998, 39.798968000000002, 34.771093999999998, "YOZGAT", null },
                    { 67, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.456409000000001, 31.798731, 41.480784, 31.874424999999999, 41.425296000000003, 31.757052000000002, "ZONGULDAK", null },
                    { 68, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.368690000000001, 34.03698, 38.446724000000003, 34.088698000000001, 38.297012000000002, 33.932515000000002, "AKSARAY", null },
                    { 69, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.255169000000002, 40.224879999999999, 40.272635999999999, 40.238261000000001, 40.242880999999997, 40.208762, "BAYBURT", null },
                    { 70, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.175930000000001, 33.228748000000003, 37.229373000000002, 33.334243999999998, 37.148257000000001, 33.166003000000003, "KARAMAN", null },
                    { 71, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.846820999999998, 33.515250999999999, 39.872843000000003, 33.597968000000002, 39.813802000000003, 33.468288999999999, "KIRIKKALE", null },
                    { 72, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.881168000000002, 41.135089999999998, 37.947274, 41.176029999999997, 37.856569999999998, 41.080590999999998, "BATMAN", null },
                    { 73, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.516388900000003, 42.461111099999997, 37.533571999999999, 42.471127000000003, 37.500093, 42.444631000000001, "ŞIRNAK", null },
                    { 74, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.6344444, 32.337499999999999, 41.656542000000002, 32.371049999999997, 41.613512999999998, 32.297457000000001, "BARTIN", null },
                    { 75, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.110481, 42.702171, 41.121467000000003, 42.717129, 41.098909999999997, 42.686418000000003, "ARDAHAN", null },
                    { 76, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.9166667, 44.033333300000002, 39.950163000000003, 44.092824999999998, 39.884109000000002, 43.980728999999997, "IĞDIR", null },
                    { 77, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.649999999999999, 29.266666699999998, 40.668059999999997, 29.316535999999999, 40.634138, 29.210232999999999, "YALOVA", null },
                    { 78, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.200000000000003, 32.633333299999997, 41.238129000000001, 32.675517999999997, 41.163013999999997, 32.592582, "KARABÜK", null },
                    { 79, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.718398999999998, 37.121220000000001, 36.747819, 37.159540999999997, 36.702672999999997, 37.085183000000001, "KİLİS", null },
                    { 80, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.068049999999999, 36.261589000000001, 37.104061000000002, 36.287940999999996, 37.046939999999999, 36.208033999999998, "OSMANİYE", null },
                    { 81, 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.843848999999999, 31.15654, 40.891762, 31.195806999999999, 40.824717, 31.106662, "DÜZCE", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_CityId",
                table: "Counties",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "Institutions");

            migrationBuilder.DropTable(
                name: "MainInstitutions");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 15, 1, 14, 14, 842, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 15, 1, 14, 14, 842, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 15, 1, 14, 14, 842, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 15, 1, 14, 14, 842, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 15, 1, 14, 14, 842, DateTimeKind.Local).AddTicks(288));
        }
    }
}
