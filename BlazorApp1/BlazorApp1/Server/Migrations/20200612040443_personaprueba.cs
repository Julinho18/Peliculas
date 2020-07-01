using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Server.Migrations
{
    public partial class personaprueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 1000, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1000" },
                    { 1072, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1072" },
                    { 1071, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1071" },
                    { 1070, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1070" },
                    { 1069, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1069" },
                    { 1068, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1068" },
                    { 1067, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1067" },
                    { 1066, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1066" },
                    { 1065, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1065" },
                    { 1064, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1064" },
                    { 1063, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1063" },
                    { 1062, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1062" },
                    { 1061, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1061" },
                    { 1060, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1060" },
                    { 1059, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1059" },
                    { 1058, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1058" },
                    { 1057, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1057" },
                    { 1056, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1056" },
                    { 1055, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1055" },
                    { 1054, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1054" },
                    { 1053, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1053" },
                    { 1052, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1052" },
                    { 1073, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1073" },
                    { 1051, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1051" },
                    { 1074, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1074" },
                    { 1076, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1076" },
                    { 1097, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1097" },
                    { 1096, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1096" },
                    { 1095, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1095" },
                    { 1094, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1094" },
                    { 1093, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1093" },
                    { 1092, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1092" },
                    { 1091, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1091" },
                    { 1090, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1090" },
                    { 1089, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1089" },
                    { 1088, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1088" },
                    { 1087, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1087" },
                    { 1086, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1086" },
                    { 1085, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1085" },
                    { 1084, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1084" },
                    { 1083, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1083" },
                    { 1082, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1082" },
                    { 1081, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1081" },
                    { 1080, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1080" },
                    { 1079, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1079" },
                    { 1078, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1078" },
                    { 1077, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1077" },
                    { 1075, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1075" },
                    { 1050, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1050" },
                    { 1049, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1049" },
                    { 1048, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1048" },
                    { 1021, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1021" },
                    { 1020, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1020" },
                    { 1019, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1019" },
                    { 1018, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1018" },
                    { 1017, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1017" },
                    { 1016, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1016" },
                    { 1015, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1015" },
                    { 1014, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1014" },
                    { 1013, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1013" },
                    { 1012, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1012" },
                    { 1011, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1011" },
                    { 1010, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1010" },
                    { 1009, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1009" },
                    { 1008, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1008" },
                    { 1007, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1007" },
                    { 1006, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1006" },
                    { 1005, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1005" },
                    { 1004, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1004" },
                    { 1003, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1003" },
                    { 1002, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1002" },
                    { 1001, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1001" },
                    { 1022, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1022" },
                    { 1023, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1023" },
                    { 1024, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1024" },
                    { 1025, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1025" },
                    { 1047, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1047" },
                    { 1046, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1046" },
                    { 1045, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1045" },
                    { 1044, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1044" },
                    { 1043, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1043" },
                    { 1042, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1042" },
                    { 1041, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1041" },
                    { 1040, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1040" },
                    { 1039, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1039" },
                    { 1038, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1038" },
                    { 1098, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1098" },
                    { 1037, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1037" },
                    { 1035, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1035" },
                    { 1034, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1034" },
                    { 1033, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1033" },
                    { 1032, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1032" },
                    { 1031, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1031" },
                    { 1030, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1030" },
                    { 1029, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1029" },
                    { 1028, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1028" },
                    { 1027, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1027" },
                    { 1026, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1026" },
                    { 1036, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1036" },
                    { 1099, null, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 1099" }
                });

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenerosPeliculas");

            migrationBuilder.DropTable(
                name: "PeliculasActores");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
