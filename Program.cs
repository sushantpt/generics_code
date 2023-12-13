// See https://aka.ms/new-console-template for more information
using GenericsExample.Classes;
using GenericsExample.Interface;

// Create some clothes
Cloth shirt = new("denim jeans", 600);
Cloth jacket = new("leather", 1200);
Cloth sweater = new("woolen", 1800);

// check if sweater is expensive. Our logic insists > 1000 to be expensive.
/*AccountingService accountingService = new AccountingService();
var isExpensive = accountingService.IsProductExpensive(sweater);
Console.WriteLine($"Is product expensive:{isExpensive}");*/


// create warehouse to store clothes
/*Warehouse<Cloth> clothesWarehouse = new();
clothesWarehouse.AddItem(shirt);
clothesWarehouse.AddItem(jacket);
clothesWarehouse.AddItem(sweater);
clothesWarehouse.TotalItems();
Console.WriteLine("-- Remove an item from the warehouse. --");
clothesWarehouse.RemoveItem(sweater);
clothesWarehouse.TotalItems();
clothesWarehouse.DisplayAllProductDetails();*/



// create some shoes
/*Shoe highTop = new("converse", 42, 900);
Shoe boot = new("gucci", 43, 3400);
Shoe lowTop = new("air max 90", 42, 4500);

// create warehouse to store shoes
Warehouse<Shoe> shoeWarehouse = new();
shoeWarehouse.AddItem(highTop);
shoeWarehouse.AddItem(boot);
shoeWarehouse.AddItem(lowTop);
shoeWarehouse.TotalItems();
Console.WriteLine("-- Remove 2 items from the warehouse. --");
shoeWarehouse.RemoveItem(highTop);
shoeWarehouse.RemoveItem(boot);
shoeWarehouse.TotalItems();
shoeWarehouse.DisplayAllProductDetails();*//*




// create warehouse to store people
*//*People john = new People("John Doe", 21);
Warehouse<People> peopleWarehouse = new(); // // This line will cause a compilation error
peopleWarehouse.AddItem(john);*/


// create shoe
/*Shoe ggSneaker = new("gucci", 42, 4400);
Shoe airMax = new("air max 90", 42, 4500);
// create cloth
Cloth winterCloth = new("hoodie", 5500);
Cloth winterCloth1 = new("sweater", 1400);
*//*covariance example *//*
Warehouse<IProductService> covarianceWarehouse = new();
// add cloth type 
covarianceWarehouse.AddItem(winterCloth);
covarianceWarehouse.AddItem(winterCloth1);
// add shoe type
covarianceWarehouse.AddItem(ggSneaker);
covarianceWarehouse.AddItem(airMax);
// print total items of covariance ware house
covarianceWarehouse.DisplayAllProductDetails();*/




// create shoe
Shoe partyShoe = new("chelsea boot", 42, 6900);
Shoe runningShoe = new("yeezy 300", 42, 7500);
// create cloth
Cloth partyWear = new("Coat", 4500);
Cloth nightWear = new("tshirt", 800);
/*contravariance example*/
/*Warehouse<IProductService> productWarehouse = new();
productWarehouse.AddItem(partyShoe);
productWarehouse.AddItem(runningShoe);*/

// Contravariant use of Warehouse
Warehouse<Shoe> contravariantWarehouse = new();
contravariantWarehouse.AddItem(partyShoe);
contravariantWarehouse.AddItem(runningShoe);
//contravariantWarehouse.AddItem(nightWear); // Compile time error
contravariantWarehouse.DisplayAllProductDetails();
