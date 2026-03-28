DeliveryItem l1 = new Letter("xyz123", 125);
DeliveryItem l2 = new Letter("qwerty123", 10);
DeliveryItem p1 = new Parcell("zxc1456", 12, "30x30x30");
DeliveryItem p2 = new Parcell("fgh345", 12, "10x20x100");

l1.PrintInfo();
l2.PrintInfo();
p1.PrintInfo();
p2.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

myCargo.AddItem(l1);
myCargo.AddItem(l2);
myCargo.AddItem(p1);
myCargo.AddItem(p2);

Console.WriteLine($"Total cost: {myCargo.GetTotalCost()}");