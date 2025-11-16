// See https://aka.ms/new-console-template for more information
using NamingApp;

Console.WriteLine("Hello, World!");

// 日本の47都道府県の初期データをセット
List<Prefecture> prefectures = GetPrefectures();

if (0 <  prefectures.Count)
{
    Console.WriteLine("都道府県データがあります。");
}
else
{
    Console.WriteLine("都道府県データがありません。");
}

Console.WriteLine($"First:\t{prefectures.FirstOrDefault().Name}");
Console.WriteLine($"Last:\t{prefectures.LastOrDefault().Name}");
Console.WriteLine($"Fukuoka:\t{prefectures.SingleOrDefault(p => p.Name.Equals("福岡県")).Name}");
Console.WriteLine($"No5:\t{prefectures.ElementAtOrDefault(4).Name}");

List<Prefecture> GetPrefectures() =>
    [
        new(1, "Hokkaido"),
        new(2, "Aomori"),
        new(3, "Iwate"),
        new(4, "Miyagi"),
        new(5, "Akita"),
        new(6, "Yamagata"),
        new(7, "Fukushima"),
        new(8, "Ibaraki"),
        new(9, "Tochigi"),
        new(10, "Gunma"),
        new(11, "Saitama"),
        new(12, "Chiba"),
        new(13, "Tokyo"),
        new(14, "Kanagawa"),
        new(15, "Niigata"),
        new(16, "Toyama"),
        new(17, "Ishikawa"),
        new(18, "Fukui"),
        new(19, "Yamanashi"),
        new(20, "Nagano"),
        new(21, "Gifu"),
        new(22, "Shizuoka"),
        new(23, "Aichi"),
        new(24, "Mie"),
        new(25, "Shiga"),
        new(26, "Kyoto"),
        new(27, "Osaka"),
        new(28, "Hyogo"),
        new(29, "Nara"),
        new(30, "Wakayama"),
        new(31, "Tottori"),
        new(32, "Shimane"),
        new(33, "Okayama"),
        new(34, "Hiroshima"),
        new(35, "Yamaguchi"),
        new(36, "Tokushima"),
        new(37, "Kagawa"),
        new(38, "Ehime"),
        new(39, "Kochi"),
        new(40, "Fukuoka"),
        new(41, "Saga"),
        new(42, "Nagasaki"),
        new(43, "Kumamoto"),
        new(44, "Oita"),
        new(45, "Miyazaki"),
        new(46, "Kagoshima"),
        new(47, "Okinawa")
    ];
