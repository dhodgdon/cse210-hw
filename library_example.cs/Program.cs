Book book = new Book("The Hobbit", "9781111111", 2345623);

book.Display();
book.CheckOut();
book.Display();
book.CheckIn();
book.Display();
book.ShowBookDetails();

DVD movie = new DVD("The Pirate", 127, 2345678);
movie.Display();
movie.ShowDVDDetails();

Magazine fsy = new Magazine("FSY", "October 2022", 8765432);
fsy.Display();
fsy.ShowMagazineDetails();
