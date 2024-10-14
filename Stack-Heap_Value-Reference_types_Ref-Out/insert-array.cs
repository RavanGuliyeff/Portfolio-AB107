using System;

class Program
{
    static void Main()
    {
        // Oyuncu ve zindan başlangıç konumları
        int playerX = 0, playerY = 0;
        int gridSize = 5; // 5x5 harita
        Random random = new Random();
        int playerHealth = 100;
        int monsterHealth = 0;
        bool isGameOver = false;

        Console.WriteLine("Zindan Kaşifi oyununa hoş geldiniz!");
        Console.WriteLine("Haritada W, A, S, D tuşları ile hareket edin. Canavarlarla karşılaşabilirsiniz!");

        while (!isGameOver)
        {
            // Oyuncu hareketi
            Console.WriteLine($"\nŞu anki konumunuz: ({playerX}, {playerY})");
            Console.Write("Hareket yönü (W: Yukarı, A: Sol, S: Aşağı, D: Sağ): ");
            char move = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (char.ToLower(move))
            {
                case 'w': if (playerY > 0) playerY--; break;
                case 'a': if (playerX > 0) playerX--; break;
                case 's': if (playerY < gridSize - 1) playerY++; break;
                case 'd': if (playerX < gridSize - 1) playerX++; break;
                default: Console.WriteLine("Geçersiz hareket."); break;
            }

            // Rastgele canavar karşılaşması (örneğin %30 olasılıkla canavarla karşılaşma)
            if (random.Next(0, 100) < 30)
            {
                Console.WriteLine("\nBir canavarla karşılaştınız!");
                monsterHealth = random.Next(20, 50); // Canavarın sağlığı rastgele belirlenir
                bool fight = true;

                // Dövüş döngüsü
                while (fight && playerHealth > 0 && monsterHealth > 0)
                {
                    Console.WriteLine($"Sizin sağlığınız: {playerHealth}, Canavarın sağlığı: {monsterHealth}");
                    Console.WriteLine("Ne yapmak istersiniz? (S: Saldır, K: Kaç)");
                    char action = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (char.ToLower(action) == 's')
                    {
                        // Oyuncu canavara saldırır
                        int playerDamage = random.Next(10, 20);
                        monsterHealth -= playerDamage;
                        Console.WriteLine($"Canavara {playerDamage} hasar verdiniz.");

                        // Eğer canavar ölmediyse canavar saldırır
                        if (monsterHealth > 0)
                        {
                            int monsterDamage = random.Next(5, 15);
                            playerHealth -= monsterDamage;
                            Console.WriteLine($"Canavar size {monsterDamage} hasar verdi.");
                        }
                    }
                    else if (char.ToLower(action) == 'k')
                    {
                        // Kaçma durumu, %50 kaçma şansı
                        if (random.Next(0, 100) < 50)
                        {
                            Console.WriteLine("Başarılı bir şekilde kaçtınız!");
                            fight = false;
                        }
                        else
                        {
                            Console.WriteLine("Kaçamadınız! Canavar size saldırıyor.");
                            int monsterDamage = random.Next(5, 15);
                            playerHealth -= monsterDamage;
                            Console.WriteLine($"Canavar size {monsterDamage} hasar verdi.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz eylem.");
                    }
                }

                // Dövüş sonucu kontrolü
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Öldünüz! Oyun bitti.");
                    isGameOver = true;
                }
                else if (monsterHealth <= 0)
                {
                    Console.WriteLine("Canavarı yendiniz!");
                }
            }

            // Oyun sonu kontrolü (örneğin sağlığınız 0 olduğunda)
            if (playerHealth <= 0)
            {
                isGameOver = true;
                Console.WriteLine("Oyun sona erdi.");
            }
        }
    }
}
