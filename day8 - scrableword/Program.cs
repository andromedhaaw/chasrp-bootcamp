using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Game game = new Game();
        game.StartGame();
    }
}

class Game {
    private Board board;
    private Player[] players;
    private TileBag tileBag;
    private int currentTurn;
    private Dictionary dictionary;

    public Game() {
        board = new Board();
        dictionary = new Dictionary();

        Func<string, bool> validateWordFunc = dictionary.IsValidWord;
        Action<string, Player> wordPlacedAction = (word, player) => 
            Console.WriteLine($"Word '{word}' placed by {player.Name}. Current score: {player.Score}");

        board.SetWordValidator(validateWordFunc);
        board.SetWordPlacedNotifier(wordPlacedAction);

        tileBag = new TileBag();
        players = new Player[] {
            new Player("Alice", tileBag),
            new Player("Bob", tileBag)
        };
        currentTurn = 0;
    }

    public void StartGame() {
        Console.WriteLine("Game Started!");
        board.Display();

        while (true) {
            Player currentPlayer = players[currentTurn];
            Console.WriteLine($"{currentPlayer.Name}'s Turn");
            Console.Write("Enter word: ");
            string word = Console.ReadLine().ToUpper();

            Console.Write("Enter x, y (e.g., 7 7): ");
            string[] coordinates = Console.ReadLine().Split();
            if (coordinates.Length != 2 || !int.TryParse(coordinates[0], out int x) || !int.TryParse(coordinates[1], out int y)) {
                Console.WriteLine("Invalid input format. Please enter two numbers separated by a space.");
                continue;
            }

            Console.Write("Is horizontal? (true/false): ");
            if (!bool.TryParse(Console.ReadLine(), out bool isHorizontal)) {
                Console.WriteLine("Invalid input for orientation. Please enter true or false.");
                continue;
            }

            Word newWord = new Word(word, new Position(x, y), isHorizontal);
            if (board.PlaceWord(currentPlayer, newWord)) {
                Console.WriteLine("Word placed successfully!");
                board.Display();
                currentTurn = (currentTurn + 1) % players.Length;
            } else {
                Console.WriteLine("Invalid word placement. Try again.");
            }
        }
    }
}

class Board {
    private char[,] grid = new char[15, 15];
    private bool firstWordPlaced = false;
    
    private Func<string, bool> validateWord;
    private Action<string, Player> notifyWordPlaced;

    public Board() {
        for (int i = 0; i < 15; i++)
            for (int j = 0; j < 15; j++)
                grid[i, j] = '.';
    }

    public void SetWordValidator(Func<string, bool> validator) {
        validateWord = validator;
    }

    public void SetWordPlacedNotifier(Action<string, Player> notifier) {
        notifyWordPlaced = notifier;
    }

    public void Display() {
        for (int i = 0; i < 15; i++) {
            for (int j = 0; j < 15; j++)
                Console.Write(grid[i, j] + " ");
            Console.WriteLine();
        }
    }

    public bool PlaceWord(Player player, Word word) {
        if (validateWord == null || !validateWord(word.Text)) return false;
        if (!IsValidMove(word)) return false;
        if (!firstWordPlaced && !IsCentered(word)) return false;

        foreach (var (ch, pos) in word.GetTiles()) {
            grid[pos.X, pos.Y] = ch;
        }
        firstWordPlaced = true;
        player.Score += word.Text.Length;

        notifyWordPlaced?.Invoke(word.Text, player);
        return true;
    }

    private bool IsValidMove(Word word) {
        bool touchesExisting = false;
        
        foreach (var (ch, pos) in word.GetTiles()) {
            if (pos.X < 0 || pos.X >= 15 || pos.Y < 0 || pos.Y >= 15)
                return false;

            if (grid[pos.X, pos.Y] != '.') {
                if (grid[pos.X, pos.Y] != ch)
                    return false;
                touchesExisting = true;
            } else {
                if (IsAdjacentToExistingLetter(pos))
                    touchesExisting = true;
            }
        }

        return firstWordPlaced ? touchesExisting : true;
    }

    private bool IsAdjacentToExistingLetter(Position pos) {
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };

        for (int i = 0; i < 4; i++) {
            int newX = pos.X + dx[i];
            int newY = pos.Y + dy[i];
            if (newX >= 0 && newX < 15 && newY >= 0 && newY < 15 && grid[newX, newY] != '.') {
                return true;
            }
        }
        return false;
    }

    private bool IsCentered(Word word) {
        foreach (var (_, pos) in word.GetTiles()) {
            if (pos.X == 7 && pos.Y == 7)
                return true;
        }
        return false;
    }
}

class Player {
    public string Name { get; }
    public int Score { get; set; }
    public Player(string name, TileBag tileBag) { Name = name; Score = 0; }
}

class Dictionary {
    private HashSet<string> words;

    public Dictionary() {
        words = new HashSet<string> { "PAST", "SCONE", "MISTER", "GOLD", "HEART", "VOTE", "BAKE", "RODE" };
    }

    public bool IsValidWord(string word) => words.Contains(word);
}

class TileBag {
    private Queue<char> tiles = new Queue<char>("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
    public char DrawTile() => tiles.Dequeue();
}

class Word {
    public string Text { get; }
    public Position StartPos { get; }
    public bool IsHorizontal { get; }

    public Word(string text, Position pos, bool isHorizontal) {
        Text = text;
        StartPos = pos;
        IsHorizontal = isHorizontal;
    }

    public IEnumerable<(char, Position)> GetTiles() {
        for (int i = 0; i < Text.Length; i++) {
            int x = StartPos.X + (IsHorizontal ? i : 0);
            int y = StartPos.Y + (IsHorizontal ? 0 : i);
            yield return (Text[i], new Position(x, y));
        }
    }
}

class Position {
    public int X { get; }
    public int Y { get; }
    public Position(int x, int y) { X = x; Y = y; }
}

// scone 9, 7 jadi scone di mundurkan satu huruf