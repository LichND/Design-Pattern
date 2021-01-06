import pure.Prototype_Pure;
import pure.ConcretePrototype;

public class Main {

	public static void main(String[] args) {
//		Prototype_Cloneable Prototype1 = new Prototype_Cloneable("Nguyen", "Van", "A");
//		Prototype_Cloneable Prototype2 = Prototype1.clone();
//		Prototype2.setTen("Another");
//
//		System.out.println(Prototype1);
//		System.out.println(Prototype2);
		
		ConcretePrototype cp = new ConcretePrototype("Nguyen", "Van", "Dong");
		Prototype_Pure cp1 = cp.clone();
		System.out.println(cp1.toString());
	}

}
