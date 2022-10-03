using static Classes.Example;


// Разница в выводе + преобразование в строку
#region Разница в выводе + преобразование в строку
Console.WriteLine("CarVendorWithoutFlags");
for (int i = 0; i < 9; i++)
{
    Console.WriteLine($"{i} : {(CarVendorWithoutFlags)i}");
}
Console.WriteLine();
Console.WriteLine("CarVendor");
for (int i = 0; i < 9; i++)
{
    Console.WriteLine($"{i} : {(CarVendor)i}");
}
#endregion



#region Поддержка битовых операций
// OR (добавление)
var MyCars = CarVendor.Minivan | CarVendor.Sedan;
Console.WriteLine(MyCars);

// XOR (удаление)
MyCars = MyCars ^ CarVendor.Minivan;
Console.WriteLine(MyCars);

// AND (наличие [0 или Значение])
MyCars = MyCars & CarVendor.Minivan;
Console.WriteLine(MyCars);
#endregion



#region Парсинг строки
CarVendor CarFlags;
CarVendorWithoutFlags CarNoFlags;
string Car = Console.ReadLine();

// С флагами выводит массив элементов
if (Enum.TryParse(Car, out CarFlags)) { Console.WriteLine(CarFlags); }
else
{
    throw new Exception("Incorrect Car");
}

// Без флагов выводит сумму введеных (например "Jeep, ElectricCar" = 96), но если "Jeep", то выведет "Jeep"
if (Enum.TryParse(Car, out CarNoFlags)) { Console.WriteLine(CarNoFlags); }
else
{
    throw new Exception("Incorrect Car");
}

#endregion

