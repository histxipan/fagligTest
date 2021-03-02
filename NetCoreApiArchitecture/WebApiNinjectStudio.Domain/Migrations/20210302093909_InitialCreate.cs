using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiNinjectStudio.Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiUrls",
                columns: table => new
                {
                    ApiUrlID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiUrlString = table.Column<string>(nullable: true),
                    ApiRequestMethod = table.Column<string>(nullable: true),
                    ApiUrlRegex = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiUrls", x => x.ApiUrlID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImageId);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    ProductTagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => x.ProductTagID);
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissionApiUrls",
                columns: table => new
                {
                    ApiUrlID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissionApiUrls", x => new { x.RoleID, x.ApiUrlID });
                    table.ForeignKey(
                        name: "FK_RolePermissionApiUrls_ApiUrls_ApiUrlID",
                        column: x => x.ApiUrlID,
                        principalTable: "ApiUrls",
                        principalColumn: "ApiUrlID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissionApiUrls_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RoleID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApiUrls",
                columns: new[] { "ApiUrlID", "ApiRequestMethod", "ApiUrlRegex", "ApiUrlString", "Description", "IsDeleted" },
                values: new object[,]
                {
                    { 1, "Get", null, "/api/User", null, false },
                    { 19, "Get", "^\\/api\\/v1\\/integrations\\/customer\\/userid$", "/api/v1/integrations/customer/userid", "Get id of current user.", false },
                    { 18, "Delete", "^\\/api\\/v1\\/products\\/\\d+$", "/api/v1/products/{productId}", "Remove the product by product id", false },
                    { 17, "Put", "^\\/api\\/v1\\/products\\/\\d+$", "/api/v1/products/{productId}", "Update the product by product id", false },
                    { 16, "Get", "^\\/api\\/v1\\/products\\/\\d+$", "/api/v1/products/{productId}", "Get info about product by product id", false },
                    { 15, "Post", "^\\/api\\/v1\\/products$", "/api/v1/products", "Create product", false },
                    { 14, "Get", "^\\/api\\/v1\\/products(\\?.*)*$", "/api/v1/products", "Get product list", false },
                    { 12, "Put", "^\\/api\\/v1\\/categories\\/\\d+\\/products$", "/api/v1/categories/{categoryId}/products", "Assign a product to the required category", false },
                    { 11, "Get", "^\\/api\\/v1\\/categories\\/\\d+\\/products(\\?.*)*$", "/api/v1/categories/{categoryId}/products", "Get products assigned to category", false },
                    { 13, "Delete", "^\\/api\\/v1\\/categories\\/\\d+\\/products\\/\\d+$", "/api/v1/categories/{categoryId}/products/{productId}", "Remove the product assignment from the category by category id and product id", false },
                    { 9, "Put", "^\\/api\\/v1\\/categories\\/\\d+$", "/api/v1/categories/{categoryId}", "Update category by identifier", false },
                    { 8, "Delete", "^\\/api\\/v1\\/categories\\/\\d+$", "/api/v1/categories/{categoryId}", "Delete category by identifier", false },
                    { 7, "Get", "^\\/api\\/v1\\/categories\\/\\d+$", "/api/v1/categories/{categoryId}", "Get info about category by category id", false },
                    { 6, "Get", "^\\/api\\/v1\\/categories$", "/api/v1/categories", "Get category list", false },
                    { 5, "Post", "^\\/api\\/v1\\/categories$", "/api/v1/categories", "Create category", false },
                    { 4, "Post", null, "/api/product", null, false },
                    { 3, "Get", null, "/api/product", null, false },
                    { 2, "Get", null, "/api/User/GetUserID", null, false },
                    { 10, "Post", "^\\/api\\/v1\\/categories\\/\\d+\\/products$", "/api/v1/categories/{categoryId}/products", "Assign a product to the required category", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Description", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text", false, "Kontorstol REGSTRUP", 300m },
                    { 2, "Barstol KLARUP", false, "Barstol KLARUP", 250m },
                    { 3, "Lorem Ipsum is simply dummy text", false, "iPhone 12", 7250m },
                    { 4, "Lorem Ipsum is simply dummy text", false, "Nokia Lumia 3000", 1420m },
                    { 5, "Lorem Ipsum is simply dummy text", false, "Tomat", 20m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, null, false, "Administrator" },
                    { 2, null, false, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ProductImageId", "IsDeleted", "ProductID", "Url" },
                values: new object[,]
                {
                    { 1, false, 1, "jysk.dk/kontor/kontorstole/basic/kontorstol-regstrup-sort-graa" },
                    { 2, false, 2, "jysk.dk/spisestue/barborde-stole/barstol-klarup-sort-krom-0" }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ProductTagID", "IsDeleted", "Name", "ProductID" },
                values: new object[,]
                {
                    { 1, false, "Bremsehjul", 1 },
                    { 2, false, "Højdejusterbar", 1 },
                    { 3, false, "Skum", 2 },
                    { 4, false, "Metal", 2 },
                    { 5, false, "6,1", 3 },
                    { 6, false, "5G", 3 }
                });

            migrationBuilder.InsertData(
                table: "RolePermissionApiUrls",
                columns: new[] { "RoleID", "ApiUrlID", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 13, false },
                    { 1, 14, false },
                    { 1, 15, false },
                    { 1, 16, false },
                    { 2, 3, false },
                    { 1, 18, false },
                    { 1, 19, false },
                    { 1, 12, false },
                    { 1, 17, false },
                    { 1, 11, false },
                    { 1, 8, false },
                    { 1, 9, false },
                    { 2, 4, false },
                    { 1, 7, false },
                    { 1, 6, false },
                    { 1, 5, false },
                    { 1, 4, false },
                    { 1, 3, false },
                    { 1, 2, false },
                    { 1, 1, false },
                    { 1, 10, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "FirstName", "IsDeleted", "LastName", "Password", "PhoneNumber", "RoleID" },
                values: new object[,]
                {
                    { 1, "one@gmail.com", "Kim", false, "Nielsen", "M4jZrsPV2wNAeOH1YooKUdALx6Ek0DJaMf8yoiYI0Mc=", null, 1 },
                    { 2, "two@gmail.com", "Martin", false, "Jensen", "FOHqRDbYuVdIBvLS6r2YMVU4Yu7E54DJJJxrWGh5YZc=", null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductID",
                table: "ProductImages",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_ProductID",
                table: "ProductTags",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionApiUrls_ApiUrlID",
                table: "RolePermissionApiUrls",
                column: "ApiUrlID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "RolePermissionApiUrls");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ApiUrls");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
