class MainClass {
  public static void Main (string[] args) {
    // 5.1.1 - รับจำนวนไอเทมในกระเป๋าของผู้เล่น
    Console.Write("กรุณากรอกจำนวนไอเทมในกระเป๋าของคุณ: ");
    int numItems = int.Parse(Console.ReadLine());

    // 5.1.2 - รับรายละเอียดไอเทมทีละชิ้นจนครบตามจำนวนที่กรอก
    Dictionary<string, string> items = new Dictionary<string, string>();
    for (int i = 1; i <= numItems; i++) {
      Console.Write($"กรุณากรอกชื่อไอเทมที่ {i}: ");
      string name = Console.ReadLine();

      Console.Write($"กรุณากรอกประเภทของไอเทม \"{name}\": ");
      string type = Console.ReadLine();

      items[name] = type;
    }

    // 5.2 - รับโหมดการค้นหาไอเทม
    while (true) {
      Console.Write("กรุณากรอกโหมดการค้นหา (หรือ \"End\" เพื่อออก): ");
      string mode = Console.ReadLine();

      if (mode == "End") {
        Console.WriteLine("End");
        break;
      } else if (mode == "ShowAll") {
        Console.WriteLine("ไอเทมในกระเป๋าของคุณ:");
        foreach (KeyValuePair<string, string> item in items) {
          Console.WriteLine($"{item.Key} ({item.Value})");
        }
      } else {
        Console.WriteLine($"ไอเทมประเภท \"{mode}\" ในกระเป๋าของคุณ:");
        foreach (KeyValuePair<string, string> item in items) {
          if (item.Value == mode) {
            Console.WriteLine(item.Key);
          }
        }
      }

      Console.WriteLine();
    }
  }
}
