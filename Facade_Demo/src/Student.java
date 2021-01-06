import java.util.Random;

public class Student {
	// Student
	

	String name;
	String studentID;
	int numberOfBook;

	public Student() {
		String alphabet = "ABCDEF";
		this.name = "Nguyen Van " + alphabet.charAt((new Random()).nextInt(alphabet.length()));
		this.numberOfBook = new Random().nextInt(5);
		this.studentID = "1" + (new Random().nextInt(7) + 2) + "52" + new Random().nextInt(1) +  new Random().nextInt(9) 
				+ new Random().nextInt(9) + new Random().nextInt(9);
	}

	public void checkStudentBookNumber() {
		System.out.println("Hop le! So luong sach dang muon la: " + this.numberOfBook);
	}

	public void updateStudentBookNumber(int number) {
		this.numberOfBook += number;
	}

	public void showCurrentStudentInformation() {
		System.out.println("Ten sinh vien: " + this.name);
		System.out.println("MSSV: " + this.studentID);
		System.out.println("So luong sach: " + this.numberOfBook);
	}
}
