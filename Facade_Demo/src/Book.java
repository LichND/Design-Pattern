import java.util.Random;

public class Book {
	// Student
	int numberOfBook;
	String bookID;
	
	public Book() {
		numberOfBook = new Random().nextInt(5) + 5;
		bookID = "Book_" + new Random().nextInt(9);
	}

	public void checkBookAvailable() {
		System.out.println("Hop le! So luong sach co " + bookID + " con lai trong kho: " + this.numberOfBook) ;
	}

	public void updateBookInventory(int number) {
		this.numberOfBook += number;
		System.out.println("Sach co ID " + bookID + " da duoc cap nhat trong kho: " + this.numberOfBook );
		
	}

	public void showAllBook() { //tat ca cac sach
		System.out.println("All book");
	}
}
