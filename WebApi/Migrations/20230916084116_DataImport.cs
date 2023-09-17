using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;
using WebApi.Model;

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
