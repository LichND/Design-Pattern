
public class Handler_100 extends Handler {

	public Handler_100(Handler handler) {
		// TODO Auto-generated constructor stub
		super.Handler(handler);
	}
	
	@Override
	protected void handleMoney(int money) {
		// TODO Auto-generated method stub
		while (money>=100000)
		{
			System.out.println("100.000 VND\n");
			money -= 100000;
		}
		super.handleMoney(money);
	}
	
}
