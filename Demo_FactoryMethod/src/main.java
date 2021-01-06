
public class main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Creator a = new ConcreteCreatorLySu();
		Creator b = new ConcreteCreatorLyThuyTinh();

		//
		Product pLySu = a.createProduct(); // => Tao ra duoc mot product LySu ma khong thong qua class LySu
		pLySu.printInfo();
	}
}
