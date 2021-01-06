
public class Handler_500 extends Handler {

	public Handler_500(Handler handler) {
		// TODO Auto-generated constructor stub
		super.Handler(handler);
	}
	
	@Override
	protected void handleMoney(int money) {
		// TODO Auto-generated method stub
		while (money>=500000)
		{
			System.out.println("500.000 VND\n");
			money -= 500000;
		}
		super.handleMoney(money);
	}
	
}
