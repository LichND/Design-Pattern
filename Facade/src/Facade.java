
public class Facade {
	// Student
	
	Student student;
	Book book;
	
	public Facade() {
		student = new Student();
		book =  new Book();
	}

	public void borrowBook() {
		student.checkStudentBookNumber();
		book.checkBookAvailable();
		book.updateBookInventory(-1);
		student.updateStudentBookNumber(1);
		student.showCurrentStudentInformation();
	}

}
