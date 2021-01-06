
public class Client {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Abstract_FEdev fe_dev = new RefinedAbstract_FEdev(new ConcreteImplementor_Design());
		fe_dev.devUI();
		fe_dev.devEvent();
	}

}
