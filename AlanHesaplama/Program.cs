using AlanHesaplama;
GeometricShapes geometric = new GeometricShapes();
Console.WriteLine("Lütfen Yapmak İstediğiniz Geometrik Şekli Seçiniz");
Console.WriteLine("1-Daire\n2-Üçgen\n3-Kare\n4-Dikdörtgen");
int secim = int.Parse(Console.ReadLine());
switch (secim)
{
    case 1:
        geometric.Circle();
        break;
    case 2:
        geometric.Triangle();
        break;
    case 3:
        geometric.Square();
        break;
    case 4:
        geometric.Rectangle();
        break;
}


