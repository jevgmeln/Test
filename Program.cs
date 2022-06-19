//1. Noteikt dalībnieku skaitu un tipu:
//spēlētāju skaits 2 :
//spēlētāju tips:
// game with friend  // labāk uztaisīt tikai vienu no sākuma, piemēram, cilvēks pret cilvēku
// -random player
// -computer
 
//2.izvēlas simbolu // good to have // Labāk uzreiz ņemt default X, bez izvēles
//
//spēlētājs izvēlas spēles simboliu (X vai O)
//
 
 
//3.Izvēlas *spēles līmeņi - viegls (3x3)
 
//4. Spēles noteikumi
//4.1 Sāk spēlētājs ar simbolu X, var veikt tikai vienu gājiemu viena reizē, gājiens pāriet nākošajam spēlētājam
//4.2 Izdarīto gājienu nedrīkst mainīt
//4.3 Nedrīkst izmantot jau aizpildītu lauciņu
//4.4 uzvar spelētājs , kurš pirmais savāc 3 savus simbolus vai nu horizontāli, vai vertikāli, vai pa diognāli
//4.5 Apsveic uzvarētāju
 
//5. Spēle beigusies
//5.1 Sākt jaunu spēli vai turpināt ar to pašu spēlētāju (ja turpina ar to pašu spēlētāju, var izvēlēties simbolu)
 
//
//
 
 
//kā saukt lauciņus:
//A1 etc, 1-9, xrinda y kolonna
 
 
using Grupa4_TicTacToe;

//Welcome screen added
Console.Clear();
GameIntro.Welcome();
Thread.Sleep(5000);
Console.Clear();


string helloPlayer = GameIntro.HelloPlayer;
Console.WriteLine(helloPlayer);


GameIntro.GameRules();
 
GameIntro.GoodLuck();


ComputerPlayer computerPlayer = new();
computerPlayer.PlayerComputer();
computerPlayer.GetPlayerName();

HumanPlayer player1 = new(); // izveidots objetkts
player1.GetPlayerName(); //izsaucam f-ciju GetPlayerName

HumanPlayer player2 = new HumanPlayer();
player2.GetPlayerName();

Thread.Sleep(2000);
Console.Clear();


Console.WriteLine($"Player {player1.Name} is playing with {Symbol.X}");
Console.WriteLine($"Player {player2.Name} is playing with {Symbol.O}");
Console.WriteLine();

int check;
  
//Board started - addded 2022-06-06

string[] arr = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };


do
{
    Board.ShowBoard(arr);

    Console.WriteLine($"Enter your value from 1 to 9: {player1.Name}");
    int addedSymbol = int.Parse(Console.ReadLine());
    
    if (arr[addedSymbol - 1] == "X" || arr[addedSymbol - 1] == "O")
    {
        break; 
    }
    
    arr[addedSymbol - 1] = "X";
    Console.Clear();
    Board.ShowBoard(arr);
    check = CheckWinnner.Winner(arr);
    if (check == 0)
    {
        Console.WriteLine("No win");
        Console.Clear();

        Board.ShowBoard(arr);
        Console.WriteLine($"Enter your value from 1 to 9: {player2.Name}");
        addedSymbol = int.Parse(Console.ReadLine());
        arr[addedSymbol - 1] = "O";
        Console.Clear();
        Board.ShowBoard(arr);
        check = CheckWinnner.Winner(arr);
        if (check == 0)
        {
            Console.WriteLine("No win");
            Console.Clear();
        }
        else Console.WriteLine($"You WON {player2.Name}. Congratulations!");
    }
    else Console.WriteLine($"You WON {player1.Name}. Congratulations!");

}

while (check == 0);