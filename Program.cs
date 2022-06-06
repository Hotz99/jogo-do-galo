int player = 1; 

int choice;

//vitoria = 1, derrota = -1
int flag = 0;

var arr = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};


while (flag == 0)
{
    Console.Clear();
    Console.WriteLine("Jogador 1: X \nJogador 2: O\n");

    if (player % 2 == 0) //vez do jogador 2
    {
        Console.WriteLine("Vez do jogador 2!\n");
    }
    else
    {
        Console.WriteLine("Vez do jogador 1!\n");
    }

    DrawBoard();

    choice = int.Parse(Console.ReadLine());

    if (arr[choice] != 'X' && arr[choice] != 'O')
    {
        if (player % 2 == 0)
        {
            arr[choice] = 'O';
            player = 1;
        }
        else
        {
            arr[choice] = 'X';
            player = 2;
        }
    }
    else
    {
        Console.WriteLine("Não podes escolher esse lugar! Tenta outra vez.");

        Thread.Sleep(2000);
    }

    flag = CheckWin();
}

if (player % 2 == 0)
{
    Console.WriteLine("O Jogador 1 ganhou!");
}
else
{
    Console.WriteLine("O Jogador 2 ganhou!");
}

void DrawBoard()
{
    Console.WriteLine("     |     |      ");
    Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
    Console.WriteLine("_____|_____|_____ ");
    Console.WriteLine("     |     |      ");
    Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
    Console.WriteLine("_____|_____|_____ ");
    Console.WriteLine("     |     |      ");
    Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
    Console.WriteLine("     |     |      ");
}

int CheckWin()
{
    //horizontal
    if (arr[1] == arr[2] && arr[2] == arr[3])
    {
        return 1;
    }
    
    else if (arr[4] == arr[5] && arr[5] == arr[6])
    {
        return 1;
    }

    else if (arr[6] == arr[7] && arr[7] == arr[8])
    {
        return 1;
    }
    
    //vertical
    else if (arr[1] == arr[4] && arr[4] == arr[7])
    {
        return 1;
    }
    
    else if (arr[2] == arr[5] && arr[5] == arr[8])
    {
        return 1;
    }
    
    else if (arr[3] == arr[6] && arr[6] == arr[9])
    {
        return 1;
    }
    
    //diagonal
    else if (arr[1] == arr[5] && arr[5] == arr[9])
    {
        return 1;
    }
    else if (arr[3] == arr[5] && arr[5] == arr[7])
    {
        return 1;
    }
    
    //empate
    else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
    {
        return -1;
    }
    else
    {
        return 0;
    }
}