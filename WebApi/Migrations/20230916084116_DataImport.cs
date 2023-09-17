using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;
using WebApi.Model;
using static System.Net.WebRequestMethods;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class DataImport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "ASUS Vivobook S 15 OLED", "https://image.alza.cz/products/NA651c2j3/NA651c2j3.jpg?width=190&height=190", 24490 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "MacBook Air 13\" M1 CZ", "https://image.alza.cz/products/NL244a1a/NL244a1a.jpg?width=190&height=190", 23490 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Lenovo V15 G3 IAP", "https://image.alza.cz/products/NT220f6k8h/NT220f6k8h.jpg?width=190&height=190", 13390 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Lenovo ThinkPad E15 Gen 4 Black", "https://image.alza.cz/products/NT217k3/NT217k3.jpg?width=190&height=190", 21990 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "GIGABYTE G5 KF", "https://image.alza.cz/products/NGB080q2/NGB080q2.jpg?width=190&height=190", 25590 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Microsoft Surface Go 3 64GB 4GB Platinum", "https://image.alza.cz/products/MCS351g2j/MCS351g2j.jpg?width=190&height=190", 10690 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "GIGABYTE G5 GE", "https://image.alza.cz/products/NGB079n3/NGB079n3.jpg?width=190&height=190", 18590 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Lenovo ThinkBook 15 G4 IAP kovový", "https://image.alza.cz/products/NT187h25i0c/NT187h25i0c.jpg?width=190&height=190", 13290 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "ASUS Vivobook 15 OLED X1505VA-OLED128W Indie Black", "https://image.alza.cz/products/NA567g50u1/NA567g50u1.jpg?width=190&height=190", 15990 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Lenovo IdeaPad 5 15ALC05 Graphite Grey celokovový", "https://image.alza.cz/products/NT385l7e0a/NT385l7e0a.jpg?width=190&height=190", 13499 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Lenovo Legion Pro 5 16IRX8 Onyx Grey kovový", "https://image.alza.cz/products/NT379k08q8/NT379k08q8.jpg?width=190&height=190", 46990 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Gembird JPD-WDV-01", "https://image.alza.cz/products/JP157d6/JP157d6.jpg?width=190&height=190", 379 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Razer DeathAdder V2 Pro", "https://image.alza.cz/products/MR066e8/MR066e8.jpg?width=190&height=190", 3100 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Keychron QMK Q8 65% Ergonomic Gateron G", "https://image.alza.cz/products/KCHRON008a12/KCHRON008a12.jpg?width=190&height=190", 5490 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "C-TECH MPG-03 černá", "https://image.alza.cz/products/MC505a3/MC505a3.jpg?width=190&height=190", 129 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "DXRACER Formula OH/FD01/NR", "https://image.alza.cz/products/DXR008f2b3/DXR008f2b3.jpg?width=190&height=190", 6500 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Epson WorkForce Pro WF-3820DWF", "https://image.alza.cz/products/PE020u4a3/PE020u4a3.jpg?width=190&height=190", 2900 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "ImgUri", "Price" },
                values: new object[] { "Alza GameBox Core RTX3050", "https://image.alza.cz/products/sklRB4a7s5b/sklRB4a7s5b.jpg?width=190&height=190", 24990 });

            migrationBuilder.InsertData(
                        table: "Products",
                        columns: new[] { "Name", "ImgUri", "Price" },
                        values: new object[] { "Samsung Galaxy A34 5G 8GB/256GB grafitová - CZ distribuce", "https://image.alza.cz/products/SAMO0249c3/SAMO0249c3.jpg?width=230&height=230", 8900 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 13 128GB černá", "https://image.alza.cz/products/RI036b2/RI036b2.jpg?width=230&height=230", 17990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 12 64GB černá", "https://image.alza.cz/products/RI032b2/RI032b2.jpg?width=230&height=230", 14990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 256GB černá - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI041c1/RI041c1.jpg?width=230&height=230", 23990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy S20 FE 5G 128GB modrá - CZ distribuce", "https://image.alza.cz/products/SAMO0203b1/SAMO0203b1.jpg?width=230&height=230", 9990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy A34 5G 8GB/256GB fialová - CZ distribuce", "https://image.alza.cz/products/SAMO0249c2/SAMO0249c2.jpg?width=230&height=230", 8990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy A34 5G 8GB/256GB stříbrná - CZ distribuce", "https://image.alza.cz/products/SAMO0249c4/SAMO0249c4.jpg?width=230&height=230", 8990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 13 mini 128GB černá", "https://image.alza.cz/products/RI037b2/RI037b2.jpg?width=230&height=230", 16990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 128GB černá - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI041b1/RI041b1.jpg?width=230&height=230", 20990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy A14 4GB/128GB černá - CZ distribuce", "https://image.alza.cz/products/SAMO0247c2/SAMO0247c2.jpg?width=230&height=230", 4490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 Pro 256GB černá - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI043c1/RI043c1.jpg?width=230&height=230", 29990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Google Pixel 7a 5G 8GB/128GB černý", "https://image.alza.cz/products/GPX1072b2/GPX1072b2.jpg?width=230&height=230", 11990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 13 128GB bílá", "https://image.alza.cz/products/RI036b1/RI036b1.jpg?width=230&height=230", 17990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 Pro 128GB černá - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI043b1/RI043b1.jpg?width=230&height=230", 27490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 128GB fialová - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI041b5/RI041b5.jpg?width=230&height=230", 20990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 Pro 128GB fialová - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI043b4/RI043b4.jpg?width=230&height=230", 27490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Xiaomi Redmi 12 8GB/256GB Sky Blue", "https://image.alza.cz/products/XI269c1/XI269c1.jpg?width=230&height=230", 4239 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Xiaomi Redmi 12 8GB/256GB Midnight Black", "https://image.alza.cz/products/XI269c3/XI269c3.jpg?width=230&height=230", 4239 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 Pro 128GB stříbrná - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI043b2/RI043b2.jpg?width=230&height=230", 27490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy A54 5G 8GB/256GB grafitová - CZ distribuce", "https://image.alza.cz/products/SAMO0250c3/SAMO0250c3.jpg?width=230&height=230", 10990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy A33 5G černá - CZ distribuce", "https://image.alza.cz/products/SAMO0233b2/SAMO0233b2.jpg?width=230&height=230", 6999 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 128GB bílá - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI041b2/RI041b2.jpg?width=230&height=230", 20990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 128GB modrá - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI041b3/RI041b3.jpg?width=230&height=230", 20990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Xiaomi Redmi Note 12S 8GB/256GB černý", "https://image.alza.cz/products/XI268b1/XI268b1.jpg?width=230&height=230", 5990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 Pro Max 256GB černá - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI044c1/RI044c1.jpg?width=230&height=230", 32990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 11 64GB černá", "https://image.alza.cz/products/RI028b2/RI028b2.jpg?width=230&height=230", 12990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy A34 5G 8GB/256GB limetková - CZ distribuce", "https://image.alza.cz/products/SAMO0249c1/SAMO0249c1.jpg?width=230&height=230", 8990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy A14 4GB/64GB černá - CZ distribuce", "https://image.alza.cz/products/SAMO0247b2/SAMO0247b2.jpg?width=230&height=230", 3990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy S23 5G 256GB zelená - CZ distribuce", "https://image.alza.cz/products/SAMO0246c4/SAMO0246c4.jpg?width=230&height=230", 21990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 Pro Max 128GB černá - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI044b1/RI044b1.jpg?width=230&height=230", 29990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 Pro 128GB zlatá - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI043b3/RI043b3.jpg?width=230&height=230", 27490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy S23 5G 256GB černá - CZ distribuce", "https://image.alza.cz/products/SAMO0246c5/SAMO0246c5.jpg?width=230&height=230", 21990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 13 128GB zelená", "https://image.alza.cz/products/RI036b6/RI036b6.jpg?width=230&height=230", 17990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Motorola Moto G13 4GB/128GB modrá", "https://image.alza.cz/products/SMTR518b1/SMTR518b1.jpg?width=230&height=230", 2539 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 Pro 256GB fialová - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI043c4/RI043c4.jpg?width=230&height=230", 29990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Xiaomi Redmi Note 12 Pro+ 5G 8GB/256GB černá", "https://image.alza.cz/products/XI266b1/XI266b1.jpg?width=230&height=230", 9990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Motorola EDGE 40 5G 8GB/256GB černá", "https://image.alza.cz/products/SMTR523b1/SMTR523b1.jpg?width=230&height=230", 14284 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Xiaomi Redmi Note 12 8GB/256GB Onyx Gray", "https://image.alza.cz/products/XI263d2/XI263d2.jpg?width=230&height=230", 4959 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 13 128GB modrá", "https://image.alza.cz/products/RI036b4/RI036b4.jpg?width=230&height=230", 17990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPhone 14 Pro Max 256GB fialová - výkupní bonus 2 500 Kč", "https://image.alza.cz/products/RI044c4/RI044c4.jpg?width=230&height=230", 32990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy Watch 4 40mm růžovo-zlaté", "https://image.alza.cz/products/SaGALW440rg/SaGALW440rg.jpg?width=230&height=230", 4490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Garmin Venu 2 Plus Silver/Gray Band", "https://image.alza.cz/products/PPvenu2PL1/PPvenu2PL1.jpg?width=230&height=230", 8990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy Watch 5 Pro 45mm LTE černé", "https://image.alza.cz/products/SaGW0512c1/SaGW0512c1.jpg?width=230&height=230", 9990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Garmin Fenix 7X Sapphire Solar Carbon Gray DLC Titanium/Black Band záruka 36 měsíců", "https://image.alza.cz/products/PPfenix7s14/PPfenix7s14.jpg?width=230&height=230", 17990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Xiaomi Smart Band 7", "https://image.alza.cz/products/XI7000a/XI7000a.jpg?width=230&height=230", 799 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "CARNEO GuardKid+ 4G Platinum black", "https://image.alza.cz/products/CAR009b1/CAR009b1.jpg?width=230&height=230", 2590 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Apple Watch SE (2022) 40mm Hvězdně bílý hliník s hvězdně bílým sportovním řemínkem", "https://image.alza.cz/products/JA090n40a/JA090n40a.jpg?width=230&height=230", 6990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Garmin Epix Pro 47mm Slate Gray/Black Band + voucher Topo Czech", "https://image.alza.cz/products/PPepixpro2gb3/PPepixpro2gb3.jpg?width=230&height=230", 20490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Apple Watch Series 8 41mm Hvězdně bílý hliník s hvězdně bílým sportovním řemínkem", "https://image.alza.cz/products/JA080a41n2/JA080a41n2.jpg?width=230&height=230", 9989 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Apple Watch SE (2022) 44mm Temně inkoustový hliník s temně inkoustovým sportovním řemínkem", "https://image.alza.cz/products/JA090n44b/JA090n44b.jpg?width=230&height=230", 7790 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "CARNEO GuardKid+ 4G Platinum blue", "https://image.alza.cz/products/CAR009b2/CAR009b2.jpg?width=230&height=230", 2590 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Garmin Fenix 7 Pro Solar Gray/Black Band + voucher Topo Czech", "https://image.alza.cz/products/PPfenix7prob1/PPfenix7prob1.jpg?width=230&height=230", 18990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Apple Watch SE (2022) 40mm Temně inkoustový hliník s temně inkoustovým sportovním řemínkem", "https://image.alza.cz/products/JA090n40b/JA090n40b.jpg?width=230&height=230", 6989 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "CARNEO GuardKid+ 4G Platinum pink", "https://image.alza.cz/products/CAR009b3/CAR009b3.jpg?width=230&height=230", 2590 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "WowME Kids 4G blue", "https://image.alza.cz/products/wowmK4b/wowmK4b.jpg?width=230&height=230", 1990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Apple Watch SE (2022) 40mm Stříbrný hliník s bílým sportovním řemínkem", "https://image.alza.cz/products/JA090n40c/JA090n40c.jpg?width=230&height=230", 6990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Apple Watch Series 8 41mm Temně inkoustový hliník s temně inkoustovým sportovním řemínkem", "https://image.alza.cz/products/JA080a41n1/JA080a41n1.jpg?width=230&height=230", 9990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Xiaomi Watch S1 Active Space Black", "https://image.alza.cz/products/XIMiwS1act3/XIMiwS1act3.jpg?width=230&height=230", 2599 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Amazfit GTR Mini Misty Pink", "https://image.alza.cz/products/XIgt404b2/XIgt404b2.jpg?width=230&height=230", 3190 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "WowME Kids 4G pink", "https://image.alza.cz/products/wowmK4p/wowmK4p.jpg?width=230&height=230", 1990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Garmin Fenix 7 Silver/Graphite Band záruka 36 měsíců", "https://image.alza.cz/products/PPfenix7s8/PPfenix7s8.jpg?width=230&height=230", 13990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Garmin Fenix 7 Sapphire Solar Carbon Gray DLC Titanium/Black Band záruka 36 měsíců", "https://image.alza.cz/products/PPfenix7s10/PPfenix7s10.jpg?width=230&height=230", 17990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Amazfit GTR 4 Superspeed Black", "https://image.alza.cz/products/XIgt401b1/XIgt401b1.jpg?width=230&height=230", 4539 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Apple Watch Series 8 45mm Cellular Temně inkoustový hliník s temně inkoustovým sportovním řemínkem", "https://image.alza.cz/products/JA080a45c1/JA080a45c1.jpg?width=230&height=230", 13990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPad 10.2 64GB WiFi Vesmírně Šedý 2021", "https://image.alza.cz/products/NL202s8a/NL202s8a.jpg?width=230&height=230", 8999 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPad Pro 11 128GB M2 Vesmírně šedý 2022", "https://image.alza.cz/products/NL202t4a/NL202t4a.jpg?width=230&height=230", 23490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPad Pro 11 128GB M2 Stříbrný 2022", "https://image.alza.cz/products/NL202t4b/NL202t4b.jpg?width=230&height=230", 23490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPad Pro 12.9 128GB M2 Vesmírně šedý 2022", "https://image.alza.cz/products/NL203a6a/NL203a6a.jpg?width=230&height=230", 32890 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy Tab A8 WiFi Gray - CZ distribuce", "https://image.alza.cz/products/SATA1026c2/SATA1026c2.jpg?width=230&height=230", 3890 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy Tab A8 WiFi 64GB Gray - CZ distribuce", "https://image.alza.cz/products/SATA1026e3/SATA1026e3.jpg?width=230&height=230", 5490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPad 10.9 64GB WiFi Modrý 2022", "https://image.alza.cz/products/NL202s9a/NL202s9a.jpg?width=230&height=230", 13390 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPad Pro 11 256GB M2 Vesmírně šedý 2022", "https://image.alza.cz/products/NL202t4e/NL202t4e.jpg?width=230&height=230", 26990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Lenovo Tab M10 Plus (3rd Gen) 2023 4GB + 128GB Storm Grey", "https://image.alza.cz/products/NT210h9p46c4e1/NT210h9p46c4e1.jpg?width=230&height=230", 4999 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Xiaomi Pad 6 8GB/256GB Gravity Gray", "https://image.alza.cz/products/XITAB013c1/XITAB013c1.jpg?width=230&height=230", 9990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Lenovo Tab M10 (3rd) 4GB + 64GB Storm Grey", "https://image.alza.cz/products/NT210h9o24p/NT210h9o24p.jpg?width=230&height=230", 3999 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Lenovo Tab P12 8GB + 128GB Storm Grey + aktivní stylus Lenovo", "https://image.alza.cz/products/NT210s1/NT210s1.jpg?width=230&height=230", 9990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Lenovo Tab M10 Plus (3rd Gen) 4GB + 128GB Storm Grey LTE + Folio Case + aktivní stylus Lenovo", "https://image.alza.cz/products/NT210h9p46c6d/NT210h9p46c6d.jpg?width=230&height=230", 6999 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Xiaomi Redmi Pad SE 4GB/128GB šedý", "https://image.alza.cz/products/XITAB014b1/XITAB014b1.jpg?width=230&height=230", 4490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPad Air M1 64GB WiFi Růžový 2022", "https://image.alza.cz/products/NL202s4z1b/NL202s4z1b.jpg?width=230&height=230", 17490 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy TAB S7 FE 5G černý - CZ distribuce", "https://image.alza.cz/products/SATA1024x4/SATA1024x4.jpg?width=230&height=230", 13590 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Lenovo Tab M10 Plus (3rd Gen) 4GB + 128GB LTE Storm Grey", "https://image.alza.cz/products/NT210h9p46c4f/NT210h9p46c4f.jpg?width=230&height=230", 5899 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Lenovo Tab M10 Plus (3rd Gen) 2023 4GB + 64GB Storm Grey", "https://image.alza.cz/products/NT210h9p46c4g/NT210h9p46c4g.jpg?width=230&height=230", 4799 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "iPad Pro 11 256GB M2 Stříbrný 2022", "https://image.alza.cz/products/NL202t4f/NL202t4f.jpg?width=230&height=230", 26990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Oscal Pad 13 8GB/256GB gray", "https://image.alza.cz/products/OSCT003b2/OSCT003b2.jpg?width=230&height=230", 4290 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Samsung Galaxy TAB S7 FE černý - CZ distribuce", "https://image.alza.cz/products/SATA1024x1/SATA1024x1.jpg?width=230&height=230", 12990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Lenovo Tab P11 Pro (2nd Gen) 8GB + 256GB Storm Grey + aktivní stylus Lenovo", "https://image.alza.cz/products/NT210k2c/NT210k2c.jpg?width=230&height=230", 10990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Xiaomi Pad 6 8GB/256GB Zlatý", "https://image.alza.cz/products/XITAB013c2/XITAB013c2.jpg?width=230&height=230", 9990 });

            migrationBuilder.InsertData(
                            table: "Products",
                            columns: new[] { "Name", "ImgUri", "Price" },
                            values: new object[] { "Lenovo Tab P11 (2nd Gen) 6GB + 128GB Storm Grey", "https://image.alza.cz/products/NT210u1c/NT210u1c.jpg?width=230&height=230", 6999 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
