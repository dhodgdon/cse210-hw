// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Team firebirds = new Team("Firebirds");


Player john = new Player("John Henderson",12);
// john.Display();
Player tim = new Player("Tim Nunn", 13);

firebirds.AddPlayer(john);
firebirds.AddPlayer(tim);


Team angryPandas = new Team("Angry pandas");

Player adam = new Player("Adam Hayes", 1);
Player jonas = new Player("Jonas Smmith", 28);

angryPandas.AddPlayer(adam);
angryPandas.AddPlayer(jonas);

Match match1 = new Match(firebirds,angryPandas);
match1.DecideWin();


angryPandas.DisplayRoster();
firebirds.DisplayRoster();