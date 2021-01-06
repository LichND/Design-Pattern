
public class Handler_200 extends Handler {

	public Handler_200(Handler handler) {
		// TODO Auto-generated constructor stub
		super.Handler(handler);
	}
	
	@Override
	protected void handleMoney(int money) {
		// TODO Auto-generated method stub
		while (money>=200000)
		{
			System.out.println("200.000 VND\n");
			money -= 200000;
		}
		super.handleMoney(money);
	}
	
}
